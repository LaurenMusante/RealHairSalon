using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
    public class Client 
    {
        public string Name { get; set; }
        public string HairType { get; set; }
        public int Id { get; set; }
        public int StyId { get; set; }
        public virtual Stylist Stylist { get; set; }

    // public Client (string Name, string HairType)
    //     {
    //         Name = name;
    //         HairType = hairType; 
    //     }

    // public Client (string Name, string HairType, int Id)
    //     {
    //         Name = name;
    //         HairType = hairType;
    //         Id = id;
    //     }
    }
}