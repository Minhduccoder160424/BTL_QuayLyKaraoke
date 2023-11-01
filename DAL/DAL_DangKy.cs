using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DangKy
    {
        QuerySQL Query = new QuerySQL();
        public void DangKyTaiKhoan(NguoiDung ND)
        {
            string _Query = "insert into NguoiDung values('{0}', N'{1}', N'{2}', {3})";
            _Query = string.Format(_Query, ND.NguoiDungID, ND.TaiKhoan, ND.MatKhau, ND.QuyenTruyCap);
            Query.ThucThiTruyVan(_Query);
        }
        public DataTable LayDuLieuBangNguoiDung()
        {
            string _Query = "select * from NguoiDung";
            return Query.LayDuLieu(_Query);
        }
    }
}
