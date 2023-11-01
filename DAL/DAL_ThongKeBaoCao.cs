using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThongKeBaoCao
    {
        QuerySQL Query = new QuerySQL();
        public DataTable LayBangGhepHoaDon()
        {
            string _Query = "select * from HoaDon HD inner join CTHoaDon CTHD on HD.MaHD = CTHD.MaHD";
            return Query.LayDuLieu(_Query);
        }
    }
}
