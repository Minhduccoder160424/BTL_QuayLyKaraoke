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
    public class BLL_QuanLyNhanVien
    {
        DAL_QuanLyNhanVien DAL = new DAL_QuanLyNhanVien();
        public DataTable LayBangNhanVien()
        {
            return DAL.BangNhanVien();
        }
        public void ThemDuLieu(NhanVien NV)
        {
            DAL.ThemNhanVien(NV);
        }
        public void SuaDuLieu(NhanVien NV)
        {
            DAL.SuaNhanVien(NV);
        }
        public void XoaDuLieu(NhanVien NV)
        {
            DAL.XoaNhanVien(NV);
        }
        public DataTable TimKiemDuLieu(string LoaiTimKiem, string TextTimKiem)
        {
            return DAL.TimKiemNhanVien(LoaiTimKiem, TextTimKiem);
        }
    }
}
