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
    public partial class KitapKayıtForm : Form
    {
        KUTUPHANEEntities1 db = new KUTUPHANEEntities1();
        int satir = -1;

        public KitapKayıtForm()
        {
            InitializeComponent();
        }

        private void KayıtForm_Load(object sender, EventArgs e)
        {
            //form acılınca gridi veritabanında varolan kitap bilgileriyle doldur
            var kitapliste = db.KITAPs.ToList();
            dataGridView1.DataSource = kitapliste;
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //gridde satıra tıklanınca veriler textboxlar ve datetimepicker içine dolduruluyor
            satir = e.RowIndex;
            if (satir > -1)
            {
                txtKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                txtADI.Text = dataGridView1.Rows[satir].Cells["ADI"].Value.ToString();
                txtISBN.Text = dataGridView1.Rows[satir].Cells["ISBN"].Value.ToString();
                txtYAZARI.Text = dataGridView1.Rows[satir].Cells["YAZARI"].Value.ToString();
                dtBASIM_TARIHI.Text = dataGridView1.Rows[satir].Cells["BASIM_TARIHI"].Value.ToString();
                txtYAYIN_EVI.Text = dataGridView1.Rows[satir].Cells["YAYIN_EVI"].Value.ToString();
                txtOZET.Text = dataGridView1.Rows[satir].Cells["OZET"].Value.ToString();
            }
        }
        private void BtnYENI_Click(object sender, EventArgs e)
        {//yeni kayıt
            txtADI.Text = "";
            txtISBN.Text = "";
            txtKITAP_REFNO.Text = "";
            txtOZET.Text = "";
            txtYAYIN_EVI.Text = "";
            txtYAZARI.Text = "";
            dtBASIM_TARIHI.Text = "";
        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {//kitap kaydet
            KITAP kitap = new KITAP();

            //Kitap bililerini eksik girilmemesi için UyarıForm oluşturuldu ve if else ile kontrol edildi
            string mesaj = "";

            if (txtADI.Text == "")
            {
                mesaj = "Kitabın adını giriniz.\r\n";
            }
            if (txtISBN.Text == "")
            {
                mesaj += "13 haneli uluslar arası kitap kodunu giriniz.\r\n";
            }
            if (txtYAZARI.Text == "")
            {
                mesaj += "Kitabın yazarının adı giriniz.\r\n";
            }
            if (dtBASIM_TARIHI.Text == "")
            {
                mesaj += "Kitabın basıldığı tarihi giriniz\r\n";
            }
            if (txtYAYIN_EVI.Text == "")
            {
                mesaj += "Kitabı yayınlayan firma adını giriniz.\r\n";
            }

            if (mesaj != "")
            {
                UyarıForm f1 = new UyarıForm();
                f1.textBox1.Text = mesaj;
                f1.ShowDialog();
                return;
            }

            if (txtKITAP_REFNO.Text != "")
            {
                //kitap UPDATE işlemi
                kitap = db.KITAPs.Find(Convert.ToInt32(txtKITAP_REFNO.Text));

                kitap.ADI = txtADI.Text;
                kitap.BASIM_TARIHI = Convert.ToDateTime(dtBASIM_TARIHI.Text);
                kitap.ISBN = txtISBN.Text;
                kitap.OZET = txtOZET.Text;
                kitap.YAZARI = txtYAZARI.Text;
                kitap.YAYIN_EVI = txtYAYIN_EVI.Text;

                db.SaveChanges();
            }
            else
            {//kitap INSERT işlemi

                kitap.ADI = txtADI.Text;
                kitap.BASIM_TARIHI = Convert.ToDateTime(dtBASIM_TARIHI.Text);
                kitap.ISBN = txtISBN.Text;
                kitap.OZET = txtOZET.Text;
                kitap.YAZARI = txtYAZARI.Text;
                kitap.YAYIN_EVI = txtYAYIN_EVI.Text;

                db.KITAPs.Add(kitap);
                db.SaveChanges();

            }
            var kitapliste = db.KITAPs.ToList();
            dataGridView1.DataSource = kitapliste;
        }

        private void BtnVAZGEC_Click(object sender, EventArgs e)
        {//vazgeç
            if (satir > -1)
            {
                txtKITAP_REFNO.Text = dataGridView1.Rows[satir].Cells["KITAP_REFNO"].Value.ToString();
                txtADI.Text = dataGridView1.Rows[satir].Cells["ADI"].Value.ToString();
                txtISBN.Text = dataGridView1.Rows[satir].Cells["ISBN"].Value.ToString();
                txtYAZARI.Text = dataGridView1.Rows[satir].Cells["YAZARI"].Value.ToString();
                dtBASIM_TARIHI.Text = dataGridView1.Rows[satir].Cells["BASIM_TARIHI"].Value.ToString();
                txtYAYIN_EVI.Text = dataGridView1.Rows[satir].Cells["YAYIN_EVI"].Value.ToString();
                txtOZET.Text = dataGridView1.Rows[satir].Cells["OZET"].Value.ToString();
            }
        }

        private void BtnSIL_Click(object sender, EventArgs e)
        {//kitap sil
            //kitap silmeden önce kullanıcıya soru soruluyor
            DialogResult dr = MessageBox.Show("Kitap silinecek.Onaylıyor musunuz?", "DİKKAT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            if (txtKITAP_REFNO.Text != "")
            {
                KITAP m = db.KITAPs.Find(Convert.ToInt32(txtKITAP_REFNO.Text));
                db.KITAPs.Remove(m);
                db.SaveChanges();

                var kitapliste = db.KITAPs.ToList();
                dataGridView1.DataSource = kitapliste;
            }

        }
    }
}
