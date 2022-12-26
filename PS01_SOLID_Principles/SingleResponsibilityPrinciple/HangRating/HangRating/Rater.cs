namespace HangRating
{
    public abstract class Rater
    {
        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();
        public virtual void Rate(RatingEngine engine, Policy policy) { }
    }
}
