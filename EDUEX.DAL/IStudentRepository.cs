using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUEX.DAL
{
    public interface IStudentRepository : IBaseRepository
    {
        IList<StudentInfo> GetAll();

        StudentInfo GetById(int id);

        StudentInfo Create(StudentInfo student);

        StudentInfo Update(StudentInfo student);

        void Delete(int studentId);
    }
}
