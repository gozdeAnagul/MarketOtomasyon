using Market.Models.ViewModels;
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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
            Models = new UrunKontrolViewModels();
        }
        public UrunKontrolViewModels Models;
    }
}
