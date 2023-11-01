using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class BLL_DangNhap
    {
        DAL_DangNhap DAL = new DAL_DangNhap();
        public int KiemTraQuyen(NguoiDung ND)
        {
            return DAL.KiemTraQuyenHan(ND);
        }
    }
}
