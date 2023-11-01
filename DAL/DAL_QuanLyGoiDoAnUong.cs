using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_QuanLyGoiDoAnUong
    {
        QuerySQL Query = new QuerySQL();
        public DataTable LayDuLieuBangLoaiHang()
        {
            string _Query = "select * from LoaiHang";
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayDuLieuBangMatHang(string LoaiHangID)
        {
            string _Query = "select MatHangID, TenMatHang from MatHang where LoaiHangID = '{0}'";
            _Query = string.Format(_Query, LoaiHangID);
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayDuLieuBangPhongHat()
        {
            string _Query = "select * from PhongHat PH inner join DatPhongHat DPH on PH.PhongHatID = DPH.PhongHatID";
            return Query.LayDuLieu(_Query);
        }
        public DataTable LayDuLieuBangDonHangBan(string PhongHatID)
        {
            string _Query = "select TenLoai, TenMatHang, DonViTinh, SoLuongBan from DonHangBan DHB inner join MatHang MH on DHB.MatHangID = MH.MatHangID inner join LoaiHang LH on MH.LoaiHangID = LH.LoaiHangID where PhongHatID = '{0}'";
            _Query = string.Format (_Query, PhongHatID);
            return Query.LayDuLieu(_Query);
        }
        public void ThemDuLieu(MatHang MH, string PhongHatID)
        {
            string _Query = "insert into DonHangBan(MatHangID, KhachHangID, NhanVienID, SoLuongBan, PhongHatID) values(N'{0}', N'{1}', N'{2}', {3}, N'{4}')";
            _Query = string.Format(_Query, MH.MatHangID, MH.KhachHangID, MH.NhanVienID, MH.SoLuongBan, PhongHatID);
            Query.ThucThiTruyVan(_Query);
        }
        public void SuaDuLieu(MatHang MH)
        {
            string _Query = "update DonHangBan set SoLuongBan = {0} where KhachHangID = '{1}'";
            _Query = string.Format(_Query, MH.SoLuongBan, MH.KhachHangID);
            Query.ThucThiTruyVan(_Query);
        }
        public void XoaDuLieu(MatHang MH)
        {
            string _Query = "delete DonHangBan where MatHangID = N'{0}' and KhachHangID = N'{1}'";
            _Query = string.Format(_Query, MH.MatHangID, MH.KhachHangID);
            Query.ThucThiTruyVan(_Query);
        }
    }
}
