﻿using DoctorAppointment.Services.Doctors.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DoctorAppointment.RestAPI.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly DoctorService _service;
        public DoctorsController(DoctorService service)
        {
            _service = service;
        }

        [HttpPost]
        public void AddDoctor(AddDoctorDto dto)
        {
            _service.Add(dto);
        }

        [HttpGet]
        public List<GetDoctorDto> GetAllDoctors()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public GetDoctorDto GetDoctor(int id)
        {
            return _service.GetByDto(id);
        }

        [HttpPut("{id}")]
        public void Update(int id, UpdateDoctorDto dto)
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
