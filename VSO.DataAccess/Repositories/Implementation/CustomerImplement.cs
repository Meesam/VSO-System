using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSO.DataAccess.Data;
using VSO.DataAccess.Repositories.Interfaces;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Repositories.Implementation
{
    public class CustomerImplement : ICustomer
    {
        private readonly VsoDbConetxt _context;

        public CustomerImplement(VsoDbConetxt context)
        {
            _context = context;
        }

        public void AddCustomer(Customer customer)
        {
            try
            {
                _context.Customers.Add(customer);
                Save();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error on server is {ex.ToString()}");
            }
            
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
