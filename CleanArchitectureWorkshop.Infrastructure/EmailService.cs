using CleanArchitectureWorkshop.Application.Contracts.Infrastructure;
using CleanArchitectureWorkshop.Application.Models.Mail;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Infrastructure
{
    public class EmailService : IEmailService
    {
        public EmailSettings _emailSettings { get; }

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public Task<bool> SendEmail(Email email)
        {
            throw new NotImplementedException();
        }
    }
}
