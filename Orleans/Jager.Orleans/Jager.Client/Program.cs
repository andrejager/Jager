using System;
using Orleans;
using Orleans.Runtime.Configuration;

namespace Jager.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientConfiguration clientConfig = ClientConfiguration.LocalhostSilo();
            IClusterClient client = new ClientBuilder().UseConfiguration(clientConfig).Build();
            client.Connect().Wait();
            Console.WriteLine("Connected");
            Console.ReadLine();
            client.Dispose();
        }
    }
}