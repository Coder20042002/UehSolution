using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ueh.Data.EF;
using Ueh.Data.Entities;

namespace Ueh.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly UEH_DbContext _dbContext;

        public StudentService(UEH_DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddStudent(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
        }
    }


}
