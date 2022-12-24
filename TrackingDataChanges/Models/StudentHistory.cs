namespace TrackingDataChanges.Models
{
    public class StudentHistory : Student, IHistory
    {
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
    }
}
