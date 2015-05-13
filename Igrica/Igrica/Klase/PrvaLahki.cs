using Igrica.Klase.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;



namespace Igrica.Klase
{
    public class PrvaLahki : IStrategy1
    {
        private List<string> lista = new List<string> { "Avatar", "Titanic", "Sherlock Holmes"};
        public static int brojacL = 0;
        public static int brojacPoenaL = 0;
        public void igraj(string film)
        {
            if (film == lista[brojacL])
            {
                MessageBox.Show("Tačno!", "Tačan odgovor :)");
                brojacPoenaL++;
            }

            else
            {
               // if(
                MessageBox.Show("Netačno", "Netačan odgovor :(", MessageBoxButton.OK);// == MessageBoxResult.OK)

                 //   ((PoveziScenuAvatarLahki)Application.Current.MainWindow).sljedeca.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                
            }
            
        }
    }
}
