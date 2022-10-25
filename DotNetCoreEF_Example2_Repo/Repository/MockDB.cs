using DotNetCoreEF_Example2_Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreEF_Example2_Repo.Repository
{
    /// <summary>
    ///  MockDB is just a dummy DB we can use, instaed of a real DB for tesitng
    ///  Its useful in real life development, where the Databse might not be set up yet
    ///  Its also useful for unit-testing as we dont want to use real Db for our 
    ///  unit tests (we are not testing the DB!! we are testing the query methods!)
    /// </summary>
    public class MockDB : IRepository
    {
        //create a list to hold out students (is essense this list is our 'db'
        private static List<Student> Students = new List<Student>();


        public void AddStudent(Student s)
        {
            //you should  add code here to ensure you are not adding student that exists alread,
            //but for simplicity i'm leaving this out for moment
            Students.Add(s);            
        }

        public List<Student> GetStudents()
        {
            return Students.ToList();
        }
    }
}
