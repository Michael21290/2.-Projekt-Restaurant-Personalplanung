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
        private PersonalplanEntities Context = new PersonalplanEntities();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeComponent();

            JahrKW.DataContext = Context.Dienstplaene.ToList().LastOrDefault();
            mo1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Montag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht");
            mo2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Montag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht");
            mo3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Montag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht");
            di1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Dienstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht");
            di2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Dienstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht");
            di3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Dienstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht");
            mi1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Mittwoch").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht");
            mi2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Mittwoch").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht");
            mi3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Mittwoch").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht");
            do1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Donnerstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht");
            do2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Donnerstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht");
            do3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Donnerstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht");
            fr1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Freitag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht");
            fr2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Freitag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht");
            fr3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Freitag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht");
            sa1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Samstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht");
            sa2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Samstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht");
            sa3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Samstag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht");
            so1.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Sonntag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Frühschicht");
            so2.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Sonntag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Mittagsschicht");
            so3.DataContext = Context.Dienstplaene.ToList().LastOrDefault().Wochentag.ToList().Where(x => x.Bezeichnung == "Sonntag").FirstOrDefault().EingeteilterMitarbeiter.ToList().Where(x => x.Schicht.Bezeichnung == "Spätschicht");
        }

        MainWindow mainWindow;
        public Dienstplan(MainWindow _mainWindow)
        {
            
            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.Height = 675;
            mainWindow.Width = 1200;
        }

        private void Speichern(object sender, RoutedEventArgs e)
        {
            Context.SaveChanges();
        }

        private void ZurueckZumMenue(object sender, RoutedEventArgs e)
        {
            mainWindow.MenueAnzeigen();
        }

        private void Drucken(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    this.IsEnabled = false;
                    PrintDialog printDialog = new PrintDialog();
                    if (printDialog.ShowDialog() == true)
                    {
                        printDialog.PrintVisual(MainGrid, "Dienstplan");
                    }
                }
                finally
                {
                    this.IsEnabled = true;
                }
            
        }
    }
}
