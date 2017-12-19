using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
namespace Pizza_Exspress_plus
{
    static class DaneOb
    {
        private static BindingList<Product> prod = new BindingList<Product>();
        private static double final = 0d;
        private static string kartaGotowka;
        private static bool majak = false;
        private static bool majak2 = false;
        public static double Final { get => final; }
        internal static BindingList<Product> Prod { get => prod; }
        public static bool Majak { get => majak; }
        public static bool Majak2 { get => majak2; }
        public static string KartaGotowka { get => kartaGotowka; set => kartaGotowka = value; }

        public static void usun()
        {
            if (final > 0d)
            {
                final = final - ((Product)prod.Last()).Cena;
                final = Math.Round(final, 2);
                prod.Remove(prod.Last());
            }
        }

        public static void wyczysc()
        {
            prod.Clear();
            final = 0d;
        }

        public static void dodaj(Product temp)
        {
            prod.Add(temp);
            final += Math.Round(temp.Cena, 2);
        }
        public static void dodajInfoKG(string info)
        {
            KartaGotowka = info;
        }
        public static void usunInfoKG()
        {
            KartaGotowka = "";
        }
        public static void dodajInfoMajak(bool maja)
        {
            majak = maja;
        }
        public static void resetujMajak()
        {
            majak = false;
        }
        public static void dodajInfoMajak2(bool maja)
        {
            majak2 = maja;
        }
        public static void resetujMajak2()
        {
            majak2 = false;
        }

        public static void dodajInfoKlienta()
        {


            string path = "paragon.txt";
            string path2 = "KlienciDane.txt";


            string[] dane = File.ReadAllLines(path);
            StreamWriter writer = File.AppendText(path2);
            foreach (string daneF in dane)
            {
                writer.WriteLine(daneF);
            }
            writer.Close();
        }

    }
}
