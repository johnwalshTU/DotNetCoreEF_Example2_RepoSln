using DotNetCoreEF_Example2_Repo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreEF_Example2_Repo.Repository
{
    internal class StudentContext : DbContext
    {
        // In order to define DB connection string to use i need to add the following method
        // OnConfiguring is part of the base DbContext class and we can override it to configure our DB
        // .Net core Entity framework calls this method when .. and passes in a DbContextOptionsBuilder
        // DbContextOptionsBuilder is the class that looks after configuration of databse
        //
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string
            string connectionstr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=StudentDB_RepoExample;Integrated Security=SSPI;AttachDBFilename=C:\Development\StudentDB_RepoExample.mdf";
            
            //We want to use sql server (with out defined connection string)
            optionsBuilder.UseSqlServer(connectionstr);
            //optionsBuilder.UseInMemoryDatabase("someDB");
        }


        public DbSet<Student> Students { get; set; }
    }
}
