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
using System.Windows.Shapes;
using Igrica.Klase;

namespace Igrica
{
    /// <summary>
    /// Interaction logic for KoZnaZna.xaml
    /// </summary>
    public partial class KoZnaZna : Window
    {
        public KoZnaZna()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pitanje.Content = "";
        }
    }
}
