namespace HangRating
{
    public class UnknownPolicyRater : Rater
    {
        public override void Rate(RatingEngine engine, Policy policy)
        {
            Logger.Log("Unknown policy type");
        }
    }
}