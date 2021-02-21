using _2_Projekt_Restaurant_Personalplanung.Datenmodel;
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

namespace _2_Projekt_Restaurant_Personalplanung
{
    /// <summary>
    /// Interaktionslogik für NeuerMitarbeiter.xaml
    /// </summary>
    public partial class NeuerMitarbeiter : UserControl
    { 
        MainWindow mainWindow;

        PersonalplanEntities Context = new PersonalplanEntities();

        public NeuerMitarbeiter(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.Height = 600;
            mainWindow.Width = 700;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool IstAdmin = false;
            if(cbIstAdmin.IsChecked == true)
            {
                IstAdmin = true;
            }

            Mitarbeiter m = new Mitarbeiter
            {
                Name = tbName.Text,
                Vorname = tbVorname.Text,
                Geburtsdatum = dpGeburtsdatum.SelectedDate,
                Einstellungsdatum = DateTime.Now,
                Stellenbezeichnung = tbStellenbezeichnung.Text,
                Email = tbEmail.Text
            };

            Benutzeraccount b = new Benutzeraccount
            {
                Benutzername = tbBenutzername.Text,
                Passwort = tbPasswort.Text,
                IstAdmin = IstAdmin,
                Angestellter = m.ID_Mitarbeiter
            };
            Context.Angestellte.Add(m);
            Context.Benutzeraccounts.Add(b);
            Context.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainWindow.MenueAnzeigen();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
