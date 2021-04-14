using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.BL
{
    public interface IStudentBL : IBaseBL
    {
        IList<Student> GetAll();

        Student GetById(int id);

        Student Create(Student student);

        Student Update(Student student);

        void Delete(int studentId);

    }
}
