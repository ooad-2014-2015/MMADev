using Igrica.Klase;
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
using System.Windows.Shapes;

namespace Igrica
{
    /// <summary>
    /// Interaction logic for Spajalica.xaml
    /// </summary>
    public partial class Spajalica : Window
    {
        public Spajalica()
        {
            InitializeComponent();
        }
        private int poeni = 0;
        private List<bool> pritisnuti = new List<bool> {false, false, false, false, false};
        private void prviL_Click(object sender, RoutedEventArgs e)
        {
            pritisnuti[0] = true;
            prviL.Background = Brushes.Blue;
        }

        private void drugiL_Click(object sender, RoutedEventArgs e)
        {
            pritisnuti[1] = true;
            drugiL.Background = Brushes.Blue;
        }

        private void treciL_Click(object sender, RoutedEventArgs e)
        {
            pritisnuti[2] = true;
            treciL.Background = Brushes.Blue;
        }

        private void cetvrtiL_Click(object sender, RoutedEventArgs e)
        {
            pritisnuti[3] = true;
            cetvrtiL.Background = Brushes.Blue;
            
        }

        private void petiL_Click(object sender, RoutedEventArgs e)
        {
            pritisnuti[4] = true;
            petiL.Background = Brushes.Blue;
        }


        private void AngelinaJolie_Click_1(object sender, RoutedEventArgs e)
        {
            DrugaLahki igra = new DrugaLahki();

            if (pritisnuti[0])
            {
                if (igra.igraj((string)prviL.Content, AngelinaJolie.Name))
                {
                    prviL.Background = Brushes.Green;
                    AngelinaJolie.Background = Brushes.Green;
                    pritisnuti[0] = false;
                    poeni++;
                }
            }
            else if (pritisnuti[1])
            {
                drugiL.Background = Brushes.Red;
                AngelinaJolie.Background = Brushes.Red;
                pritisnuti[1] = false;
                poeni--;
            }
            else if (pritisnuti[2])
            {
                treciL.Background = Brushes.Red;
                AngelinaJolie.Background = Brushes.Red;
                pritisnuti[2] = false;
                poeni--;
            }
            else if (pritisnuti[3])
            {
                cetvrtiL.Background = Brushes.Red;
                AngelinaJolie.Background = Brushes.Red;
                pritisnuti[3] = false;
                poeni--;
            }
            else if (pritisnuti[4])
            {
                petiL.Background = Brushes.Red;
                AngelinaJolie.Background = Brushes.Red;
                pritisnuti[4] = false;
                poeni--;
            }
        }

        private void BradleyCooper_Click(object sender, RoutedEventArgs e)
        {
            DrugaLahki igra = new DrugaLahki();

            if (pritisnuti[1])
            {
                if (igra.igraj((string)drugiL.Content, BradleyCooper.Name))
                {
                    drugiL.Background = Brushes.Green;
                    BradleyCooper.Background = Brushes.Green;
                    pritisnuti[1] = false;
                    poeni++;
                }
            }
            else if (pritisnuti[0])
            {
                prviL.Background = Brushes.Red;
                BradleyCooper.Background = Brushes.Red;
                pritisnuti[0] = false;
                poeni--;
            }
            else if (pritisnuti[2])
            {
                treciL.Background = Brushes.Red;
                BradleyCooper.Background = Brushes.Red;
                pritisnuti[2] = false;
                poeni--;
            }
            else if (pritisnuti[3])
            {
                cetvrtiL.Background = Brushes.Red;
                BradleyCooper.Background = Brushes.Red;
                pritisnuti[3] = false;
                poeni--;
            }
            else if (pritisnuti[4])
            {
                petiL.Background = Brushes.Red;
                BradleyCooper.Background = Brushes.Red;
                pritisnuti[4] = false;
                poeni--;
            }
        }

        private void TomHanks_Click(object sender, RoutedEventArgs e)
        {
            DrugaLahki igra = new DrugaLahki();

            if (pritisnuti[2])
            {
                if (igra.igraj((string)treciL.Content, TomHanks.Name))
                {
                    treciL.Background = Brushes.Green;
                    TomHanks.Background = Brushes.Green;
                    pritisnuti[2] = false;
                    poeni++;
                }
            }
            else if (pritisnuti[1])
            {
                drugiL.Background = Brushes.Red;
                TomHanks.Background = Brushes.Red;
                pritisnuti[1] = false;
                poeni--;
            }
            else if (pritisnuti[0])
            {
                prviL.Background = Brushes.Red;
                TomHanks.Background = Brushes.Red;
                pritisnuti[0] = false;
                poeni--;
            }
            else if (pritisnuti[3])
            {
                cetvrtiL.Background = Brushes.Red;
                TomHanks.Background = Brushes.Red;
                pritisnuti[3] = false;
                poeni--;
            }
            else if (pritisnuti[4])
            {
                petiL.Background = Brushes.Red;
                TomHanks.Background = Brushes.Red;
                pritisnuti[4] = false;
                poeni--;
            }
        }

        private void NicolasCage_Click(object sender, RoutedEventArgs e)
        {
            DrugaLahki igra = new DrugaLahki();

            if (pritisnuti[3])
            {
                if (igra.igraj((string)cetvrtiL.Content, NicolasCage.Name))
                {
                    cetvrtiL.Background = Brushes.Green;
                    NicolasCage.Background = Brushes.Green;
                    pritisnuti[3] = false;
                    poeni++;
                }
            }
            else if (pritisnuti[1])
            {
                drugiL.Background = Brushes.Red;
                NicolasCage.Background = Brushes.Red;
                pritisnuti[1] = false;
                poeni--;
            }
            else if (pritisnuti[2])
            {
                treciL.Background = Brushes.Red;
                NicolasCage.Background = Brushes.Red;
                pritisnuti[2] = false;
                poeni--;
            }
            else if (pritisnuti[0])
            {
                prviL.Background = Brushes.Red;
                NicolasCage.Background = Brushes.Red;
                pritisnuti[0] = false;
                poeni--;
            }
            else if (pritisnuti[4])
            {
                petiL.Background = Brushes.Red;
                NicolasCage.Background = Brushes.Red;
                pritisnuti[4] = false;
                poeni--;
            }
        }

        private void EmmaWatson_Click(object sender, RoutedEventArgs e)
        {
            DrugaLahki igra = new DrugaLahki();

            if (pritisnuti[4])
            {
                if (igra.igraj((string)prviL.Content, AngelinaJolie.Name))
                {
                    petiL.Background = Brushes.Green;
                    EmmaWatson.Background = Brushes.Green;
                    pritisnuti[4] = false;
                    poeni++;
                }
            }
            else if (pritisnuti[1])
            {
                drugiL.Background = Brushes.Red;
                EmmaWatson.Background = Brushes.Red;
                pritisnuti[1] = false;
                poeni--;
            }
            else if (pritisnuti[2])
            {
                treciL.Background = Brushes.Red;
                EmmaWatson.Background = Brushes.Red;
                pritisnuti[2] = false;
                poeni--;
            }
            else if (pritisnuti[3])
            {
                cetvrtiL.Background = Brushes.Red;
                EmmaWatson.Background = Brushes.Red;
                pritisnuti[3] = false;
                poeni--;
            }
            else if (pritisnuti[0])
            {
                prviL.Background = Brushes.Red;
                EmmaWatson.Background = Brushes.Red;
                pritisnuti[0] = false;
                poeni--;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.rezultat += poeni;
            if (MessageBox.Show("Osvojili ste " + poeni + " poena.", "Kraj igre") == MessageBoxResult.OK)
                this.Close();
        }

       
    }
}
