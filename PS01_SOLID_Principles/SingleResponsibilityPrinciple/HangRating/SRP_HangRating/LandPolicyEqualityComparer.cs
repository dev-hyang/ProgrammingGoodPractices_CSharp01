using System.Diagnostics.CodeAnalysis;
using SRP_HangRating.Models;

namespace SRP_HangRating
{
    public class LandPolicyEqualityComparer : EqualityComparer<LandPolicy>
    {
        public override bool Equals(LandPolicy? x, LandPolicy? y)
        {
            return x?.Type == y?.Type
                && x?.BondAmount == y?.BondAmount
                && x?.Address == y?.Address
                && x?.Size == y?.Size
                && x?.Valuation == y?.Valuation;
        }

        public override int GetHashCode([DisallowNull] LandPolicy obj)
        {
            // how to generate hashcode
            return obj.GetHashCode();
        }
    }
}
