using System.Diagnostics.CodeAnalysis;
using SRP_HangRating.Models;

namespace SRP_HangRating
{
    public class AutoPolicyEqualityComparer : EqualityComparer<AutoPolicy>
    {
        public override bool Equals(AutoPolicy? x, AutoPolicy? y)
        {
            return x?.Type == y?.Type
                && x?.Make == y?.Make
                && x?.Model == y?.Model
                && x?.Year == y?.Year
                && x?.Miles == y?.Miles
                && x?.Deductible == y?.Deductible;
        }

        public override int GetHashCode([DisallowNull] AutoPolicy obj)
        {
            // how to generate hashcode
            return obj.GetHashCode();
        }
    }
}
