using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloCodeFirst
{
    public class tect_CodeFirstContext : DbContext
    {
        public tect_CodeFirstContext() : base()
        {
        }
        public DbSet<lecturer> lecturers { get; set; }        
        public DbSet<email> emails { get; set; }       
        public DbSet<course> courses { get; set; }       
        public DbSet<faculty> faculty { get; set; }        
        public DbSet<course_lecturer> courses_leturers { get; set; }
    }
}
