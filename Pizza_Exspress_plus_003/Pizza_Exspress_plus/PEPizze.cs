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
    public partial class PEPizze : UserControl
    {
        List<Pizze> menuP = new List<Pizze>();
       
        public PEPizze()
        {
            
            InitializeComponent(); // Lista menu pizz
            menuP.Add(new Pizze("Pizza FUNGHI MAX", 30.90, "sos, pieczarki, ser", "Max"));
            menuP.Add(new Pizze("Pizza FUNGHI ŚRE", 19.90, "sos, pieczarki, ser", "Średnia"));
            menuP.Add(new Pizze("Pizza FUNGHI MAŁ", 16.90, "sos, pieczarki, ser", "Mała"));
            menuP.Add(new Pizze("Pizza PEPERONI ŚRE", 19.00, "salami, cebula, sos pomidorowy", "Średnia"));
            menuP.Add(new Pizze("Pizza PEPERONI MAŁ", 15.40, "salami, cebula, sos pomidorowy", "Mała"));
            menuP.Add(new Pizze("Pizza MIĘSNA MAX", 36.99, "mięso wołowe, sos pomidorowy", "Max"));
            menuP.Add(new Pizze("Pizza MIĘSNA ŚRE", 21.99, "mięso wołowe, sos pomidorowy", "Średnia"));
            menuP.Add(new Pizze("Pizza MIĘSNA MAŁ", 18.90, "mięso wołowe, sos pomidorowy", "Mała"));
            menuP.Add(new Pizze("Pizza RIMINI ŚRE", 17.80, "salami, pieczarki, sos pomidorowy", "Średnia"));
            menuP.Add(new Pizze("Pizza RIMINI MAŁ", 14.80, "salami, pieczarki, sos pomidorowy", "Mała"));
            menuP.Add(new Pizze("Pizza BARBECUE ŚRE", 18.50, "boczek, kurczak gyros, cebula, sos Barbecue", "Średnia"));
            menuP.Add(new Pizze("Pizza BARBECUE MAŁ", 14.50, "boczek, kurczak gyros, cebula, sos Barbecue", "Mała"));

        }


        private void funghiMaxDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[0]);
        }

        private void funghiSreDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[1]);
        }

        private void funghiMalDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[2]);
        }

        private void peperoniSreDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[3]);
        }

        private void peperoniMalDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[4]);
        }

        private void miesnaMaxDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[5]);
        }

        private void miesnaSreDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[6]);
        }

        private void miesnaMlaDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[7]);
        }

        private void riminiSreDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[8]);
        }
        private void riminiMlaDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[9]);
        }

        private void barbecueSreDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[10]);
        }

        private void barbecueMlaDodaj(object sender, EventArgs e)
        {
             DaneOb.dodaj((Product)menuP[11]);
        }
    }
}
