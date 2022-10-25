using DotNetCoreEF_Example2_Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreEF_Example2_Repo.Repository
{
    public interface IRepository
    {
        void AddStudent(Student s);
        List<Student> GetStudents();
    }
}
