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
    /// Interaktionslogik für MenueAdmin.xaml
    /// </summary>
    public partial class MenueAdmin : UserControl
    {
        MainWindow mainWindow;
        
        public MenueAdmin(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.Height = 300;
            mainWindow.Width = 500;

        }

        private void PlanAnzeigen(object sender, RoutedEventArgs e)
        {
            mainWindow.DienstplanAnzeigen();
        }

        private void DienstplanErstellen(object sender, RoutedEventArgs e)
        {
            mainWindow.NeuerDienstplanAnzeigen();
        }

        private void Mitarbeiterhinzufuegen(object sender, RoutedEventArgs e)
        {
            mainWindow.NeuerMitarbeiterAnzeigen();
        }

        private void Ausloggen(object sender, RoutedEventArgs e)
        {
            mainWindow.LoginAnzeigen();
        }

        
    }
}
