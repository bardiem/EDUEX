using AutoMapper;
using EDUEX.BL;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace EDUEX.Web.Api
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL _userBL;
        private readonly IMapper _mapper;


        public UserController(IUserBL userBL, IMapper mapper)
        {
            _userBL = userBL;
            _mapper = mapper;
        }


        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userBL.GetAll();
        }


        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userBL.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserDto userDto)
        {

            if (!ModelState.IsValid || _userBL.IsUserExists(userDto.Email))
                return BadRequest();

            User user = new User();
            _mapper.Map(userDto, user);

            var result = _userBL.Create(user);
            return Ok(result);
        }

        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            user.Id = id;
            _userBL.Update(user);
            return Ok();
        }

       
    }
}
