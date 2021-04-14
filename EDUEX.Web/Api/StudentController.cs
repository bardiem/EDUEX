using AutoMapper;
using EDUEX.BL;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EDUEX.Web.Api
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : BaseUserController
    {
        private readonly IStudentBL studentBL;
        private readonly IMapper mapper;

        public StudentController(IUserBL userBL, IStudentBL studentBL, IMapper mapper) : base(userBL)
        {
            this.studentBL = studentBL;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = studentBL.GetAll();
            var result = mapper.Map<List<StudentDto>>(list);
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var student = studentBL.GetById(id);
            var result = mapper.Map<StudentDto>(student);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody]StudentDto student)
        {
            var entry = mapper.Map<StudentInfo>(student);
            var newEntry = studentBL.Create(entry);
            var result = mapper.Map<StudentDto>(newEntry);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put([FromBody] StudentDto student)
        {
            var entry = mapper.Map<StudentInfo>(student);
            var newEntry = studentBL.Update(entry);
            var result = mapper.Map<StudentDto>(newEntry);
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            studentBL.Delete(id);
            return Ok();
        }

    }
}
