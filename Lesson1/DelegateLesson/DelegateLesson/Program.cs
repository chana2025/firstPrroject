using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m=new Manager() { CompanyAddress=new Address() { City="bnei-braq"} };
            m.myAddress.City = "tel-aviv";
            Student student = new Student() ;
            student.myAddress.City = "elad";
            Console.Read();
        }
    }
}
