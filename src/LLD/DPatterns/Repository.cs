using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.LLD.DPatterns
{
    public class Repository
    {
        public static void NotMain(string[] args)
        {
            EmployeeRepository _employeeRepository = new EmployeeRepository();
            _employeeRepository.Add(new Employee() { EmpId = 1, EmpName = "A", Salary = 1000 });
            _employeeRepository.Add(new Employee() { EmpId = 2, EmpName = "B", Salary = 2000 });
            _employeeRepository.Add(new Employee() { EmpId = 3, EmpName = "C", Salary = 3000 });
            _employeeRepository.Remove(_employeeRepository.GetById(1)); 
            var employees = _employeeRepository.GetAll();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.EmpId} - {employee.EmpName} - {employee.Salary}");
            }

        }
    }
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
    }

    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Remove(T entity);
    }

    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly List<Employee> _employees = new List<Employee>();
        public IEnumerable<Employee> GetAll() => _employees;
        public Employee GetById(int id) => _employees.FirstOrDefault(_ => _.EmpId == id);
        public void Add(Employee employee) => _employees.Add(employee);
        public void Remove(Employee employee) => _employees.Remove(employee);
    }
}
