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
using _2_Projekt_Restaurant_Personalplanung.Datenmodel;

namespace _2_Projekt_Restaurant_Personalplanung
{
    /// <summary>
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        MainWindow mainWindow;
        public Login(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.Height = 300;
            mainWindow.Width = 500;
        }

        private void Einloggen(object sender, RoutedEventArgs e)
        {
            try
            {
                using (PersonalplanEntities db = new PersonalplanEntities())
                {
                    var list = db.Benutzeraccounts.Where(x => x.Benutzername == Username.Text && x.Passwort == Password.Password).ToList();
                    foreach (var b in list)
                    {
                        if (b.IstAdmin == true)
                        {

                            mainWindow.MenueAnzeigen();
                            return;
                        }
                        else if (b.IstAdmin == false)
                        {

                            mainWindow.DienstplanMitarbeiterAnzeigen();
                            return;
                        }
                    }
                    MessageBox.Show("Benutzername oder Passwort falsch!");
                    Username.Text = "";
                    Password.Password = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }
    }
}
