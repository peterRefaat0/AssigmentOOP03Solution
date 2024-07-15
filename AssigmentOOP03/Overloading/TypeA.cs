using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP03.Overloading
{
    public class TypeA
    {

        public int A { get; set; }

        public TypeA(int _a)
        {
            
            A = _a;
        }

        public void Myfunction()
            {

            Console.WriteLine("I am Base");

             }

        public virtual void  Myfunction2()
        {
            Console.WriteLine($"TypeA : A {A}");
        }


    }




}
