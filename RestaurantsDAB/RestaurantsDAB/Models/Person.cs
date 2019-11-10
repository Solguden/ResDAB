using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsDAB.Models
{
    public class Person
    {
     
        public string PersonId { get; set; }
        [Required]
        public string Name { get; set; }

        public string WaiterID { get; set; }
        public Waiter Waiter { get; set; }

        public string GuestID { get; set; }
        public Guest Guest { get; set; }

    }
}
