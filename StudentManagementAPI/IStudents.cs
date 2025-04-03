using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementAPI
{
    public interface IStudents
    {
        int Id { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }

        string Department { get; set; }
        decimal DegreeFee { get; set; }

    }
}
