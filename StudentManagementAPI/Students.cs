using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementAPI
{
     public class Students : IStudents
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Department { get; set; }
        public virtual decimal DegreeFee { get; set; }
       
    }
}
