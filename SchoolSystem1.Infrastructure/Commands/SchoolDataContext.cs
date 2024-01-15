using Microsoft.EntityFrameworkCore;
using SchoolSystem1.Infrastructure.Model;

namespace SchoolSystem1.Infrastructure.DatabaseContext
{
    public class SchoolDataContext : DbContext
    {
       public DbSet<Student> Students { get; set; }
        
    }
}
