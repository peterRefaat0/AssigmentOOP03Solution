using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP03.Inerface
{
    class MyType : IMyType
    {
       

        public int Age { get; set; }

        public void Myfunction()
        {
            throw new NotImplementedException();
        }

        public void MyTupe() 
        {


            Console.WriteLine("Hallo");


        }

    }
}
