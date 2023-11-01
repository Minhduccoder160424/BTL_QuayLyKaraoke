using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatPhong
    {
        public string PhongHatID { get; set; }
        public string TenPhong { get; set; }
        public int TrangThaiPhong { get; set; }
        public double GiaTheoGio {  get; set; }
        public string KhachHangID { get; set; }
        public string NhanVienID { get; set; }
        public string ThoiGianDatPhong { get; set; }
        public string ThoiGianTraPhong { get; set; } 
        public double GiamGiaThanThiet {  get; set; }
    }
}
