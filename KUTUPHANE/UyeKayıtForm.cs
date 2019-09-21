using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUTUPHANE
{
    public partial class UyeKayıtForm : Form
    {
        KUTUPHANEEntities1 db = new KUTUPHANEEntities1();
        int satir = -1;
        public UyeKayıtForm()
        {
            InitializeComponent();
        }

        private void UyeKayıtForm_Load(object sender, EventArgs e)
        {
            //form acılınca gridi veritabanında varolan üye bilgileriyle doldurur
            var uyeliste = db.UYEs.ToList();
            dataGridView1.DataSource = uyeliste;
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //gridde satıra tıklanınca veriler textboxlar ve datetimepicker içine dolduruluyor
            satir = e.RowIndex;
            if (satir > -1)
            {
                txtUYE_REFNO.Text = dataGridView1.Rows[satir].Cells["UYE_REFNO"].Value.ToString();
                txtADI_SOYAD.Text = dataGridView1.Rows[satir].Cells["ADI_SOYAD"].Value.ToString();
                txtADRES.Text = dataGridView1.Rows[satir].Cells["ADRES"].Value.ToString();
                txtTELEFON.Text = dataGridView1.Rows[satir].Cells["TELEFON"].Value.ToString();
                txtEMAIL.Text = dataGridView1.Rows[satir].Cells["EMAIL"].Value.ToString();
                txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
                dtEKLEME_TARIHI.Text = dataGridView1.Rows[satir].Cells["EKLEME_TARIHI"].Value.ToString();
                cmbDURUMU.Text = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
            }
        }

        private void BtnYENİ_Click(object sender, EventArgs e)
        {
            //yeni
            txtUYE_REFNO.Text = "";
            txtTELEFON.Text = "";
            txtEMAIL.Text = "";
            txtADRES.Text = "";
            txtADI_SOYAD.Text = "";
            txtACIKLAMA.Text = "";
            dtEKLEME_TARIHI.Text = "";
            cmbDURUMU.Text = "";
        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            //uye kaydet
            UYE uye = new UYE();

            //Üye bililerini eksik girilmemesi için UyarıForm oluşturuldu ve if else ile kontrol edildi
            string mesaj = "";

            if (txtTELEFON.Text == "")
            {
                mesaj = "Telefon bilgisini giriniz.\r\n";
            }
            if (txtEMAIL.Text == "")
            {
                mesaj += "Email giriniz.\r\n";
            }
            if (txtADRES.Text == "")
            {
                mesaj += "Adres bilisini giriniz.\r\n";
            }
            if (dtEKLEME_TARIHI.Text == "")
            {
                mesaj += "Ekleme Tarihini giriniz\r\n";
            }
            if (txtADI_SOYAD.Text == "")
            {
                mesaj += "Üyenin ad soyad bilgisini giriniz.\r\n";
            }
            if (cmbDURUMU.Text == "")
            {
                mesaj += "Üyenin Durumu(Aktif,Pasif) giriniz.\r\n";
            }


            if (mesaj != "")
            {
                UyarıForm f1 = new UyarıForm();
                f1.textBox1.Text = mesaj;
                f1.ShowDialog();
                return;
            }

            if (txtUYE_REFNO.Text != "")
            {
                //üye UPDATE işlemi
                uye = db.UYEs.Find(Convert.ToInt32(txtUYE_REFNO.Text));

                uye.TELEFON = txtTELEFON.Text;
                uye.EKLEME_TARIHI = Convert.ToDateTime(dtEKLEME_TARIHI.Text);
                uye.EMAIL = txtEMAIL.Text;
                uye.ADRES = txtADRES.Text;
                uye.ADI_SOYAD = txtADI_SOYAD.Text;
                uye.ACIKLAMA = txtACIKLAMA.Text;
                uye.DURUMU = Convert.ToBoolean(cmbDURUMU.Text);

                db.SaveChanges();
            }
            else
            {//uye INSERT işlemi

                uye.TELEFON = txtTELEFON.Text;
                uye.EKLEME_TARIHI = Convert.ToDateTime(dtEKLEME_TARIHI.Text);
                uye.EMAIL = txtEMAIL.Text;
                uye.ADRES = txtADRES.Text;
                uye.ADI_SOYAD = txtADI_SOYAD.Text;
                uye.ACIKLAMA = txtACIKLAMA.Text;
                uye.DURUMU = Convert.ToBoolean(cmbDURUMU.Text);

                db.UYEs.Add(uye);
                db.SaveChanges();
            }
            var uyeliste = db.UYEs.ToList();
            dataGridView1.DataSource = uyeliste;
        }

        private void BtnVAZGEC_Click(object sender, EventArgs e)
        {
            //vazgec
            if (satir > -1)
            {
                txtUYE_REFNO.Text = dataGridView1.Rows[satir].Cells["UYE_REFNO"].Value.ToString();
                txtADI_SOYAD.Text = dataGridView1.Rows[satir].Cells["ADI_SOYAD"].Value.ToString();
                txtADRES.Text = dataGridView1.Rows[satir].Cells["ADRES"].Value.ToString();
                txtTELEFON.Text = dataGridView1.Rows[satir].Cells["TELEFON"].Value.ToString();
                txtEMAIL.Text = dataGridView1.Rows[satir].Cells["EMAIL"].Value.ToString();
                txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
                dtEKLEME_TARIHI.Text = dataGridView1.Rows[satir].Cells["EKLEME_TARIHI"].Value.ToString();
                cmbDURUMU.Text = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
            }
        }

        private void BtnSIL_Click(object sender, EventArgs e)
        {
            //uye sil
            //uye silmeden önce kullanıcıya soru soruluyor
            DialogResult dr = MessageBox.Show("Üye silinecek.Onaylıyor musunuz?", "DİKKAT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            if (txtUYE_REFNO.Text != "")
            {
                UYE m = db.UYEs.Find(Convert.ToInt32(txtUYE_REFNO.Text));
                db.UYEs.Remove(m);
                db.SaveChanges();

                var uyeliste = db.UYEs.ToList();
                dataGridView1.DataSource = uyeliste;
            }
        }
    }
}
