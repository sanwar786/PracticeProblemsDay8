using PracticeProblemsDay8.LineComparison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsDay8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmpPresentUC1.FindEmpPresent();
            //EmpWageUC2.FindEmpWage();
            //PartTimeWageUC3.FindPartTimeWage();
            //EmpWageSwitchUC4.FindEmpWageSwitch();
            //EmpWageMonthUC5.FindEmpWageForMonth();
            //WageNumofDayUC6.FindWageofWorkingDays();
            //ComputeEmpWageUC7.ComputeEmpWage();

            CalculateLengthUC1 length = new CalculateLengthUC1();
            length.CalLength(2, 4, 6, 8);

            CompareLineUC2.CompareLine();
            CompareUC3.Compare();

            Console.ReadLine();
        }
    }
}
