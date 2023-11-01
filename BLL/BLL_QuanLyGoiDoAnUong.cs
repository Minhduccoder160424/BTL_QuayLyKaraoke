using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_QuanLyGoiDoAnUong
    {
        DAL_QuanLyGoiDoAnUong DAL = new DAL_QuanLyGoiDoAnUong();
        public DataTable DuLieuComboboxChonMon() => DAL.LayDuLieuBangLoaiHang();
        public DataTable DuLieuComboboxTenMon(string LoaiHangID) => DAL.LayDuLieuBangMatHang(LoaiHangID);
        public DataTable DuLieuComboboxPhong() => DAL.LayDuLieuBangPhongHat();
        public DataTable DuLieuDGVMatHangMua(string KhachHangID) => DAL.LayDuLieuBangDonHangBan(KhachHangID);
        public void ThemDuLieu(MatHang MH, string PhongHatID)
        {
            DAL.ThemDuLieu(MH, PhongHatID);
        }
        public void SuaDuLieu(MatHang MH)
        {
            DAL.SuaDuLieu(MH);
        }
        public void XoaDuLieu(MatHang MH)
        {
            DAL.XoaDuLieu(MH);
        }
        public string LayKhachHangID(string TenPhong) => DuLieuComboboxPhong().Select($"TenPhong = '{TenPhong}'")[0]["KhachHangID"].ToString();
        public string LayNhanVienID(string TenPhong) => DuLieuComboboxPhong().Select($"TenPhong = '{TenPhong}'")[0]["NhanVienID"].ToString();
    }
}
