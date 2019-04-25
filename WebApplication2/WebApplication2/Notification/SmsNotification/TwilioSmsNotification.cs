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
        public void SendSms(string toPhoneNumber, string bodyMessage)
        {
            const string accountSid = "ACeb0bfe31785044cb659e70085da53550";
            const string authToken = "5347c34771748e1d930b01f7ccc17099";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: bodyMessage,
                from: new Twilio.Types.PhoneNumber("+13367925756"),
                to: new Twilio.Types.PhoneNumber(toPhoneNumber)
            );
        }
    }
}
