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
using Kino.ViewModel;

namespace Kino.View
{
    /// <summary>
    /// Interaction logic for FormaDodaci.xaml
    /// </summary>
    public partial class FormaDodaci : Window
    {
        public FormaDodaci()
        {
            InitializeComponent();
            ProdajaDodatakViewModel dvm = new ProdajaDodatakViewModel();
            base.DataContext = dvm;
        }

    }
}
