namespace KUTUPHANE
{
    partial class OduncKitapForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDURUMU = new System.Windows.Forms.ComboBox();
            this.txtODUNC_KITAP_REFNO = new System.Windows.Forms.TextBox();
            this.txtVERILIS_TARIHI = new System.Windows.Forms.TextBox();
            this.txtALINIS_TARIHI = new System.Windows.Forms.TextBox();
            this.txtACIKLAMA = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSIL = new System.Windows.Forms.Button();
            this.btnVAZGEC = new System.Windows.Forms.Button();
            this.btnKAYDET = new System.Windows.Forms.Button();
            this.btnYENİ = new System.Windows.Forms.Button();
            this.cmbADI_SOYAD = new System.Windows.Forms.ComboBox();
            this.cmbKITAP_REFNO = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ODUNC_KITAP_REFNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADI_SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KITAP_REFNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "VERILIS_TARIHI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ALINIS_TARIHI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(357, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DURUMU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ACIKLAMA";
            // 
            // cmbDURUMU
            // 
            this.cmbDURUMU.FormattingEnabled = true;
            this.cmbDURUMU.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbDURUMU.Location = new System.Drawing.Point(446, 63);
            this.cmbDURUMU.Name = "cmbDURUMU";
            this.cmbDURUMU.Size = new System.Drawing.Size(121, 21);
            this.cmbDURUMU.TabIndex = 7;
            // 
            // txtODUNC_KITAP_REFNO
            // 
            this.txtODUNC_KITAP_REFNO.Location = new System.Drawing.Point(174, 26);
            this.txtODUNC_KITAP_REFNO.Name = "txtODUNC_KITAP_REFNO";
            this.txtODUNC_KITAP_REFNO.ReadOnly = true;
            this.txtODUNC_KITAP_REFNO.Size = new System.Drawing.Size(100, 20);
            this.txtODUNC_KITAP_REFNO.TabIndex = 8;
            // 
            // txtVERILIS_TARIHI
            // 
            this.txtVERILIS_TARIHI.Location = new System.Drawing.Point(174, 138);
            this.txtVERILIS_TARIHI.MaxLength = 150;
            this.txtVERILIS_TARIHI.Name = "txtVERILIS_TARIHI";
            this.txtVERILIS_TARIHI.Size = new System.Drawing.Size(100, 20);
            this.txtVERILIS_TARIHI.TabIndex = 11;
            // 
            // txtALINIS_TARIHI
            // 
            this.txtALINIS_TARIHI.Location = new System.Drawing.Point(446, 26);
            this.txtALINIS_TARIHI.MaxLength = 11;
            this.txtALINIS_TARIHI.Name = "txtALINIS_TARIHI";
            this.txtALINIS_TARIHI.Size = new System.Drawing.Size(100, 20);
            this.txtALINIS_TARIHI.TabIndex = 12;
            // 
            // txtACIKLAMA
            // 
            this.txtACIKLAMA.Location = new System.Drawing.Point(446, 104);
            this.txtACIKLAMA.MaxLength = 500;
            this.txtACIKLAMA.Multiline = true;
            this.txtACIKLAMA.Name = "txtACIKLAMA";
            this.txtACIKLAMA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtACIKLAMA.Size = new System.Drawing.Size(279, 68);
            this.txtACIKLAMA.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 183);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // btnSIL
            // 
            this.btnSIL.Location = new System.Drawing.Point(524, 223);
            this.btnSIL.Name = "btnSIL";
            this.btnSIL.Size = new System.Drawing.Size(75, 23);
            this.btnSIL.TabIndex = 24;
            this.btnSIL.Text = "SİL";
            this.btnSIL.UseVisualStyleBackColor = true;
            this.btnSIL.Click += new System.EventHandler(this.BtnSIL_Click);
            // 
            // btnVAZGEC
            // 
            this.btnVAZGEC.Location = new System.Drawing.Point(402, 223);
            this.btnVAZGEC.Name = "btnVAZGEC";
            this.btnVAZGEC.Size = new System.Drawing.Size(75, 23);
            this.btnVAZGEC.TabIndex = 23;
            this.btnVAZGEC.Text = "VAZGEÇ";
            this.btnVAZGEC.UseVisualStyleBackColor = true;
            this.btnVAZGEC.Click += new System.EventHandler(this.BtnVAZGEC_Click);
            // 
            // btnKAYDET
            // 
            this.btnKAYDET.Location = new System.Drawing.Point(280, 223);
            this.btnKAYDET.Name = "btnKAYDET";
            this.btnKAYDET.Size = new System.Drawing.Size(75, 23);
            this.btnKAYDET.TabIndex = 22;
            this.btnKAYDET.Text = "KAYDET";
            this.btnKAYDET.UseVisualStyleBackColor = true;
            this.btnKAYDET.Click += new System.EventHandler(this.BtnKAYDET_Click);
            // 
            // btnYENİ
            // 
            this.btnYENİ.Location = new System.Drawing.Point(158, 223);
            this.btnYENİ.Name = "btnYENİ";
            this.btnYENİ.Size = new System.Drawing.Size(75, 23);
            this.btnYENİ.TabIndex = 21;
            this.btnYENİ.Text = "YENİ";
            this.btnYENİ.UseVisualStyleBackColor = true;
            this.btnYENİ.Click += new System.EventHandler(this.BtnYENİ_Click);
            // 
            // cmbADI_SOYAD
            // 
            this.cmbADI_SOYAD.FormattingEnabled = true;
            this.cmbADI_SOYAD.Location = new System.Drawing.Point(174, 67);
            this.cmbADI_SOYAD.Name = "cmbADI_SOYAD";
            this.cmbADI_SOYAD.Size = new System.Drawing.Size(100, 21);
            this.cmbADI_SOYAD.TabIndex = 25;
            // 
            // cmbKITAP_REFNO
            // 
            this.cmbKITAP_REFNO.FormattingEnabled = true;
            this.cmbKITAP_REFNO.Location = new System.Drawing.Point(174, 104);
            this.cmbKITAP_REFNO.Name = "cmbKITAP_REFNO";
            this.cmbKITAP_REFNO.Size = new System.Drawing.Size(100, 21);
            this.cmbKITAP_REFNO.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OduncKitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(760, 471);
            this.Controls.Add(this.cmbKITAP_REFNO);
            this.Controls.Add(this.cmbADI_SOYAD);
            this.Controls.Add(this.btnSIL);
            this.Controls.Add(this.btnVAZGEC);
            this.Controls.Add(this.btnKAYDET);
            this.Controls.Add(this.btnYENİ);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtACIKLAMA);
            this.Controls.Add(this.txtALINIS_TARIHI);
            this.Controls.Add(this.txtVERILIS_TARIHI);
            this.Controls.Add(this.txtODUNC_KITAP_REFNO);
            this.Controls.Add(this.cmbDURUMU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OduncKitapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Kitap Ekranı";
            this.Load += new System.EventHandler(this.OduncKitapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDURUMU;
        private System.Windows.Forms.TextBox txtODUNC_KITAP_REFNO;
        private System.Windows.Forms.TextBox txtVERILIS_TARIHI;
        private System.Windows.Forms.TextBox txtALINIS_TARIHI;
        private System.Windows.Forms.TextBox txtACIKLAMA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSIL;
        private System.Windows.Forms.Button btnVAZGEC;
        private System.Windows.Forms.Button btnKAYDET;
        private System.Windows.Forms.Button btnYENİ;
        private System.Windows.Forms.ComboBox cmbADI_SOYAD;
        private System.Windows.Forms.ComboBox cmbKITAP_REFNO;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}