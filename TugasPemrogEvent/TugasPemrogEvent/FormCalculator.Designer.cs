namespace TugasPemrogEvent
{
    partial class FormCalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProses = new System.Windows.Forms.Button();
            this.NilaiB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NilaiA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Operasi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.80723F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.19277F));
            this.tableLayoutPanel1.Controls.Add(this.btnProses, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NilaiA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Operasi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NilaiB, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 179);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // btnProses
            // 
            this.btnProses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProses.AutoSize = true;
            this.btnProses.Location = new System.Drawing.Point(121, 136);
            this.btnProses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(243, 38);
            this.btnProses.TabIndex = 13;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.BtnProses_Click);
            // 
            // NilaiB
            // 
            this.NilaiB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NilaiB.Location = new System.Drawing.Point(121, 81);
            this.NilaiB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(243, 26);
            this.NilaiB.TabIndex = 12;
            this.NilaiB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nilai B";
            // 
            // NilaiA
            // 
            this.NilaiA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NilaiA.Location = new System.Drawing.Point(121, 44);
            this.NilaiA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(243, 26);
            this.NilaiA.TabIndex = 10;
            this.NilaiA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nilai A";
            // 
            // Operasi
            // 
            this.Operasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Operasi.FormattingEnabled = true;
            this.Operasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.Operasi.Location = new System.Drawing.Point(121, 5);
            this.Operasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Operasi.Name = "Operasi";
            this.Operasi.Size = new System.Drawing.Size(243, 28);
            this.Operasi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Operasi";
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(395, 209);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NilaiA;
        private System.Windows.Forms.ComboBox Operasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NilaiB;
    }
}