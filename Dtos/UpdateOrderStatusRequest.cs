using System;
namespace webApp.Dtos
{
    public class UpdateOrderStatusRequest
    {
        public int driverId { get; set; }
        public int orderId { get; set; }
        public int status { get; set; }
    }
}
