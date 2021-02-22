using _2_Projekt_Restaurant_Personalplanung.Datenmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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
        private List<Mitarbeiter> EingeteilteMitarbeiterListe = new List<Mitarbeiter>();

        MainWindow mainWindow;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainGrid.DataContext = Context.Angestellte.ToList();
            EingeteilteMitarbeiter.DataContext = EingeteilteMitarbeiterListe;
        }

        public NeuerDienstplan(MainWindow _mainWindow)
        {

            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.Height = 450;
            mainWindow.Width = 700;
        }

        private void Speichern(object sender, RoutedEventArgs e)
        {
            Datenmodel.Dienstplan d = new Datenmodel.Dienstplan
            {
                Jahr = TbJahr.Text,
                Kallenderwoche = TbKW.Text,
                Wochentag = TbWochentag.Text,
                FuerDatum = TbDatum.SelectedDate,
                ErstelltDatum = DateTime.Now,
                Mitarbeiter = EingeteilteMitarbeiterListe
            };
            Context.Dienstplaene.Add(d);
            Context.SaveChanges();
            mainWindow.MenueAnzeigen();
        }

        private void ZurueckZumMenue(object sender, RoutedEventArgs e)
        {
            mainWindow.MenueAnzeigen();
        }

        

        private void Angestellte_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            bool present = false;
            var selected = Angestellte.SelectedItem;
            if (selected != null)
            {
                present = EingeteilteMitarbeiterListe.Contains((Mitarbeiter)selected);
                if (!present)
                {
                    EingeteilteMitarbeiterListe.Add((Mitarbeiter)selected);
                    EingestellteMitarbeiterUpdate();
                }
            }
        }

        private void EingeteilteMitarbeiter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selected = EingeteilteMitarbeiter.SelectedItem;
            if (selected != null)
            {
                EingeteilteMitarbeiterListe.Remove((Mitarbeiter)selected);
                EingestellteMitarbeiterUpdate();
            }
        }

        private void EingestellteMitarbeiterUpdate()
        {
            EingeteilteMitarbeiter.ItemsSource = null;
            EingeteilteMitarbeiter.ItemsSource = EingeteilteMitarbeiterListe;
        }
    }
}
