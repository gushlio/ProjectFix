using DataAccessLayer;
using DataAccessLayer.DTOs;
using Domain.Entity;

using Domain.MapperClasses;
using System.Diagnostics.Contracts;

namespace Domain.Manager
{
    public class EmployeeManager
    {
        public EmployeeDatabase employeeDatabase { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Entity.Contract> Contracts { get; set; }
        public List<int> HistoryInts { get; set; }


        public EmployeeManager()
        {
            employeeDatabase = new EmployeeDatabase();
            Employees = new List<Employee>();
            Contracts = new List<Entity.Contract>();
        }

        public void AddEmployee(string firstName, string lastName, string emailAddress, string password, string dateOfBirth, string contactInfo, string bsn, string address)
        {
            employeeDatabase.AddEmployee(firstName, lastName, emailAddress, password, dateOfBirth, contactInfo, bsn, address);
            LoadEmployees();
        }

        public void LoadEmployees()
        {
            Employees.Clear();
            employeeDatabase.LoadEmployees();
            foreach (List<string> employeeData in employeeDatabase.EmployeeData)
            {
                // Create the Contract object from the employee data
                Entity.Contract contract = new Entity.Contract(
                Convert.ToInt32(employeeData[12]), // Contract ID
                employeeData[13], // Contract Start
                employeeData[14], // End Message
                employeeData[15], // Contract End
                Convert.ToDouble(employeeData[16]), // Salary
                employeeData[17]  // Job Title
            );

                Employee employee = new Employee(
                   Convert.ToInt32(employeeData[0]),  // Employee ID
                   employeeData[1],  // First Name
                   employeeData[2],  // Last Name
                   employeeData[3],  // Email Address
                   employeeData[4],  // Password
                   employeeData[6], // Date of Birth
                   employeeData[7],  // Contact Info
                   employeeData[10], // Bsn
                   employeeData[9]  // Address
                );

                employee.Salt = employeeData[5]; 

                // Determine if the employee is logging in for the first time
                // Assuming you have some logic to determine the first login if needed

                // Add the contract to the employee
                if (string.IsNullOrEmpty(contract.EndMessage) ||
                    contract.EndMessage == "Contract isn't terminated" || contract.EndMessage == null)
                {
                    employee.SetContractHistory(GetContractHistory(employee.Id));
                    if (HistoryInts.Contains(contract.Id))
                    {
                        GetNewContract(employee.Id);
                    }
                    else
                    {
                        employee.SetContract(contract);
                    }
                }
                else
                {
                    GetNewContract(employee.Id);
                }

                // Add the employee to the list
                Employees.Add(employee);
            }
        }

        public void LoadContracts()
        {
            Contracts.Clear();
            employeeDatabase.LoadContracts();
            foreach (List<string> contractData in employeeDatabase.ContractData)
            {
                Entity.Contract contract = new Entity.Contract(Convert.ToInt32(contractData[0]), contractData[1], contractData[2], contractData[3], Convert.ToDouble(contractData[16]), contractData[5]);
                Contracts.Add(contract);

            }
        }

        public void DeleteEmployee(Employee employee)
        {
            employeeDatabase.DeleteEmployee(employee.Id);
            LoadEmployees();
        }

        public void AddContract(int employeeId, string ContractStart, string EndMessage, string ContractEnd, double Salary, string JobTitle)
        {
            employeeDatabase.AddContract( employeeId,  ContractStart,  EndMessage,  ContractEnd,  Salary,  JobTitle);
            LoadEmployees();
        }
        public void GetNewContract(int id)
        {
            employeeDatabase.GetNewContract(id);

        }

        public List<string> GetEmployeesInfo()
        {
            LoadEmployees();
            List<string> infos = new List<string>();
            foreach (Employee employee in Employees)
            {
                infos.Add(employee.Info);
            }
            return infos;
        }

        public Employee GetEmployeeByInfo(string employeeInfo)
        {
            LoadEmployees();
            foreach (Employee employee in Employees)
            {
                if (employee.Info == employeeInfo)
                {
                    return employee;

                }
            }
            return null;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            LoadEmployees();
            foreach (Employee employee in Employees)
            {
                if (employee.Id == employeeId)
                {
                    return employee;

                }
            }
            return null;
        }

        public void UpdateContract(int contractId, string ContractStart, string EndMessage, string ContractEnd, double Salary, string JobTitle)
        {
            employeeDatabase.UpdateContract(contractId, JobTitle, ContractStart, ContractEnd, EndMessage, Salary);
            LoadEmployees();
        }

        public List<Entity.Contract> GetContractHistory(int employeeId)
        {
            LoadContracts();
            List<Entity.Contract> list = new List<Entity.Contract>();
            string historyString = employeeDatabase.GetContractHistory(employeeId);
            string[] historyArray = historyString.Split(",");
            HistoryInts = new List<int>();
            foreach (string str in historyArray)
            {
                if (int.TryParse(str, out int number))
                {
                    // Add the integer to the list
                    HistoryInts.Add(number);
                    foreach (Entity.Contract contract in Contracts)
                    {
                        if (contract.Id == number)
                        {
                            list.Add(contract);
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid number: {str}");
                }
            }
            return list;
        }

        public void AddContractToHistory(int employeeId, int contractId)
        {

            string historyString = employeeDatabase.GetContractHistory(employeeId);
            historyString += "," + contractId.ToString();
            employeeDatabase.UpdateContractHistory(employeeId, historyString);
            LoadContracts();
            LoadEmployees();
        }
        public List<string> SearchEmployee(string name, string jobPosition, string location)
        {
            List<string> searchedEmployees = new List<string>();
            if (name != "" && jobPosition != "" && location != "")
            {
                foreach (Employee employee in Employees)
                {
                    if (employee.FirstName.ToString() == name && employee.Contract.JobTitle == jobPosition && employee.Location.Name == location)
                    {
                        searchedEmployees.Add(employee.Info);
                    }
                }
                return searchedEmployees;
            }
            else if (name != "" && jobPosition != "" && location == "")
            {
                foreach (Employee employee in Employees)
                {
                    if (employee.FirstName.ToString() == name && employee.Contract.JobTitle == jobPosition)
                    {
                        searchedEmployees.Add(employee.Info);
                    }
                }
                return searchedEmployees;
            }
            else if (name != "" && jobPosition == "" && location != "")
            {
                foreach (Employee employee in Employees)
                {
                    if (employee.FirstName.ToString() == name && employee.Location.Name == location)
                    {
                        searchedEmployees.Add(employee.Info);
                    }
                }
                return searchedEmployees;
            }
            else if (name == "" && jobPosition != "" && location != "")
            {
                foreach (Employee employee in Employees)
                {
                    if (employee.Contract.JobTitle == jobPosition && employee.Location.Name == location)
                    {
                        searchedEmployees.Add(employee.Info);
                    }
                }
                return searchedEmployees;
            }
            else if (name != "" && jobPosition == "" && location == "")
            {
                foreach (Employee employee in Employees)
                {
                    if (employee.FirstName.ToString() == name)
                    {
                        searchedEmployees.Add(employee.Info);
                    }
                }
                return searchedEmployees;
            }
            else if (name == "" && jobPosition != "" && location == "")
            {
                foreach (Employee employee in Employees)
                {
                    if (employee.Contract.JobTitle == jobPosition)
                    {
                        searchedEmployees.Add(employee.Info);
                    }
                }
                return searchedEmployees;
            }
            else if (name == "" && jobPosition == "" && location != "")
            {
                foreach (Employee employee in Employees)
                {
                    if (employee.Location.Name == location)
                    {
                        searchedEmployees.Add(employee.Info);
                    }
                }
                return searchedEmployees;
            }
            else
            {
                return GetEmployeesInfo();
            }
        }

        public bool EmployeeExists(string email)
        {
            LoadEmployees();
            foreach (Employee employee in Employees)
            {
                if (employee.EmailAddress == email)
                {
                    return true;
                }
            }
            return false;
        }
        public Employee GetEmployeeByEmail(string email)
        {
            LoadEmployees();
            foreach (Employee employee in Employees)
            {
                if (email == employee.EmailAddress)
                {
                    return employee;
                }
            }
            return null;
        }

        public Employee GetEmployeeByUsername(string username)
        {

            List<DateTime> startDates = new List<DateTime>();
            List<int> employeeCounts = new List<int>();

            LoadEmployees();
            foreach (Employee employee in Employees)
            {
                if (username == employee.Username)
                {
                    return employee;
                }
            }
            return null;
        }

        public void UpdateEmployee(int Id,string firstName, string lastName, string emailAddress, string dateOfBirth, string contactInfo, string bsn, string address)
        {

            employeeDatabase.UpdateEmployeeData( Id,  firstName,  lastName,  emailAddress,  dateOfBirth,  contactInfo,  bsn,  address);
            LoadEmployees();
        }

        public void UpdatePassword(int id, string password, string salt)
        {
            foreach (Employee em in Employees)
            {
                if (id == em.Id)
                {
                    employeeDatabase.UpdateEmployeePassword(id, password, salt);
                }
            }
        }

        public (List<DateTime>, List<int>) GetEmployeeHiringStatistics()
        {
            List<DateTime> startDates = new List<DateTime>();
            List<int> employeeCounts = new List<int>();

            // Get the list of all employees
            LoadEmployees();

            // Group employees by their contract start date and count the number of employees for each date
            var groupedEmployees = Employees.GroupBy(e => e.GetContractStartDate().Date);
            int cumulativeCount = 0;
            foreach (var group in groupedEmployees.OrderBy(g => g.Key))
            {
                startDates.Add(group.Key);
                cumulativeCount += group.Count();
                employeeCounts.Add(cumulativeCount);
            }

            return (startDates, employeeCounts);

        }
    }
}