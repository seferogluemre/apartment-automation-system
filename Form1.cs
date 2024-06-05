using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Otomasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult tepki = new DialogResult();
            tepki = MessageBox.Show("Sistemden Ayrılıyorsunuz", "Emin Misiniz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tepki==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FrmGelirler().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new FrmGiderler().Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
