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
    public class course
    {
        [Key]
        public string course_id { get; set; }   
        public string course_name { get; set; }     
        public string type { get; set; }       
        public string facl_id { get; set; }     
        public Nullable<int> size { get; set; }     
        public Nullable<decimal> marks { get; set; }    
        public Nullable<int> quantity { get; set; }      
        public Nullable<System.DateTime> begin_date { get; set; }  
        public short contract { get; set; }
        public virtual faculty faculty { get; set; }
    } 
}
