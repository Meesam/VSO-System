using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Repositories.Interfaces
{
    public interface IUser
    {
        public void AddUser(User user);

        public void UpdateUser(User user);

        public void DeleteUser(int id);

        public Task<IQueryable<User>> GetAllUser();

        public User GetUserById(int id);
    }
}
