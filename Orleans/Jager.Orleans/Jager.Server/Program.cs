using System;
using Orleans.Runtime.Configuration;
using Orleans.Runtime.Host;

namespace Jager.Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var siloConfig = ClusterConfiguration.LocalhostPrimarySilo();
            var silo = new SiloHost("Test Silo", siloConfig);
            silo.InitializeOrleansSilo();
            
            if (silo.StartOrleansSilo())
                Console.WriteLine("Started");
            
            Console.WriteLine("Press Enter to close.");
// wait here
            Console.ReadLine();

// shut the silo down after we are done.
            silo.ShutdownOrleansSilo();
        }
    }
}