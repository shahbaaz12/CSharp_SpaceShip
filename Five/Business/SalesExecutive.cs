using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Business
{
    public class SalesExecutive : Employee
    {
        private int incentive;


        public SalesExecutive( string Fname, int Sal, int incentive)
            : base(Fname,Sal)
        {
            this.incentive = incentive;
        }
        public int Sales { get; set; } = 10;
        
        public override int MonthlySalary()
        {
            int bonus;
            int sal = base.MonthlySalary();
            if (Sales > 10)
            {
                bonus = (Sales - 10) * incentive;
            }
            else
            {
                bonus = 0;
            }

            sal += bonus;
            return sal;
            
        }
    }
}
