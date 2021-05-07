﻿using System.ComponentModel.DataAnnotations;

namespace EDUEX.Web.Dto
{
    public class RoleDto
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string Code { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(300)]
        public string PermissionDescription { get; set; }
    }
}
