using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contoso1.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
        /**
         * alternative to shortened getter/setter
         * 
         * private string LastName
         * 
         * public string LastName
         * {
         *      get { return LastName;}
         *      set { LastName = value;} // where value is whatever argument is passed in
         * }
         */
    }
}