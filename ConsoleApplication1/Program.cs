using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CosmeticsLibrary.FACADE;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating HTTP channel for the application
            HttpChannel channel = new HttpChannel(4445);
            //Registering Channels
            ChannelServices.RegisterChannel(channel, false);
            // Registering the Service
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(SalesStaffFacade), "SalesStaffFacade", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(LocalManagerFacade), "LocalManagerFacade", WellKnownObjectMode.Singleton);

            Console.WriteLine("Server is ready.... on port 4445...");
            Console.Read();
        }
    }
}
