using Hospital.Data;
using Hospital.Models;
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

        public IActionResult MakeAppointment(CompleteAppointment completeAppointment)
        {
            dbContext.CompleteAppointments.Add(new CompleteAppointment()
            {
                PatientName = completeAppointment.PatientName,
                DoctorId= completeAppointment.DoctorId,
                AppointmentDate= completeAppointment.AppointmentDate,
                AppointmentTime= completeAppointment.AppointmentTime,

            } );
            dbContext.SaveChanges();
            return RedirectToAction(nameof(BookAppointment));
       
        }
    }

}

