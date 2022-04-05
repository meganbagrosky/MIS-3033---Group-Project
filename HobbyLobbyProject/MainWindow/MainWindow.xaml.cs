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

namespace MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Action request
        }

        private void btnStoreView_Click(object sender, RoutedEventArgs e)
        {
            StoreView storewnd = new StoreView();
            storewnd.PopulateScreen();

            storewnd.ShowDialog();
        }

        private void btnTransportView_Click(object sender, RoutedEventArgs e)
        {
            TruckerView truckerwnd = new TruckerView();
            truckerwnd.PopulateScreen();

            truckerwnd.ShowDialog();
        }
    }
}
