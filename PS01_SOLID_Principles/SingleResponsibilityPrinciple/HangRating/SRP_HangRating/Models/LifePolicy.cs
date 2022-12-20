using System;

namespace SRP_HangRating.Models
{

    public class LifePolicy : Policy
    {
        public PolicyType Type { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsSmoker { get; set; }
        public decimal Amount { get; set; }
    }
}