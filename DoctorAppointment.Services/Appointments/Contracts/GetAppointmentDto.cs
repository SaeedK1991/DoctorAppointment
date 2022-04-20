using DoctorAppointment.Services.Doctors.Contracts;
using DoctorAppointment.Services.Patients.Contracts;
using System;

namespace DoctorAppointment.Services.Appointments.Contracts
{
    public class GetAppointmentDto
    {
        public GetAppointmentDto()
        {
            doctor = new GetDoctorDto();
            patient = new GetPatientDto();
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public GetDoctorDto doctor { get; set; }
        public GetPatientDto patient { get; set; }
    }
}