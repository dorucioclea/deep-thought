using Grpc.Core;
using StarWarsContract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static StarWarsContract.StarWarsService;

namespace SWClient.Services
{
    public class StarWarsClientService
    {

        private readonly CancellationTokenSource _tokenSource;
        private readonly StarWarsServiceClient _client;
        public StarWarsClientService(StarWarsServiceClient client)
        {
            _tokenSource = new CancellationTokenSource();
            _client = client;
        }
        
        public async Task GetSpaceShipInfo(SpaceShipInfoRequest request)
        {
            var response = await _client.GetSpaceShipInfoAsync(request);
            Console.WriteLine($"Ad: {response.Name} \n" +
                $"Sınıf: {response.Classification}\n" +
                $"Mürettebat: {response.Crew}\n" +
                $"Uzunluk: {response.Length}\n" +
                $"Üretici: {response.Producer}\n" +
                $"Birlik: {response.Union}\n");
        }
        
        public async Task MonitoringSpaceShip()
        {
            var request = new MonitoringSpaceShipRequest() { SpaceShip = SpaceShips.MillenniumFalcon };

            using (var call = _client.MonitoringSpaceShip(request))
            {
                while (await call.ResponseStream.MoveNext(_tokenSource.Token))
                {
                    var currentResponse = call.ResponseStream.Current;
                    Console.WriteLine($"Health:{currentResponse.Health} \n Shield:{currentResponse.Shield} \n  Message:{currentResponse.Message}");
                    Console.WriteLine("----------------------------------");
                }
            }
        }
        
        public async Task SendToDeathStarPlans()
        {
            int transferingPercentage = 0;
            using (var call = _client.SendToDeathStarPlans())
            {
                for (int i = 0; i < 25; i++)
                {
                    var rnd = new Random();
                    var request = new SendToDeathStarPlansRequest()
                    {
                        PlansPercentage = rnd.Next(0, 10),
                    };
                    await call.RequestStream.WriteAsync(request);
                    await Task.Delay(100);

                    transferingPercentage += request.PlansPercentage;
                    Console.WriteLine($"Aktarım Oranı: %{transferingPercentage}");
                }
                await call.RequestStream.CompleteAsync();

                var response = await call;

                string result = "";
                switch (response.Status)
                {
                    case TransmissionStatus.Done:
                        result = "Aktarım Başarılı";
                        break;
                    case TransmissionStatus.Failed:
                        result = "Aktarım Başarısız";
                        break;
                    case TransmissionStatus.None:
                        result = "Aktarıma Başlanılmadı.";
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Sonuç = {result}");
            }
        }
        
        public async Task SendMessageAllJedi()
        {
            using (var call = _client.SendMessageAllJedi())
            {
                var responseReaderTask = Task.Run(async () =>
                {
                    while (await call.ResponseStream.MoveNext())
                    {
                        var response = call.ResponseStream.Current;
                        Console.WriteLine($"JediId:{response.JediId} Status: {response.MessageStatus}");
                    }
                });

                Random rnd = new Random();


                for (int i = 0; i < 25; i++)
                {

                    var requestModel = new SendMessageAllJediRequest
                    {
                        JediId = Guid.NewGuid().ToString(),
                        Planet = (Planets)rnd.Next(0, 7),
                    };

                    await Task.Delay(200);
                    await call.RequestStream.WriteAsync(requestModel);
                }

                await call.RequestStream.CompleteAsync();
                await responseReaderTask;
            }
        }
    }
}
