using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Mailer
    {
        protected static readonly string senderEmail = "martiko0098@gmail.com";
        protected static readonly string password = "12012001";

        public static void SendMail(Reservations reservations)
        {
            try
            {
                List<string> mailContent = GenerateMail(reservations);

                MailMessage message = new MailMessage(senderEmail, reservations.Email, mailContent[0], mailContent[1]);
                message.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential(senderEmail, password);
                client.Send(message);

            }

            catch (Exception)
            {

            }
        }

        private static List<string> GenerateMail(Reservations reservations)
        {
            List<string> output = new List<string>();

            string subject = "About your reservation";
            output.Add(subject);

            string body = $"Hello {reservations.Name} {reservations.Lastname}!" + Environment.NewLine;
            body += $"Your reservation for the flight has been booked successfully.";
            output.Add(body);
            return output;
        }

        public static void SendMail(ApplicationUser user)
        {
            try
            {
                List<string> mailContent = GenerateMail(user);

                MailMessage message = new MailMessage(senderEmail, user.Email, mailContent[0], mailContent[1]);
                message.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential(senderEmail, password);
                client.Send(message);

            }

            catch (Exception)
            {

            }
        }

        private static List<string> GenerateMail(ApplicationUser user)
        {
            List<string> output = new List<string>();

            string subject = "Successful registration";
            output.Add(subject);

            string body = $"Hello {user.FirstName} {user.LastName}!" + Environment.NewLine;
            body += $"You have successfully registered into AirportManager.";
            output.Add(body);
            return output;
        }
    }
}
