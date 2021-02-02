using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Scala.Oefening02.Core;

namespace Scala.Oefening02.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Fiets fiets1 = new Fiets("Oxford", "OX120", 879.23M, false, 2);
            Fiets fiets2 = new Fiets("Oxford", "OX240", 1245.3M, false, 2);
            Fiets fiets3 = new Fiets("Oxford", "iOX120", 2879.99M, true, 2);
            Fiets fiets4 = new Fiets("Cambridge", "SNR1900", 546M, false, 3);

            lstFietsen.Items.Add(fiets1);
            lstFietsen.Items.Add(fiets2);
            lstFietsen.Items.Add(fiets3);
            lstFietsen.Items.Add(fiets4);
        }

        private void lstFietsen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Fiets fiets = (Fiets)lstFietsen.SelectedItem;
            lblMerk.Content = fiets.Merk;
            lblSerie.Content = fiets.Serie;
            lblVerkoopprijsEuro.Content = fiets.VerkoopprijsEuro.ToString("#,##0.00 €");
            lblVerkoopprijsPond.Content = fiets.GetVerkoopprijsAndereMunt(0.88).ToString("#,##0.00 £");
            lblVerkoopprijsDollar.Content = fiets.GetVerkoopprijsAndereMunt(1.2).ToString("#,##0.00 $");
            lblElektrisch.Content = "Neen";
            if (fiets.IsElektrisch) lblElektrisch.Content = "Ja";
            lblAantalWielen.Content = fiets.AantalWielen;
        }
    }
}
