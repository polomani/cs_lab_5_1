using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloCodeFirst
{
     [Table("email")]  
    public class email  
     {      
         [Key]   
         public int em_Id { get; set; }     
         public string em_value { get; set; }
        public string lc_id { get; set; }
        // even email have 1 field for foreign key from lecturer,  virtual allow for it to be overridden in a derived class   
         public virtual lecturer lecturer { get; set; }    
     }
 
}
