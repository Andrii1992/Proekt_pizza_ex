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
    public partial class PELista : UserControl
    {        
        public PELista()
        {
            InitializeComponent();
        }
        // wyswietla liste dodanych prodoktow
        private void FormatList(object sender, ListControlConvertEventArgs e)
        { 
            string cNazwa = ((Product)e.ListItem).Nazwa;           
            string cenaP = String.Format(" ............ {0}zl",((Product)e.ListItem).Cena);                     
            e.Value = cNazwa + cenaP; // dodanie na listu           
        }

        private void listaZaladuj(object sender, EventArgs e)
        {
            listaBox.DataSource = DaneOb.Prod;
            listaBox.DisplayMember = "nazwa";
        }
    }
}
