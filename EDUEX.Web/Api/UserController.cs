using AutoMapper;
using EDUEX.BL;
using EDUEX.Domain;
using EDUEX.Web.Dto.UserDtos;
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
        public IEnumerable<UserDtoWithEmail> Get()
        {
            var users = _userBL.GetAll();
            var usersView = _mapper.Map<List<UserDtoWithEmail>>(users);
            return usersView;
        }


        [HttpGet("{id}")]
        public UserDtoWithEmail Get(int id)
        {
            var user = _userBL.GetById(id);
            var userView = _mapper.Map<UserDtoWithEmail>(user);
            return userView;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);

            var result = _userBL.Create(user);
            return Ok(result);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {
            user.Id = id;
            _userBL.Update(user);
            return Ok();
        }


    }
}
