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

namespace _2_Projekt_Restaurant_Personalplanung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary> 
   

    public partial class MainWindow : Window
    {
        Login login;
        Dienstplan dienstplan;
        public MainWindow()
        {

            InitializeComponent();
            LoginAnzeigen();
        }
        public void DienstplanAnzeigen()
        {
            dienstplan = new Dienstplan(this);
            UserControl.Content = dienstplan;
        }
        public void LoginAnzeigen()
        {
            Login login = new Login(this);
            UserControl.Content = login;
        }
    }
}
