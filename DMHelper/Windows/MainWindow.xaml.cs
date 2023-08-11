using DMHelper.Windows;
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

namespace DMHelper
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rozpocznij_sesje_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Wyjscie_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Stworz_sesje_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Zarzadzaj_swiatami_Click(object sender, RoutedEventArgs e)
        {
            ZarzadzajSwiatamiWindow zarzadzajSwiatamiWindow = new ZarzadzajSwiatamiWindow();
            zarzadzajSwiatamiWindow.Owner = this;
            zarzadzajSwiatamiWindow.Show();
        }

        private void Pomoc_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
