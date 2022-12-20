using System.Diagnostics.CodeAnalysis;
using SRP_HangRating.Models;

namespace SRP_HangRating
{
    public class PolicyEqualityComparer : EqualityComparer<Policy>
    {
        public override bool Equals(Policy? x, Policy? y)
        {
            return (x == default && y == default) || x.Type == y.Type || x == y;
        }

        public override int GetHashCode([DisallowNull] Policy obj)
        {
            // how to generate hashcode
            return obj.GetHashCode();
        }
    }
}
