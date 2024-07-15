using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP03.Binding
{
    internal class PartTimeEmployee : Employee
    {

        public decimal HourRAte { get; set; }
        public new void myfunction()
        {

            Console.WriteLine("I am partTime Employee");
        }

        public override void myfunction01()
        {
            Console.WriteLine($"Id : {Id} , Name : {Name} , Age : {Age} , HourRate {HourRAte}");
         }



    }
}
