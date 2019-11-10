using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsDAB.Models.Relationship
{


    public class GuestDish
    {
        public string GuestId { get; set; }
        public Guest Guest { get; set; }
        public string DishId { get; set; }
        public Dish Dish { get; set; }

    }

}