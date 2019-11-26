using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPemrogEvent
{
    public partial class FormCalculator : Form
    {
        public delegate void CreateUpdateEventHandler(int nilaiA, int nilaiB, int index);

        public event CreateUpdateEventHandler Perhitungan;
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnProses_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(NilaiA.Text);
            var b = Convert.ToInt32(NilaiB.Text);

            Perhitungan(a, b, Operasi.SelectedIndex);
        }
    }
}
