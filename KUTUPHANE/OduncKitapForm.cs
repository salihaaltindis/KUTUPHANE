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
    public partial class OduncKitapForm : Form
    {
        KUTUPHANEEntities1 db = new KUTUPHANEEntities1();
        int satir = -1;

        //Uye ve Kitap isimlerini combobox a doldurmak için list olusturuldu
        List<UYE> UYELER = new List<UYE>();
        List<KITAP> KITAPLAR = new List<KITAP>();

        public OduncKitapForm()
        {
            InitializeComponent();
        }

        private void OduncKitapForm_Load(object sender, EventArgs e)
        {
            //form acılınca gridi veritabanında varolan ödünc kitap bilgileriyle doldur
            var odunckitapliste = db.ODUNC_KITAP.ToList();
            dataGridView1.DataSource = odunckitapliste;
 
            UYELER = db.UYEs.ToList();
            foreach (var i in UYELER)
            {
                cmbADI_SOYAD.Items.Add(i.ADI_SOYAD);
            }

            KITAPLAR = db.KITAPs.ToList();
            foreach (var i in KITAPLAR)
            {
                cmbKITAP_REFNO.Items.Add(i.KITAP_REFNO);
            }
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //gridde satıra tıklanınca veriler textboxlar ve datetimepicker içine dolduruluyor
            satir = e.RowIndex;
            if (satir > -1)
            {
                txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
                txtALINIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["ALINIS_TARIHI"].Value.ToString();
                cmbKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                cmbADI_SOYAD.Text = dataGridView1.Rows[satir].Cells["ADI_SOYAD"].Value.ToString();
                txtVERILIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["VERILIS_TARIHI"].Value.ToString();
                txtODUNC_KITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["ODUNC_KITAP_REFNO"].Value.ToString();
                cmbDURUMU.Text = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
            }
        }

        private void BtnYENİ_Click(object sender, EventArgs e)
        {
            //yeni
            txtODUNC_KITAP_REFNO.Text = "";
            cmbADI_SOYAD.Text = "";
            cmbKITAP_REFNO.Text = "";
            txtACIKLAMA.Text = "";
            txtALINIS_TARIHI.Text = "";
            txtVERILIS_TARIHI.Text = "";
            cmbDURUMU.Text = "";

        }

        private void BtnVAZGEC_Click(object sender, EventArgs e)
        {
            //vazgec
            if (satir > -1)
            {
                txtACIKLAMA.Text = dataGridView1.Rows[satir].Cells["ACIKLAMA"].Value.ToString();
                txtALINIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["ALINIS_TARIHI"].Value.ToString();
                cmbKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                cmbADI_SOYAD.Text = dataGridView1.Rows[satir].Cells["ADI_SOYAD"].Value.ToString();
                txtVERILIS_TARIHI.Text = dataGridView1.Rows[satir].Cells["VERILIS_TARIHI"].Value.ToString();
                txtODUNC_KITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["ODUNC_KITAP_REFNO"].Value.ToString();
                cmbDURUMU.Text = dataGridView1.Rows[satir].Cells["DURUMU"].Value.ToString();
            }
        }

        private void BtnSIL_Click(object sender, EventArgs e)
        {
            //odunc kitap sil
            //odunc alınan kitap silmeden önce kullanıcıya soru soruluyor
            DialogResult dr = MessageBox.Show("Ödünç alınan kitap bilgisi silinecek.Onaylıyor musunuz?", "DİKKAT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            if (txtODUNC_KITAP_REFNO.Text != "")
            {
                ODUNC_KITAP m = db.ODUNC_KITAP.Find(Convert.ToInt32(txtODUNC_KITAP_REFNO.Text));
                db.ODUNC_KITAP.Remove(m);
                db.SaveChanges();

                var odunckitapliste = db.ODUNC_KITAP.ToList();
                dataGridView1.DataSource = odunckitapliste;
            }
        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            //odunc kitap kaydet
            ODUNC_KITAP odunckitap = new ODUNC_KITAP();

            //Odunc kitap bilgilerini eksik girilmemesi için UyarıForm oluşturuldu ve if else ile kontrol edildi
            string mesaj = "";

            if (cmbADI_SOYAD.Text == "")
            {
                mesaj = "Üye adı ve soyadı giriniz.\r\n";
            }
            if (cmbKITAP_REFNO.Text == "")
            {
                mesaj = "Odunc verilecek kitabın id'sini giriniz.\r\n";
            }
            if (txtVERILIS_TARIHI.Text == "")
            {
                mesaj = "VERILIS_TARIHI giriniz.\r\n";
            }
            if (cmbDURUMU.Text == "")
            {
                mesaj += "Kitabın Durumu(Verildi,Alındı) giriniz.\r\n";
            }

            if (mesaj != "")
            {
                UyarıForm f1 = new UyarıForm();
                f1.textBox1.Text = mesaj;
                f1.ShowDialog();
                return;
            }

            if (txtODUNC_KITAP_REFNO.Text != "")
            {
                //odunc kitap UPDATE işlemi
                odunckitap = db.ODUNC_KITAP.Find(Convert.ToInt32(txtODUNC_KITAP_REFNO.Text));

                odunckitap.ACIKLAMA = txtACIKLAMA.Text;
                odunckitap.ALINIS_TARIHI = txtALINIS_TARIHI.Text;
                odunckitap.KITAP_REFNO = Convert.ToInt32(cmbKITAP_REFNO.Text);
                odunckitap.ADI_SOYAD = cmbADI_SOYAD.Text;
                odunckitap.VERILIS_TARIHI = txtVERILIS_TARIHI.Text;
                odunckitap.DURUMU = Convert.ToBoolean(cmbDURUMU.Text);

                db.SaveChanges();
            }
            else
            {//uye INSERT işlemi


                odunckitap.ACIKLAMA = txtACIKLAMA.Text;
                odunckitap.ALINIS_TARIHI = txtALINIS_TARIHI.Text;
                odunckitap.KITAP_REFNO = Convert.ToInt32(cmbKITAP_REFNO.Text);
                odunckitap.ADI_SOYAD = cmbADI_SOYAD.Text;
                odunckitap.VERILIS_TARIHI = txtVERILIS_TARIHI.Text;
                odunckitap.DURUMU = Convert.ToBoolean(cmbDURUMU.Text);

                db.ODUNC_KITAP.Add(odunckitap);
                db.SaveChanges();

            }
            var odunckitapliste = db.ODUNC_KITAP.ToList();
            dataGridView1.DataSource = odunckitapliste;
        }
    }
    }

