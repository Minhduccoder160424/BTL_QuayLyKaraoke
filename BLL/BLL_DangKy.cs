using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DangKy
    {
        DAL_DangKy DAL = new DAL_DangKy();
        public string TaoNguoiDungID()
        {
            int SoLuong = DAL.LayDuLieuBangNguoiDung().Rows.Count + 1;
            if (SoLuong < 10)
            {
                return $"ND00{SoLuong}";
            }
            else if (SoLuong < 100)
            {
                return $"ND0{SoLuong}";
            }
            else
            {
                return $"ND{SoLuong}";
            }
        }
        public void TaoTaiKhoan(NguoiDung ND)
        {
            DAL.DangKyTaiKhoan(ND);
        }
        public bool KiemTraHopLe(string MatKhau, string XacNhanMatKhau)
        {
            if (Equals(MatKhau, XacNhanMatKhau))
            {
                return true;
            }
            return false;
        }
    }
}
