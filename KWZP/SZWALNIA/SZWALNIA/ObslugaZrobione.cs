﻿using System;
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
    public partial class ObslugaZrobione : Form
    {
        public ObslugaZrobione(SzwalniaEntities db, String rodzajObslugi)
        {
            InitializeComponent();
            Obsluga_Techniczna obsulga = db.Obsluga_Techniczna.Where(rodzaj => rodzaj.Rodzaj_Obslugi.Nazwa == rodzajObslugi).First();
            lblTitle.Text = obsulga.Rodzaj_Obslugi.Nazwa;
            txtRodzaj.Text = obsulga.Rodzaj_Obslugi.Nazwa;
            Srodki_Trwale srodki = db.Srodki_Trwale(producent => producent);
            txtMaszyna.Text = srodki.Producent;
            txtPracownik.Text = obsulga.Pracownicy.Nazwisko;
            txtData.Text = obsulga.Data_Wykonania.ToString();
            dgvObsluga.DataSource = db.vObsluga.Where(rodzaj => rodzaj.Nazwa == rodzajObslugi).ToList();
        }
    }
}
