using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_QuanLyKhachHang
    {
        QuerySQL Query = new QuerySQL();
        public DataTable LayBangKhachHang()
        {
            string _Query = "select * from KhachHang";
            return Query.LayDuLieu(_Query);
        }
        public void ThemKhachHang(KhachHang KH)
        {
            string _Query = "insert into KhachHang values(N'{0}', N'{1}', N'{2}', {3})";
            _Query = string.Format(_Query, KH.KhachHangID, KH.TenKhachHang, KH.SoDienThoai, KH.DoThanThiet);
            Query.ThucThiTruyVan(_Query);
        }
        public void SuaKhachHang(KhachHang KH)
        {
            string _Query = "update KhachHang set TenKhachHang = N'{1}', SoDienThoai = N'{2}', DoThanThiet = {3} where KhachHangID = N'{0}'";
            _Query = string.Format(_Query, KH.KhachHangID, KH.TenKhachHang, KH.SoDienThoai, KH.DoThanThiet);
            Query.ThucThiTruyVan(_Query);
        }
        public void XoaKhachHang(KhachHang KH)
        {
            string _Query = "delete KhachHang where KhachHangID = N'{0}'";
            _Query = string.Format(_Query, KH.KhachHangID);
            Query.ThucThiTruyVan(_Query);
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
