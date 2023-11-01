using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string NhanVienID { get; set; }
        public string HoTenNV { get; set; }
        public string GioiTinhNV {  get; set; }
        public DateTime NgaySinh {  get; set; }
        public string DiaChi {  get; set; }
        public string SoDienThoai { get; set; }
    }
}
