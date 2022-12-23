namespace TrackingDataChanges.Models
{
    public interface History
    {
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
    }
}
