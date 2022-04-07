using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace MainWindow
{
    /// <summary>
    /// Interaction logic for TruckerView.xaml
    /// </summary>
    public partial class TruckerView : Window
    {
        public TruckerView()
        {
            InitializeComponent();
        }
        public void PopulateScreen() 
        {
            HobbyLobbyStores api;

            string json = File.ReadAllText("HL_Stores.json");
            api = JsonConvert.DeserializeObject<HobbyLobbyStores>(json);

            foreach (var store in api.Stores)
            {
                lbStoreEntries.Items.Add(store);
            }
        }

    }
}
