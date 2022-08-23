using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPractice
{
    public class Employee
    {
        private int empNo;
        private string empFirstName;
        private string empLastName;
        private string dateOfHire;
        private string jobDesc;
        private string dept;
        private double salary;

         public Employee(int empNum,string Fname,string Lname,string dateofjoining,string jobdesc,string deptmnt,double sal)
        {
            empNo = empNum;
            empFirstName = Fname;  
            empLastName=Lname;  
            dateOfHire = dateofjoining; 
            jobDesc = jobdesc;
            dept=deptmnt;
            salary = sal;
        }
        public double setSalary
        {
            get { return salary; }
            set { if(salary>0)
                salary = value; }

        }
        public string setEmpFname
        {
            get { return empFirstName; }
            set { if(empFirstName!=null&& empFirstName!="") empFirstName = value; }
        }
        public string setEmpLname
        {
            get { return empLastName; }
            set { if (empLastName != null && empLastName != "") empLastName = value; }
        }

        public  string method1()
        {
            return empFirstName + " " + empLastName;
        }
        public string method2()
        {
            return empLastName + ", " + empFirstName;
        }

    }
}
