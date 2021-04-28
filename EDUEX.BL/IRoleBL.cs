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
    }
}
