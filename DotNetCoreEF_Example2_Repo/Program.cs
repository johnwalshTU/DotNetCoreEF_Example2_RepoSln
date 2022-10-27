// See https://aka.ms/new-console-template for more information

//........................................
//**** Notes regardss Net version 6 Console applications
//........................................
// This is a .Net version 6 console app
// .Net 6 changed the way program.cs is used (of course they did!)
// We no longer need to add Class and Main() function as this
// will be generated in the background when we run this app
// .Net 6 decided that it was cleaner to leave these out (and for it to just add it when program is run !!!
// So now you just wrtie you code straing away (rather that put inside Main()

//........................................
//**** Notes regardss Entity framework ***
//........................................
//
//  --IMPORTANT--
//  Before running this example you  will need to open
//  the 'Package Manager console' window and run the 'update-database –verbose'command
//
// goto main menu -> Tools -> Nuget Package Manager -> Package Manager Console
// enter in the following command
//  update-database –verbose
//
// This also assume you have a 'C:\Development' folder on you computer as this is what we have
// set the database location to in this example
// see 'var connectionStr..'  in the 'StudentContext.cs' file where we define the database connection string
//
//
// If you were creating this project yourself, befre you run the  update-database command you would  need to 
//  - add nuget package   Microsoft.EntityFrameworkCore.SqlServer      
//  - add nuget package   Microsoft.EntityFrameworkCore.Tools
//  - then add you dbContext code (if you havnt already done this)
//  - then open Package Manager console window and type the following 2 commands
//  - add-migration CreateStudentDB       (i've done this already for this sample project. This command adds the 'Migrations' folder which has code fro creating the DB and then for tracking DB changes
//  - update-database –verbose            (this command runs the commands (code) in the 'Migration' 
//
//----------------------------------------*/


using DotNetCoreEF_Example2_Repo.Models;
using DotNetCoreEF_Example2_Repo.Repository;

Console.WriteLine("Hello, World!");


IRepository repo = new RealSqlDB();
repo.AddStudent(new Student { Name = "john", StudentNo = "s1", Email = "j@j.com" });
repo.AddStudent(new Student { Name = "tim", StudentNo = "s2", Email = "s@j.com" });

var lst = repo.GetStudents().Select(s => s.Name).ToList();

foreach (var item in lst)
{
    Console.WriteLine(item);
}
