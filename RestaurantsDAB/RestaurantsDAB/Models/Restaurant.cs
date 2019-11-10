using RestaurantsDAB.Models.Relationship;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsDAB.Models
{
    public class Restaurant
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Address { get; set; }
        public string RestaurantID { get; set; }

        public List<Review> Reviews { get; set; }
        public List<RestaurantDish> RestaurantDishes { get; set; }
        public List<Table> Tables { get; set; }


    }
}
