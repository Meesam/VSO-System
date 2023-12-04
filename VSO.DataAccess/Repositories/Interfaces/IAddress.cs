using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Repositories.Interfaces
{
    public interface IAddress
    {
        public void AddAddress(Address address);

        public void UpdateAddress(Address address);

        public void DeleteAddress(int id);

        public List<Address> GetAllAddress(int id, string addressType);

        public Address GetAddressById(int id);
    }
}
