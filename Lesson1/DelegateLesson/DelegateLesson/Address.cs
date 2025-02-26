using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    //1הצהרה 
   public delegate void changeAddress();
    public class Address
    {
        //2 מופע
       public changeAddress onChangeAddress;

        private string city;

        public string City
        {
            get { return city; }
            set { city = value;
                //3 זימון
                if(onChangeAddress != null )
                onChangeAddress();
            }
        }


        public int NumHouse { get; set; }
        public string Street { get; set; }     
    }
}
