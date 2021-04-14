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

        public StudentInfo Create(StudentInfo student)
            => Execute(context =>
            {
                context.StudentInfos.Add(student);
                context.SaveChanges();
                return student;
            });

        public void Delete(int studentId)
            => Execute(context =>
            {
                var entry = context.StudentInfos.Find(studentId);
                if (entry != null)
                {
                    context.StudentInfos.Remove(entry);
                    context.SaveChanges();
                }
            });

        public IList<StudentInfo> GetAll()
            => Execute(context => context.StudentInfos.ToList());


        public StudentInfo GetById(int id)
             => Execute(context => context.StudentInfos.Find(id));

        
        public StudentInfo Update(StudentInfo student)
             => Execute(context =>
             {
                 context.StudentInfos.Update(student);
                 context.SaveChanges();
                 return student;
             });
    }
}
