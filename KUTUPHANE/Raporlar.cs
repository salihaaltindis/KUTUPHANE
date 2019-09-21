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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }
        private void KitapListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kitap Listesi Raporu
            KitapListesiRaporu kitapfrm = new KitapListesiRaporu();
            kitapfrm.ShowDialog();
        }

        private void ÜyeListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Uye Listesi Raporu
            UyeListesiRaporu uyekayıtfrm = new UyeListesiRaporu();
            uyekayıtfrm.ShowDialog();
        }

        private void ÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bütün Ödünç Verilen Kitapların Listesi Raporu
            OduncKitapListesiRaporu odunckitapfrm = new OduncKitapListesiRaporu();
            odunckitapfrm.ShowDialog();
        }

        private void ÜyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Üye Ekleme Güncelleme Form
            UyeKayıtForm yeniuyefrm = new UyeKayıtForm();
            yeniuyefrm.ShowDialog();
        }
        private void YeniKitapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kitap Ekleme Güncelleme Form
            KitapKayıtForm yenikitapfrm = new KitapKayıtForm();
            yenikitapfrm.ShowDialog();
        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Ödünç Kitap Form
            OduncKitapForm yeniodunckitapfrm = new OduncKitapForm();
            yeniodunckitapfrm.ShowDialog();
        }
        private void ÖdünçVerilenKitapDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ödünç Verilen Kitapların Durumu
            KitapDurumForm kitapdurumfrm = new KitapDurumForm();
            kitapdurumfrm.ShowDialog();
        }
        private void AlınanÖdünçKitapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ödünç Alınan Kitapları Tarihe Göre Sıralama Form
            AlınanOduncKıtapSıralamaFormu alınanodunckıtapfrm = new AlınanOduncKıtapSıralamaFormu();
            alınanodunckıtapfrm.ShowDialog();
        }
    }
}
