using System;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;

namespace EmailClientGUI
{
    class MailSender
    {
        Base64Translator translator = new Base64Translator();
        public static void SendMail(Message message)
        {
            var userID = MailService.GetUserID();
            var service = Connection.GetGmailService();
            service.Users.Messages.Send(message, userID).Execute();
        }

        public static Message MessageConstructor(string to, string subject, string body)
        {
            string plainText = String.Format("To: {0}\r\n" +
                "Subject: {1}\r\n" +
                "Content-Type: text/html; charset=us-ascii\r\n\r\n" +
                "<h1>{2} </h1>", to, subject, body);
            var newMessage = new Google.Apis.Gmail.v1.Data.Message
            {
                Raw = Base64Translator.Base64UrlEncode(plainText.ToString())
            };
            return newMessage;
        }
    }
}
