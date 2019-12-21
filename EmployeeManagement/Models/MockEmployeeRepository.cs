using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary Sue", Email = "MS@email.com", Department = "HR" },
                new Employee() { Id = 1, Name = "Bob Green", Email = "BG@email.com", Department = "IT" },
                new Employee() { Id = 1, Name = "Tom Cat", Email = "TC@email.com", Department = "OTHER" },
            };
        }

        public List<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
