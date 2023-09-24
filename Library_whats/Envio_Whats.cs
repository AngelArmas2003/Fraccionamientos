using System;
using System.Collections.Generic;
using System.Linq;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;







namespace Library_whats
{



    public class Envio_Whats
    {

        //

        //



        public void EnvioWhats()
        {


            //
            //var accountSid = "AC3d42fcdb1d6ab8162680d22c36c05364";
            //var authToken = "8a4961d3a3867d03a9e859eb4f5ea1ee";
            //TwilioClient.Init(accountSid, authToken);

            //var messageOptions = new CreateMessageOptions(
            //  new PhoneNumber("whatsapp:+5215618347412"));
            //messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            //messageOptions.Body = "Hola mA me este es una prueba de envio por medio de un programa, me dice si le llego por favor";


            //var message = MessageResource.Create(messageOptions);
            //Console.WriteLine(message.Body);



            // Find your Account SID and Auth Token at twilio.com/console
            // and set the environment variables. See http://twil.io/secure
            string accountSid = "AC3d42fcdb1d6ab8162680d22c36c05364";// Environment.GetEnvironmentVariable("AC3d42fcdb1d6ab8162680d22c36c05364");
            string authToken = "8a4961d3a3867d03a9e859eb4f5ea1ee";// Environment.GetEnvironmentVariable("8a4961d3a3867d03a9e859eb4f5ea1ee");

            TwilioClient.Init(accountSid, authToken);

            var mediaUrl = new[] {
            new Uri("https://demo.twilio.com/owl.png")
        }.ToList();

            var message = MessageResource.Create(
                body: "Here's that picture of an owl you requested.",
                mediaUrl: mediaUrl,
                from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
                to: new Twilio.Types.PhoneNumber("whatsapp:+5215618347412")
            );

            Console.WriteLine(message.Sid);



        }
        //

        //var accountSid = "AC3d42fcdb1d6ab8162680d22c36c05364";
        //var authToken = "8a4961d3a3867d03a9e859eb4f5ea1ee";
        //TwilioClient.Init(accountSid, authToken);

        //var messageOptions = new CreateMessageOptions(
        //  new PhoneNumber("+525569680388"));
        //messageOptions.From = new PhoneNumber("+14325274682");
        //messageOptions.Body = "hi";


        //var message = MessageResource.Create(messageOptions);
        //Console.WriteLine(message.Body);
    }

        






    
}
