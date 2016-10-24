using System;
using Liquid11_MobileVerification;
using Newtonsoft.Json;

namespace Liquid11_MobileVerification_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an account and set an api password at https://www.mobileverification.co.uk
            using (var client = new Client("myuser@mydomain.com", "mypassword"))
            {
                Console.WriteLine("# Tps Request");
                Console.WriteLine(JsonConvert.SerializeObject(client.TpsLookup("0044***********").Result, Formatting.Indented));
                Console.WriteLine("\n\n");

                Console.WriteLine("# Hlr Request");
                Console.WriteLine(JsonConvert.SerializeObject(client.HlrLookup("0044***********").Result, Formatting.Indented));
                Console.WriteLine("\n\n");

                Console.WriteLine("# Landline Request");
                Console.WriteLine(JsonConvert.SerializeObject(client.LandlandLookup("0044***********").Result, Formatting.Indented));
                Console.WriteLine("\n\n");

                Console.WriteLine("# Email");
                Console.WriteLine(JsonConvert.SerializeObject(client.EmailLookup("myuser@mydomain.com").Result,Formatting.Indented));
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("\n\n\n All done!");
            Console.Read();
        }
    }
}
