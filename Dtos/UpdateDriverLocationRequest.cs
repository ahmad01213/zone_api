﻿using System;
namespace webApp.Dtos
{
    public class UpdateDriverLocationRequest
    {
        public int id { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
    }
}
