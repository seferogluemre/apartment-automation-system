using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Otomasyon_Sistemi
{
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantısı dataMethods = new SqlBaglantısı();

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            DataTable data = dataMethods.GetDataTable("Select * From GiderlerTablosu");

            foreach (DataRow item in data.Rows)
            {
                listBox1.Items.Add(item[3].ToString());
                listBox2.Items.Add(item[1].ToString());
                listBox3.Items.Add(item[2].ToString());
                
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            DataTable data = dataMethods.GetDataTable("Select * from GiderlerTablosu");
            int para = Convert.ToInt32(TxtTutar.Text);
            DateTime dt = DatepckTarih.Value;
            string giderler = "";

            foreach (Control item in panel1.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    giderler += "," + item.Text;  
                }
            }
            giderler = giderler.Remove(0, 1);

            SqlParameter parameter3 = new SqlParameter("Para", para);
            SqlParameter parameter2 = new SqlParameter("Tarih",dt);
            SqlParameter parameter1 = new SqlParameter("Gider", giderler);
            dataMethods.ExeCuteProc("Giderlerim",parameter3,parameter2,parameter1);
            data = dataMethods.GetDataTable("select * from GiderlerTablosu");
        }
    }
}
