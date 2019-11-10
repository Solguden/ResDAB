using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsDAB.Models
{
    public class Review
    {
        public string ReviewId { get; set; }
        [Range(0,6)]
        public int Stars { get; set; }

        public string Text { get; set; }

        public List<Dish> Dishes { get; set; }
        public List<Guest> Guests { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
