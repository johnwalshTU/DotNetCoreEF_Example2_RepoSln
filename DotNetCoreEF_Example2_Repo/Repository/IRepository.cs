using DotNetCoreEF_Example2_Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreEF_Example2_Repo.Repository
{
    /// <summary>
    /// IRepository defines the DB operations (i.e we want ot be able to Add a student to DB and Get a list of all students)
    /// </summary>
    public interface IRepository
    {
        void AddStudent(Student s);
        List<Student> GetStudents();
    }
}
