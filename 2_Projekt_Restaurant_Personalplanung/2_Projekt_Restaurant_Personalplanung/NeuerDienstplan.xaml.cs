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
        ICollectionView CollectionView;

        MainWindow mainWindow;
        public NeuerDienstplan(MainWindow _mainWindow)
        {

            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.Height = 675;
            mainWindow.Width = 1200;

            Context.Angestellte.Load();
            CollectionView = CollectionViewSource.GetDefaultView(Context.Angestellte.Local);
            DGAngestellte.DataContext = CollectionView;
        }

        private void Speichern(object sender, RoutedEventArgs e)
        {
            int kw;
            int.TryParse(Kallenderwoche.Text, out kw);
            int jahr;
            int.TryParse(Jahr.Text, out jahr);
            Datenmodel.Dienstplan d = new Datenmodel.Dienstplan()
            {
                Kallenderwoche = kw,
                Jahr = jahr,
            };
            d.Wochentag = Context.Wochentage.Where(x => x.Bezeichnung == "Montag" || x.Bezeichnung == "Dienstag" || x.Bezeichnung == "Mittwoch" || x.Bezeichnung == "Donnerstag" || x.Bezeichnung == "Freitag" || x.Bezeichnung == "Samstag" || x.Bezeichnung == "Sonntag").ToList();
            foreach (var t in d.Wochentag)
            {
                t.Schicht = Context.Schichten.Where(x => x.Bezeichnung == "Frühschicht" || x.Bezeichnung == "MittagsSchicht" || x.Bezeichnung == "Spätschicht");
            }
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Montag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht").FirstOrDefault().name = mo1.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Montag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht").FirstOrDefault().name = mo2.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Montag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht").FirstOrDefault().name = mo3.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Dienstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht").FirstOrDefault().name = di1.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Dienstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht").FirstOrDefault().name = di2.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Dienstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht").FirstOrDefault().name = di3.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Mittwoch").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht").FirstOrDefault().name = mi1.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Mittwoch").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht").FirstOrDefault().name = mi2.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Mittwoch").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht").FirstOrDefault().name = mi3.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Donnerstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht").FirstOrDefault().name = do1.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Donnerstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht").FirstOrDefault().name = do2.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Donnerstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht").FirstOrDefault().name = do3.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Freitag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht").FirstOrDefault().name = fr1.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Freitag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht").FirstOrDefault().name = fr2.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Freitag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht").FirstOrDefault().name = fr3.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Samstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht").FirstOrDefault().name = sa1.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Samstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht").FirstOrDefault().name = sa2.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Samstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht").FirstOrDefault().name = sa3.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Sonntag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht").FirstOrDefault().name = so1.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Sonntag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht").FirstOrDefault().name = so2.Text;
            d.Wochentag.ToList().Where(x => x.Bezeichnung == "Sonntag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht").FirstOrDefault().name = so3.Text;
            Context.Dienstplaene.Add(d);
            Context.SaveChanges();
        }

        private void ZurueckZumMenue(object sender, RoutedEventArgs e)
        {
            mainWindow.MenueAnzeigen();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
