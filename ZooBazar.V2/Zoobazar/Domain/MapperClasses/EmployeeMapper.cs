using DataAccessLayer.DTOs;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MapperClasses
{
    public class EmployeeMapper
    {
        public static Employee MapToEntity(EmployeeDTO employeeDTO)
        {
            return new Employee(
                employeeDTO.Id,
                employeeDTO.FirstName,
                employeeDTO.LastName,
                employeeDTO.EmailAddress,
                employeeDTO.Password,
                employeeDTO.Salary,
                employeeDTO.HireDate,
                employeeDTO.JobTitle
            );
        }

        public static EmployeeDTO MapToDTO(Employee employee)
        {
            return new EmployeeDTO
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                EmailAddress = employee.EmailAddress,
                Password = employee.Password,
                Salary = employee.Salary,
                HireDate = employee.HireDate,
                JobTitle = employee.JobTitle
            };
        }
    }
}
