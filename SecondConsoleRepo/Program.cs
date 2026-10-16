using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleRepo
{
    internal class Program
    {
        public void Display()
        {
            List<Student> lst = new List<Student>();
            lst.Add(new Student() { RollNo = 1, StudentName = "Ajay" });
            lst.Add(new Student() { RollNo = 2, StudentName = "Amit" });
            lst.Add(new Student() { RollNo = 3, StudentName = "Anil" });
            lst.Add(new Student() { RollNo = 4, StudentName = "Divya" });
            lst.Add(new Student() { RollNo = 5, StudentName = "Jaya" });
            foreach(var s in lst)
            {
                Console.WriteLine($"{s.RollNo} {s.StudentName}");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Display();
        }
    }
}
