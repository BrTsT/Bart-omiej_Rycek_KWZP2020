using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SZWALNIA
{
    public partial class Start : Form
    {
        public SzwalniaEntities szwalnia;
        public Start()
        {
            InitializeComponent();
            szwalnia = new SzwalniaEntities();
        }
        private void btnPrzygotowanieProdukcji_Click(object sender, EventArgs e)
        {
            PrzygotowanieProdukcji przygotowanieProdukcji = new PrzygotowanieProdukcji(szwalnia);
            przygotowanieProdukcji.Show();
        }
    }
}
