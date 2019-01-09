using Market.DAL;
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
    public partial class MarketOtomasyon : Form
    {
        public MarketOtomasyon()
        {
            InitializeComponent();
        }
        private Satıs satisForm;
        private MalKabul MalKabulForm;
        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (satisForm == null || satisForm.IsDisposed)
            {
                satisForm = new Satıs();
            }
            satisForm.MdiParent = this;
            satisForm.Show();
        }

        private void malGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MalKabulForm == null || MalKabulForm.IsDisposed)
            {
                MalKabulForm = new MalKabul();
            }
            MalKabulForm.MdiParent = this;
            MalKabulForm.Show();
        }

        private void MarketOtomasyon_Load(object sender, EventArgs e)
        {
            
        }
    }
}
