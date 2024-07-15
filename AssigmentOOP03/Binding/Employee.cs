using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP03.Binding
{
    internal class Employee // container
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int? Age { get; set; }

        public void  myfunction() 
        {

            Console.WriteLine("I am Employee");
        }


        public virtual void myfunction01()
        {

            Console.WriteLine($"Id : {Id} , Name : {Name} , Age : {Age}");
        }

    }
}
