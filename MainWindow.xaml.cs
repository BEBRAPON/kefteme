using System.Windows;
using Pract1.newDataSetTableAdapters;

namespace Pract1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void per_Click(object sender, RoutedEventArgs e)
        {
            PAGE.Content = new FirstPage();
        }

        private void per2_Click(object sender, RoutedEventArgs e)
        {
            PAGE.Content = new SecondPage();
        }
    }
}
