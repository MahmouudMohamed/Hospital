using Hospital.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class DoctorController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public IActionResult BookAppointment()
        {
            var Doctors = dbContext.Doctors.ToList();
            return View(Doctors);
        }

        public IActionResult CompleteAppointment(int id)
        {
            var Doc = dbContext.Doctors.Find(id);
            return View(Doc);
        }
    }

}

