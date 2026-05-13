using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details1
{
    public class Employee
    {
        public static string CompanyName = "TCS";
        public int Eid;
        public string EmpName;
        public double Salary;

        public void AcceptEmployeeDetails()
        {
            Console.WriteLine("Enter Employee ID :");
            Eid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name :");
            EmpName=Console.ReadLine();
            Console.WriteLine("Enter Employee Salary :");
            Salary=int.Parse(Console.ReadLine());
        }
        public static void displayCompany()
        {
            Console.WriteLine("Company name is :" + CompanyName);
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine(" Employee ID is :"+Eid);
            Console.WriteLine(" Employee Name is :"+EmpName);
            Console.WriteLine(" Employee Salary is :"+Salary);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] e = new Employee[5];
            for(int i = 0; i < e.Length; i++)
            {
                e[i]=new Employee();
                e[i].AcceptEmployeeDetails();
            }
            for(int j=0; j < e.Length; j++)
            {
                Employee.displayCompany();
                e[j].DisplayEmployeeDetails();
            }
        }
    }
}
