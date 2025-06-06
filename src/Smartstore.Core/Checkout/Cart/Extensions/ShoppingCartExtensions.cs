﻿using Smartstore.Core.Catalog.Products;
using Smartstore.Core.Localization;

namespace Smartstore.Core.Checkout.Cart
{
    public static partial class ShoppingCartExtensions
    {
        /// <summary>
        /// Gets the total quantity of products in the cart.
        /// </summary>
		public static int GetTotalQuantity(this ShoppingCart cart)
        {
            Guard.NotNull(cart);

            return cart.Items.Where(x => x.Item.ParentItemId == null).Sum(x => (int?)x.Item.Quantity) ?? 0;
        }

        /// <summary>
        /// Gets all products in cart, including those of bundle items.
        /// </summary>
        public static Product[] GetAllProducts(this ShoppingCart cart)
        {
            Guard.NotNull(cart);

            return [.. cart.Items
                .Select(x => x.Item.Product)
                .Union(cart.Items.Select(x => x.ChildItems).SelectMany(child => child.Select(x => x.Item.Product)))
                .Where(x => x != null && !x.Deleted)];
        }

        /// <summary>
        /// Gets a value indicating whether the cart includes products matching the condition.
        /// </summary>
        /// <param name="matcher">The condition to match cart items.</param>
        /// <param name="activeOnly">
        /// A value indicating whether to check active items.
        /// <c>true</c> (default) to only check active, <c>false</c> to only check inactive items. <c>null</c> to check all items.
        /// </param>
        /// <returns><c>True</c> if any product matches the condition, otherwise <c>false</c>.</returns>
        public static bool IncludesMatchingItems(this ShoppingCart cart, Func<Product, bool> matcher, bool? activeOnly = true)
        {
            Guard.NotNull(cart);

            return cart.Items.Any(x => 
                x.Item.Product != null 
                && matcher(x.Item.Product) 
                && (activeOnly == null || x.Active == activeOnly.Value));
        }

        /// <summary>
        /// Gets a value indicating whether the shopping cart contains any recurring item.
        /// </summary>
		public static bool ContainsRecurringItem(this ShoppingCart cart)
            => cart.IncludesMatchingItems(x => x.IsRecurring);

        /// <summary>
        /// Gets the recurring cycle information.
        /// </summary>
        /// <returns><see cref="RecurringCycleInfo"/>.</returns>
        public static RecurringCycleInfo GetRecurringCycleInfo(this ShoppingCart cart, ILocalizationService localizationService)
        {
            Guard.NotNull(cart);
            Guard.NotNull(localizationService);

            var info = new RecurringCycleInfo();
            int? cycleLength = null;
            RecurringProductCyclePeriod? cyclePeriod = null;
            int? totalCycles = null;

            foreach (var cartItem in cart.Items)
            {
                var product = cartItem.Item.Product ?? throw new InvalidOperationException($"Product with Id={cartItem.Item.ProductId} cannot be loaded.");
                if (product.IsRecurring)
                {
                    if (cycleLength.HasValue && cycleLength.Value != product.RecurringCycleLength)
                    {
                        info.ErrorMessage = localizationService.GetResource("ShoppingCart.ConflictingShipmentSchedules");
                        return info;
                    }
                    else
                    {
                        cycleLength = product.RecurringCycleLength;
                    }

                    if (cyclePeriod.HasValue && cyclePeriod.Value != product.RecurringCyclePeriod)
                    {
                        info.ErrorMessage = localizationService.GetResource("ShoppingCart.ConflictingShipmentSchedules");
                        return info;
                    }
                    else
                    {
                        cyclePeriod = product.RecurringCyclePeriod;
                    }

                    if (totalCycles.HasValue && totalCycles.Value != product.RecurringTotalCycles)
                    {
                        info.ErrorMessage = localizationService.GetResource("ShoppingCart.ConflictingShipmentSchedules");
                        return info;
                    }
                    else
                    {
                        totalCycles = product.RecurringTotalCycles;
                    }
                }
            }

            if (cycleLength.HasValue && cyclePeriod.HasValue && totalCycles.HasValue)
            {
                info.CycleLength = cycleLength.Value;
                info.CyclePeriod = cyclePeriod.Value;
                info.TotalCycles = totalCycles.Value;
            }

            return info;
        }
    }
}
