namespace TrackingDataChanges.Models
{
    public interface IHistory
    {
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
    }
}
