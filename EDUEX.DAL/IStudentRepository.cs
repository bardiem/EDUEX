﻿using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUEX.DAL
{
    public interface IStudentRepository : IBaseRepository
    {
        IList<Student> GetAll();

        Student GetById(int id);

        Student Create(Student student);

        Student Update(Student student);

        void Delete(int studentId);
    }
}
