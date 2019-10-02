using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;

namespace SOLID.SRP.BadCode
{
    class UserService
    {
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);

            SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
        }

        private void SendEmail(MailMessage mailMessage)
        {
            throw new NotImplementedException();
        }

        private bool ValidateEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}