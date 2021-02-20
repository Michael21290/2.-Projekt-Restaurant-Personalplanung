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
using _2_Projekt_Restaurant_Personalplanung.Datenmodel;

namespace _2_Projekt_Restaurant_Personalplanung
{
    /// <summary>
    /// Interaktionslogik für Dienstplan.xaml
    /// </summary>
    public partial class Dienstplan : UserControl
    {
        PersonalplanEntities Context = new PersonalplanEntities();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            JahrKW.DataContext = Context.Dienstplaene.ToList().LastOrDefault();
            mo1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Montag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Frühschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            mo2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Montag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Mittagsschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            mo3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Montag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Spätschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            di1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Dienstag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Frühschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            di2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Dienstag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Mittagsschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            di3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Dienstag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Spätschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            mi1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Mittwoch").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Frühschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            mi2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Mittwoch").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Mittagsschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            mi3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Mittwoch").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Spätschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            do1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Donnerstag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Frühschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            do2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Donnerstag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Mittagsschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            do3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Donnerstag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Spätschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            fr1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Freitag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Frühschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            fr2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Freitag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Mittagsschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            fr3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Freitag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Spätschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            sa1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Samstag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Frühschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            sa2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Samstag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Mittagsschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            sa3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Samstag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Spätschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            so1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Sonntag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Frühschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            so2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Sonntag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Mittagsschicht").FirstOrDefault().MitarbeiterSchicht.ToList();
            so3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Sonntag").FirstOrDefault().Schicht.ToList().Where(y => y.Bezeichnung == "Spätschicht").FirstOrDefault().MitarbeiterSchicht.ToList();

        }

        MainWindow mainWindow;
        public Dienstplan(MainWindow _mainWindow)
        {
            
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void Speichern(object sender, RoutedEventArgs e)
        {
            Context.SaveChanges();
        }

        private void ZurueckZumMenue(object sender, RoutedEventArgs e)
        {
            mainWindow.MenueAnzeigen();
        }
    }
}
