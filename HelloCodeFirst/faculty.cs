using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloCodeFirst
{
    [Table("faculties")]
    public class faculty
    {
        [Key]
        public string facl_id { get; set; }       
        public string facl_name { get; set; }   
        public string university { get; set; }      
        public string state { get; set; }     
        public string country { get; set; }
        public virtual ICollection<course> course { get; set; }
    }
}
