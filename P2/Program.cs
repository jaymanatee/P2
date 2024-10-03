namespace P2
{
    internal class Program
    {

        static void Main()
        {
            City RacoonCity = new City("Racoon City");
            Console.WriteLine(RacoonCity.ToString());
            Taxi Taxi1 = RacoonCity.AddTaxiLicense("7236 ATS");
            Taxi Taxi2 = RacoonCity.AddTaxiLicense("6730 JDG");
            Taxi Taxi3 = RacoonCity.AddTaxiLicense("0265 KOP");
            PoliceCar PoliceCar1 = RacoonCity.AddPoliceCar("1234 HJK", true);
            PoliceCar PoliceCar2 = RacoonCity.AddPoliceCar("3425 FTR", false);
            PoliceCar PoliceCar3 = RacoonCity.AddPoliceCar("0923 EYI", true);
            PoliceCar2.StartPatrolling();
            PoliceCar3.StartPatrolling();
            PoliceCar1.StartPatrolling();
            PoliceCar2.UseRadar(Taxi1);
            Taxi3.StartRide();
            PoliceCar1.UseRadar(Taxi3);
            RacoonCity.RemoveTaxi();
        }
    }
}


