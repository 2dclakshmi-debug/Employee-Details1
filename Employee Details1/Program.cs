using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details1
{
    public class Employee
    {
        //    public static string CompanyName = "TCS";
        //    public int Eid;
        //    public string EmpName;
        //    public double Salary;

        //    public void AcceptEmployeeDetails()
        //    {
        //        Console.WriteLine("Enter Employee ID :");
        //        Eid=int.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter Employee Name :");
        //        EmpName=Console.ReadLine();
        //        Console.WriteLine("Enter Employee Salary :");
        //        Salary=int.Parse(Console.ReadLine());
        //    }
        //    public static void displayCompany()
        //    {
        //        Console.WriteLine("Company name is :" + CompanyName);
        //    }
        //    public void DisplayEmployeeDetails()
        //    {
        //        Console.WriteLine(" Employee ID is :"+Eid);
        //        Console.WriteLine(" Employee Name is :"+EmpName);
        //        Console.WriteLine(" Employee Salary is :"+Salary);
        //    }
        }


       



    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee[] e = new Employee[5];
            //for(int i = 0; i < e.Length; i++)
            //{
            //    e[i]=new Employee();
            //    e[i].AcceptEmployeeDetails();
            //}
            //for(int j=0; j < e.Length; j++)
            //{
            //    Employee.displayCompany();
            //    e[j].DisplayEmployeeDetails();
            //}

            int[] eid = new int[2];
            string[] ename = new string[2];
            double[] Salary = new double[2];
            for(int i=0; i<eid.Length; i++)
            {
                Console.WriteLine("Enter employee id :");
                eid[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name :");
                ename[i] = Console.ReadLine();
                Console.WriteLine("Enter employee salary :");
                Salary[i] = int.Parse(Console.ReadLine());
            }
            for(int j=0;j<eid.Length;j++)
            {
                Console.WriteLine("Employee id is : {0}" , eid[j]);
                Console.WriteLine("Employee name is : {0}" , ename[j]);
                Console.WriteLine("Employee salary is : {0}" , Salary[j]);
            }
        }
    }
}
