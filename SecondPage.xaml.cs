using System.Windows.Controls;
using Pract1.newDataSetTableAdapters;

namespace Pract1
{

    public partial class SecondPage : Page
    {
        sTableAdapter staff1 = new sTableAdapter();
        public SecondPage()
        {
            InitializeComponent();
            staff.ItemsSource = staff1.GetData();
        }

    }
}
