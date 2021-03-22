﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.DTOs
{
    public class CarDetailDto:IDto
    {
        public string CarName { get; set; }
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public int BrandId { get; set; }
        public string ColorName { get; set; }
        public int ColorId { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }
        public List<string> ImagePath { get; set; }
    }
}
