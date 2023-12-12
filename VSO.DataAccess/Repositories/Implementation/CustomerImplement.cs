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
            catch (Exception)
            {
                throw;
            }
            
        }

        public void DeleteCustomer(int id)
        {
            try
            {
                var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
                if(customer != null)
                {
                    _context.Customers.Remove(customer);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<IQueryable<Customer>> GetAllCustomer()
        {
            try
            {
                return Task.FromResult(_context.Customers.AsQueryable());
            } 
            catch (Exception)
            {
                throw;
            }
            
        }

        public Customer? GetCustomerById(int id)
        {
            try
            {
                var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
                if (customer == null)
                {
                    return null;
                }
                else { return customer; }
            }
            catch (Exception) 
            {
                throw;
            }

        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                var customerData = _context.Customers.FirstOrDefault(c => c.Id == customer.Id);
                if (customer != null)
                {
                    _context.Customers.Update(customer);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
