using Market.BLL.Repository;
using System;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, System.EventArgs e)
        {
           // var suan = DateTime.Now;
           // //new KategoriRepo().GetAll(x=>x.);
           // //new UrunRepo().GetAll(x => x.);
           // //new SatisRepo().GetAll(x => x.);
           //label1.Text = new FisRepo().GetAll(x => x.EklenmeZamani>suan.AddMonths(-1)).ToString();
        }

       

        private void btnGunlukRapor_Click(object sender, EventArgs e)
        {

        }
    }
}
