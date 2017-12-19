using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pizza_Exspress_plus
{
    public partial class PEPodKarta : UserControl
    {
        public PEPodKarta()
        {
            InitializeComponent();
            if (DaneOb.Prod.Count > 0) { drukujPar.Enabled = true; }
            else { drukujPar.Enabled = false; }
        }
        // w menu wyswietla finalnu cenu dlia karty
        private void KrataPaint(object sender, PaintEventArgs e)
        {
            kartaP.Text = DaneOb.Final.ToString();
            // jesli reszta jest nie ujemna i jest towar na liscie do mozna drukowac paragon
            if (DaneOb.Prod.Count > 0) { drukujPar.Enabled = true; }
            else { drukujPar.Enabled = false; }
        }

        private void drukujParagon(object sender, EventArgs e)
        {

            FileStream paragon = new FileStream("paragon.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(paragon);

            // paragon
            writer.WriteLine("PIZZA express + /POLSKA/ Sp. z o. o.   ");
            writer.WriteLine("ul. Jagiellońska 52, 10-279 Olsztyn    ");
            writer.WriteLine("        NIP 526-10-37-739              ");
            writer.WriteLine("---------------------------------------");
            writer.WriteLine();
            writer.WriteLine(DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);
            writer.WriteLine();
            writer.WriteLine("        PARAGON FISKALNY            ");

            for (int i = 0; i < DaneOb.Prod.Count; i++)
            {
                writer.WriteLine(DaneOb.Prod[i].Nazwa + "............" + DaneOb.Prod[i].Cena);
            }
            writer.WriteLine("Podsuma                        " + DaneOb.Final);
            writer.WriteLine();
            writer.WriteLine("---------------------------------------");
            writer.WriteLine("PSRZEDARZ OPODATKOWANIA A      " + (DaneOb.Final * 0.1d));
            writer.WriteLine("PTU A 23 %                     " + ((DaneOb.Final * 0.1d) * 0.22d));
            writer.WriteLine("PSRZEDARZ OPODATKOWANIA D      " + (DaneOb.Final - (DaneOb.Final * 0.1d)));
            writer.WriteLine("PTU A 5.00 %                   " + ((DaneOb.Final - (DaneOb.Final * 0.1d)) * 0.05d));
            writer.WriteLine("SUMA PTU                       " + (((DaneOb.Final * 0.1d) * 0.22d) + ((DaneOb.Final - (DaneOb.Final * 0.1d)) * 0.05d)));
            writer.WriteLine("---------------------------------------");
            writer.WriteLine(DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00"));
            writer.WriteLine();
            writer.WriteLine();
            writer.WriteLine("SUMA PLN                       " + DaneOb.Final);
            writer.WriteLine();
            writer.WriteLine();
            writer.WriteLine("Platnosc karta                         ");
            writer.WriteLine();
            writer.WriteLine();
            writer.WriteLine();
            writer.WriteLine("---------------------------------------");
            writer.WriteLine("       www.expresspluswz.com.pl        ");
            writer.WriteLine("       Info linija 800 500 789         ");
            writer.WriteLine("    Nr rejestrowy GETAR E0002022WBW    ");

            writer.Close();
            paragon.Close();

            DaneOb.dodajInfoKlienta();


            DaneOb.wyczysc();
            kartaP.Text = "0";
        }

        private void Odswiez(object sender, EventArgs e)
        {
            kartaP.Text = DaneOb.Final.ToString();
            // jesli reszta jest nie ujemna i jest towar na liscie do mozna drukowac paragon
            if (DaneOb.Prod.Count > 0) { drukujPar.Enabled = true; }
            else { drukujPar.Enabled = false; }
        }
    }
}
