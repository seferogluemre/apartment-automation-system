namespace Apartman_Otomasyon_Sistemi
{
    partial class FrmGiderler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatepckTarih = new System.Windows.Forms.DateTimePicker();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckTemizlik = new System.Windows.Forms.CheckBox();
            this.CheckAsansör = new System.Windows.Forms.CheckBox();
            this.CheckSu = new System.Windows.Forms.CheckBox();
            this.CheckElektrik = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEkle);
            this.panel1.Controls.Add(this.DatepckTarih);
            this.panel1.Controls.Add(this.TxtTutar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CheckTemizlik);
            this.panel1.Controls.Add(this.CheckAsansör);
            this.panel1.Controls.Add(this.CheckSu);
            this.panel1.Controls.Add(this.CheckElektrik);
            this.panel1.Location = new System.Drawing.Point(39, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 146);
            this.panel1.TabIndex = 1;
            // 
            // DatepckTarih
            // 
            this.DatepckTarih.Location = new System.Drawing.Point(224, 63);
            this.DatepckTarih.Name = "DatepckTarih";
            this.DatepckTarih.Size = new System.Drawing.Size(200, 27);
            this.DatepckTarih.TabIndex = 7;
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(224, 17);
            this.TxtTutar.MaxLength = 6;
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(200, 27);
            this.TxtTutar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutar:";
            // 
            // CheckTemizlik
            // 
            this.CheckTemizlik.AutoSize = true;
            this.CheckTemizlik.Location = new System.Drawing.Point(19, 110);
            this.CheckTemizlik.Name = "CheckTemizlik";
            this.CheckTemizlik.Size = new System.Drawing.Size(83, 24);
            this.CheckTemizlik.TabIndex = 3;
            this.CheckTemizlik.Text = "Temizlik";
            this.CheckTemizlik.UseVisualStyleBackColor = true;
            // 
            // CheckAsansör
            // 
            this.CheckAsansör.AutoSize = true;
            this.CheckAsansör.Location = new System.Drawing.Point(19, 80);
            this.CheckAsansör.Name = "CheckAsansör";
            this.CheckAsansör.Size = new System.Drawing.Size(82, 24);
            this.CheckAsansör.TabIndex = 2;
            this.CheckAsansör.Text = "Asansör";
            this.CheckAsansör.UseVisualStyleBackColor = true;
            // 
            // CheckSu
            // 
            this.CheckSu.AutoSize = true;
            this.CheckSu.Location = new System.Drawing.Point(19, 50);
            this.CheckSu.Name = "CheckSu";
            this.CheckSu.Size = new System.Drawing.Size(45, 24);
            this.CheckSu.TabIndex = 1;
            this.CheckSu.Text = "Su";
            this.CheckSu.UseVisualStyleBackColor = true;
            // 
            // CheckElektrik
            // 
            this.CheckElektrik.AutoSize = true;
            this.CheckElektrik.Location = new System.Drawing.Point(19, 20);
            this.CheckElektrik.Name = "CheckElektrik";
            this.CheckElektrik.Size = new System.Drawing.Size(79, 24);
            this.CheckElektrik.TabIndex = 0;
            this.CheckElektrik.Text = "Elektrik";
            this.CheckElektrik.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(39, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 204);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(190, 184);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(131, 204);
            this.listBox2.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(340, 184);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(131, 204);
            this.listBox3.TabIndex = 4;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(224, 96);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(200, 38);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(183)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(498, 400);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderler";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CheckTemizlik;
        private System.Windows.Forms.CheckBox CheckAsansör;
        private System.Windows.Forms.CheckBox CheckSu;
        private System.Windows.Forms.CheckBox CheckElektrik;
        private System.Windows.Forms.DateTimePicker DatepckTarih;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button BtnEkle;
    }
}