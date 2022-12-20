using SRP_HangRating.Models;
using SRP_HangRating.Utils;

namespace SRP_HangRating.StrategyDesign
{
    public class LifePolicyStrategy : IPolicyStrategy
    {
        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();

        public decimal Execute(Policy policy)
        {
            var lifePolicy = policy;
            var rating = 0m;
            Logger.Log("Rating LIFE policy...");
            Logger.Log("Validating policy.");
            if (lifePolicy.DateOfBirth == DateTime.MinValue)
            {
                Logger.Log("Life policy must include Date of Birth.");
                return rating;
            }
            if (lifePolicy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                Logger.Log("Centenarians are not eligible for coverage.");
                return rating;
            }
            if (lifePolicy.Amount == 0)
            {
                Logger.Log("Life policy must include an Amount.");
                return rating;
            }
            int age = DateTime.Today.Year - lifePolicy.DateOfBirth.Year;
            if (lifePolicy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < lifePolicy.DateOfBirth.Day ||
                DateTime.Today.Month < lifePolicy.DateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = lifePolicy.Amount * age / 200;
            if (lifePolicy.IsSmoker)
            {
                rating = baseRate * 2;
                return rating;
            }
            rating = baseRate;
            return rating;
        }
    }
}
