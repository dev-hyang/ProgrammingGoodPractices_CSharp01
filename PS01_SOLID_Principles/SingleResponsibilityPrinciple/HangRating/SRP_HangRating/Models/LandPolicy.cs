﻿using System;

namespace SRP_HangRating.Models
{

    public class LandPolicy : Policy
    {
        public string Address { get; set; }
        public decimal Size { get; set; }
        public decimal Valuation { get; set; }
        public decimal BondAmount { get; set; }
    }
}