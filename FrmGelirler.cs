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
    public partial class FrmGelirler : Form
    {
        public FrmGelirler()
        {
            InitializeComponent();
        }
        SqlBaglantısı Methods = new SqlBaglantısı();
        private void FrmGelirler_Load(object sender, EventArgs e)
        {
            DataTable dataTbl = Methods.GetDataTable("Select * from AidatÖdemeTablosu");
            foreach (DataRow  data in dataTbl.Rows)
            {
                listBox1.Items.Add(data["DaireNo"]).ToString();
                listBox2.Items.Add(data["Para"]).ToString();
                listBox3.Items.Add(data["Tarih"]).ToString();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            int daireNo = Convert.ToInt32(CmbBxNo.Text);    
            int Para = Convert.ToInt32(numericUpDown1.Value);
            DateTime dt = dateTimePicker1.Value;
            
            if (numericUpDown1.Value > 1500)
            {
                ErrorProvider error = new ErrorProvider();
                error.SetError(numericUpDown1, "En fazla 1500 Yatırılabilir");
                numericUpDown1.Value = 1500;
            }
            if (numericUpDown1.Value<=1500 && CmbBxNo.Text!="")
            {
                SqlParameter parametre1 = new SqlParameter("Daireno", daireNo);
                SqlParameter parametre2 = new SqlParameter("Para", Para);
                SqlParameter parametre3 = new SqlParameter("Tarih", dt);

                Methods.ExeCuteProc("Aidat", parametre1, parametre2, parametre3);
            }
        }
    }
}
