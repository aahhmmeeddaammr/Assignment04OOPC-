using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOPC_.IClonable
{
    class Department : ICloneable
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Department()
        {

        }
        public object Clone()
        {
            return new Department(this);

        }
        public Department(Department department)
        {
            this.Name = department.Name;
            this.Id = department.Id;
        }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} ";
        }


    }
    internal class Employee : ICloneable, IComparable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public Department Department { get; set; }

        public object Clone()
        {
            return new Employee(this);

        }
        public Employee(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Salary = employee.Salary;
            this.Department = (Department)employee.Department.Clone();
        }

        public Employee()
        {
        }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary} , Department : {Department}";
        }

        public int CompareTo(object? obj)
        {
            Employee employee = (Employee)obj;
            return this.Salary.CompareTo(employee.Salary);
        }


    }
}
