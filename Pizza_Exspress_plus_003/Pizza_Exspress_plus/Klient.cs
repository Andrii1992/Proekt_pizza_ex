using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pizza_Exspress_plus
{
    class Klient : IMetoda
    {
        
        private string imie;
        private string nazwisko;
        private bool vip;
        private string numer_telef;
        private string adres;
        private string uwagi;
        private static int ile = 1;

        public string Imie { get => imie; }
        public string Nazwisko { get => nazwisko; }
        public bool Vip { get => vip; }
        public string Numer_telef { get => numer_telef; }
        public string Adres { get => adres; }
        public string Uwagi { get => uwagi; }


        public Klient(string imie, string nazwisko, bool vip, string numer_telef, string adres, string uwagi)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.vip = vip;
            this.numer_telef = numer_telef;
            this.adres = adres;
            this.uwagi = uwagi;
            zapiszDane(imie, nazwisko, vip, numer_telef, adres, uwagi);
        }

        public void zapiszDane(string imie, string nazwisko, bool vip, string numer_telef, string adres, string uwagi)
        {
            FileStream fstream = new FileStream("KlienciDane.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(fstream);


            writer.WriteLine();
            writer.WriteLine("-------------------------------------");
            writer.WriteLine();
            writer.WriteLine("   Klient № " + ile);
            writer.WriteLine();
            writer.WriteLine("Imie              " + imie);
            writer.WriteLine("Nazwisko          " + nazwisko);
            writer.WriteLine("Status vip        " + vip);
            writer.WriteLine("Numer telefonu    " + numer_telef);
            writer.WriteLine("Czas lub adres    " + adres);
            writer.WriteLine(uwagi);
            writer.WriteLine();
            writer.WriteLine();
            fstream.Seek(0, SeekOrigin.End);

            ile++;
            writer.Close();
            fstream.Close();


        }
    }
}
