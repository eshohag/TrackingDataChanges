namespace TrackingDataChanges.Models
{
    public class StudentHistory : Student, History
    {
        public DateTime PeriodStart { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime PeriodEnd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
