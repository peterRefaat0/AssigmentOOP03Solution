using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP03.Inerface
{
     interface IMyType
    {

        // signature for property
        public int Age { get; set; }



        // signature for method
        public void Myfunction();


     


        // Default implemented method 

        public void print()
        {

            Console.WriteLine("Default");

        }



    }


    
    




}
