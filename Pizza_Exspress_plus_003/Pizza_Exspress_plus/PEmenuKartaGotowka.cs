using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Exspress_plus
{
    public partial class PEmenuKartaGotowka : UserControl
    {
        public PEmenuKartaGotowka()
        {
            InitializeComponent();
        }
        // w menu pobiera platnosc
        private void kartaZmien(object sender, EventArgs e)
        {
            DaneOb.dodajInfoKG("Płatność kartą");
            DaneOb.dodajInfoMajak2(true);
        }

        private void gotowkaZmien(object sender, EventArgs e)
        {
            DaneOb.dodajInfoKG("Płatność gotówką");
            DaneOb.dodajInfoMajak2(true);
        }       
    }
}
