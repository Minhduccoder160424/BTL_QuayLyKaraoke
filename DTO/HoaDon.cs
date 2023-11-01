using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public string MaHD { get; set; }
        public string KhachHangID { get; set; }
        public string NhanVienID { get; set; }
        public DateTime NgayLapHD { get; set; }
        public double TongGiaTien { get; set; }
        public string MatHangID { get; set; }
        public string PhongHatID { get; set; }
        public double TienPhong { get; set; }
        public double TienMatHang { get; set; }
        public double SoGio {  get; set; }
    }
}
