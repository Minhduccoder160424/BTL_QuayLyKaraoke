using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaoHoaDon
    {
        QuerySQL Query = new QuerySQL();
        public DataTable LayDuLieuBangHoaDon()
        {
            string _Query = "select * from HoaDon";
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayDuLieuBangCTHoaDon(string MaHD)
        {
            string _Query = "select MH.MatHangID, TenMatHang, TienMatHang from CTHoaDon CTHD inner join MatHang MH on CTHD.MatHangID = MH.MatHangID where MaHD = '{0}'";
            _Query = string.Format(_Query, MaHD);
            return Query.LayDuLieu(_Query);
        }
    }
}
