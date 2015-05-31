using Kino.Model;
using Kino.ViewModel;
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

namespace Kino.View
{
    /// <summary>
    /// Interaction logic for FormaFilm.xaml
    /// </summary>
    public partial class FormaFilm : Window
    {
        //FilmViewModel fvm = new FilmViewModel(); 
        public FormaFilm()
        {
            InitializeComponent();
            FilmViewModel fvm = new FilmViewModel(this);

            base.DataContext = fvm;
            listBox.DataContext = fvm;
            listBox.SetBinding(ItemsControl.ItemsSourceProperty, new Binding("Filmovi"));
        }

    }
}
