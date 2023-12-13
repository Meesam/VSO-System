using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VSO.DataAccess.Data;
using VSO.DataAccess.Repositories.Interfaces;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Repositories.Implementation
{
    public class EmailAddressesImplement : IEmailAddresses
    {

        private readonly VsoDbConetxt _context;

        public EmailAddressesImplement(VsoDbConetxt context)
        {
            _context = context;
        }
        public void AddEmail(EmailAddress emailAddress)
        {
            try
            {
                _context.EmailAddresses.Add(emailAddress);
                Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteEmail(int id)
        {
            try
            {
                var emailAddress = _context.EmailAddresses.FirstOrDefault(c => c.Id == id);
                if (emailAddress != null)
                {
                    _context.EmailAddresses.Remove(emailAddress);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EmailAddress GetEmailById(int id)
        {
            try
            {
                var emailAddress = _context.EmailAddresses.FirstOrDefault(c => c.Id == id);
                if (emailAddress == null)
                {
                    return null;
                }
                else { return emailAddress; }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateEmail(EmailAddress emailAddress)
        {
            try
            {
                var emailAddressData = _context.EmailAddresses.FirstOrDefault(c => c.Id == emailAddress.Id);
                if (emailAddressData != null)
                {
                    _context.EmailAddresses.Update(emailAddress);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<IQueryable<EmailAddress>> GetAllEmails(int id, string emailType)
        {
            try
            {
                return Task.FromResult(_context.EmailAddresses.AsQueryable());
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
