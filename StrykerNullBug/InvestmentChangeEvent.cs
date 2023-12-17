namespace StrykerNullBug
{
    public class InvestmentChangeEvent
    {
        public Increment Increment { get; internal set; }

        public Switch Switch { get; set; }
    }
}