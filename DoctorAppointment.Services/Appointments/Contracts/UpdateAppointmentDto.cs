using System;

namespace DoctorAppointment.Services.Appointments.Contracts
{
    public class UpdateAppointmentDto
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
    }
}