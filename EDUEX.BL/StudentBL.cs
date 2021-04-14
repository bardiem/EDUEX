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
        private readonly IUserRepository userRepository;

        public StudentBL(IStudentRepository studentRepository, IUserRepository userRepository)
        {
            this.studentRepository = studentRepository;
            this.userRepository = userRepository;
        }

        public Student Create(Student student)
        {
            var user = userRepository.Create(student.User);
            student.UserId = user.Id;
            student.User = null;
            return studentRepository.Create(student);
        }
        
        public void Delete(int studentId)
            => studentRepository.Delete(studentId);
       

        public IList<Student> GetAll()
            => studentRepository.GetAll();

        public Student GetById(int id)
            => studentRepository.GetById(id);

        public Student Update(Student student)
            => studentRepository.Update(student);
    }
}
