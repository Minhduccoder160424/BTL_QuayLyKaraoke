using DAL;
using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_QuanLyQuanHat
    {
        DAL_QuanLyQuanHat DAL = new DAL_QuanLyQuanHat();
        public DataTable DuLieuBangPhong()
        {
            return DAL.LayDuLieuBangPhong();
        }
        public DataTable DuLieuBangPhongHat()
        {
            return DAL.LayDuLieuBangPhongHat();
        }
        public DataTable DuLieuBangMonDaGoi(string PhongHatID)
        {
            return DAL.LayDuLieuBangMonDaGoi(PhongHatID);
        }
        public DataTable DuLieuNhanVien()
        {
            return DAL.LayDuLieuBangNhanVien();
        }
        public DataTable DuLieuKhachHang()
        {
            return DAL.LayDuLieuBangKhachHang();
        }
        public void SuaDuLieu()
        {

        }
        public KhachHang LayKhachHang(string KhachHangID)
        {
            var TruyXuat = DuLieuKhachHang().Select($"KhachHangID = '{KhachHangID}'")[0];
            KhachHang KH = new KhachHang();
            KH.KhachHangID = KhachHangID;
            KH.TenKhachHang = TruyXuat["TenKhachHang"].ToString();
            KH.SoDienThoai = TruyXuat["SoDienThoai"].ToString();
            KH.DoThanThiet = Convert.ToInt32(TruyXuat["DoThanThiet"]);

            return KH;
        }
        public NhanVien LayNhanVien(string NhanVienID)
        {
            var TruyXuat = DuLieuNhanVien().Select($"NhanVienID = '{NhanVienID}'")[0];
            NhanVien NV = new NhanVien();

            NV.NhanVienID = NhanVienID;
            NV.HoTenNV = TruyXuat["HoTenNV"].ToString();
            NV.NgaySinh = Convert.ToDateTime(TruyXuat["NgaySinh"]);
            NV.GioiTinhNV = TruyXuat["GioiTinhNV"].ToString();
            NV.DiaChi = TruyXuat["DiaChi"].ToString();
            NV.SoDienThoai = TruyXuat["SoDienThoai"].ToString();

            return NV;
        }
        public double TinhSoGio(DateTime After, DateTime Before)
        {
            return (After - Before).TotalHours;
        }
        public double TinhSoTienPhong(double SoGio, double TienPhong)
        {
            return SoGio * TienPhong;
        }
        public string LayPhongHatID(string TenPhong)
        {
            return DuLieuBangPhongHat().Select($"TenPhong = '{TenPhong}'")[0]["PhongHatID"].ToString();
        }
        public double TinhTongTienMatHang(string PhongHatID)
        {
            double TongTien = 0;
            foreach (DataRow i in DuLieuBangMonDaGoi(PhongHatID).Rows)
            {
                var SoLuong = Convert.ToInt32(i["SoLuongBan"]);
                var GiaSP = Convert.ToDouble(i["DonGiaBan"]);
                var Tien = SoLuong * GiaSP;
                TongTien += Tien;
            }
            return TongTien;
        }
        public double TinhTongTienPhaiTra(double TienPhong, double TienSP)
        {
            return TienPhong + TienSP;
        }
        public string TaoIDHoaDon()
        {
            int SoLuong = DAL.LayDuLieuBangHD().Rows.Count + 1;
            if (SoLuong < 10)
            {
                return $"HD00{SoLuong}";
            }
            else if (SoLuong < 100)
            {
                return $"HD0{SoLuong}";
            }
            else
            {
                return $"HD{SoLuong}";
            }
            
        }
        public void ThemHoaDon(HoaDon HD)
        {
            DAL.ThemDuLieuHoaDon(HD);
        }
        public void ThemChiTietHoaDon(string MaHD, string PhongHatID, double TienPhong, double SoGio)
        {
            foreach (DataRow i in DuLieuBangMonDaGoi(PhongHatID).Rows)
            {
                HoaDon HD = new HoaDon();

                HD.MaHD = MaHD;
                HD.MatHangID = i["MatHangID"].ToString();
                HD.PhongHatID = PhongHatID;
                HD.TienPhong = TienPhong;
                HD.TienMatHang = Convert.ToInt32(i["SoLuongBan"]) * Convert.ToDouble(i["DonGiaBan"]);
                HD.SoGio = SoGio;

                DAL.ThemDuLieuChiTietHoaDon(HD);
            }
        }
        public void XoaDatPhongHat(string PhongHatID)
        {
            DAL.XoaDuLieuDatPhongHat(PhongHatID);
        }
        public void XoaDonHangBan(string PhongHatID)
        {
            DAL.XoaDuLieuDonHangBan(PhongHatID);
        }
        public void CapNhatTrangThaiPhong(string TenPhong, int TrangThaiPhong)
        {
            DAL.SuaTrangThaiPhong(TenPhong, TrangThaiPhong);
        }
    }
}
