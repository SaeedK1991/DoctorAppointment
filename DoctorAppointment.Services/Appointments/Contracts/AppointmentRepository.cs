using DoctorAppointment.Entities;
using System;
using System.Collections.Generic;

namespace DoctorAppointment.Services.Appointments.Contracts
{
    public interface AppointmentRepository
    {
        void Add(Appointment appointment);

        bool Isvisited(int doctorId, int patientId, DateTime date);

        int Appointmentcount(int doctorId, DateTime date);

        List<GetAppointmentDto> GetAll();

        Appointment GetById(int id);

        GetAppointmentDto GetAppointmentDto(int id);

        void Delete(Appointment appointment);
    }
}
