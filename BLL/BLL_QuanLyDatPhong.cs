using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Windows.Forms;
using System.Web;

namespace BLL
{
    public class BLL_QuanLyDatPhong
    {
        DAL_QuanLyDatPhong DAL = new DAL_QuanLyDatPhong();
        public void ThemKhachHang(KhachHang KH)
        {
            DAL.ThemKhachHang(KH);
        }
        public string TaoKhachHangID()
        {
            int SoLuongKH = DuLieuBangKhachHang().Rows.Count + 1;
            string TailID;
            if (SoLuongKH < 10)
            {
                TailID = "00" + SoLuongKH.ToString();
            }
            else if (SoLuongKH < 100)
            {
                TailID = "0" + SoLuongKH.ToString();
            }
            else
            {
                TailID = SoLuongKH.ToString();
            }
            string create = "KH" + TailID;
            return create;
        }
        public DataTable DuLieuBangKhachHang()
        {
            return DAL.LayBangKhachHang();
        }
        public DataTable DuLieuBangNhanVien()
        {
            return DAL.LayBangNhanVien();
        }
        public DataTable DuLieuComboboxPhongDat()
        {
            return DAL.LayComboboxPhongDat();
        }
        public DataTable DuLieuComboboxNhanVien()
        {
            return DAL.LayComboBoxNhanVien();
        }
        public DataTable DuLieuDGVPhongHat()
        {
            return DAL.LayDGVPhongHat();
        }
        public DataTable DuLieuDGVDatPhongHat()
        {
            return DAL.LayDGVDatPhongHat();
        }
        public KhachHang TimKiemKhachHang(string TenKhachHang, string SoDienThoai)
        {
            var TruyXuat = DuLieuBangKhachHang().Select($"TenKhachHang = '{TenKhachHang}' and SoDienThoai = '{SoDienThoai}'");
            if (TruyXuat.Length > 0)
            {
                KhachHang KH = new KhachHang();

                KH.KhachHangID = TruyXuat[0]["KhachHangID"].ToString();
                KH.TenKhachHang = TenKhachHang;
                KH.SoDienThoai = SoDienThoai;
                KH.DoThanThiet = Convert.ToInt32(TruyXuat[0]["DoThanThiet"]);

                return KH;
            }
            return null;
        }
        public bool KiemTraPhongTrong(string TenPhong)
        {
            var TruyXuat = DuLieuDGVPhongHat().Select($"TenPhong = '{TenPhong}'")[0];
            if (Convert.ToInt32(TruyXuat["TrangThaiPhong"]) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CapNhatTrangThaiPhong(string TenPhong, int TrangThaiPhong)
        {
            DAL.SuaTrangThaiPhong(TenPhong, TrangThaiPhong);
        }
        public void ThemPhong(DatPhong DP)
        {
            DAL.ThemPhong(DP);
        }
        public void XoaPhong(string PhongHatID)
        {
            DAL.XoaPhong(PhongHatID);
        }
        public NhanVien LayThongTinNhanVien(string NhanVienID)
        {
            var TruyXuat = DuLieuBangNhanVien().Select($"NhanVienID = '{NhanVienID}'")[0];

            NhanVien NV = new NhanVien();
            NV.NhanVienID = NhanVienID;
            NV.HoTenNV = TruyXuat["HotenNV"].ToString();
            NV.NgaySinh = Convert.ToDateTime(TruyXuat["NgaySinh"]);
            NV.GioiTinhNV = TruyXuat["GioiTinhNV"].ToString();
            NV.DiaChi = TruyXuat["DiaChi"].ToString();
            NV.SoDienThoai = TruyXuat["SoDienThoai"].ToString();

            return NV;
        }
        public KhachHang LayThongTinKhachHang(string KhachHangID)
        {
            var TruyXuat = DuLieuBangKhachHang().Select($"KhachHangID = '{KhachHangID}'")[0];

            KhachHang KH = new KhachHang();
            KH.KhachHangID = KhachHangID;
            KH.TenKhachHang = TruyXuat["TenKhachHang"].ToString();
            KH.SoDienThoai = TruyXuat["SoDienThoai"].ToString();
            KH.DoThanThiet = Convert.ToInt32(TruyXuat["DoThanThiet"]);

            return KH;
        }
        public void XoaMatHangCuaPhong(string PhongHatID)
        {
            DAL.XoaMatHangCuaPhong(PhongHatID);
        }
    }
}
