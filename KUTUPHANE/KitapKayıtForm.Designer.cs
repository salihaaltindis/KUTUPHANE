namespace KUTUPHANE
{
    partial class KitapKayıtForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnYENİ = new System.Windows.Forms.Button();
            this.btnKAYDET = new System.Windows.Forms.Button();
            this.btnVAZGEC = new System.Windows.Forms.Button();
            this.btnSIL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKITAP_REFNO = new System.Windows.Forms.TextBox();
            this.txtADI = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtYAZARI = new System.Windows.Forms.TextBox();
            this.txtYAYIN_EVI = new System.Windows.Forms.TextBox();
            this.dtBASIM_TARIHI = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOZET = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYENİ
            // 
            this.btnYENİ.Location = new System.Drawing.Point(152, 203);
            this.btnYENİ.Name = "btnYENİ";
            this.btnYENİ.Size = new System.Drawing.Size(75, 23);
            this.btnYENİ.TabIndex = 8;
            this.btnYENİ.Text = "YENİ";
            this.btnYENİ.UseVisualStyleBackColor = true;
            this.btnYENİ.Click += new System.EventHandler(this.BtnYENI_Click);
            // 
            // btnKAYDET
            // 
            this.btnKAYDET.Location = new System.Drawing.Point(274, 203);
            this.btnKAYDET.Name = "btnKAYDET";
            this.btnKAYDET.Size = new System.Drawing.Size(75, 23);
            this.btnKAYDET.TabIndex = 9;
            this.btnKAYDET.Text = "KAYDET";
            this.btnKAYDET.UseVisualStyleBackColor = true;
            this.btnKAYDET.Click += new System.EventHandler(this.BtnKAYDET_Click);
            // 
            // btnVAZGEC
            // 
            this.btnVAZGEC.Location = new System.Drawing.Point(396, 203);
            this.btnVAZGEC.Name = "btnVAZGEC";
            this.btnVAZGEC.Size = new System.Drawing.Size(75, 23);
            this.btnVAZGEC.TabIndex = 10;
            this.btnVAZGEC.Text = "VAZGEÇ";
            this.btnVAZGEC.UseVisualStyleBackColor = true;
            this.btnVAZGEC.Click += new System.EventHandler(this.BtnVAZGEC_Click);
            // 
            // btnSIL
            // 
            this.btnSIL.Location = new System.Drawing.Point(518, 203);
            this.btnSIL.Name = "btnSIL";
            this.btnSIL.Size = new System.Drawing.Size(75, 23);
            this.btnSIL.TabIndex = 11;
            this.btnSIL.Text = "SİL";
            this.btnSIL.UseVisualStyleBackColor = true;
            this.btnSIL.Click += new System.EventHandler(this.BtnSIL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "KITAP_REFNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(56, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "YAZARI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(386, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "BASIM_TARIHI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(386, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "YAYIN_EVI";
            // 
            // txtKITAP_REFNO
            // 
            this.txtKITAP_REFNO.Location = new System.Drawing.Point(154, 10);
            this.txtKITAP_REFNO.Name = "txtKITAP_REFNO";
            this.txtKITAP_REFNO.ReadOnly = true;
            this.txtKITAP_REFNO.Size = new System.Drawing.Size(138, 20);
            this.txtKITAP_REFNO.TabIndex = 1;
            // 
            // txtADI
            // 
            this.txtADI.Location = new System.Drawing.Point(154, 52);
            this.txtADI.MaxLength = 100;
            this.txtADI.Name = "txtADI";
            this.txtADI.Size = new System.Drawing.Size(138, 20);
            this.txtADI.TabIndex = 2;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(154, 97);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(138, 20);
            this.txtISBN.TabIndex = 3;
            // 
            // txtYAZARI
            // 
            this.txtYAZARI.Location = new System.Drawing.Point(154, 136);
            this.txtYAZARI.MaxLength = 50;
            this.txtYAZARI.Name = "txtYAZARI";
            this.txtYAZARI.Size = new System.Drawing.Size(138, 20);
            this.txtYAZARI.TabIndex = 4;
            // 
            // txtYAYIN_EVI
            // 
            this.txtYAYIN_EVI.Location = new System.Drawing.Point(486, 52);
            this.txtYAYIN_EVI.MaxLength = 50;
            this.txtYAYIN_EVI.Name = "txtYAYIN_EVI";
            this.txtYAYIN_EVI.Size = new System.Drawing.Size(213, 20);
            this.txtYAYIN_EVI.TabIndex = 6;
            // 
            // dtBASIM_TARIHI
            // 
            this.dtBASIM_TARIHI.Location = new System.Drawing.Point(486, 10);
            this.dtBASIM_TARIHI.Name = "dtBASIM_TARIHI";
            this.dtBASIM_TARIHI.Size = new System.Drawing.Size(213, 20);
            this.dtBASIM_TARIHI.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "OZET";
            // 
            // txtOZET
            // 
            this.txtOZET.Location = new System.Drawing.Point(486, 94);
            this.txtOZET.MaxLength = 500;
            this.txtOZET.Multiline = true;
            this.txtOZET.Name = "txtOZET";
            this.txtOZET.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOZET.Size = new System.Drawing.Size(213, 62);
            this.txtOZET.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(750, 240);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // KitapKayıtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(750, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOZET);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtBASIM_TARIHI);
            this.Controls.Add(this.txtYAYIN_EVI);
            this.Controls.Add(this.txtYAZARI);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtADI);
            this.Controls.Add(this.txtKITAP_REFNO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSIL);
            this.Controls.Add(this.btnVAZGEC);
            this.Controls.Add(this.btnKAYDET);
            this.Controls.Add(this.btnYENİ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KitapKayıtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Kayıt Ekranı";
            this.Load += new System.EventHandler(this.KayıtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYENİ;
        private System.Windows.Forms.Button btnKAYDET;
        private System.Windows.Forms.Button btnVAZGEC;
        private System.Windows.Forms.Button btnSIL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKITAP_REFNO;
        private System.Windows.Forms.TextBox txtADI;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtYAZARI;
        private System.Windows.Forms.TextBox txtYAYIN_EVI;
        private System.Windows.Forms.DateTimePicker dtBASIM_TARIHI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOZET;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

