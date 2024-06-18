using System.Collections.Generic;
using System.Linq;
using NuGet.Packaging;
using Smartstore.Core.Identity;
using Smartstore.Core.Security;

namespace JAN.Sizing.Extensions
{
    internal static class SizingPermissions
    {
        public static class MasterData
        {
            public const string Self = "masterdata";

            public static class ChungLoaiSanPham
            {
                public const string Self = "masterdata.chungloaisanpham";
                public const string Read = "masterdata.chungloaisanpham.read";
                public const string Update = "masterdata.chungloaisanpham.update";
                public const string Create = "masterdata.chungloaisanpham.create";
                public const string Delete = "masterdata.chungloaisanpham.delete";
            }

            public static class DacDiemCoThe
            {
                public const string Self = "masterdata.dacdiemcothe";
                public const string Read = "masterdata.dacdiemcothe.read";
                public const string Update = "masterdata.dacdiemcothe.update";
                public const string Create = "masterdata.dacdiemcothe.create";
                public const string Delete = "masterdata.dacdiemcothe.delete";
            }

            public static class DonVi
            {
                public const string Self = "masterdata.donvi";
                public const string Read = "masterdata.donvi.read";
                public const string Update = "masterdata.donvi.update";
                public const string Create = "masterdata.donvi.create";
                public const string Delete = "masterdata.donvi.delete";
            }

            public static class KieuDang
            {
                public const string Self = "masterdata.kieudang";
                public const string Read = "masterdata.kieudang.read";
                public const string Update = "masterdata.kieudang.update";
                public const string Create = "masterdata.kieudang.create";
                public const string Delete = "masterdata.kieudang.delete";
            }

            public static class LoaiVai
            {
                public const string Self = "masterdata.loaivai";
                public const string Read = "masterdata.loaivai.read";
                public const string Update = "masterdata.loaivai.update";
                public const string Create = "masterdata.loaivai.create";
                public const string Delete = "masterdata.loaivai.delete";
            }

            public static class LyDoChuaDo
            {
                public const string Self = "masterdata.lydochuado";
                public const string Read = "masterdata.lydochuado.read";
                public const string Update = "masterdata.lydochuado.update";
                public const string Create = "masterdata.lydochuado.create";
                public const string Delete = "masterdata.lydochuado.delete";
            }

            public static class Size
            {
                public const string Self = "masterdata.size";
                public const string Read = "masterdata.size.read";
                public const string Update = "masterdata.size.update";
                public const string Create = "masterdata.size.create";
                public const string Delete = "masterdata.size.delete";
            }

            public static class ThongSoDo
            {
                public const string Self = "masterdata.thongsodo";
                public const string Read = "masterdata.thongsodo.read";
                public const string Update = "masterdata.thongsodo.update";
                public const string Create = "masterdata.thongsodo.create";
                public const string Delete = "masterdata.thongsodo.delete";
            }

            public static class ViTriCuDong
            {
                public const string Self = "masterdata.vitricudong";
                public const string Read = "masterdata.vitricudong.read";
                public const string Update = "masterdata.vitricudong.update";
                public const string Create = "masterdata.vitricudong.create";
                public const string Delete = "masterdata.vitricudong.delete";
            }

            public static class YeuCauMac
            {
                public const string Self = "masterdata.yeucaumac";
                public const string Read = "masterdata.yeucaumac.read";
                public const string Update = "masterdata.yeucaumac.update";
                public const string Create = "masterdata.yeucaumac.create";
                public const string Delete = "masterdata.yeucaumac.delete";
            }

            public static class YeuCauMacKhac
            {
                public const string Self = "masterdata.yeucaumackhac";
                public const string Read = "masterdata.yeucaumackhac.read";
                public const string Update = "masterdata.yeucaumackhac.update";
                public const string Create = "masterdata.yeucaumackhac.create";
                public const string Delete = "masterdata.yeucaumackhac.delete";
            }

            public static class MauIn
            {
                public const string Self = "masterdata.mauin";
                public const string Read = "masterdata.mauin.read";
                public const string Update = "masterdata.mauin.update";
                public const string Create = "masterdata.mauin.create";
                public const string Delete = "masterdata.mauin.delete";
            }

            public static class EmailTemplate
            {
                public const string Self = "masterdata.emailtemplate";
                public const string Read = "masterdata.emailtemplate.read";
                public const string Update = "masterdata.emailtemplate.update";
                public const string Create = "masterdata.emailtemplate.create";
                public const string Delete = "masterdata.emailtemplate.delete";
            }
        }

        public static class NghiepVuQuyCo
        {
            public const string Self = "nghiepvuquyco";

            public static class KhachHang
            {
                public const string Self = "nghiepvuquyco.khachhang";
                public const string Read = "nghiepvuquyco.khachhang.read";
                public const string Update = "nghiepvuquyco.khachhang.update";
                public const string Create = "nghiepvuquyco.khachhang.create";
                public const string Delete = "nghiepvuquyco.khachhang.delete";
            }

            public static class NhanVienKH
            {
                public const string Self = "nghiepvuquyco.nhanvienkh";
                public const string Read = "nghiepvuquyco.nhanvienkh.read";
                public const string Update = "nghiepvuquyco.nhanvienkh.update";
                public const string Create = "nghiepvuquyco.nhanvienkh.create";
                public const string Delete = "nghiepvuquyco.nhanvienkh.delete";
                public const string Import = "nghiepvuquyco.nhanvienkh.import";
            }

            public static class DanhSachDo
            {
                public const string Self = "nghiepvuquyco.danhsachdo";
                public const string Read = "nghiepvuquyco.danhsachdo.read";
                public const string Update = "nghiepvuquyco.danhsachdo.update";
                public const string Create = "nghiepvuquyco.danhsachdo.create";
                public const string Delete = "nghiepvuquyco.danhsachdo.delete";
                public const string Import = "nghiepvuquyco.danhsachdo.import";
            }

            public static class QuanLyDo
            {
                public const string Self = "nghiepvuquyco.quanlydo";
                public const string Read = "nghiepvuquyco.quanlydo.read";
                public const string Update = "nghiepvuquyco.quanlydo.update";

                //public const string Create = "nghiepvuquyco.quanlydo.create";
                public const string Import = "nghiepvuquyco.quanlydo.import";

                public const string ChuyenQuyCo = "nghiepvuquyco.quanlydo.ChuyenQuyCo";
                public const string Export = "nghiepvuquyco.quanlydo.Export";
                public const string Send = "nghiepvuquyco.quanlydo.send";
            }

            public static class QuyCo
            {
                public const string Self = "nghiepvuquyco.lanquyco";
                public const string Read = "nghiepvuquyco.lanquyco.read";

                /// <summary>
                /// xử lý quy cỡ nói chung (quy cỡ, thay đổi lượng cử động, khóa thông số, hoàn thành)
                /// </summary>
                public const string Process = "nghiepvuquyco.lanquyco.process";

                /// <summary>
                /// xuất thông tin thay đổi
                /// </summary>
                public const string ExportChanged = "nghiepvuquyco.lanquyco.exportchanged";

                public const string Done = "nghiepvuquyco.lanquyco.done";
            }
        }

        public static class DonSanXuat
        {
            public const string Self = "donsanxuat";
            public const string Read = Self + ".read";
            public const string Update = Self + ".update";
            public const string Create = Self + ".create";
            public const string Delete = Self + ".delete";
        }

        public static class LenhSanXuat
        {
            public const string Self = "lenhsanxuat";
            public const string Read = Self + ".read";
            public const string Update = Self + ".update";
            public const string Create = Self + ".create";
            public const string Delete = Self + ".delete";
        }

        public static class NhomLenhSanXuat
        {
            public const string Self = "nhomlenhsanxuat";
            public const string Read = Self + ".read";
            public const string Update = Self + ".update";
            public const string Create = Self + ".create";
            public const string Delete = Self + ".delete";
            public const string Export = Self + ".export";
            public const string Print = Self + ".print";
        }
    }

    internal class SizingPermissionProvider : IPermissionProvider
    {
        public IEnumerable<PermissionRecord> GetPermissions()
        {
            // Get all permissions from above static class.
            var permissionSystemNames = PermissionHelper.GetPermissions(typeof(SizingPermissions.DonSanXuat));
            permissionSystemNames.AddRange(PermissionHelper.GetPermissions(typeof(SizingPermissions.LenhSanXuat)));
            permissionSystemNames.AddRange(PermissionHelper.GetPermissions(typeof(SizingPermissions.MasterData)));
            permissionSystemNames.AddRange(PermissionHelper.GetPermissions(typeof(SizingPermissions.NghiepVuQuyCo)));
            permissionSystemNames.AddRange(PermissionHelper.GetPermissions(typeof(SizingPermissions.NhomLenhSanXuat)));

            var permissions = permissionSystemNames.Select(x => new PermissionRecord { SystemName = x });

            return permissions;
        }

        public IEnumerable<DefaultPermissionRecord> GetDefaultPermissions()
        {
            // Allow root permission for admin by default.
            return new[]
            {
                new DefaultPermissionRecord
                {
                    CustomerRoleSystemName = SystemCustomerRoleNames.Administrators,
                    PermissionRecords = new[]
                    {
                        new PermissionRecord { SystemName = SizingPermissions.MasterData.Self },
                        new PermissionRecord { SystemName = SizingPermissions.NghiepVuQuyCo.Self },
                        new PermissionRecord { SystemName = SizingPermissions.DonSanXuat.Self },
                        new PermissionRecord { SystemName = SizingPermissions.LenhSanXuat.Self },
                        new PermissionRecord { SystemName = SizingPermissions.NhomLenhSanXuat.Self },
                    }
                }
            };
        }
    }
}
