﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        public Employee GetEmployee(int Id);
        public List<Employee> GetAllEmployee();
    }
}
