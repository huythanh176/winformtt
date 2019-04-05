using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ThaoTacCSDL
    {
        SqlConnection GetConnection;
        private void KetnoiCSDL()
        {
            GetConnection = new SqlConnection("Data Source=DESKTOP-96ROPSG;Initial Catalog=QLBH;Integrated Security=true");
            GetConnection.Open();

        }
        private void NgatKetNoi()
        {
            GetConnection.Close();
            GetConnection.Dispose();
        }
        public DataTable SQL_LayDuLieu(string TenSP)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(TenSP, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
        }
        public DataTable SQL_LayDuLieu_codk(string TenSP, string[] name, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(TenSP, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
            
            
        }
        public int sQL_thuchien(string TenSP,string[] name,object[] value,int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(TenSP, GetConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            for(int i=0;i<Npara;i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
         }
    }
}
