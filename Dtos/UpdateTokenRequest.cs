using System;
namespace webApp.Dtos
{
    public class UpdateTokenRequest
    {
        public int UserId { get; set; }
        public string Token { get; set; }
        public string isDriver { get; set; }
    }
}
