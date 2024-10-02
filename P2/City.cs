namespace P2
{
    public class City
    {
        private PoliceStation PoliceStation = new PoliceStation();
        private List<Taxi> Taxis = new List<Taxi>();

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