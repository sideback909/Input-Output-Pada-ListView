namespace WindowsFormsApp1
{
    partial class FrmListMahasiswa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dptTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskNpm = new System.Windows.Forms.MaskedTextBox();
            this.rdoPerempuan = new System.Windows.Forms.RadioButton();
            this.rdoLakilaki = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dptTanggalLahir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTempatLahir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mskNpm);
            this.groupBox1.Controls.Add(this.rdoPerempuan);
            this.groupBox1.Controls.Add(this.rdoLakilaki);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Mahasiswa";
            // 
            // dptTanggalLahir
            // 
            this.dptTanggalLahir.CustomFormat = "dd/MM/yyyy";
            this.dptTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptTanggalLahir.Location = new System.Drawing.Point(101, 220);
            this.dptTanggalLahir.Name = "dptTanggalLahir";
            this.dptTanggalLahir.Size = new System.Drawing.Size(100, 20);
            this.dptTanggalLahir.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tanggal Lahir";
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Location = new System.Drawing.Point(101, 163);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(250, 20);
            this.txtTempatLahir.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tempat Lahir";
            // 
            // mskNpm
            // 
            this.mskNpm.Location = new System.Drawing.Point(101, 53);
            this.mskNpm.Mask = "##.##.####";
            this.mskNpm.Name = "mskNpm";
            this.mskNpm.Size = new System.Drawing.Size(100, 20);
            this.mskNpm.TabIndex = 20;
            // 
            // rdoPerempuan
            // 
            this.rdoPerempuan.AutoSize = true;
            this.rdoPerempuan.Location = new System.Drawing.Point(171, 120);
            this.rdoPerempuan.Name = "rdoPerempuan";
            this.rdoPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rdoPerempuan.TabIndex = 19;
            this.rdoPerempuan.TabStop = true;
            this.rdoPerempuan.Text = "Perempuan";
            this.rdoPerempuan.UseVisualStyleBackColor = true;
            // 
            // rdoLakilaki
            // 
            this.rdoLakilaki.AutoSize = true;
            this.rdoLakilaki.Location = new System.Drawing.Point(101, 120);
            this.rdoLakilaki.Name = "rdoLakilaki";
            this.rdoLakilaki.Size = new System.Drawing.Size(64, 17);
            this.rdoLakilaki.TabIndex = 18;
            this.rdoLakilaki.TabStop = true;
            this.rdoLakilaki.Text = "Laki-laki";
            this.rdoLakilaki.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Jenis Kelamin";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(101, 83);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(250, 20);
            this.txtNama.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "NPM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwMahasiswa);
            this.groupBox2.Location = new System.Drawing.Point(385, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 278);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daftar Mahasiswa";
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.Location = new System.Drawing.Point(6, 19);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(499, 253);
            this.lvwMahasiswa.TabIndex = 0;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            this.lvwMahasiswa.SelectedIndexChanged += new System.EventHandler(this.lvwMahasiswa_SelectedIndexChanged);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(821, 296);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 23);
            this.btnTutup.TabIndex = 11;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(12, 296);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 10;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(93, 296);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 0;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // FrmListMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmListMahasiswa";
            this.Text = "FrmListMahasiswa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dptTanggalLahir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskNpm;
        private System.Windows.Forms.RadioButton rdoPerempuan;
        private System.Windows.Forms.RadioButton rdoLakilaki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.ListView lvwMahasiswa;
        private System.Windows.Forms.Button btnHapus;
    }
}