using DoctorAppointment.Entities;
using DoctorAppointment.Services.Doctors.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DoctorAppointment.Persistence.EF.Doctors
{
    public class EFDoctorRepository : DoctorRepository
    {
        private readonly DbSet<Doctor> _doctors;

        public EFDoctorRepository(ApplicationDbContext dbcontext)
        {
            _doctors = dbcontext.Set<Doctor>();
        }

        public void Add(Doctor doctor)
        {
            _doctors.Add(doctor);
        }

        public List<GetDoctorDto> GetAll()
        {
            return _doctors.Select(_ => new GetDoctorDto
            {
                Id = _.Id,
                LastName = _.LastName,
                FirstName = _.FirstName,
                NationalCode = _.NationalCode,
                Field = _.Field,
            }).ToList();
        }

        public GetDoctorDto GetByDto(int id)
        {
            return _doctors
             .Select(_ => new GetDoctorDto
             {
                 Id = _.Id,
                 LastName = _.LastName,
                 FirstName = _.FirstName,
                 NationalCode = _.NationalCode,
                 Field = _.Field,
             }).FirstOrDefault(_ => _.Id == id);
        }

        public Doctor GetById(int id)
        {
            return _doctors
                .Include(_ => _.Appointments)
                .FirstOrDefault(_ => _.Id == id);
        }


        public void Delete(Doctor doctor)
        {
            _doctors.Remove(doctor);
        }

        public bool IsExistNationalCode(string nationalCode)
        {
            return _doctors.Any(_ => _.NationalCode == nationalCode);
        }


    }
}
