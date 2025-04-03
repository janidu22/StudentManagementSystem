using StudentManagementAPI;

namespace StudentManagementSystem
{
    public enum DegreeProgramme
    {
        CyberSecuirety,
        BussinessManagement,
        Psychology,
        SoftwareEnginering
    }

    internal class Program
    {
      
        static void Main(string[] args)
        {
            decimal uniInirialEarnings = 0;
                
            List<IStudents> students = new List<IStudents>();
            SeedData(students);

            Console.WriteLine($"Initial yearly Earnings from students: ${students.Sum(std => std.DegreeFee)}");
            Console.WriteLine();
            foreach (var student in students)
            {
                Console.WriteLine($"Batch Rep of {student.Department} : {student.Firstname+ " " +student.Lastname}");
            }
          

        }

        public static void SeedData(List<IStudents> students)
        {
            IStudents softwareEngstud = StudentsFactory.GetStudentInstance(DegreeProgramme.SoftwareEnginering,1,"janidu","yapa", "SoftwareEnginering",2100M );
            students.Add(softwareEngstud);

            IStudents cyberSecuiretystud = StudentsFactory.GetStudentInstance(DegreeProgramme.CyberSecuirety,2, "sanduni", "dissanayaka", "CyberSecuirety", 2100M);

            students.Add (cyberSecuiretystud);

            IStudents BussinessManagementstud = StudentsFactory.GetStudentInstance(DegreeProgramme.BussinessManagement,3, "kaveesha", "perera", "BussinessManagement", 2100M);

            students.Add(BussinessManagementstud);

            IStudents Psychologystud = StudentsFactory.GetStudentInstance(DegreeProgramme.Psychology,4, "kasun", "thilakarathne", "Psychology", 2100M);

            students.Add(Psychologystud);
        }

    }


    public class CyberSecuirety : Students
    {
        public override decimal DegreeFee { get => base.DegreeFee+ (base.DegreeFee * 0.04m); }
    }

    public class BussinessManagement : Students
    {
        public override decimal DegreeFee { get => base.DegreeFee + (base.DegreeFee * 0.02m); }
    }


    public class Psychology : Students
    {
        public override decimal DegreeFee { get => base.DegreeFee + (base.DegreeFee * 0.03m); }
    }

    public class SoftwareEngineering : Students
    {
        public override decimal DegreeFee { get => base.DegreeFee + (base.DegreeFee * 0.06m); }
    }


    public static class StudentsFactory
    {
         public static IStudents GetStudentInstance(DegreeProgramme student,int id , string firstname, string lastname,string department, decimal degreefee)
        {
            IStudents students = null;

            switch (student)
            {
                case DegreeProgramme.CyberSecuirety:
                    students = StudentFactoryPattern<IStudents, CyberSecuirety>.GetInstance();
                    break;
                case DegreeProgramme.BussinessManagement:
                    students = StudentFactoryPattern<IStudents, BussinessManagement>.GetInstance();
                    break;
                case DegreeProgramme.Psychology:
                    students = StudentFactoryPattern<IStudents, Psychology>.GetInstance();
                    break;
                case DegreeProgramme.SoftwareEnginering:
                    students = StudentFactoryPattern<IStudents, SoftwareEngineering>.GetInstance();
                    break;
            }

            if (students != null)
            {
                students.Id = id;
                students.Firstname = firstname;
                students.Lastname = lastname;  
                students.Department = department;
                students.DegreeFee = degreefee;
            }
            else
            {
                throw new NullReferenceException();
            }
            return students;
        }
    }


}
