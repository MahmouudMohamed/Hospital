﻿namespace Hospital.Models
{
    public class CompleteAppointment
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AppointmentTime { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
