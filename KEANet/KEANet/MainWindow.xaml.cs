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

namespace KEANet
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

        private void listbox_left_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void GreaterThanButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("greater than button");
        }

        private void LesserThanButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("lesser than button");
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("buy button");
        }

        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("checkbox checked");
        }

        private void checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("checkbox unchecked");
        }
    }
}
