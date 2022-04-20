using DoctorAppointment.Entities;
using System.Collections.Generic;

namespace DoctorAppointment.Services.Patients.Contracts
{
    public interface PatientRepository
    {
        void Add(Patient doctor);
        bool IsExistNationalCode(string nationalCode);

        List<GetPatientDto> GetAll();

        Patient GetById(int id);

        GetPatientDto GetByDto(int id);

        void Delete(Patient patient);
    }
}
