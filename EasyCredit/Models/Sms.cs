using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Configuration;
public class Sms
{  
    static string AccountSid { get { return ConfigurationManager.AppSettings["AutenticacionID"].ToString(); } }
    static string AuthToken { get { return ConfigurationManager.AppSettings["AutenticacionToken"].ToString(); } }
    static string From { get { return ConfigurationManager.AppSettings["From"].ToString(); } }
    public  static void Main(string telefono ,string body)
    {
        TwilioClient.Init(AccountSid, AuthToken);
        var messageOptions = new CreateMessageOptions(
          new PhoneNumber($"+57{telefono}"));
        messageOptions.From = new PhoneNumber(From);//PhoneNumber("+12566496782")
        messageOptions.Body = body;
        var message = MessageResource.Create(messageOptions);
        Console.WriteLine(message.Body);
    }
}