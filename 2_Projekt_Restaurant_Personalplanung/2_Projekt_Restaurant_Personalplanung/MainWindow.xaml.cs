﻿using System;
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
using System.Data.Entity;
using _2_Projekt_Restaurant_Personalplanung.Datenmodel;

namespace _2_Projekt_Restaurant_Personalplanung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary> 

    public partial class MainWindow : Window
    {
        Login login;
        Dienstplan dienstplan;
        NeuerDienstplan NeuerDienstplan;
        MenueAdmin Menue;
        NeuerMitarbeiter NeuerMitarbeiter;
        DienstplanMitarbeiter DienstplanMitarbeiter;
        MitarbeiterBearbeiten MitarbeiterBearbeiten;
        
        
        
        public MainWindow()
        {
            InitializeComponent();
            LoginAnzeigen(); 
        }

        public void MenueAnzeigen()
        {
            Menue = new MenueAdmin(this);
            UserControl.Content = Menue;
        }

        public void NeuerDienstplanAnzeigen()
        {
            NeuerDienstplan = new NeuerDienstplan(this);
            UserControl.Content = NeuerDienstplan;
        }

        public void DienstplanAnzeigen()
        {
            dienstplan = new Dienstplan(this);
            UserControl.Content = dienstplan;
        }

        public void LoginAnzeigen()
        {
            login = new Login(this);
            UserControl.Content = login;
        }

        public void NeuerMitarbeiterAnzeigen()
        {
            NeuerMitarbeiter = new NeuerMitarbeiter(this);
            UserControl.Content = NeuerMitarbeiter;
        }

        public void DienstplanMitarbeiterAnzeigen()
        {
            DienstplanMitarbeiter = new DienstplanMitarbeiter(this);
            UserControl.Content = DienstplanMitarbeiter;
        }

        public void MitarbeiterBearbeitenAnzeigen()
        {
            MitarbeiterBearbeiten = new MitarbeiterBearbeiten(this);
            UserControl.Content = MitarbeiterBearbeiten;
        }
    }
}
