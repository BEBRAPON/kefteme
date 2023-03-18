using Pract1.newDataSetTableAdapters;
using System;
using System.Data;
using System.Windows.Controls;

namespace Pract1
{
    
    public partial class FirstPage : Page
    {
        pTableAdapter post1 = new pTableAdapter();

        public FirstPage()
        {
            InitializeComponent();     
            post.ItemsSource = post1.GetData();

        }

        private void dobInf_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            post1.Insert1(Name.Text, Convert.ToInt32(Sol.Text));
            Name.Text = "";
            Sol.Text = "";
            post.ItemsSource = post1.GetData();

        }

        private void remInf_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int id = (int)(post.SelectedItem as DataRowView).Row[0];
            post1.Delete1(id);
            post.ItemsSource = post1.GetData();
        }
    }
}
