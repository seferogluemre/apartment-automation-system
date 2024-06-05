using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Otomasyon_Sistemi
{
    class SqlBaglantısı
    {
        private string ConnectionString { get; set; }
        public SqlConnection Connection { get; set; }

        public SqlBaglantısı()
        {
            ConnectionString = "Data Source=EMRE_SEFEROGLU\\SQLEXPRESS;Initial Catalog=ApartmanSistemi;Integrated Security=True;Encrypt=False";
            Connection = new SqlConnection(ConnectionString);
        }

        public void ExeCuteProc(string procName,params SqlParameter[] Ps)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText= procName;
            command.Parameters.AddRange(Ps);
            command.Connection= Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("İşlem Gerçekleşti","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Connection.Close();
        }

        public DataTable GetDataTable(string Data)
        {
            SqlDataAdapter sda = new SqlDataAdapter(Data,ConnectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
       
    }
}
