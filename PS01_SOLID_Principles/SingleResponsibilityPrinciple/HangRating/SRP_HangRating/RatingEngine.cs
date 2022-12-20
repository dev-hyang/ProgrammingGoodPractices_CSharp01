using SRP_HangRating.Models;
using SRP_HangRating.StrategyDesign;
using SRP_HangRating.Utils;

namespace SRP_HangRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public decimal Rating { get; set; }
        // Logging to replace every Logger.Log in the old class
        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();
        public IPolicyStrategy PolicyStrategy { get; set; }

        public void Rate(IPolicyStrategy policyStrategy, Policy policy)
        {
            Logger.Log("Starting rate.");
            Logger.Log("Loading policy.");

            PolicyStrategy = policyStrategy ?? new AutoPolicyStrategy();
            Rating = PolicyStrategy.Execute(policy);

            Logger.Log($"Process completed: The Rating is {Rating}");
        }
    }
}