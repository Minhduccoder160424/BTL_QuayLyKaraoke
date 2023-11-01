using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_QuanLyKhachHang
    {
        DAL_QuanLyKhachHang DAL = new DAL_QuanLyKhachHang();
        public DataTable LayDuLieuKhachHang()
        {
            return DAL.LayBangKhachHang();
        }
        public void ThemDuLieu(KhachHang KH)
        {
            DAL.ThemKhachHang(KH);
        }
        public void SuaDuLieu(KhachHang KH)
        {
            DAL.SuaKhachHang(KH);
        }
        public void XoaDuLieu(KhachHang KH)
        {
            DAL.XoaKhachHang(KH);
        }
        public DataTable TimKiemDuLieu(string LoaiTimKiem, string TextTimKiem)
        {
            if (Equals(LoaiTimKiem, "Tên khách hàng"))
            {
                return DAL.TimKiemKhachHang("TenKhachHang", TextTimKiem);
            }
            else if (Equals(LoaiTimKiem, "Số điện thoại"))
            {
                return DAL.TimKiemKhachHang("SoDienThoai", TextTimKiem);
            }
            else
            {
                return DAL.LayBangKhachHang();
            }
        }
    }
}
