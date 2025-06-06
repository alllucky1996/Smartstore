﻿using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;

namespace Smartstore.Core.Localization
{
    /// <summary>
    /// An <see cref="IHtmlContent"/> with localized resource string.
    /// </summary>
    [DebuggerDisplay("{Value}")]
    public class LocalizedString : IHtmlContent
    {
        public LocalizedString(string value, bool isResourceNotFound = false)
            : this(value, null, isResourceNotFound, [])
        {
        }

        public LocalizedString(string value, string name, params object[] arguments)
            : this(value, name, false, arguments)
        {
        }

        public LocalizedString(string value, string name, bool isResourceNotFound, params object[] arguments)
        {
            Name = name;
            Value = value;
            Arguments = arguments;
            IsResourceNotFound = isResourceNotFound;
        }

        /// <summary>
        /// The name of the string resource.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The original resource string, prior to formatting with any constructor arguments.
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Arguments to format <see cref="Value"/> with.
        /// </summary>
        public object[] Arguments { get; }

        /// <summary>
        /// Gets a flag that indicates if the resource is not found.
        /// </summary>
        public bool IsResourceNotFound { get; }

        /// <summary>
        /// Returns a js encoded string which already contains double quote delimiters.
        /// </summary>
        public IHtmlContent JsValue => new HtmlString(Value.EncodeJsString());

        public static implicit operator string(LocalizedString obj)
        {
            return obj.ToString();
        }

        public static implicit operator LocalizedString(string value)
        {
            return new LocalizedString(value);
        }

        /// <inheritdoc />
        public void WriteTo(TextWriter writer, HtmlEncoder encoder)
        {
            Guard.NotNull(writer);
            Guard.NotNull(encoder);

            var value = Arguments.Length > 0 ? string.Format(Value, Arguments) : Value;
            encoder.Encode(writer, value);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            if (string.IsNullOrEmpty(Value))
            {
                return string.Empty;
            }

            return Arguments.Length > 0 ? string.Format(Value, Arguments) : Value;
        }

        /// <inheritdoc />
        public override int GetHashCode()
            => HashCode.Combine(Value, Arguments);

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
                return false;

            var that = (LocalizedString)obj;
            return string.Equals(Value, that.Value) && Arguments.SequenceEqual(that.Arguments);
        }
    }
}