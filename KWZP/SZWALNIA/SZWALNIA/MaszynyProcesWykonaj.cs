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
    public partial class MaszynyProcesWykonaj : Form
    {
       public MaszynyProcesWykonaj(SzwalniaEntities db, String maszynyProces)
        {
            InitializeComponent();
            Proces_Zamowienie proces = db.Proces_Zamowienie.Where(id => id.ID_Proces_Technologiczny.ToString() == maszynyProces).First();
            lblIdMaszynyProces.Text = proces.ID_Proces_Technologiczny.ToString();
            Maszyny_Proces dane = db.Maszyny_Proces(rodzaj => rodzaj);
            txtRodzajMaszyny.Text = dane.Rodzaj_Maszyny.ToString();
            txtLiczba.Text = dane.Liczba_Maszyn.ToString();
            txtLiczbaRbh.Text = dane.Liczba_Rbh_Maszyna.ToString();
            dgvRodzajMaszyny.DataSource = db.vMaszyny_rodzaj_liczba.Where(rodzaj => rodzaj.ID_Proces_Technologiczny.ToString() == maszynyProces).ToList();
        }
    }
}
