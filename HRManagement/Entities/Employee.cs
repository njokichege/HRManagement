using HRManagement.Repository;

namespace HRManagement.Entities;

public class Employee
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Age { get; set; }
    public string Designation { get; set; }
    public string Department { get; set; }
    public string Salary { get; set; }
    public Employee(string csvString)
    {
        CsvRepository csvRepository = new CsvRepository();
        csvRepository.GetAllData(csvString);
    }
    public Employee(string id, string firstName, string lastName, string age, string designation, string department, string salary)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Designation = designation;
        Department = department;
        Salary = salary;
    }
}
