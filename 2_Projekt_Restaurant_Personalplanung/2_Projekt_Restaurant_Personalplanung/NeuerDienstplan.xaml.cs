using _2_Projekt_Restaurant_Personalplanung.Datenmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace _2_Projekt_Restaurant_Personalplanung
{
    /// <summary>
    /// Interaktionslogik für NeuerDienstplan.xaml
    /// </summary>
    public partial class NeuerDienstplan : UserControl
    {
        
        PersonalplanEntities Context = new PersonalplanEntities();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainGrid.DataContext = Context.Angestellte.ToList().Where(x => x.Stellenbezeichnung == "Koch" && x.IstVerfügbar == true).OrderBy(x => x.Vorname);
        }


        MainWindow mainWindow;
        public NeuerDienstplan(MainWindow _mainWindow)
        {

            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void Speichern(object sender, RoutedEventArgs e)
        {

        }

        private void ZurueckZumMenue(object sender, RoutedEventArgs e)
        {
            mainWindow.MenueAnzeigen();
        }
    }
}
