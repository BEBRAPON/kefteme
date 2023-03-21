using System.Data;
using System.Windows.Controls;
using Pract1.newDataSetTableAdapters;

namespace Pract1
{

    public partial class SecondPage : Page
    {
        pTableAdapter post1 = new pTableAdapter();
        sTableAdapter staff1 = new sTableAdapter();
        public SecondPage()
        {
            InitializeComponent();
            staff.ItemsSource = staff1.GetData();
            FK.ItemsSource = post1.GetData();
            FK.DisplayMemberPath = "name";
            FK.SelectedValuePath = "id";
        }

        private void dobInf_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int id = (int)FK.SelectedValue;
            staff1.Insert2(Name.Text, Surname.Text, id);
            
            staff.ItemsSource = staff1.GetData();

        }

        private void remInf_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int id = (int)(staff.SelectedItem as DataRowView).Row[0];
            staff1.Delete2(id);

            staff.ItemsSource = staff1.GetData();
        }

       

        private void updateInf_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (staff.SelectedItem != null)
            {
                var item = staff.SelectedItem as DataRowView;
                staff1.UpdateQuery(Name.Text, Surname.Text, (int)FK.SelectedValue, (int)item.Row[0]);

                staff.ItemsSource = staff1.GetData();
            }
        }

        private void staff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (staff.SelectedItem != null)
            {
                var item = staff.SelectedItem as DataRowView;
                Name.Text = (string)item.Row[1];
                Surname.Text = (string)item.Row[2];
                FK.SelectedValue = (int)item.Row[3];
            }
        }
    }
}
