using Grpc.Core;
using StarWarsContract;
using SWClient.Services;
using System;
using System.Threading.Tasks;

namespace SWClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
            var client = new StarWarsService.StarWarsServiceClient(channel);

            StarWarsClientService service = new StarWarsClientService(client);

            int process = 0;
            while (process >= 0)
            {
                Console.WriteLine("-1: Exit");
                Console.WriteLine("0: Unary");
                Console.WriteLine("1: Server Streaming");
                Console.WriteLine("2: Client Streaming");
                Console.WriteLine("3: Client-Server Streaming");

                process = Convert.ToInt32(Console.ReadLine().ToString());
                Console.WriteLine("\n");
                Random rnd = new Random();
                if (process == 0)
                    await service.GetSpaceShipInfo(new SpaceShipInfoRequest
                    {
                        SpaceShip = (SpaceShips)rnd.Next(0, 5),
                    });
                else if (process == 1)
                    await service.MonitoringSpaceShip();
                else if (process == 2)
                    await service.SendToDeathStarPlans();
                else if (process == 3)
                    await service.SendMessageAllJedi();
            }
        }
    }
}
