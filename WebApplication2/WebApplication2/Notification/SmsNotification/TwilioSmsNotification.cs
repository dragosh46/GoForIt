using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace WebApplication2.Notification.SmsNotification
{
    public class TwilioSmsNotification
    {
        public void SendSms(string toPhoneNumber)
        {
            const string accountSid = "ACeb0bfe31785044cb659e70085da53550";
            const string authToken = "your_auth_token";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
                from: new Twilio.Types.PhoneNumber("+13367925756"),
                to: new Twilio.Types.PhoneNumber(toPhoneNumber)
            );
        }
    }
}
