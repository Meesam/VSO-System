using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Repositories.Interfaces
{
    public interface IEmailAddresses
    {
        public void AddEmail(EmailAddress emailAddress);

        public void UpdateEmail(EmailAddress emailAddress);

        public void DeleteEmail(int id);

        public List<EmailAddress> GetAllEmails(int id,string emailType);

        public EmailAddress GetEmailById(int id);
    }
}
