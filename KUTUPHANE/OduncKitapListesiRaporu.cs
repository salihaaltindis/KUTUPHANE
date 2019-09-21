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
    public partial class OduncKitapListesiRaporu : Form
    {
        KUTUPHANEEntities1 db = new KUTUPHANEEntities1();

        public OduncKitapListesiRaporu()
        {
            InitializeComponent();
        }

        private void OduncKitapListesiRaporu_Load(object sender, EventArgs e)
        {
            var odunckitapliste = (from k in db.KITAPs
                                   from o in db.ODUNC_KITAP
                                   orderby o.ODUNC_KITAP_REFNO
                                   where k.KITAP_REFNO == o.KITAP_REFNO && o.DURUMU == true
                                   select new
                                   {
                                       KitapAdı = k.ADI,
                                       ÜyeADI = o.ADI_SOYAD,
                                       ISBN = k.ISBN,
                                       VerilişTarihi = o.VERILIS_TARIHI
                                   }).ToList();

            dataGridView1.DataSource = odunckitapliste;
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
    }
}
