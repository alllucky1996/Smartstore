using FluentMigrator;
using JAN.Sizing.Domain;
using Smartstore.Core.Data.Migrations;

namespace JAN.Sizing.Migrations
{
    [MigrationVersion("2024-06-16 00:00:01", "Sizing: Initial")]
    internal class _20240616000001_Initial : Migration
    {
        public override void Up()
        {
            //if (!Schema.Table(DMSize.TableName).Exists())
            //{
            //    Execute.Script(@"E:\Projects\Open\git\alllucky_1996\Smartstore\src\Smartstore.Web\Modules\JAN.Sizing\Migrations\Queries\quyco_scheme.sql");
            //    Execute.Script(@"E:\Projects\Open\git\alllucky_1996\Smartstore\src\Smartstore.Web\Modules\JAN.Sizing\Migrations\Queries\quyco_view.sql");
            //}
            //// Tablename is taken from Domain->Attribute->Table
            //if (!Schema.Table(DMSize.TableName).Exists())
            //{
            //    Create.Table(DMSize.TableName)
            //        .WithIdColumn()
            //        .WithColumn(nameof(DMSize.Size))
            //            .AsString()
            //            .NotNullable()
            //        .WithColumn(nameof(DMSize.DisplayOrder))
            //            .AsInt32()
            //            .NotNullable();
            //}

            //if (!Schema.Table(nameof(Notification)).Exists())
            //{
            //    Create.Table(nameof(Notification))
            //        .WithIdColumn() // Adds the Id column, which defaults to primary key.
            //        .WithColumn(nameof(Notification.CustomerId))
            //            .AsInt32()
            //            .NotNullable()
            //            .Indexed("IX_Notification_CustomerId")
            //        .WithColumn(nameof(Notification.Readed))
            //            .AsBoolean()
            //            .NotNullable()
            //            .Indexed("IX_Notification_Readed")
            //        .WithColumn(nameof(Notification.Message))
            //            .AsMaxString()
            //            .NotNullable()
            //        .WithColumn(nameof(Notification.Title))
            //            .AsMaxString()
            //            .Nullable();
            //}

            //if (!Schema.Table(ChatlieuKieuDangMap.TableName).Exists())
            //{
            //    Create.Table(ChatlieuKieuDangMap.TableName)
            //        .WithIdColumn()
            //        .WithColumn(nameof(ChatlieuKieuDangMap.Sku))
            //            .AsString(255)
            //            .Nullable()
            //        .WithColumn(nameof(ChatlieuKieuDangMap.ChatLieu))
            //            .AsString(255)
            //            .Nullable()
            //        .WithColumn(nameof(ChatlieuKieuDangMap.KieuDang))
            //            .AsString(255)
            //            .Nullable();
            //}
        }

        public override void Down()
        {
            // Ignore this.
            Delete.Table(nameof(Notification));
            Delete.Table(ChatlieuKieuDangMap.TableName);
            Delete.Table(DMSize.TableName);
        }
    }
}
