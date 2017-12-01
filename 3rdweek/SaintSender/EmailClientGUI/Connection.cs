using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmailClientGUI
{
    class Connection
    {
        static string[] Scopes = { GmailService.Scope.MailGoogleCom };
        static string ApplicationName = "Gmail API .NET Quickstart";

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
    }
}
