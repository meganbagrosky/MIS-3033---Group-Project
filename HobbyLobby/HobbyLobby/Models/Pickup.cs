//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HobbyLobby.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pickup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pickup()
        {
            this.Requests = new HashSet<Request>();
        }
    
        public int PickupNumber { get; set; }
        public Nullable<int> TruckNumber { get; set; }
        public Nullable<System.DateTime> ScheduledDate { get; set; }
        public decimal PickupCapacity { get; set; }
    
        public virtual Truck Truck { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Requests { get; set; }
    }
}
