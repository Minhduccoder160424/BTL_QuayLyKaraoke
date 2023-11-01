using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_QuanLyNhanVien
    {
        QuerySQL Query = new QuerySQL();
        public DataTable BangNhanVien()
        {
            var BangNV = Query.LayDuLieu("select * from NhanVien");
            return BangNV;
        }
        public void ThemNhanVien(NhanVien NV)
        {
            string _Query = "INSERT INTO NHANVIEN VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')";
            _Query = string.Format(_Query, NV.NhanVienID, NV.HoTenNV, NV.GioiTinhNV, NV.NgaySinh, NV.DiaChi, NV.SoDienThoai);
            Query.ThucThiTruyVan(_Query);
        }
        public void SuaNhanVien(NhanVien NV)
        {
            string _Query = "UPDATE NHANVIEN SET HoTenNV = N'{1}', GioiTinhNV = N'{2}', NgaySinh = N'{3}', DiaChi = N'{4}', SoDienThoai = N'{5}' WHERE NhanVienID = '{0}'";
            _Query = string.Format(_Query, NV.NhanVienID, NV.HoTenNV, NV.GioiTinhNV, NV.NgaySinh, NV.DiaChi, NV.SoDienThoai);
            Query.ThucThiTruyVan(_Query);
        }
        public void XoaNhanVien(NhanVien NV)
        {
            string _Query = "DELETE NHANVIEN WHERE NhanVienID = '{0}'";
            _Query = string.Format(_Query, NV.NhanVienID);
            Query.ThucThiTruyVan(_Query);
        }
        public DataTable TimKiemNhanVien(string LoaiTimKiem, string TextTimKiem)
        {
            string _Query = "select * from NhanVien where contains({0}, N'\"{1}\"')";
            _Query = string.Format(_Query, LoaiTimKiem, TextTimKiem);
            var BangTimKiem = Query.LayDuLieu(_Query);
            return BangTimKiem;
        }
    }
}
