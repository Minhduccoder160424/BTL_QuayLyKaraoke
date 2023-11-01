using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    internal class QuerySQL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EA6JH6AK;Initial Catalog=BTL_QuanLyKaraoke;Integrated Security=True");
        void MoKetNoi()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        void DongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable LayDuLieu(string Query)
        {
            MoKetNoi();
            DataSet DS = new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter(Query, conn);
            DataTable DT = new DataTable();
            Adapter.Fill(DT);
            DS.Tables.Add(DT);
            DongKetNoi();
            return DS.Tables[0];
        }
        public void ThucThiTruyVan(string Query)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
        public int ThucThiThuTucQuyenNguoiDung(NguoiDung ND)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("KiemTraTruyCap", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tai_khoan", ND.TaiKhoan);
            cmd.Parameters.AddWithValue("@mat_khau", ND.MatKhau);

            SqlParameter quyenTruyCapParam = new SqlParameter("@quyen_truy_cap", SqlDbType.Int);
            quyenTruyCapParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(quyenTruyCapParam);

            cmd.ExecuteNonQuery();
            DongKetNoi();

            return Convert.ToInt32(cmd.Parameters["@quyen_truy_cap"].Value);
        }
    }
}
