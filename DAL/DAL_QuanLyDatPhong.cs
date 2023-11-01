using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{

    public class DAL_QuanLyDatPhong
    {
        QuerySQL Query = new QuerySQL();
        public DataTable LayBangNhanVien()
        {
            string _Query = "select * from NhanVien";
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayBangKhachHang()
        {
            string _Query = "select * from KhachHang";
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayComboboxPhongDat()
        {
            string _Query = "select PhongHatID, TenPhong from PhongHat";
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayComboBoxNhanVien()
        {
            string _Query = "select NhanVienID, HoTenNV from NhanVien";
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayDGVPhongHat()
        {
            string _Query = "select TenPhong, TrangThaiPhong from PhongHat";
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayDGVDatPhongHat()
        {
            string _Query = "select PhongHatID, NhanVienID, KhachHangID, ThoiGianDatPhong from DatPhongHat";
            return Query.LayDuLieu(_Query);
        }
        public void ThemPhong(DatPhong DP)
        {
            string _Query = "insert into DatPhongHat(PhongHatID, NhanVienID, KhachHangID, ThoiGianDatPhong) values(N'{0}', N'{1}', N'{2}', N'{3}')";
            _Query = string.Format(_Query, DP.PhongHatID, DP.NhanVienID, DP.KhachHangID, DP.ThoiGianDatPhong);
            Query.ThucThiTruyVan(_Query);
        }
        public void ThemKhachHang(KhachHang KH)
        {
            string _Query = "insert into KhachHang values(N'{0}', N'{1}', N'{2}', {3})";
            _Query = string.Format(_Query, KH.KhachHangID, KH.TenKhachHang, KH.SoDienThoai, KH.DoThanThiet);
            Query.ThucThiTruyVan(_Query);
        }
        public void XoaPhong(string PhongHatID)
        {
            string _Query = "delete DatPhongHat where PhongHatID = N'{0}'";
            _Query = string.Format(_Query, PhongHatID);
            Query.ThucThiTruyVan(_Query);
        }
        public void SuaTrangThaiPhong(string TenPhong, int TrangThaiPhong)
        {
            string _Query = "update PhongHat set TrangThaiPhong = {0} where TenPhong = N'{1}'";
            _Query = string.Format(_Query, TrangThaiPhong, TenPhong);
            Query.ThucThiTruyVan(_Query);
        }
        public void XoaMatHangCuaPhong(string PhongHatID)
        {
            string _Query = "delete DonHangBan where PhongHatID = N'{0}'";
            _Query = string.Format(_Query, PhongHatID);
            Query.ThucThiTruyVan(_Query);
        }
    }
}
