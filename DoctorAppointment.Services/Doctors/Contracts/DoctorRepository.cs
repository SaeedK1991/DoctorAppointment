using DoctorAppointment.Entities;
using System.Collections.Generic;

namespace DoctorAppointment.Services.Doctors.Contracts
{
    public interface DoctorRepository
    {
        void Add(Doctor doctor);

        bool IsExistNationalCode(string nationalCode);

        List<GetDoctorDto> GetAll();

        Doctor GetById(int id);

        GetDoctorDto GetByDto(int id);

        void Delete(Doctor doctor);

    }
}
