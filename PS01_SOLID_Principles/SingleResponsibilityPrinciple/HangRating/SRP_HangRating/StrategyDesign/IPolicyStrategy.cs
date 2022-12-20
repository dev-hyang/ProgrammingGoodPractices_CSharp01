using SRP_HangRating.Models;

namespace SRP_HangRating.StrategyDesign
{
    public interface IPolicyStrategy
    {
        decimal Execute(Policy policy);
    }
}