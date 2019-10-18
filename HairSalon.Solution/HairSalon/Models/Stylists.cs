using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {

        public int StylistId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public virtual ICollection<Client> Clients { get; set; } //We declare Clients as an instance of ICollection, a generic interface built into the .NET framework. We use ICollection specifically because Entity requires it.
        
        public Stylist()
        {
            this.Clients = new HashSet<Client>(); //A HashSet is an unordered collection of unique elements. We create a HashSet of Clients in the constructor to help avoid exceptions when no records exist in the "many" side of the relationship.
        }
    }
}