using Pract1.newDataSetTableAdapters;
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
    }
}
