using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUEX.Domain;

namespace EDUEX.BL
{
    public interface IRoleBL : IBaseBL
    {
        IList<Role> GetList();

        Role Create(Role role);

        Role Update(Role role);

        void Delete(int id);

    }
}
