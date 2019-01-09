using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class MalKabul : Form
    {
        public MalKabul()
        {
            InitializeComponent();
        }

        private void MalKabul_Load(object sender, EventArgs e)
        {
            lstUrunler.DataSource = new UrunDetayRepo().GetAll();
        }
        List<UrunDetay> aramalar;
        List<UrunDetay> urunDetaylar;

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtAra.Text.ToLower();

            aramalar = new UrunDetayRepo().GetAll();
            urunDetaylar = null;
            urunDetaylar.Where(urun => urun.Aciklama.ToLower().Contains(ara)).ToList().ForEach(urun => aramalar.Add(urun));
            lstUrunler.DataSource = null;
            lstUrunler.DataSource = aramalar;
        }
    }
}
