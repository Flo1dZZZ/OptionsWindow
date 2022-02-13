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

namespace OptionsWindow
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void tabBtn1_Click(object sender, RoutedEventArgs e)
        {
            tbCntrl1.SelectedIndex = 0;
        }

        private void tabBtn2_Click(object sender, RoutedEventArgs e)
        {
            tbCntrl1.SelectedIndex = 1;
        }

        private void tabBtn3_Click(object sender, RoutedEventArgs e)
        {
            tbCntrl1.SelectedIndex = 2;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
