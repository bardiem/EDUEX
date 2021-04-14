using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.DAL
{
    public interface IUserRepository : IBaseRepository
    {
        User GetById(int id);

        User Create(User user);
    }
}
