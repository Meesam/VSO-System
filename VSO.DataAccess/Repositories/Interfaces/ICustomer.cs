using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Repositories.Interfaces
{
    public interface ICustomer
    {
        public void AddCustomer(Customer customer);

        public void UpdateCustomer(Customer customer);

        public void DeleteCustomer(int id);

        public Task<IQueryable<Customer>> GetAllCustomer();

        public Customer GetCustomerById(int id);

        public void Save();

    }
}
