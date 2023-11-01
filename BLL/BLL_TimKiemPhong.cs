using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TimKiemPhong
    {
        DAL_TimKiemPhong DAL = new DAL_TimKiemPhong();
        public DataTable DuLieuBangPhongHat()
        {
            return DAL.LayDuLieuBangPhongHat();
        }
        public DataTable TimKiemTenPhong(string TenPhong)
        {
            return DAL.TimKiemPhongTheoTenPhong(TenPhong);
        }
        public DataTable TimKiemTrangThai(int TrangThai)
        {
            return DAL.TimKiemPhongTheoTrangThai(TrangThai);
        }
    }
}
