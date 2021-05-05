using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUEX.DAL;
using EDUEX.Domain;

namespace EDUEX.BL
{
    public class RoleBL : IRoleBL
    {
        private readonly IRoleRepository roleRepository;

        public RoleBL(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public IList<Role> GetList()
        {
            return roleRepository.GetList();
        }

        public Role Create(Role role)
        {
            return roleRepository.Create(role);
        }

        public Role Update(Role role)
        {
            return roleRepository.Update(role);
        }

        public void Delete(int role)
        {
            roleRepository.Delete(role);
        }
    }
}
