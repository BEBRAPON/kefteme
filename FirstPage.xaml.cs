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
            post.ItemsSource = post1.GetData();

        }

        private void remInf_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int id = (int)(post.SelectedItem as DataRowView).Row[0];
            post1.Delete1(id);
            post.ItemsSource = post1.GetData();
        }


        private void updateInf_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (post.SelectedItem != null)
            {
                var item = post.SelectedItem as DataRowView;
                post1.UpdateQuery(Name.Text, Convert.ToInt32(Sol.Text), (int)item.Row[0]);

                post.ItemsSource = post1.GetData();
            }
        }

        private void post_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (post.SelectedItem != null)
            {
                var item = post.SelectedItem as DataRowView;
                Name.Text = item.Row[1] as string;
                Sol.Text = Convert.ToString(item.Row[2]);
            }
        }
    }
}
