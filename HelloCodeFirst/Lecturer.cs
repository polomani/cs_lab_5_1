using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations;

namespace HelloCodeFirst
{
    public class lecturer
    {
        [Key]
        public string lc_id { get; set; }
        public string lc_fname { get; set; }
        public string lc_lname { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        // field foreign key in email: 1 lecturer may have N emails     
        public virtual ICollection<email> emails { get; set; }
        public virtual ICollection<course_lecturer> course_lecturers
        {
            get;
            set;
        }

    }
}
