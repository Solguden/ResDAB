using RestaurantsDAB.Models.Relationship;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace RestaurantsDAB.Models
{
    public class Table
    {
        [Required]
        public int Number { get; set; }
        public string TableId { get; set; }

        public List<WaiterTable> WaiterTables { get; set; }
        public Restaurant Restaurant { get; set; }
        public Guest Guest { get; set; }

    }
}
