using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TaoHoaDon
    {
        DAL_TaoHoaDon DAL = new DAL_TaoHoaDon();
        public DataTable DuLieuBangHoaDon()
        {
            return DAL.LayDuLieuBangHoaDon();
        }
        public DataTable DuLieuBangCTHoaDon(string MaHD)
        {
            return DAL.LayDuLieuBangCTHoaDon(MaHD);
        }
    }
}
