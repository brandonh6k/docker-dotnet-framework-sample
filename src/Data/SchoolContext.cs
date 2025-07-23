using System.Data.Entity;
using myWebApp.Models;

namespace myWebApp.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolContext")
        {
            Database.SetInitializer<SchoolContext>(new SchoolInitializer());
        }

        public DbSet<Student> Students { get; set; }
    }

    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new Student[]
            {
                new Student { FirstMidName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.Parse("2019-09-01") },
                new Student { FirstMidName = "Meredith", LastName = "Alonso", EnrollmentDate = DateTime.Parse("2017-09-01") },
                new Student { FirstMidName = "Arturo", LastName = "Anand", EnrollmentDate = DateTime.Parse("2018-09-01") }
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
            
            base.Seed(context);
        }
    }
}