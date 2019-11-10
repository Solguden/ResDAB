using RestaurantsDAB.Models.Relationship;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsDAB.Models
{
    public class Waiter 
    {
        public string WaiterId { get; set; }
        [Required]
        public double Salary { get; set; }
        public List<WaiterTable> WaiterTables { get; set; }
        public Person Person { get; set; }
    }
}
