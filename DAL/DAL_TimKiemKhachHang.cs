using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TimKiemKhachHang
    {
        QuerySQL Query = new QuerySQL();
        public DataTable LayDuLieuBangKhachHang()
        {
            string _Query = "select * from KhachHang";
            return Query.LayDuLieu(_Query);
        }
        public DataTable TimKiemKhachHang(string LoaiTimKiem, string TextTimKiem)
        {
            string _Query = "select * from KhachHang where contains({0}, N'\"{1}\"')";
            _Query = string.Format(_Query, LoaiTimKiem, TextTimKiem);
            var BangTimKiem = Query.LayDuLieu(_Query);
            return BangTimKiem;
        }
    }
}
