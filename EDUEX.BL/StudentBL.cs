using EDUEX.DAL;
using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.BL
{
    public class StudentBL : IStudentBL
    {
        private readonly IStudentRepository studentRepository;
        
        public StudentBL(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public StudentInfo Create(StudentInfo student)
        {
            return studentRepository.Create(student);
        }
        
        public void Delete(int studentId)
            => studentRepository.Delete(studentId);
       

        public IList<StudentInfo> GetAll()
            => studentRepository.GetAll();

        public StudentInfo GetById(int id)
            => studentRepository.GetById(id);

        public StudentInfo Update(StudentInfo student)
            => studentRepository.Update(student);
    }
}
