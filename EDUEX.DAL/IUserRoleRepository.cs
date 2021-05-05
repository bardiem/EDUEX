﻿using EDUEX.Domain;
using System.Collections.Generic;

namespace EDUEX.DAL
{
    public interface IUserRoleRepository : IBaseRepository
    {
        UserRole Create(UserRole userRole);

        void Delete(int id);

        UserRole GetUserRole(int id);

        IList<UserRole> GetAll();

        UserRole Update(UserRole userRole);
    }
}
