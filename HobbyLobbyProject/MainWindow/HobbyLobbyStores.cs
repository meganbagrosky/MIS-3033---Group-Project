using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWindow
{
    public class HobbyLobbyStores
    {
        public List<Store> Stores { get; set; }
    }

    public class Store
    {
        public int Store_Number { get; set; }
        public string Location { get; set; }
        public string Street_Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Store()
        {
            Store_Number = 0;
            Location= string.Empty;
            Street_Address= string.Empty;
            City = string.Empty;
            State = string.Empty;
        }
        public override string ToString()
        {
            return $"{Store_Number} {Location} {City} {State}"; 
        }
    }
}
