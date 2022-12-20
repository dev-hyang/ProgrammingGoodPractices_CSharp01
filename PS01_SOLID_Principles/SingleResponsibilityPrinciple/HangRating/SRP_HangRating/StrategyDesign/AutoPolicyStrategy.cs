using SRP_HangRating.Models;
using SRP_HangRating.Utils;

namespace SRP_HangRating.StrategyDesign
{
    public class AutoPolicyStrategy : IPolicyStrategy
    {
        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();

        public decimal Execute(Policy policy)
        {
            var autoPolicy = policy;
            var rating = 0m;
            Logger.Log("Rating AUTO policy...");
            Logger.Log("Validating policy.");
            if (string.IsNullOrEmpty(autoPolicy.Make))
            {
                Logger.Log("Auto policy must specify Make");
                return rating;
            }
            if (autoPolicy.Make == "BMW")
            {
                if (autoPolicy.Deductible < 500)
                {
                    rating = 1000m;
                }
                rating = 900m;
            }
            return rating;
        }
    }
}
