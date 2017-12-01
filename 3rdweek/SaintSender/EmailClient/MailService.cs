using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace EmailClient
{
    class Program
    {
        static string[] Scopes = { GmailService.Scope.GmailReadonly };
        static string ApplicationName = "Gmail API .NET Quickstart";

        static void Main(string[] args)
        {
            var service = GetGmailService();
            PrintLabels(service);
            ProcessMessages(service);
        }

        public static string Base64UrlDecode(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "<strong>Message body was not returned from Google</strong>";

            string InputStr = input.Replace("-", "+").Replace("_", "/");
            return Encoding.UTF8.GetString(Convert.FromBase64String(InputStr));
        }

        public static GmailService GetGmailService()
        {
            var credential = GetCredential();
            // Create Gmail API service.
            return new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        public static UserCredential GetCredential()
        {
            UserCredential credential;
            using (var stream =
            new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }
            return credential;
        }

        public static void PrintLabels(GmailService service)
        {
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

        public static IList<Message> GetMessageList(GmailService service)
        {
            UsersResource.MessagesResource.ListRequest messageRequest = service.Users.Messages.List("me");
            IList<Message> messages = messageRequest.Execute().Messages;
            return messages;
        }

        public static IList<MessagePartHeader> GetMessageHeaders(UsersResource.MessagesResource.GetRequest req)
        {
            return req.Execute().Payload.Headers;
        }

        public static string GetMessageBodyHtml(UsersResource.MessagesResource.GetRequest req)
        {
            string result = "";
            var parts = req.Execute().Payload.Parts;
            foreach (var item in parts)
            {
                result += Base64UrlDecode(item.Body.Data);
            }
            return result;
        }

        public static string GetMessageSnippet(UsersResource.MessagesResource.GetRequest req)
        {
            return req.Execute().Snippet;
        }

        public static void ProcessMessages(GmailService service)
        {

            IList<Message> messages = GetMessageList(service);
            Console.WriteLine("Messages:");
            if (messages != null && messages.Count > 0)
            {
                foreach (var messageItem in messages)
                {
                    Console.WriteLine(messageItem.Id);
                    UsersResource.MessagesResource.GetRequest readMessage = service.Users.Messages.Get("me", messageItem.Id);
                    string snippet = readMessage.Execute().Snippet;
                    var headers = GetMessageHeaders(readMessage);
                    /*
                    Console.WriteLine("Received: " + headers[2].Value);
                    Console.WriteLine("Subject: " + headers[5].Value);
                    Console.WriteLine("From: " + headers[6].Value);
                    Console.WriteLine("To: " + headers[7].Value);
                    */
                    Console.WriteLine(GetMessageSnippet(readMessage));
                    Console.WriteLine("\n");
                    Console.WriteLine("GetMessageBodyHtml: \n" + GetMessageBodyHtml(readMessage));
                }
            }
            else
            {
                Console.WriteLine("No labels found.");
            }
            Console.Read();
        }
    }
}
