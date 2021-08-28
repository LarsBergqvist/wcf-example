using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfServiceLib;

namespace ServiceHostConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // netsh http add urlacl url=http://+:8080/CalculatorService/ user=<DOMAIN/User>
            
            Uri baseAddress = new Uri("http://localhost:8080/CalculatorService");

            // Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService), baseAddress))
            {
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior
                {
                    HttpGetEnabled = true,
                };
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
