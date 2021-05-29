using AutoMapper;
using EDUEX.BL;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using EDUEX.Web.Dto.UserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EDUEX.Web.Api
{
    [Route("api/user")]
    [Authorize]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL _userBL;
        private readonly IMapper _mapper;
        private readonly IHashing _hasher;

        public UserController(IUserBL userBL, IMapper mapper, IHashing hasher)
        {
            _userBL = userBL;
            _mapper = mapper;
            _hasher = hasher;
        }


        //[Authorize(Roles = "admin")]
        [HttpGet]
        public IEnumerable<UserDtoWithEmail> Get()
        {
            var users = _userBL.GetAll();
            var usersView = _mapper.Map<List<UserDtoWithEmail>>(users);
            return usersView;
        }


        //[Authorize(Roles = "admin")]
        [HttpGet("{id}")]
        public UserDtoWithEmail Get(int id)
        {
            var user = _userBL.GetById(id);
            var userView = _mapper.Map<UserDtoWithEmail>(user);
            return userView;
        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserDto userDto)
        {
            userDto.Password = _hasher.GetHash(userDto.Password);
            if (userDto.Roles == null)
            {
                userDto.Roles = new List<string> { "user" };
            }

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


        [Authorize(Roles = "admin")]
        [HttpGet]
        [Route("userRoles/{userId}")]
        public IEnumerable<UserRoleDto> GetUserRoles(int userId)
        {
            var users = _userBL.GetUserRoles(userId);
            var userDtos = _mapper.Map<List<UserRoleDto>>(users);
            return userDtos;
        }


        [Authorize(Roles = "admin")]
        [HttpPost]
        [Route("userRoles")]
        public IActionResult AddUserRole([FromBody] UserRoleDto userRoleDto)
        {
            var result = _userBL.AddRole(userRoleDto.UserId, userRoleDto.RoleId);
            return Ok(result);
        }


        [Authorize(Roles = "admin")]
        [HttpPut]
        [Route("userRoles/{id}")]
        public IActionResult PutUserRole(int id, [FromBody] UserRoleDto userRoleDto)
        {
            userRoleDto.Id = id;
            var userRole = _mapper.Map<UserRole>(userRoleDto);
            var result = _userBL.UpdateUserRole(userRole);
            return Ok(result);
        }


        [Authorize(Roles = "admin")]
        [HttpDelete]
        [Route("userRoles/{id}")]
        public IActionResult DeleteUserRole(int id)
        {
            _userBL.DeleteUserRole(id);
            return Ok();
        }

    }
}
