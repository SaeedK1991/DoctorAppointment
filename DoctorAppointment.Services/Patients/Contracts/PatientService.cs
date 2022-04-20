using System.Collections.Generic;

namespace DoctorAppointment.Services.Patients.Contracts
{
    public interface PatientService
    {
        void Add(AddPatientDto dto);

        GetPatientDto GetByDto(int id);

        List<GetPatientDto> GetAll();

        void Update(UpdatePatientDto dto, int id);

        void Delete(int id);
    }
}
