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
        public static EmployeeDTO MapToDTO(Employee employee)
        {
            if (employee == null)
                return null;

            return new EmployeeDTO
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                EmailAddress = employee.EmailAddress,
                Password = employee.Password,
                Birthday = employee.Birthday,
                ContactInfo = employee.ContactInfo
            };
        }

        public static Employee MapToEntity(EmployeeDTO employeeDTO)
        {
            if (employeeDTO == null)
                return null;

            return new Employee(employeeDTO.Id, employeeDTO.FirstName, employeeDTO.LastName,
                                employeeDTO.EmailAddress, employeeDTO.Password, employeeDTO.Birthday,
                                employeeDTO.ContactInfo);
        }
    }
}
