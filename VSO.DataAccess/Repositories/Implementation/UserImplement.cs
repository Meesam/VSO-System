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
    public class UserImplement : IUser
    {
        private readonly VsoDbConetxt _context;

        public UserImplement(VsoDbConetxt context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(c => c.Id == id);
                if (user != null)
                {
                    _context.Users.Remove(user);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User GetUserById(int id)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(c => c.Id == id);
                if (user == null)
                {
                    return null;
                }
                else { return user; }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                var userData = _context.Users.FirstOrDefault(c => c.Id == user.Id);
                if (user != null)
                {
                    _context.Users.Update(user);
                    Save();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<IQueryable<User>> GetAllUser()
        {
            try
            {
                return Task.FromResult(_context.Users.AsQueryable());
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
