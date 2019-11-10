using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RestaurantsDAB.Models.Relationship
{
    public class WaiterTable
    {
        public string WaiterId { get; set; }
        public Waiter Waiter { get; set; }
        public string TableId { get; set; }
        public Table Table { get; set; }
    }
}
