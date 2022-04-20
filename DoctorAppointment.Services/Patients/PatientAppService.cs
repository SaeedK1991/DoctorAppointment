using DoctorAppointment.Entities;
using DoctorAppointment.Infrastructure.Application;
using DoctorAppointment.Services.Patients.Contracts;
using DoctorAppointment.Services.Patients.Exceptions;
using System.Collections.Generic;

namespace DoctorAppointment.Services.Patients
{
    public class PatientAppService : PatientService
    {
        private readonly PatientRepository _repository;
        private readonly UnitOfWork _unitOfWork;

        public PatientAppService(
            PatientRepository patientRepository,
            UnitOfWork unitOfWork)
        {
            _repository = patientRepository;
            _unitOfWork = unitOfWork;
        }
        public void Add(AddPatientDto dto)
        {
            var patient = new Patient
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                NationalCode = dto.NationalCode,
            };
            var isExistNationalCode = _repository
                .IsExistNationalCode(patient.NationalCode);
            if (isExistNationalCode)
            {
                throw new PatientAlreadyExistException();
            }
            _repository.Add(patient);
            _unitOfWork.Commit();
        }

        public List<GetPatientDto> GetAll()
        {
            return _repository.GetAll();
        }

        public GetPatientDto GetByDto(int id)
        {
            return _repository.GetByDto(id);
        }

        public void Update(UpdatePatientDto dto, int id)
        {
            var patient = _repository.GetById(id);

            if (patient.NationalCode != dto.NationalCode)
            {
                var isExistNationalCode = _repository
               .IsExistNationalCode(patient.NationalCode);
                if (isExistNationalCode)
                {
                    throw new PatientAlreadyExistException();
                }
            }

            patient.FirstName = dto.FirstName;
            patient.LastName = dto.LastName;
            patient.NationalCode = dto.NationalCode;

            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            var patient = _repository.GetById(id);
            _repository.Delete(patient);
            _unitOfWork.Commit();

        }

    }
}
