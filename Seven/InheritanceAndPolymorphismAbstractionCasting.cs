using Five.Abstract;
using Five.Abstract.Variety;
using Five.Business;
using Five.Casting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven
{
    class InheritanceAndPolymorphismAbstractionCasting
    {
        static void Main(string[] args)
        {
            Employee Jack = new Employee();
            Jack.SetFullName("Jack Jackson");
            Jack.SetSalary(300000);
            //Employee Jack = new Employee("Jack Jackson", 300000);

            //inherited classes
            ITExecutives Jill = new ITExecutives();
            Jill.SetFullName("Jill White");
            Jill.SetSalary(400000);

            // SalesExecutive John = new SalesExecutive(); 
            //wont work since no parameterless ctor exists

            SalesExecutive John = new SalesExecutive("John Parker", 300000, 120);
            John.Sales = 20;

            EmployeeInfo(Jack);
            EmployeeInfo(Jill);
            EmployeeInfo(John);

            ///////////////////////////

            //LivingBeing x = new LivingBeing();

            Humans human = new Humans();
            Cow cow = new Cow();
            Cat cat = new Cat();
            French frman = new French();
            Spanish spman = new Spanish();

            List<LivingBeing> livingBeings =  new List<LivingBeing>();
            livingBeings.Add(human);
            livingBeings.Add(cat);
            livingBeings.Add(cow);
            livingBeings.Add(frman);
            livingBeings.Add(spman);

            Talk(livingBeings);
            ///////////

            //casting

            
            Car Nissan = new Car { RegNos = 122, TopSpeed = 120 };
            Car Audi = new Car { RegNos = 221, TopSpeed = 170 };
            Truck Tata = new Truck { RegNos = 1011, IsLoaded = false, NoOfTyres = 10 };
            Truck Mazda = new Truck { RegNos = 50501, IsLoaded = true, NoOfTyres = 8 };
            List<Vehicle> vehicles = new List<Vehicle>
            {
                 Nissan,
                 Audi,
                 Tata,
                 Mazda
            };
            VehicleGarrage(vehicles);
            Console.ReadKey();
        }
        private static void VehicleGarrage( List<Vehicle> vehicles)
        {
            int carCounter = 0;
            foreach (var vehicle in vehicles)
            {
                if (vehicle is Car)
                {
                    carCounter++;
                }
                else
                {                 
                    Truck truck = vehicle as Truck;
                    if (truck != null)
                    {
                        truck.LoadUnload();
                    }
                    /*alternatively
                    Truck truck = (Truck)vehicle;
                    may throw InvalidCastException
                    
                    */

                }
            }
            Console.WriteLine("No of Cars Serviced = {0}",carCounter);
        }
        private static void Talk(List<LivingBeing> LivingBeings)
        {
            foreach (var lb in LivingBeings)
            {
                Console.WriteLine("``````````````````");
                lb.Speak();
                Console.WriteLine("``````````````````");
            }
        }
        //casting
        private static void EmployeeInfo(Employee obj)
        {
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Employee Name : {0}", obj.GetFullName());
            Console.WriteLine("Employee Monthly Salary  : {0}", obj.MonthlySalary());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }
    }
}
