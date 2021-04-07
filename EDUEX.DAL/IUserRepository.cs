using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUEX.Domain;

namespace EDUEX.DAL
{
    public interface IUserRepository : IBaseRepository
    {
        User GetById(int id);
    }
}
