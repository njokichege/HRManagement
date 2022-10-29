using HRManagement.Repository;
using HRManagement.Data;
using HRManagement.Entities;

namespace HRManagement
{
    class Program
    {
        static void Main(string[] arrgs)
        {
            string csv = @"C:\Users\v-menjok\source\repos\EmployeeHierarchy\EmployeeHierarchy\EmployeeData.csv";
            var repo = new Employee(csv);
            SqlRepository sqlRepository = new SqlRepository(new HRAppDbContext());
            DisplayEmployees(sqlRepository);
        }
        private static void DisplayEmployees(SqlRepository employeeRepository)
        {
            var items = employeeRepository.GetValues();
            foreach (var item in items)
            {
                Console.WriteLine($"Employee Id: {item.Id}");
                Console.WriteLine($"Employee First Name: {item.FirstName}");
                Console.WriteLine($"Employee Last Name: {item.LastName}");
                Console.WriteLine($"Employee Age: {item.Age}");
                Console.WriteLine($"Employee Designation: {item.Designation}");
                Console.WriteLine($"Employee Department: {item.Department}");
                Console.WriteLine($"Employee Salary: {item.Salary}\n");
            }
        }
    }
}



