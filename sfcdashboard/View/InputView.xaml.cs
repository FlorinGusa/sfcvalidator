using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace sfcdashboard.View
{
    /// <summary>
    /// Interaction logic for InfoView.xaml
    /// </summary>
    public partial class InputView : UserControl
    {
        ObservableCollection<String> list = new ObservableCollection<string>();
        public InputView()
        {
            InitializeComponent();
        }

        //Text Dropdown button
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        //Delete in listview
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
