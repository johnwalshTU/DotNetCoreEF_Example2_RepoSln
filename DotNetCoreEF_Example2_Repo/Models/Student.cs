using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreEF_Example2_Repo.Models
{
    //------ Model Class ----------------------------------------
    // a Student entity
    public class Student                                // POCO
    {
        public int ID { get; set; }                     // PK and identity also
        public string StudentNo { get; set; } = "";        // X number, null
        public string Name { get; set; } = "";             // null
        public string Email { get; set; } = "";              // null
    }
}
