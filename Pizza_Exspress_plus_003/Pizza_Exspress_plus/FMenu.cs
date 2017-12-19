using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Exspress_plus
{
    public partial class FMenu : Form
    {
        private BindingList<Product> produkts = new BindingList<Product>(); // lista 
        private Klient Temp; // dlia przerzcania info obiektu klient
        private bool idikator = false;  // rzeby wiedziec czy to z dostawy wyk w 30 liniejce
        private int x = 0; private int y = 0; // do przesuniecia okna


        //korzystam z clssSender w clasie  Dostawa dlia tego mod internal
        internal void clssSender(string imie, string nazwisko, bool vip, string numer_telef, string adres, string uwagi)
        {
            Temp = new Klient(imie, nazwisko, vip, numer_telef, adres, uwagi);
            numerTelW.Text = numer_telef;
            adresW.Text = adres;
            idikator = true;
        }

        public FMenu()
        {
            InitializeComponent();
            numerTelW.Text = ""; //  jak wchodzimy przez zamowienie z lokalu nic nie bylo wyswietlane 
            adresW.Text = "";  // --||--||-
        }

        private void zminimalizuj(object sender, EventArgs e) // minimalizacja
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void powiekszPomiejsz(object sender, EventArgs e) //powienkszenie pomiejszenie
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
        }

        private void zamknij(object sender, EventArgs e) //zanmykanie tylko tego okna
        {
            this.Hide();
        }

        private void przesunD(object sender, MouseEventArgs e) // pszesuniecie
        {
            x = e.X; y = e.Y;
        }

        private void przesunM(object sender, MouseEventArgs e) // pszesuniecie
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }

        private void usunDaneZListy(object sender, EventArgs e) //usuwam dane z listy pojedynczo
        {
            DaneOb.usun();
        }

        private void dodajPizze(object sender, EventArgs e) //wybor piz
        {
            pizzE_P1.BringToFront();
        }

        private void dodajSouse(object sender, EventArgs e) //wybor sosow
        {
            sousE_P1.BringToFront();
        }

        private void dodajNapoje(object sender, EventArgs e) //wybur napojow
        {
            napojE_P1.BringToFront();
        }

        private void podsumujZamowienie(object sender, EventArgs e)
        {
            // jesli wchodzisz przez dostawe to zeby nie bylo menu wyboru platnosci
            if ((idikator == true) && (Temp.Uwagi.Contains("Płatność kartą")) || (DaneOb.KartaGotowka == "Płatność kartą"))
            {
                podKartaP.BringToFront();
                DaneOb.KartaGotowka = "";
            }
            // a przez inne to  menu wyboru platnosci
            else { podsumowanieReszta.BringToFront(); }
        }

        private void menuPaint(object sender, PaintEventArgs e)
        {
            // zeby nie mozna bylo kliknac na podsumowanie bez wybranej wczesniej platnosci
            if (DaneOb.Majak) { menuKartaGotowkaO.BringToFront(); podsumowanie.Enabled = false; DaneOb.resetujMajak();/*wraca majak na false*/ }

        }

        private void klikMenu(object sender, EventArgs e)
        {
            // jesli platnosc wybrana to podwojnym klikiem mozna podsumowac
            if (DaneOb.Majak2)
            {
                podsumowanie.Enabled = true;
                DaneOb.resetujMajak2(); //wraca majak2 na false
            }
        }
    }
}
