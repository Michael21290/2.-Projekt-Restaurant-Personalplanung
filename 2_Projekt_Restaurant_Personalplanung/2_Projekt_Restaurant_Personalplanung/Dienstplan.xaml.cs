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
        ICollectionView CollectionView;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            Context.Dienstplaene.Load();
            CollectionView = CollectionViewSource.GetDefaultView(Context.Dienstplaene.Local);
            MainGrid.DataContext = CollectionView;
            
        }

        MainWindow mainWindow;
        public Dienstplan(MainWindow _mainWindow)
        {
            
            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.Height = 600;
            mainWindow.Width = 900;
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

        private void TbFilterJahr_KeyUp(object sender, KeyEventArgs e)
        {
            string filter = TbFilterJahr.Text.ToLower();
            CollectionView.Filter = (x => ((Datenmodel.Dienstplan)x).Jahr.ToLower().Contains(filter));
        }

        private void TbFilterKW_KeyUp(object sender, KeyEventArgs e)
        {
            string filter = TbFilterKW.Text.ToLower();
            CollectionView.Filter = (x => ((Datenmodel.Dienstplan)x).Kallenderwoche.ToLower().Contains(filter));
        }

        private void Löschen(object sender, RoutedEventArgs e)
        {
            int searchID = (int)DienstplanID.Content;
            Datenmodel.Dienstplan n = Context.Dienstplaene.ToList().Where(x => x.ID_Dienstplan == searchID).FirstOrDefault();
            Context.Dienstplaene.Remove(n);
            Context.SaveChanges();
        }     
    }
}
