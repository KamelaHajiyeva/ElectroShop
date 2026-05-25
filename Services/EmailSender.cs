using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;
using System;
using System.Collections.Generic;

namespace ElectroShop.Services
{
    public class EmailSender
    {
        public static bool SendEmail(
            string apiKey,
            string senderName,
            string senderEmail,
            string toName,
            string toEmail,
            string subject,
            string textContent)
        {
            try
            {
                // IMPORTANT: Add değil, set ediyoruz (duplicate hatası olmaz)
                Configuration.Default.ApiKey["api-key"] = apiKey;

                var apiInstance = new TransactionalEmailsApi();

                var sender = new SendSmtpEmailSender(senderName, senderEmail);

                var toList = new List<SendSmtpEmailTo>
                {
                    new SendSmtpEmailTo(toEmail, toName)
                };

                // Hem text hem html gönderelim
                var sendSmtpEmail = new SendSmtpEmail
                {
                    Sender = sender,
                    To = toList,
                    Subject = subject,
                    TextContent = textContent,
                    HtmlContent = "<pre style='font-family:Arial'>" + System.Net.WebUtility.HtmlEncode(textContent) + "</pre>"
                };

                CreateSmtpEmail result = apiInstance.SendTransacEmail(sendSmtpEmail);
                Console.WriteLine("Brevo OK. MessageId: " + result.MessageId);
                return true;
            }
            catch (ApiException apiEx)
            {
                // Brevo hata detayı burada olur
                Console.WriteLine($"Brevo API ERROR: Code={(int)apiEx.ErrorCode} Message={apiEx.Message}");
                Console.WriteLine("Brevo API Response: " + apiEx.ErrorContent);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("EmailSender Exception: " + ex);
                return false;
            }
        }
    }
}