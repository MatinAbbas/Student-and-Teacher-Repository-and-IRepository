using Microsoft.EntityFrameworkCore;

namespace Student_and_Teacher_Repository_and_IRepository
{
    public class ApplicationContext : DbContext

    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
            { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
    }
   

}
    

