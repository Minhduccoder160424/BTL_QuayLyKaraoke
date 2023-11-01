using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TimKiemKhachHang
    {
        DAL_TimKiemKhachHang DAL = new DAL_TimKiemKhachHang();
        public DataTable DuLieuBangKhachHang()
        {
            return DAL.LayDuLieuBangKhachHang();
        }
        public DataTable DuLieuTimKiem(string LoaiTimKiem, string TextTimKiem)
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
                return DAL.LayDuLieuBangKhachHang();
            }
        }
    }
}
