using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            var kategoriler = new KategoriRepo().GetAll();
            lstKategori.DataSource = kategoriler;
        }

        private void btnKatEkle_Click(object sender, EventArgs e)
        {
            var kategori = new Kategori
            {
                KategoriAdi = txtKategori.Text,
                Aciklama = txtKategoriAciklama.Text
            };
            var kategoriE = new KategoriRepo().Insert(kategori);
            if (kategoriE>0)
            {
                MessageBox.Show("Başarılı.");
            }
            else
            {
                MessageBox.Show("Kategori ekleme hatasi.");
            }
        }
    }
}
