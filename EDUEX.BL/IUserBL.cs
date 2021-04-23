using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUEX.Domain;

namespace EDUEX.BL
{
    public interface IUserBL : IBaseBL
    {
        User GetById(int id);

        User Create(User user);

        IList<User> GetAll();

        User Update(User user);

        bool IsUserExists(string email);
    }
}
