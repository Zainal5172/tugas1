using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            lblNIM.Text   ="NIM  : 22.11.5172";
            lblNama.Text  ="Nama : M. Zainal Abidin";
            lblKelas.Text ="Kelas : S1-22IF10";
        }

        private void btnKosong_Click(object sender, EventArgs e)
        {
            lblNIM.Text = "NIM  : ";
            lblNama.Text = "Nama : ";
            lblKelas.Text = "Kelas : ";
        }
    }
}
