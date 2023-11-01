using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_QuanLyQuanHat
    {
        QuerySQL Query = new QuerySQL();
        
        public DataTable LayDuLieuBangPhong()
        {
            string _Query = "select TenPhong, KhachHangID, NhanVienID, ThoiGianDatPhong, GiaTheoGio from PhongHat PH inner join DatPhongHat DPH on PH.PhongHatID = DPH.PhongHatID";
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayDuLieuBangPhongHat() 
        {
            string _Query = "select PhongHatID, TenPhong, TrangThaiPhong from PhongHat";
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayDuLieuBangMonDaGoi(string PhongHatID)
        {
            string _Query = "select TenLoai, MH.MatHangID,TenMatHang, SoLuongBan, DonGiaBan from LoaiHang LH inner join MatHang MH on LH.LoaiHangID = MH.LoaiHangID inner join DonHangBan DHB on MH.MatHangID = DHB.MatHangID where PhongHatID = N'{0}'";
            _Query = string.Format(_Query, PhongHatID);
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayDuLieuBangNhanVien()
        {
            string _Query = "select * from NhanVien";
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayDuLieuBangKhachHang()
        {
            string _Query = "select * from KhachHang";
            return Query.LayDuLieu(_Query);
        }
        public void ThemDuLieuHoaDon(HoaDon HD)
        {
            string _Query = "insert into HoaDon values('{0}', '{1}', '{2}', '{3}', {4})";
            _Query = string.Format(_Query, HD.MaHD, HD.KhachHangID, HD.NhanVienID, HD.NgayLapHD, HD.TongGiaTien);
            Query.ThucThiTruyVan(_Query);
        }
        public void ThemDuLieuChiTietHoaDon(HoaDon HD)
        {
            string _Query = "insert into CTHoaDon values('{0}', '{1}', '{2}', {3}, {4}, {5})";
            _Query = string.Format(_Query, HD.MaHD, HD.MatHangID, HD.PhongHatID, HD.TienPhong, HD.TienMatHang, HD.SoGio);
            Query.ThucThiTruyVan(_Query);
        }
        public void XoaDuLieuDonHangBan(string PhongHatID)
        {
            string _Query = "delete DonHangBan where PhongHatID = '{0}'";
            _Query = string.Format(_Query, PhongHatID);
            Query.ThucThiTruyVan(_Query);
        }
        public void XoaDuLieuDatPhongHat(string PhongHatID)
        {
            string _Query = "delete DatPhongHat where PhongHatID = '{0}'";
            _Query = string.Format(_Query, PhongHatID);
            Query.ThucThiTruyVan(_Query);
        }
        public DataTable LayDuLieuBangHD()
        {
            string _Query = "select * from HoaDon";
            return Query.LayDuLieu(_Query);
        }
        public void SuaTrangThaiPhong(string TenPhong, int TrangThaiPhong)
        {
            string _Query = "update PhongHat set TrangThaiPhong = {0} where TenPhong = N'{1}'";
            _Query = string.Format(_Query, TrangThaiPhong, TenPhong);
            Query.ThucThiTruyVan(_Query);
        }
    }
}
