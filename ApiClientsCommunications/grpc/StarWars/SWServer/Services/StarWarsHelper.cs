using System;
using StarWarsContract;

namespace ApiClientsCommunications.grpc.grpc.SWServer.Services
{
    public class StarWarsHelper
    {

        public static SpaceShipInfoResponse GetSpaceShipInfo(SpaceShips spaceShips)
        {
            SpaceShipInfoResponse response = new SpaceShipInfoResponse();

            switch (spaceShips) 
            {
                case SpaceShips.Xwing:
                    response.Name = "X-Wing";
                    response.Producer = "Incom Corporation";
                    response.Classification = "T-65 X-wing starfighter";
                    response.Crew = "1 pilot, 1 droid";
                    response.Length = "12,5 m.";
                    response.Union = "Asi Güçleri";
                    break;
                case SpaceShips.Ywing:
                    response.Name = "Y-Wing";
                    response.Producer = "Incom Corporation";
                    response.Classification = "Y-Wing Starfighter";
                    response.Crew = "1 pilot";
                    response.Length = "10.2 meters";
                    response.Union = "Asi Güçleri";
                    break;
                case SpaceShips.Tiefighter:
                    response.Name = "TIE Fighter";
                    response.Producer = "Sienar Fleet Systems Sienar";
                    response.Classification = "	Space superiority fighter";
                    response.Crew = "1 pilot";
                    response.Length = "7.2 meters";
                    response.Union = "İmparatorluk Güçleri";
                    break;
                case SpaceShips.MillenniumFalcon:
                    response.Name = "Millennium Falcon";
                    response.Producer = "Corellian Engineering Corp.";
                    response.Classification = "HİPER Uzay Gemileri";
                    response.Crew = "Han Solo, Chewie, Rey";
                    response.Length = "26,7 metre";
                    response.Union = "Kaçakçılar, Asiler,";
                    break;
                case SpaceShips.StarDestroyer:
                    response.Name = "Star Destroyer";
                    response.Producer = "Kuat Drive Yards Kuat - Entralla Engineering";
                    response.Classification = "Eclipse-class";
                    response.Crew = "Subay (9.235), Gönüllü asker(27.850)";
                    response.Length = "700–19,000 metres";
                    response.Union = "İmparatorluk";
                    break;
                default:
                    break;
            }

            return response;

        }

        public static string GetMessage(ref int health, ref int shield)
        {
            Random rnd = new Random();

            if (shield >= 0)
            {
                shield -= rnd.Next(0, 40);
                if (shield <= 0)
                    return "Tüm kalkanlar devre dışı!";


                return string.Empty;
            }

            health -= rnd.Next(0, 80);
            if (health <= 0)
                return "Uzay aracı yok edildi!";

            return string.Empty;
        }
    }
}