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

namespace ProjektPAD
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Plec(object sender, RoutedEventArgs e)
        {
            if(CheckK.IsChecked == true || CheckM.IsChecked == true)
            {
                DodajBtn.IsEnabled = true;
            }
            if(CheckK.IsChecked == true)
            {
                CheckM.IsChecked = false;
            }
            if (CheckM.IsChecked == true)
            {
                CheckK.IsChecked = false;
            }
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {

        }
    }
}
