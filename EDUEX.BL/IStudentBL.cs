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
        IList<StudentInfo> GetAll();

        StudentInfo GetById(int id);

        StudentInfo Create(StudentInfo student);

        StudentInfo Update(StudentInfo student);

        void Delete(int studentId);

    }
}
