using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_ThongKeBaoCao
    {
        DAL_ThongKeBaoCao DAL = new DAL_ThongKeBaoCao();
        public DataTable DuLieuBangGhepHoaDon()
        {
            return DAL.LayBangGhepHoaDon();
        }
        public double ThongKeTheoNam(int Nam)
        {
            double TongTien = 0;
            foreach (DataRow i in DuLieuBangGhepHoaDon().Rows)
            {
                if (Convert.ToDateTime(i["NgayLapHD"]).Year == Nam)
                {
                    TongTien += Convert.ToDouble(i["TongSoTien"]);
                }
            }
            return TongTien;
        }
        public double ThongKeTheoThang(int Nam, int Thang)
        {
            double TongTien = 0;
            foreach (DataRow i in DuLieuBangGhepHoaDon().Rows)
            {
                if (Convert.ToDateTime(i["NgayLapHD"]).Year == Nam && Convert.ToDateTime(i["NgayLapHD"]).Month == Thang)
                {
                    TongTien += Convert.ToDouble(i["TongSoTien"]);
                }
            }
            return TongTien;
        }
    }
}
