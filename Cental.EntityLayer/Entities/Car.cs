﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public string ModelName { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int SeatCount { get; set; }
        public string GearType { get; set; }
        public string GasType { get; set; }
        public int Year { get; set; }
        public string Transmission { get; set; }
        public int Kilometer { get; set; }
        public int BrandId { get; set; }

        public Brand Brand { get; set; }  //navigation property
        public List<Review> Reviews { get; set; }
    }
}
