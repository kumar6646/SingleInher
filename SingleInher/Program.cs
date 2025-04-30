using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInher
{

    /*
     * Inheritance: is nothing but deriving properties of one class to 
     * another class.
     * 
     * A class which is giving is called base class or parent or super class.
     * 
     * A class which is receiving is called as sub or derived or child
     * 
     * because of inheriance sub class can access super class
     * 
     * 
     * because of inheriance super class cannot access sub class members
     * Types of Inheritance
     * SingleInheritance
     * multilevel
     * multiple
     * hybrid
     * hierarchical
     * 
     * 
     * SingleInheritance
     * Inheriting from one class to another class 
     * 
     * 
     * 
     * multilevel inheritance:
     * Inheriting from one class to another class from that class to some other 
     * class.
     */
    class HeadOffice
    {
        string Headoffloc;
        string HeadOffPhone;
        internal HeadOffice(string Headoffloc, string HeadOffPhone)
        {
            this.Headoffloc = Headoffloc;
            this.HeadOffPhone = HeadOffPhone;
        }
        public void DisplayHeadOff()
        {
            Console.WriteLine("Head off location is {0}",Headoffloc);
            Console.WriteLine("Head off phone is {0}", HeadOffPhone);
        }
}
    class Branch:HeadOffice

    {
        int branchid;
        string bname;
        string bloc;
        internal Branch(int branchid, string bname, string bloc):
            base("Delhi","040123456")
        {
            this.branchid = branchid;
            this.bname = bname;
            this.bloc = bloc;
        }
        public void BranchDisplay()
        {
            Console.WriteLine("Branch id is {0}", branchid);
            Console.WriteLine("Branch name is {0}", bname);
            Console.WriteLine("Branch loca is {0}", bloc);
            base.DisplayHeadOff();
        }
    }
    class Employee : Branch
    {
        int empid;
        string ename;
        string edesig;
        internal Employee(int empid, string ename, string edesig) :
            base(111, "Hyderabad", "HiTech")
        {
            this.empid = empid;
            this.ename = ename;
            this.edesig = edesig;
        }
        public void EmployeeDisplay()
        {
            Console.WriteLine("Employee id is {0}", empid);
            Console.WriteLine("Employee name is {0}", ename);
            Console.WriteLine("Employee designation is {0}", edesig);
            base.BranchDisplay();
        }
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee obj = new Employee(1, "ABC", "IT");
                obj.EmployeeDisplay();
                Employee emp = new Employee(2, "XYZ", "Non IT");
                emp.EmployeeDisplay();
            }
        }
    }
}