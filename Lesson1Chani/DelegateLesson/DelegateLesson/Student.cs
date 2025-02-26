using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class Student
    {

        public int Id { get; set; }
        public string  Name { get; set; }
        public  Address myAddress{ get; set; }
        public Student()
        {
            myAddress=new Address();
            myAddress.onChangeAddress = func2;
        }

        public void func2() {

            Console.WriteLine("wellcome ....");
        }
    }
}
