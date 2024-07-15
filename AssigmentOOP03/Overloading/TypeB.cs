using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP03.Overloading
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A , int _B ) : base(_A)
        {
            B = _B; 
        }

        // Apply Function overriding using new keyword
        // static binded method
        //compiler bind function call based on refrence not object
        // compilation time [early binding]
        public new void Myfunction()
        {

            Console.WriteLine("I am child");

        }


          // Apply Function overriding using overriding keyword
         // but the function wii be overriding using override keyword
        //public virtual
       //dynamic binded method
       //compiler bind function call based on object not refrence
        // at Runtime [late binding]
        public override void Myfunction2()
        {
            Console.WriteLine($"TypeB : B {B}");
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
