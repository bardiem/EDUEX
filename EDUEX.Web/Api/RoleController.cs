using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using EDUEX.BL;
using EDUEX.Web.Dto;
using EDUEX.Domain;
using Microsoft.AspNetCore.Authorization;

namespace EDUEX.Web.Api
{
    [Route("/api/role")]
    [Authorize]
    [ApiController]
    public class RoleController : BaseController
    {

        private readonly IRoleBL roleBL;
        private readonly IMapper mapper;

        public RoleController(IRoleBL roleBL, IMapper mapper)
        {
            this.roleBL = roleBL;
            this.mapper = mapper;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<RoleDto>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var roles = roleBL.GetList();
            var result = mapper.Map<List<RoleDto>>(roles);
            return Ok(result);
        }


        [HttpGet("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(RoleDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int id)
        {
            var roles = roleBL.GetList();
            var role = roles.FirstOrDefault(p => p.Id == id);
            var result = mapper.Map<RoleDto>(role);
            return Ok(result);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(RoleDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody]RoleDto roleDto)
        {
            var result = mapper.Map<Role>(roleDto);
            var role = roleBL.Create(result);
            return Ok(role);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Role role)
        {
            role.Id = id;
            var updateRole = roleBL.Update(role);
            return Ok(updateRole);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRole(int id)
        {
            roleBL.Delete(id);
            return Ok();
        }
    }
}
