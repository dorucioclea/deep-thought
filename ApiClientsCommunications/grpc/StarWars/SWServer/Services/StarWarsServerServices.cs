using System.Threading.Tasks;
using Grpc.Core;
using System;
using System.Collections.Generic;
using StarWarsContract;
using ApiClientsCommunications.grpc.grpc.SWServer.Services;

namespace SWServer.Services
{
    public class StarWarsServerServices : StarWarsService.StarWarsServiceBase
    {
        public override async Task<SpaceShipInfoResponse> GetSpaceShipInfo(SpaceShipInfoRequest request, ServerCallContext context)
        {
            return StarWarsHelper.GetSpaceShipInfo(request.SpaceShip);
        }
        public override async Task MonitoringSpaceShip(MonitoringSpaceShipRequest request, IServerStreamWriter<MonitoringSpaceShipResponse> responseStream, ServerCallContext context)
        {
            MonitoringSpaceShipResponse response = new MonitoringSpaceShipResponse();

            int health = 0;
            int shield = 0;
            switch (request.SpaceShip)
            {
                case SpaceShips.Xwing:
                    health = 100;
                    shield = 100;
                    break;
                case SpaceShips.Ywing:
                    health = 100;
                    shield = 100;
                    break;
                case SpaceShips.Tiefighter:
                    health = 120;
                    shield = 80;
                    break;
                case SpaceShips.MillenniumFalcon:
                    health = 800;
                    shield = 1000;
                    break;
                case SpaceShips.StarDestroyer:
                    health = 10000;
                    shield = 20000;
                    break;
                default:
                    break;
            }

            while (health > 0)
            {
                response.Message = StarWarsHelper.GetMessage(ref health, ref shield);
                response.Health = health;
                response.Shield = shield;

                await Task.Delay(200);
                await responseStream.WriteAsync(response);
            }

        }
        public override async Task<SendToDeathStarPlansResponse> SendToDeathStarPlans(IAsyncStreamReader<SendToDeathStarPlansRequest> requestStream, ServerCallContext context)
        {

            var request = new SendToDeathStarPlansResponse() { Status = TransmissionStatus.None };
            int planPercentage = 0;


            while (await requestStream.MoveNext())
            {
                planPercentage += requestStream.Current.PlansPercentage;
                if (planPercentage >= 100)
                {
                    request.Status = TransmissionStatus.Done;
                }
                else
                {
                    request.Status = TransmissionStatus.Failed;
                }
            }

            return request;

        }
        public override async Task SendMessageAllJedi(IAsyncStreamReader<SendMessageAllJediRequest> requestStream, IServerStreamWriter<SendMessageAllJediResponse> responseStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext())
            {
                var request = requestStream.Current;
                Console.WriteLine($"Jedi:{request.JediId} Planet:{request.Planet.ToString()}");


                Random rnd = new Random();

                SendMessageAllJediResponse responseModel = new SendMessageAllJediResponse
                {
                    JediId = request.JediId,
                    MessageStatus = rnd.Next(0, 2) == 0 ? MessageStatus.SuccessMessage : MessageStatus.FailedMessage,

                };

                await Task.Delay(100);
                await responseStream.WriteAsync(responseModel);
            }
        }


    }
}
