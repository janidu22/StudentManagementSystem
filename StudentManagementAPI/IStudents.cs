using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementAPI
{
    public interface IStudents
    {
        int id { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        decimal DegreeFee { get; set; }

    }
}
