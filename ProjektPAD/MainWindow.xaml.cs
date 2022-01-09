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

namespace ProjektPAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //var 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewWindow(object sender, RoutedEventArgs e)
        {
            Window1 p = new Window1();
            p.Show();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Wyszukaj(object sender, RoutedEventArgs e)
        {
            Wyszukaj p = new Wyszukaj();
            p.Show();
        }

        private void Podglad(object sender, RoutedEventArgs e)
        {
            Window2 p = new Window2();
            p.Show();
        }
    }
}
