namespace P2
{
    public class City
    {
        private List<Taxi> Taxis = new List<Taxi>();
        private PoliceStation PoliceStation = new PoliceStation();

        public void AddTaxiLicense(string plate)
        {
            Taxis.Add(new Taxi(plate));
        }

        public void AddPoliceCar(string plate)
        {
            PoliceStation.RegisterCar(plate);
        }
    }
}