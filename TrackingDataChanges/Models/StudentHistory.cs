namespace TrackingDataChanges.Models
{
    public class StudentHistory : Student, History
    {
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
    }
}
