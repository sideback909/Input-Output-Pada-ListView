using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            if(!mskNpm.MaskFull)
            {
                MessageBox.Show("Npm Harus Diisi!!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskNpm.Focus();
                return;
            }
            if (!(txtNama.Text.Length > 0))
            {
                MessageBox.Show("Nama Harus Diisi!!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskNpm.Focus();
                return;
            }
            if (!(txtTempatLahir.Text.Length > 0))
            {
                MessageBox.Show("Tempat Lahir Harus Diisi!!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskNpm.Focus();
                return;
            }

            var jenisKelamin = rdoLakilaki.Checked ? "Laki-laki" : "Perempuan";

            var msg = string.Format("NPM: {0} \nNama: {1} \nJenis Kelamin: {2} \nTempat&Tanggal Lahir: {3}, {4}", mskNpm.Text, txtNama.Text, jenisKelamin, txtTempatLahir.Text, dptTanggalLahir.Text);

            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            var msg = "Apakah Anda Yakin";

            var result = MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
