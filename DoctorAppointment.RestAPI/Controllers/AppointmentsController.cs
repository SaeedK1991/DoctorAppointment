using DoctorAppointment.Services.Appointments.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DoctorAppointment.RestAPI.Controllers
{
    [ApiController]
    [Route("api/appointments")]
    public class AppointmentsController : Controller
    {
        private readonly AppointmentService _service;

        public AppointmentsController(AppointmentService service)
        {
            _service = service;
        }

        [HttpPost]
        public void Add(AddAppointmentDto dto)
        {
            _service.Add(dto);
        }

        [HttpGet]
        public List<GetAppointmentDto> GetAllAppointment()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public GetAppointmentDto GetAppointment(int id)
        {
            return _service.GetByDto(id);
        }

        [HttpPut("{id}")]
        public void Update(UpdateAppointmentDto dto, int id)
        {
            _service.Update(id, dto);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
