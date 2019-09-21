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
    public partial class KitapListesiRaporu : Form
    {
        KUTUPHANEEntities1 db = new KUTUPHANEEntities1();

        int ToplamSatir = 0;
        int SayfadakiSatir = 10;
        int ToplamSayfa = 0;
        int AktifSayfa = 1;

        public KitapListesiRaporu()
        {
            InitializeComponent();
        }

        private void KitapListesiRaporu_Load_1(object sender, EventArgs e)
        {
            //Her sayfada 10 adet kayıt gösterilecek şekilde grid üzerinde sayfalama işlemi yapıldı Take , Skip methotları ile
            ToplamSatir = db.KITAPs.Count();
            ToplamSayfa = ToplamSatir / SayfadakiSatir;

            if (ToplamSatir % SayfadakiSatir != 0) ToplamSayfa++;

            var kitapliste =  (from KITAP in db.KITAPs
                               orderby KITAP.KITAP_REFNO 
                               select new { KitapAdı = KITAP.ADI, Yazarı = KITAP.YAZARI, ISBN = KITAP.ISBN,  BasımTarihi = KITAP.BASIM_TARIHI, YayınEvi = KITAP.YAYIN_EVI }).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();

            dataGridView1.DataSource = kitapliste;

        }

        private void ExceleAktar(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  

            //excel ing yada tr olabilir onu kontrol etmis olduk
            try
            {
                worksheet = workbook.Sheets["Sayfa1"];
            }
            catch (Exception)
            {

                worksheet = workbook.Sheets["Sheet1"];
            }

            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            //ilk for ile sutunları girdik header ları 2. for ile satırları girdik
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }  
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //bir ileri
            if (AktifSayfa < ToplamSayfa)
            {
                AktifSayfa++;
                var kitapliste = (from KITAP in db.KITAPs
                                  orderby KITAP.KITAP_REFNO
                                  select new { KitapAdı = KITAP.ADI, Yazarı = KITAP.YAZARI, ISBN = KITAP.ISBN, BasımTarihi = KITAP.BASIM_TARIHI, YayınEvi = KITAP.YAYIN_EVI }).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();

                dataGridView1.DataSource = kitapliste;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //son sayfa
            AktifSayfa = ToplamSayfa;
            var kitapliste = (from KITAP in db.KITAPs
                              orderby KITAP.KITAP_REFNO
                              select new { KitapAdı = KITAP.ADI, Yazarı = KITAP.YAZARI, ISBN = KITAP.ISBN, BasımTarihi = KITAP.BASIM_TARIHI, YayınEvi = KITAP.YAYIN_EVI }).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();

            dataGridView1.DataSource = kitapliste;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //bir geri
            if (AktifSayfa > 1)
            {
                AktifSayfa--;
                var kitapliste = (from KITAP in db.KITAPs
                                  orderby KITAP.KITAP_REFNO
                                  select new { KitapAdı = KITAP.ADI, Yazarı = KITAP.YAZARI, ISBN = KITAP.ISBN, BasımTarihi = KITAP.BASIM_TARIHI, YayınEvi = KITAP.YAYIN_EVI }).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();

                dataGridView1.DataSource = kitapliste;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //ilk sayfa
            AktifSayfa = 1;
            var kitapliste = (from KITAP in db.KITAPs
                              orderby KITAP.KITAP_REFNO
                              select new { KitapAdı = KITAP.ADI, Yazarı = KITAP.YAZARI, ISBN = KITAP.ISBN, BasımTarihi = KITAP.BASIM_TARIHI, YayınEvi = KITAP.YAYIN_EVI }).Skip((AktifSayfa - 1) * SayfadakiSatir).Take(SayfadakiSatir).ToList();

            dataGridView1.DataSource = kitapliste;
        }
    }
}
