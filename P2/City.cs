namespace P2 
{
    public class City : IMessageWritter
    {
        private string name;
        private List<Taxi> Taxis = new List<Taxi>();
        private PoliceStation PoliceStation = new PoliceStation();

        public City(string name)
        {
            this.name = name;
        }

        public Taxi AddTaxiLicense(string plate)
        {
            Taxi taxi = new Taxi(plate);
            Taxis.Add(taxi);
            Console.WriteLine(WriteMessage($"Taxi with plate {plate} has been registered"));
            return taxi;
        }

        public PoliceCar AddPoliceCar(string plate, bool withRadar)
        {
            return PoliceStation.RegisterCar(plate, withRadar);
        }

        public override string ToString()
        {
            return $"We are in {name}";
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }

        public void RemoveTaxi()
        {
            string plate = PoliceStation.GetInfractor();
            for (int i = Taxis.Count - 1; i >= 0; i--)
            {
                if (Taxis[i].GetPlate() == plate)
                {
                    Taxis.RemoveAt(i); 
                    Console.WriteLine(WriteMessage($"License of Taxi with plate {plate} was removed"));
                }
            }
        }
    }
}