using System;
namespace webApp.Models
{
    public class DriverOrder
    {
        public int id { get; set; }
        public int driver_id { get; set; }
        public int order_id { get; set; }
        public int market_id { get; internal set; }
    }
}
