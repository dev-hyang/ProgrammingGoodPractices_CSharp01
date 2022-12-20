using System.Diagnostics.CodeAnalysis;
using SRP_HangRating.Models;

namespace SRP_HangRating
{
    public class LifePolicyEqualityComparer : EqualityComparer<LifePolicy>
    {
        public override bool Equals(LifePolicy? x, LifePolicy? y)
        {
            return x?.Type == y?.Type
                && x?.FullName == y?.FullName
                && x?.IsSmoker == y?.IsSmoker
                && x?.Amount == y?.Amount
                && x?.DateOfBirth == y?.DateOfBirth;
        }

        public override int GetHashCode([DisallowNull] LifePolicy obj)
        {
            // how to generate hashcode
            return obj.GetHashCode();
        }
    }
}
