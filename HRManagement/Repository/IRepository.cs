using HRManagement.Entities;

namespace HRManagement.Repository
{
    public interface IRepository
    {
        void Add(Employee employee);
        void Delete(Employee employee);
        IEnumerable<Employee> GetAllData();
        Employee GetById(int id);
        void Save();
    }
}