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
    public partial class PESouse : UserControl
    {
        List<Sous> menuS = new List<Sous>();
        public PESouse()
        {
            InitializeComponent();
            //menu souse
            menuS.Add(new Sous("Czosnkowy 80ml", 1.99, "80ml"));
            menuS.Add(new Sous("Czosnkowy 120ml", 2.99, "120ml"));
            menuS.Add(new Sous("Gyros 80ml", 1.99, "80ml"));
            menuS.Add(new Sous("Gyros 120ml", 2.99, "120ml"));
            menuS.Add(new Sous("Jalapeno 80ml", 1.99, "80ml"));
            menuS.Add(new Sous("Jalapeno 120ml", 2.99, "120ml"));
            menuS.Add(new Sous("Pomidorowy 80ml", 1.99, "80ml"));
            menuS.Add(new Sous("Pomidorowy 120ml", 2.99, "120ml"));
            menuS.Add(new Sous("Pikantny 80ml", 1.99, "80ml"));
            menuS.Add(new Sous("Pikantny 120ml", 2.99, "120ml"));
            menuS.Add(new Sous("Kabul 80ml", 1.99, "80ml"));
            menuS.Add(new Sous("Kabul 120ml", 2.99, "120ml"));
        }



        private void czosnkowy80Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[0]);
        }

        private void czosnkowy120Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[1]);
        }

        private void gyros80Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[2]);
        }

        private void gyros120Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[3]);
        }

        private void jalapeno80Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[4]);
        }

        private void jalapeno120Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[5]);
        }

        private void pomidorowy80Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[6]);
        }

        private void pomidorowy120Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[7]);
        }

        private void pikantny80Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[8]);
        }

        private void pikantny120Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[9]);
        }

        private void kabul80Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[10]);
        }

        private void kabul120Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuS[11]);
        }
    }
}
