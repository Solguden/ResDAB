using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsDAB.Models.Relationship
{
    public class RestaurantDish
    {
        public string RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public string DishId { get; set; }
        public Dish Dish { get; set; }


    }
}
