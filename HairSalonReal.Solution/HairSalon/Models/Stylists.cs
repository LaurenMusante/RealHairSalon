using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }

        public string Name { get; set; }
        public bool Specialty { get; set; }
        public int StyId { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        
    }
}