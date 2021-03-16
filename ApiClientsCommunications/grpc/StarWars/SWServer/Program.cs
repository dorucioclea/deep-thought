using Grpc.Core;
using StarWarsContract;
using SWServer.Services;
using System;

namespace SWServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server gRPCServer = new Server
            {
                Services = { StarWarsService.BindService(new StarWarsServerServices()) },
                Ports = { new ServerPort("localhost", 50051, ServerCredentials.Insecure) }
            };

            gRPCServer.Start();
            Console.ReadLine();
            gRPCServer.ShutdownAsync().Wait();
        }
    }
}
