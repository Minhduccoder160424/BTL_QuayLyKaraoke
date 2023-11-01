using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TimKiemPhong
    {
        QuerySQL Query = new QuerySQL();
        public DataTable LayDuLieuBangPhongHat()
        {
            var _Query = "select * from PhongHat";
            return Query.LayDuLieu(_Query);
        }
        public DataTable TimKiemPhongTheoTenPhong(string TenPhong)
        {
            var _Query = $"select * from PhongHat where TenPhong = N'{TenPhong}'";
            return Query.LayDuLieu(_Query);
        }
        public DataTable TimKiemPhongTheoTrangThai(int TrangThai)
        {
            var _Query = $"select * from PhongHat where TrangThaiPhong = N'{TrangThai}'";
            return Query.LayDuLieu(_Query);
        }
    }
}
