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
    public partial class PENnapoje : UserControl
    {
        List<Napoje> menuN = new List<Napoje>(); // menu napojow
        
        public PENnapoje()
        {
            InitializeComponent();
            menuN.Add(new Napoje("Pepsi 0.5l", 3, "0.5", 'N'));
            menuN.Add(new Napoje("Pepsi 1l", 5, "1", 'N'));
            menuN.Add(new Napoje("Pepsi 2l", 8, "2", 'N'));
            menuN.Add(new Napoje("Coca-Cola 0.5l", 3, "0.5", 'N'));
            menuN.Add(new Napoje("Coca-Cola 1l", 5, "1", 'N'));
            menuN.Add(new Napoje("Coca-Cola 2l", 8, "2", 'N'));
            menuN.Add(new Napoje("Fanta 0.5l", 3, "0.5", 'N'));
            menuN.Add(new Napoje("Fanta 1l", 5, "1", 'N'));
            menuN.Add(new Napoje("Fanta 2l", 8, "2", 'N'));
            menuN.Add(new Napoje("Sprite 0.5l", 3, "0.5", 'N'));
            menuN.Add(new Napoje("Sprite 1l", 5, "1", 'N'));
            menuN.Add(new Napoje("Sprite 2l", 8, "2", 'N'));
        }

        private void pepsi05Dodaj(object sender, EventArgs e)
        {            
            DaneOb.dodaj((Product)menuN[0]);
        }

        private void pepsi1lDodaj(object sender, EventArgs e)
        {            
            DaneOb.dodaj((Product)menuN[1]);
        }

        private void pepsi2lDodaj(object sender, EventArgs e)
        {            
            DaneOb.dodaj((Product)menuN[2]);
        }

        private void cola05Dodaj(object sender, EventArgs e)
        {                       
            DaneOb.dodaj((Product)menuN[3]);
        }

        private void cola1lDodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuN[4]);
        }

        private void cola2lDodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuN[5]);
        }

        private void fanta05Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuN[6]);
        }

        private void fanta1lDodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuN[7]);
        }

        private void fanta2lDodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuN[8]);
        }

        private void sprite05Dodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuN[9]);
        }

        private void sprite1lDodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuN[10]);
        }

        private void sprite2lDodaj(object sender, EventArgs e)
        {
            DaneOb.dodaj((Product)menuN[11]);
        }
    }
}
