using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

//namespace Assignment_26
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee Emp = new Employee
//            {
//                Id = 1,
//                FirstName = "Ram",
//                LastName = "Mohan",
//                Salary = 50000.0
//            };
//            IFormatter formatter = new BinaryFormatter();
//            Stream stream = new FileStream(@"C:\Users\user\Desktop\Simplilearn Assignments\Day 21 Assignment 1\Assignment 26\EmployeeData.txt", FileMode.Create, FileAccess.Write);
//            formatter.Serialize(stream, Emp);
//            stream.Close();
//            stream = new FileStream(@"C:\Users\user\Desktop\Simplilearn Assignments\Day 21 Assignment 1\Assignment 26\EmployeeData.txt", FileMode.Open, FileAccess.Read);
//            Employee objnew = (Employee)formatter.Deserialize(stream);
//            Console.WriteLine(Emp.Id);
//            Console.WriteLine(Emp.FirstName);
//            Console.WriteLine(Emp.LastName);
//            Console.WriteLine(Emp.Salary);
//            Console.ReadKey();

//        }
//    }
//}
namespace Assignment_26
{
    [Serializable]
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Employees Emp = new Employees
            {
                Id = 1,
                FirstName = "Ram",
                LastName = "Mohan",
                Salary = 50000.0
            };

            // Serialize the employee object to XML
            XmlSerializer serializer = new XmlSerializer(typeof(Employees));
            using (TextWriter writer = new StreamWriter("employee.xml"))
            {
                serializer.Serialize(writer, Emp);
            }
            //Descrialize the object from XML
            Employees deserializedEmp;
            using (TextReader reader = new StreamReader("employee.xml"))
            {
                deserializedEmp = (Employees)serializer.Deserialize(reader);
            }

            // Accessing the properties of deserializedEmployee
            Console.WriteLine(deserializedEmp.Id);
            Console.WriteLine(deserializedEmp.FirstName);
            Console.WriteLine(deserializedEmp.LastName);
            Console.WriteLine(deserializedEmp.Salary);
            Console.ReadKey();
        }
    }
}