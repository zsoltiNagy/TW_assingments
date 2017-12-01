using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmailClientGUI
{
    class MailService
    {
        static string userID = "me";

        public static string GetUserID()
        {
            return userID;
        }

        public static void PrintLabels()
        {
            var service = Connection.GetGmailService();
            // List labels.
            UsersResource.LabelsResource.ListRequest request = service.Users.Labels.List("me");
            IList<Label> labels = request.Execute().Labels;
            Console.WriteLine("Labels:");
            if (labels != null && labels.Count > 0)
            {
                foreach (var labelItem in labels)
                {
                    Console.WriteLine(labelItem.Name + " Message list visibility: " +
                        labelItem.MessageListVisibility +
                        " Messages Total: " + labelItem.MessagesTotal.HasValue
                        + "Unread: " + labelItem.MessagesUnread.HasValue);
                }
            }
            else
            {
                Console.WriteLine("No labels found.");
            }
        }

        public static IList<Message> GetMessageList()
        {
            var service = Connection.GetGmailService();
            UsersResource.MessagesResource.ListRequest messageRequest = service.Users.Messages.List("me");
            IList<Message> messages = messageRequest.Execute().Messages; //Unhandled System.Net.Http.HttpRequestException
            return messages;
        }

        public static IList<MessagePartHeader> GetMessageHeaders(UsersResource.MessagesResource.GetRequest req)
        {
            return req.Execute().Payload.Headers;
        }

        public static string GetMessageBodyHtml(UsersResource.MessagesResource.GetRequest req)
        {
            // Refactored "clever" solution
            var response = req.Execute();
            string encodedBody = null;
            if (response.Payload.Parts[1].Body.Data == null)
            {
                encodedBody = response.Payload.Body.Data;
            } else
            {
                encodedBody = response.Payload.Parts[1].Body.Data;
            }
            string result = Base64Translator.Base64UrlDecode(encodedBody);
            return result;
        }

        public static string GetMessageBodyPlain(UsersResource.MessagesResource.GetRequest req)
        {
            // The "clever" solution
            return Base64Translator.Base64UrlDecode(req.Execute().Payload.Parts[0].Body.Data);
        }

        public static string GetMessageSnippet(UsersResource.MessagesResource.GetRequest req)
        {
            return req.Execute().Snippet.Replace("&#39;", "\'");
        }

        public static List<UsersResource.MessagesResource.GetRequest> GetMessageRequestList()
        {
            List<UsersResource.MessagesResource.GetRequest> reqList = new List<UsersResource.MessagesResource.GetRequest>();
            IList<Message> messages = GetMessageList();
            var service = Connection.GetGmailService();
            if (messages != null && messages.Count > 0)
            {
                foreach (var messageItem in messages)
                {
                    reqList.Add(service.Users.Messages.Get("me", messageItem.Id));
                }
            }
            var cleanedReqList = reqList.Distinct().ToList();

            return cleanedReqList;
        }

        public static string GetEmailWindowHeader(UsersResource.MessagesResource.GetRequest req)
            {
            string subject = "(no subject)";
            string sender = null;
            foreach (var header in GetMessageHeaders(req)) {
                if (header.Name.Equals("Subject") && header.Value.Length > 0)
                {
                    subject = header.Value;
                }
                if (header.Name.Equals("From"))
                {
                    sender = header.Value;
                }
            }
            string result = sender + "   " + subject;
            return result;
        }
}
}
