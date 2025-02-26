using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class Manager
    {
        public int Id { get; set; }
        public string  Name { get; set; } 

        public Address CompanyAddress { get; set; }
        public Address myAddress { get; set; }
        //4
        public Manager()
        {
            myAddress = new Address();
            //4קישור בין הדלגייט לפונקציה 
            myAddress.onChangeAddress = func;
                
        }
        //5 כתיבת הפונקציה
        public void func()
        {
            if (!myAddress.City.Equals(CompanyAddress.City))
            {
                Console.WriteLine(  "manager must live in city's company");
            }

        }

    }
}
