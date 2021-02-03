using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Created by Jacob McNeilly
//This application is going to accept user input for Name, Hourly Rate, and Number of Hours Worked
//It will then calculate and display in a well fomrated way the following:
//user input, gross pay, federal withholding based on tax rate of 15%
//State withholding based on the tax rate of 5%
namespace Payroll
{
    class Payroll
    {
        static void Main(string[] args)
        {
            //Declare variables
            //Declare appropriate variable for accepting user input
            string Name;
            double hourlyRate;
            int hoursWorked;
            //Declare Named Constant for tax rates
            const double FED_TAX_RATE = 0.15;
            const double STATE_TAX_RATE = 0.05;
            //Declare variable that will hold calculated output
            double grossPay;
            double fedWithholding, statewithholding;
            double netPay;

            //Getting input 
            //Prompt the user to enter Name:
            Console.Write("Enter Employee Name: ");
            //Save user input to Name variable
            Name = Console.ReadLine();
            //Prompt the user to enter hourly rate
            Console.Write("Enter Hourly Rate: ");
            //Save user input to hourlyRate variable
            hourlyRate = Convert.ToDouble(Console.ReadLine());
            //Prompt the user to enter hours worked
            Console.Write("Enter Hours Worked: ");
            //Save user input to hourlyWorked variable
            hoursWorked = Convert.ToInt32(Console.ReadLine());

            //Process: do the calculations
            //Calculate GrossPay
            grossPay = hoursWorked * hourlyRate;
            //Calculate federal withholding
            fedWithholding = grossPay * FED_TAX_RATE;
            //calcualte state withholding
            statewithholding = grossPay * STATE_TAX_RATE;
            //calculate the net pay
            netPay = grossPay - fedWithholding - statewithholding;

            //Output: Display the result in a well formatted way
            //add some blank lines between input and output
            Console.WriteLine("\n\nPayroll Summary for: {0}", Name);
            //Display hourly rate and hours worked
            Console.WriteLine("{0} worked {1} hours at {2} per hour", Name, hoursWorked, hourlyRate.ToString("C"));
            //Dispaly gross pay with the numbers being right aligned
            Console.WriteLine("Gross Pay:\t\t{0,8}", grossPay.ToString("C"));
            //Display federal withholding in a similar format
            Console.WriteLine("\nFederal withholding: \t{0,8}", fedWithholding.ToString("C"));
            //Display state withholding
            Console.WriteLine("\nState withholding:\t{0,8}", statewithholding.ToString("C"));
            //Display net pay with a seperator
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Net pay:\t\t{0,8}", netPay.ToString("C"));

            Console.ReadKey();
        }
    }
}
