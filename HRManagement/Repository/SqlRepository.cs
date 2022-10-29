using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HRManagement.Data;
using HRManagement.Entities;

namespace HRManagement.Repository
{
    public class SqlRepository : IRepository
    {
        private readonly DbContext context;
        private readonly DbSet<Employee> dbset;
        public SqlRepository(DbContext context)
        {
            this.context = context;
            dbset = context.Set<Employee>();
        }
        public void Add(Employee employee)
        {
            dbset.Add(employee);
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public Employee GetById(int id)
        {
            return dbset.Find(id);
        }
        public void Delete(Employee employee)
        {
            dbset.Remove(employee);
        }
        public IEnumerable<Employee> GetAllData()
        {
            return dbset.OrderBy(employee => employee.Id).ToList();
        }
    }
}
