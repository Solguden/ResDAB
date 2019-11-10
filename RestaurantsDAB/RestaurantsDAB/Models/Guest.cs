using RestaurantsDAB.Models.Relationship;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsDAB.Models
{
    public class Guest 
    {
       
        public string GuestId { get; set; }
        public DateTime Time { get; set; }
        public Review Reviews { get; set; }
        public List<Table> Tables { get; set; }
        public List<GuestDish> GuestDishes { get; set; }
        public Person Person { get; set; }
    }
}
