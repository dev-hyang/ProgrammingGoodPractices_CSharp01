using SRP_HangRating.Models;
using SRP_HangRating.Utils;

namespace SRP_HangRating.StrategyDesign
{
    public class LandPolicyStrategy : IPolicyStrategy
    {
        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();

        public decimal Execute(Policy policy)
        {
            var landPolicy = policy;
            var rating = 0m;
            Logger.Log("Rating LAND policy...");
            Logger.Log("Validating policy.");
            if (landPolicy.BondAmount == 0 || landPolicy.Valuation == 0)
            {
                Logger.Log("Land policy must specify Bond Amount and Valuation.");
                return rating;
            }
            if (landPolicy.BondAmount < 0.8m * landPolicy.Valuation)
            {
                Logger.Log("Insufficient bond amount.");
                return rating;
            }
            rating = landPolicy.BondAmount * 0.05m;
            return rating;
        }
    }
}
