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
using Kino.View;

namespace Kino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e){}
        private void Button_Click(object sender, RoutedEventArgs e){}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "dodaci")
            {
                FormaDodaci fd = new FormaDodaci();

                //fd.DataContext = new ViewModel.ProdajaDodatakViewModel();
                fd.Show();
                this.Close();
            }
            else if (PasswordBox.Password=="film")
            {
                FormaFilm ff = new FormaFilm();
            
                ff.Show();
                this.Close();
            }
            else if (PasswordBox.Password=="karta")
            {
                FormaKarta fk = new FormaKarta();

              //  fk.DataContext = new ViewModel.KartaViewModel();
                fk.Show();
                this.Close();
            }
        
        }
    }
}
