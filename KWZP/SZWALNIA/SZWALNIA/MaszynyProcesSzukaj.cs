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
    public partial class MaszynyProcesSzukaj : Form
    {
        private SzwalniaEntities szwalnia;
        public MaszynyProcesSzukaj(SzwalniaEntities db)
        {
            InitializeComponent();
            szwalnia = db;
        }
        private void btnSzukaj_Click_1(object sender, EventArgs e)
        {
            MaszynyProcesWykonaj maszynyProcesWykonaj = new MaszynyProcesWykonaj(szwalnia, txtbSzukaj.Text);
            maszynyProcesWykonaj.Show();
        }
    }
}
