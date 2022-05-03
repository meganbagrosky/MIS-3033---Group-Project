using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HobbyLobby.Models
{
    public class StoreRequestView
    {
        public List<Request> RequestClass { get; set; }
        public List<Pickup> PickupClass { get; set; }
        public HobbyLobby.Models.Request RequestName { get; set; }
        public HobbyLobby.Models.Store StoreClass { get; set; }
        public HobbyLobby.Models.Pickup PickUpName { get; set; }
    }
}