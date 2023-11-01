using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DangNhap
    {
        QuerySQL Query = new QuerySQL();
        public int KiemTraQuyenHan(NguoiDung ND)
        {
            return Query.ThucThiThuTucQuyenNguoiDung(ND);
        }
    }
}
