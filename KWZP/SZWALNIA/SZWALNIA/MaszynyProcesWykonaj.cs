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
          
            dgvRodzajMaszyny.DataSource = db.vMaszyny_rodzaj_liczba.Where(rodzaj => rodzaj.ID_Proces_Technologiczny.ToString() == maszynyProces).ToList();
        }
    }
}
