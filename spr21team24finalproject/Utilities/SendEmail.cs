using Microsoft.AspNetCore.Identity;
using spr21team24finalproject.DAL;
using spr21team24finalproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace spr21team24finalproject.Utilities
{
    public static class SendEmail
    {
        public static void SendMessage(String toEmailAddress, String emailSubject, String emailBody)
        {
            //Create an email client to send the emails
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                //This is the SENDING email address and password
                Credentials = new NetworkCredential("sp21team24@gmail.com", "Team24!<3"),
                EnableSsl = true
            };


            //Add anything that you need to the body of the message
            // /n is a new line – this will add some white space after the main body of the message
            String finalMessage = emailBody + "\n\n Love, Team 24 333K :)";
            //client.UseDefaultCredentials = false;


            //Create an email address object for the sender address
            MailAddress senderEmail = new MailAddress("sp21team24@gmail.com", "Bevo's Tunes");
            MailMessage mm = new MailMessage();
            mm.Subject = "Team 24 - " + emailSubject;
            mm.Sender = senderEmail;
            mm.From = senderEmail;
            mm.To.Add(new MailAddress(toEmailAddress));
            mm.Body = finalMessage;
            client.Send(mm);
        }
       
           

    }
}
