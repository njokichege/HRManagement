using HRManagement.Data;
using HRManagement.Entities;
using Microsoft.VisualBasic.FileIO;

namespace HRManagement.Repository
{
    public class CsvRepository
    {
        public SqlRepository SqlRepository = new SqlRepository(new HRAppDbContext());
        public void GetAllData(string csvString)
        {
            TextFieldParser textFieldParser = new TextFieldParser(csvString);
            textFieldParser.TextFieldType = FieldType.Delimited;
            textFieldParser.SetDelimiters(new string[] { "," });
            textFieldParser.HasFieldsEnclosedInQuotes = true;
            string[] colFields;
            string id, firstName, lastName, age, designation, department, salary;
            while (!textFieldParser.EndOfData)
            {
                colFields = textFieldParser.ReadFields();
                id = colFields[0];
                firstName = colFields[1];
                lastName = colFields[2];
                age = colFields[3];
                designation = colFields[4];
                department = colFields[5];
                salary = colFields[6];
                Employee employee = new Employee(id, firstName, lastName, age, designation, department, salary);
                SqlRepository.Add(employee);
                SqlRepository.Save();
            }
        }
    }
}
