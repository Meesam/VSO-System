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
    public class AddressImplement : IAddress
    {

        private readonly VsoDbConetxt _context;

        public AddressImplement(VsoDbConetxt context)
        {
            _context = context;
        }
        public void AddAddress(Address address)
        {
            try
            {
                _context.Address.Add(address);
                Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteAddress(int id)
        {
            try
            {
                var address = _context.Address.FirstOrDefault(c => c.Id == id);
                if (address != null)
                {
                    _context.Address.Remove(address);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Address GetAddressById(int id)
        {
            try
            {
                var address = _context.Address.FirstOrDefault(c => c.Id == id);
                if (address == null)
                {
                    return null;
                }
                else { return address; }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateAddress(Address address)
        {
            try
            {
                var addressData = _context.Address.FirstOrDefault(c => c.Id == address.Id);
                if (addressData != null)
                {
                    _context.Address.Update(address);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<IQueryable<Address>> GetAllAddress(int id, string addressType)
        {
            try
            {
                return Task.FromResult(_context.Address.AsQueryable());
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
