// Assignment 1: Employee Wage Calculator
//
// Author: Jesse Foster
// October 5, 2019
//
// Purpose: Calculating an employee's net pay after deductions.
//
// Description: This application will request an employee's information including name, hours worked, deduction percentage, and hourly rate
// and then will calculate and display their gross pay, deductions taken, and net pay after deductions. This will also display data input by
// user including employee name, hours worked, and hourly rate.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeName; // user enters employee name here
            float hoursWorked;   // user inputs hours worked here
            float hourlyRate;    // user inputs hourly rate   
            float grossPay;      // gross pay will be calculated from hours worked * hourly and displayed
            float netPay;        // net pay will be calculated from gross pay - deductions
            int deductionRate;   // user enters deduction rate here
            float deductions;    // deductions will be calculated by gross pay * entered deduction rate percentage (converted to a floating decimal point and divided by 100)   

            // employee name is input here

            Console.Write("Please enter employee name: ");
            employeeName = Console.ReadLine();

            // user inputs data needed to calculate gross pay, deductions, and net pay

            Console.Write("Please enter hours worked this week. Decimal values are allowed here: ");
            hoursWorked = float.Parse(Console.ReadLine());

            Console.Write("Please enter hourly rate. Decimal values are allowed here: ");
            hourlyRate = float.Parse(Console.ReadLine());

            Console.Write("Please enter deduction rate. Whole percentages only: ");
            deductionRate = int.Parse(Console.ReadLine());

            // gross pay, deductions and net pay are calculated here

            grossPay = hoursWorked * hourlyRate;

            deductions = grossPay * deductionRate / 100;

            netPay = grossPay - deductions;

            // all result values including employee name, hours, hourly rate, deduction rate, gross pay and net pay are displayed here after calculations are run

            Console.WriteLine($"Employee Name: {employeeName}");
            Console.WriteLine($"Hours worked: {hoursWorked} hours at ${hourlyRate} per hour.");
            Console.WriteLine($"Gross Pay: ${grossPay:n2}");
            Console.WriteLine($"Deduction Rate: {deductionRate}%");
            Console.WriteLine($"Deductions: -${deductions:n2}");
            Console.WriteLine($"Net Pay: ${netPay:n2}");

        }
    }
}
