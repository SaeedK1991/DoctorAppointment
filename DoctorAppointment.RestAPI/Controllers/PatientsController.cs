using DoctorAppointment.Services.Patients.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DoctorAppointment.RestAPI.Controllers
{
    [ApiController]
    [Route("api/patients")]
    public class PatientsController : Controller
    {
        private readonly PatientService _service;

        public PatientsController(PatientService service)
        {
            _service = service;
        }

        [HttpPost]
        public void Add(AddPatientDto dto)
        {
            _service.Add(dto);
        }

        [HttpGet]
        public List<GetPatientDto> GetAllPatient()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public GetPatientDto GetByDto(int id)
        {
            return _service.GetByDto(id);
        }

        [HttpPut("{id}")]
        public void Update(UpdatePatientDto dto, int id)
        {
            _service.Update(dto, id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
