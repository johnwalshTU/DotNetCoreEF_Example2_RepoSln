using DotNetCoreEF_Example2_Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreEF_Example2_Repo.Repository
{
    public class RealSqlDB : IRepository
    {
        StudentContext ct;

        public RealSqlDB()
        {
            ct = new StudentContext();
        }
        ~RealSqlDB()
        {
            //free Up DBContext when we are finished
            if (ct != null) ct.Dispose();
        }

        #region "IRepository Interface methods"
 
        public void AddStudent(Student s)
        {
            ct.Students.Add(s);

            ct.SaveChanges();
        }

        public List<Student> GetStudents()
        {
            return ct.Students.ToList();
        }

        #endregion
    }
}
