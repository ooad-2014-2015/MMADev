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

namespace Igrica.Resources
{
    /// <summary>
    /// Interaction logic for SpajalicaTeski.xaml
    /// </summary>
    public partial class SpajalicaTeski : Window
    {
        public SpajalicaTeski()
        {
            InitializeComponent();
        }

        private int poeni = 0;
        private List<bool> pritisnuti = new List<bool> { false, false, false, false, false };
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

        private void ClintEastwood_Click(object sender, RoutedEventArgs e)
        {
            DrugaTeski igra = new DrugaTeski();

            if (pritisnuti[0])
            {
                if (igra.igraj((string)prviL.Content, ClintEastwood.Name))
                {
                    prviL.Background = Brushes.Green;
                    ClintEastwood.Background = Brushes.Green;
                    pritisnuti[0] = false;
                    poeni++;
                }
            }
            else if (pritisnuti[1])
            {
                drugiL.Background = Brushes.Red;
                ClintEastwood.Background = Brushes.Red;
                pritisnuti[1] = false;
            }
            else if (pritisnuti[2])
            {
                treciL.Background = Brushes.Red;
                ClintEastwood.Background = Brushes.Red;
                pritisnuti[2] = false;
            }
            else if (pritisnuti[3])
            {
                cetvrtiL.Background = Brushes.Red;
                ClintEastwood.Background = Brushes.Red;
                pritisnuti[3] = false;
            }
            else if (pritisnuti[4])
            {
                petiL.Background = Brushes.Red;
                ClintEastwood.Background = Brushes.Red;
                pritisnuti[4] = false;
            }
        }



        private void VinDiesel_Click(object sender, RoutedEventArgs e)
        {
            DrugaTeski igra = new DrugaTeski();

            if (pritisnuti[2])
            {
                if (igra.igraj((string)treciL.Content, VinDiesel.Name))
                {
                    treciL.Background = Brushes.Green;
                    VinDiesel.Background = Brushes.Green;
                    pritisnuti[2] = false;
                    poeni++;
                }
            }
            else if (pritisnuti[1])
            {
                drugiL.Background = Brushes.Red;
                VinDiesel.Background = Brushes.Red;
                pritisnuti[1] = false;
            }
            else if (pritisnuti[0])
            {
                prviL.Background = Brushes.Red;
                VinDiesel.Background = Brushes.Red;
                pritisnuti[0] = false;
            }
            else if (pritisnuti[3])
            {
                cetvrtiL.Background = Brushes.Red;
                VinDiesel.Background = Brushes.Red;
                pritisnuti[3] = false;
            }
            else if (pritisnuti[4])
            {
                petiL.Background = Brushes.Red;
                VinDiesel.Background = Brushes.Red;
                pritisnuti[4] = false;
            }
        }

        private void JasonStatham_Click(object sender, RoutedEventArgs e)
        {
            DrugaTeski igra = new DrugaTeski();

            if (pritisnuti[3])
            {
                if (igra.igraj((string)cetvrtiL.Content, JasonStatham.Name))
                {
                    cetvrtiL.Background = Brushes.Green;
                    JasonStatham.Background = Brushes.Green;
                    pritisnuti[3] = false;
                    poeni++;
                }
            }
            else if (pritisnuti[1])
            {
                drugiL.Background = Brushes.Red;
                JasonStatham.Background = Brushes.Red;
                pritisnuti[1] = false;
            }
            else if (pritisnuti[2])
            {
                treciL.Background = Brushes.Red;
                JasonStatham.Background = Brushes.Red;
                pritisnuti[2] = false;
            }
            else if (pritisnuti[0])
            {
                prviL.Background = Brushes.Red;
                JasonStatham.Background = Brushes.Red;
                pritisnuti[0] = false;
            }
            else if (pritisnuti[4])
            {
                petiL.Background = Brushes.Red;
                JasonStatham.Background = Brushes.Red;
                pritisnuti[4] = false;
            }
        }

        private void ArnoldSchwarzenegger_Click(object sender, RoutedEventArgs e)
        {
            DrugaTeski igra = new DrugaTeski();

            if (pritisnuti[4])
            {
                if (igra.igraj((string)petiL.Content, ArnoldSchwarzenegger.Name))
                {
                    petiL.Background = Brushes.Green;
                    ArnoldSchwarzenegger.Background = Brushes.Green;
                    pritisnuti[4] = false;
                    poeni++;
                }
            }
            else if (pritisnuti[1])
            {
                drugiL.Background = Brushes.Red;
                ArnoldSchwarzenegger.Background = Brushes.Red;
                pritisnuti[1] = false;
            }
            else if (pritisnuti[2])
            {
                treciL.Background = Brushes.Red;
                ArnoldSchwarzenegger.Background = Brushes.Red;
                pritisnuti[2] = false;
            }
            else if (pritisnuti[3])
            {
                cetvrtiL.Background = Brushes.Red;
                ArnoldSchwarzenegger.Background = Brushes.Red;
                pritisnuti[3] = false;
            }
            else if (pritisnuti[0])
            {
                prviL.Background = Brushes.Red;
                ArnoldSchwarzenegger.Background = Brushes.Red;
                pritisnuti[0] = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           if( MessageBox.Show("Osvojili ste " + poeni + " poena.", "Kraj igre") == MessageBoxResult.OK)
            this.Close();
        }

        private void LiamNeeson_Click(object sender, RoutedEventArgs e)
        {
            DrugaTeski igra = new DrugaTeski();

            if (pritisnuti[1])
            {
                if (igra.igraj((string)drugiL.Content, LiamNeeson.Name))
                {
                    drugiL.Background = Brushes.Green;
                    LiamNeeson.Background = Brushes.Green;
                    pritisnuti[1] = false;
                    poeni++;
                }
            }
            else if (pritisnuti[0])
            {
                prviL.Background = Brushes.Red;
                LiamNeeson.Background = Brushes.Red;
                pritisnuti[0] = false;
            }
            else if (pritisnuti[2])
            {
                treciL.Background = Brushes.Red;
                LiamNeeson.Background = Brushes.Red;
                pritisnuti[2] = false;
            }
            else if (pritisnuti[3])
            {
                cetvrtiL.Background = Brushes.Red;
                LiamNeeson.Background = Brushes.Red;
                pritisnuti[3] = false;
            }
            else if (pritisnuti[4])
            {
                petiL.Background = Brushes.Red;
                LiamNeeson.Background = Brushes.Red;
                pritisnuti[4] = false;
            }
        }

        



    }
}
