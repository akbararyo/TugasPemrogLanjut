namespace TugasPemrogEvent
{
    partial class FormHasil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstHasil = new System.Windows.Forms.ListBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHitung, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.30512F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.69488F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lstHasil);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(765, 381);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Hasil]";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // lstHasil
            // 
            this.lstHasil.FormattingEnabled = true;
            this.lstHasil.ItemHeight = 20;
            this.lstHasil.Location = new System.Drawing.Point(9, 29);
            this.lstHasil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(748, 324);
            this.lstHasil.TabIndex = 0;
            this.lstHasil.SelectedIndexChanged += new System.EventHandler(this.LstHasil_SelectedIndexChanged);
            // 
            // btnHitung
            // 
            this.btnHitung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHitung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHitung.Location = new System.Drawing.Point(13, 400);
            this.btnHitung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(765, 40);
            this.btnHitung.TabIndex = 2;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.BtnHitung_Click);
            // 
            // FormHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 464);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormHasil";
            this.Text = "HasilPerhitungan";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstHasil;
        private System.Windows.Forms.Button btnHitung;
    }
}