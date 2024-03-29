﻿using System;
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
    public partial class FormHasil : Form
    {
        public FormHasil()
        {
            InitializeComponent();
        }

        private void Perhitungan(int nilaiA, int nilaiB, int index)
        {
            int hasil;

            if (index == 0)
            {
                hasil = nilaiA + nilaiB;
                lstHasil.Items.Add(string.Format("Hasil penjumlahan {0} + {1} = {2}", nilaiA, nilaiB, hasil));
            }
            else if (index == 1)
            {
                hasil = nilaiA - nilaiB;
                lstHasil.Items.Add(string.Format("Hasil pengurangan {0} - {1} = {2}", nilaiA, nilaiB, hasil));
            }
            else if (index == 2)
            {
                hasil = nilaiA * nilaiB;
                lstHasil.Items.Add(string.Format("Hasil perkalian {0} * {1} = {2}", nilaiA, nilaiB, hasil));
            }
            else if (index == 3)
            {
                hasil = nilaiA / nilaiB;
                lstHasil.Items.Add(string.Format("Hasil pembagian {0} / {1} = {2}", nilaiA, nilaiB, hasil));
            }
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            FormCalculator frmC = new FormCalculator();
            frmC.Perhitungan += Perhitungan;
            frmC.ShowDialog();
        }
    }
}
