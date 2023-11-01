using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MatHang
    {
        public string LoaiHangID { get; set; } 
        public string TenLoai { get; set; }
        public string MatHangID { get; set; }
        public string TenMatHang {  get; set; }
        public string DonViTinh {  get; set; }
        public int SoLuongBan { get; set; }
        public double DonGiaBan { get; set; }
        public string KhachHangID { get; set; }
        public string NhanVienID { get; set; }
    }
}
