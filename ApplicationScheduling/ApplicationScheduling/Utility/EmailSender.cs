using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationScheduling.Utility
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailjetClient client = new MailjetClient("31a022b1b305379bf8c25dbc252e8d93", "df12a853cef420ecde3b74eabf5be62a")
            {
                
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
            .Property(Send.FromEmail, "philani.software.dev@gmail.com")
            .Property(Send.FromName, "Appointment Schedular")
            .Property(Send.Subject, subject)
            .Property(Send.HtmlPart, htmlMessage)
            .Property(Send.Recipients, new JArray
            {
                new JObject
                {
                    {"Email", email }
                }
            });
            MailjetResponse response = await client.PostAsync(request);
        }
    }
}
