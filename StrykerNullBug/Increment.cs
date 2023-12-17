namespace StrykerNullBug
{
    public class Increment 
    {
        public Guid Id { get; set; }

        public string AccountNumber { get; set; }

        public string IncrementNumber { get; set; }

        public string IncrementType { get; set; }

        public string ProductClassType { get; set; }

        public DateTime IncrementStartDate { get; set; }

        public DateTime PlanStartDate { get; set; }

        public DateTime EffectiveStartDate { get; set; }

        public DateTime? EffectiveEndDate { get; set; }

        public DateTime? RetirementDate { get; set; }

        public DateTime? RebalanceDate { get; set; }

        public int? RebalanceFrequencyMonths { get; set; }
    }
}
