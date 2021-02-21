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
    /// Interaktionslogik für MitarbeiterBearbeiten.xaml
    /// </summary>
    public partial class MitarbeiterBearbeiten : UserControl
    {
        MainWindow mainWindow;

        PersonalplanEntities Context = new PersonalplanEntities();
        ICollectionView CollectionView;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Context.Angestellte.Load();
            CollectionView = CollectionViewSource.GetDefaultView(Context.Angestellte.Local);
            MainGrid.DataContext = CollectionView;
        }

        public MitarbeiterBearbeiten(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.Height = 600;
            mainWindow.Width = 700;

        }

        private void AenderungenSpeichern(object sender, RoutedEventArgs e)
        {
            Context.SaveChanges();
        }

        private void ZurueckZumMenue(object sender, RoutedEventArgs e)
        {
            mainWindow.MenueAnzeigen();
        }

        private void VorherigerMitarbeiter(object sender, RoutedEventArgs e)
        {
            CollectionView.MoveCurrentToPrevious();
            if (CollectionView.IsCurrentBeforeFirst)
            {
                CollectionView.MoveCurrentToLast();
            }
        }

        private void NaechsterMitarbeiter(object sender, RoutedEventArgs e)
        {
            CollectionView.MoveCurrentToNext();
            if (CollectionView.IsCurrentAfterLast)
            {
                CollectionView.MoveCurrentToFirst();
            }
        }
    }
}
