using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Estruturais.Composite
{
    public interface IDepartmentComponent
    {
        decimal CalculateTotalSalary();
        string GetName();
    }

    public interface IDepartmentGroup : IDepartmentComponent
    {
        void Add(IDepartmentComponent component);
        void Remove(IDepartmentComponent component);
    }

    // Leaf
    public class Employee : IDepartmentComponent
    {
        public string Name { get; private set; }
        public decimal Salary { get; private set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public decimal CalculateTotalSalary()
        {
            return Salary;
        }

        public string GetName()
        {
            return Name;
        }
    }

    // Composite
    public class Department : IDepartmentGroup
    {
        private List<IDepartmentComponent> children = new List<IDepartmentComponent>();
        public string Name { get; private set; }

        public Department(string name)
        {
            Name = name;
        }

        public void Add(IDepartmentComponent component)
        {
            children.Add(component);
        }

        public void Remove(IDepartmentComponent component)
        {
            children.Remove(component);
        }

        public decimal CalculateTotalSalary()
        {
            decimal total = 0;
            foreach (var child in children)
            {
                total += child.CalculateTotalSalary();
            }
            return total;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
