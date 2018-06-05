using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Business
{
    public class Employee
    {
        private string  FullName;

        private int salaryPerAnum;

        //ctor  
        public Employee()
        {

        }

        public Employee(string FName, int Sal)
        {
            FullName = FName;
            salaryPerAnum = Sal;
        }

        public int GetSalary()
        {
            return this.salaryPerAnum;
        }

        public string GetFullName()
        {
            return this.FullName;
        }

        public void SetSalary(int sal)
        {
            this.salaryPerAnum = sal;
        }

        public void SetFullName(string name)
        {
            this.FullName = name;
        }

        public  virtual int MonthlySalary()
        {
            return salaryPerAnum / 12;
        }
    }
}
