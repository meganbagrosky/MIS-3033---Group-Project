using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HobbyLobby.Models
{
    public class PickUpRequest
    {
        public HobbyLobby.Models.Pickup PickUpName { get; set; }
        public HobbyLobby.Models.Request RequestName { get; set; }
    }
}