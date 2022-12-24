using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrackingDataChanges.Models;

namespace TrackingDataChanges.Controllers
{
    public class TemporalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TemporalController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Students.TemporalAll()
                .Select(a => new StudentHistory()
                {
                    Id = a.Id,
                    Name = a.Name,
                    PeriodStart = EF.Property<DateTime>(a, "PeriodStart"),
                    PeriodEnd = EF.Property<DateTime>(a, "PeriodEnd")
                }).ToList();

            //var periodStart = Convert.ToDateTime("2022-12-23 13:30:50.6736582");
            //var periodEnd = Convert.ToDateTime("2022-12-23 13:30:50.6736582");
            //var students = _context.Students.TemporalAsOf(periodStart);
            //var students = _context.Students.TemporalBetween(periodStart, periodEnd);
            //var students = _context.Students.TemporalContainedIn(periodStart, periodEnd);
            //var students = _context.Students.TemporalFromTo(periodStart, periodEnd);
            return View(students);
        }
    }
}
