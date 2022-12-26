using System.Reflection;

namespace HangRating
{
    public class RaterFactory
    {
        public Rater GetRater(Policy policy, bool isReflected = false)
        {
            /*
            if (isReflected)
            {
                var assembly = Assembly.GetAssembly(this.GetType());
                var rater = assembly?.CreateInstance($"HangRating.{policy.Type}PolicyRater");
                if (rater != null)
                {
                    return (Rater)rater;
                }
            }

            return policy.Type switch
            {
                PolicyType.Auto => new AutoPolicyRater(),
                PolicyType.Land => new LandPolicyRater(),
                PolicyType.Life => new LifePolicyRater(),
                _ => throw new Exception("No valid policy rater found!")
            };
            */
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"HangRating.{policy.Type}PolicyRater"));
            }
            catch
            {
                return null;
            }
        }
    }
}
