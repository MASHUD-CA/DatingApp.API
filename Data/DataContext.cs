using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    //Derived data from DbContext
    public class DataContext : DbContext
    {
        //Constructor. Add DbContextOptions then type/class using for out data context
        // and specify options. Also need to do call into the class are deriving from and its options.
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // tell data context class about our entities. Specify value as type of particular DB set
        // Values here is table name that gets created waht we scaffold our database
        public DbSet<Value> Values { get; set; }


    }
}