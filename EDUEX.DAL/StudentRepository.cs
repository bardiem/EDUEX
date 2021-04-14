using EDUEX.Data;
using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.DAL
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public StudentRepository(Func<IEduExDbContext> getDbContext) : base(getDbContext)
        {
        }

        public Student Create(Student student)
            => Execute(context =>
            {
                context.Students.Add(student);
                context.SaveChanges();
                return student;
            });

        public void Delete(int studentId)
            => Execute(context =>
            {
                var entry = context.Students.Find(studentId);
                if (entry != null)
                {
                    context.Students.Remove(entry);
                    context.SaveChanges();
                }
            });

        public IList<Student> GetAll()
            => Execute(context => context.Students.ToList());


        public Student GetById(int id)
             => Execute(context => context.Students.Find(id));

        
        public Student Update(Student student)
             => Execute(context =>
             {
                 context.Students.Update(student);
                 context.SaveChanges();
                 return student;
             });
    }
}
