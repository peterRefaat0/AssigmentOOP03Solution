using AssigmentOOP03.Binding;
using AssigmentOOP03.Inerface;
using AssigmentOOP03.Overloading;

namespace AssigmentOOP03
{
    internal class Program
    {

        #region Overloading
        public static int sum(int x, int y)
        { return x + y; }
        public static int sum(int x, int y, int z)
        { return x + y + z; }
        public static int sum(int x, int y, int z, int d)
        { return x + y + z + d; }
        #endregion

        public static void prcessemp(Employee employee)
        {
            if (employee != null)
            {

                employee.myfunction();
                employee.myfunction01();
            }

        }

        static void Main(string[] args)
        {
            #region Overloading
            int result = sum(1, 2, 3);
            Console.WriteLine(result);
            #endregion


            #region Binding
            TypeA typeA = new TypeA(1);

            typeA.A = 2;


            typeA.Myfunction();
            typeA.Myfunction2();

            TypeB typeB = new TypeB(1, 2);


            typeB.A = 3;
            typeB.B = 4;
            typeB.Myfunction();
            typeB.Myfunction2();

            // Binging

            // refrence from parent = object from child

            TypeA RefBase = new TypeB(1, 2);


            RefBase.A = 3;


            RefBase.Myfunction();
            RefBase.Myfunction2();

            #endregion


            #region Not Binding
            TypeA typeA1 = new TypeB(1, 2); // binding
            typeA = new TypeA(1);

            TypeB typeB1 = (TypeB)typeA; // casting [unsafe] 
            #endregion



            #region Bussniess Need of Binding
            Employee fullTime = new FullTimeEmployee()
            {
                Id = 1,
                Name = "saad",
                Age = 30,
                Salary = 3000

            };


            Employee partTime = new PartTimeEmployee()
            {
                Id = 50,
                Name = "Ahmed",
                Age = 26,
                HourRAte = 20


            };


            Employee employee = new Employee();
            FullTimeEmployee employee1 = new FullTimeEmployee();
            PartTimeEmployee employee2 = new PartTimeEmployee();
            Employee employee3 = new FullTimeEmployee();
            Employee employee4 = new PartTimeEmployee();



            prcessemp(employee3);

            #endregion

            #region Interface



            IMyType myType = new MyType();

            myType.Myfunction();

            myType.Age = 30;

            myType.print();

            
            #endregion









        }
    }
}
