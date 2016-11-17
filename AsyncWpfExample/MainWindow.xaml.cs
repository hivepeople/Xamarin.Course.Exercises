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

namespace AsyncWpfExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            countLabel.Content = 0;
        }

        private void countButton_Click(object sender, RoutedEventArgs e)
        {
            int currentCount = (int)countLabel.Content;
            int next = currentCount + 1;
            countLabel.Content = next;
        }

        private void resetCountButton_Click(object sender, RoutedEventArgs e)
        {
            countLabel.Content = 0;
        }

        private void slowWorkButton_Click(object sender, RoutedEventArgs e)
        {
            slowWorkProgressLabel.Content = "Working...";

            slowWorkProgressLabel.Content = "Done!";
        }

        private void slowWorkAsyncButton_Click(object sender, RoutedEventArgs e)
        {
            slowWorkAsyncProgressLabel.Content = "Working...";

            slowWorkAsyncProgressLabel.Content = "Done!";
        }
    }
}
