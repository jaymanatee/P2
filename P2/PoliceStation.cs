
namespace P2
{
    public class PoliceStation : IMessageWritter
    {
        private List<PoliceCar> Cars = new List<PoliceCar>();
        private bool alert = false;
        private string infractor = "";

        public void StartAlarm(string plate)
        {
            alert = true;
            SendInfractor(plate);
            infractor = plate;
            Console.WriteLine(WriteMessage($"Notice to all patrolling units: Vehicle with plate {plate} is on the run"));
        }
        
        public void SendInfractor(string plate)
        {
            foreach (PoliceCar Car in Cars)
            {
                if (Car.IsPatrolling())
                {
                    Car.SetInfractor(plate);
                }
            }
        }

        public PoliceCar RegisterCar(string plate, bool withRadar)
        {
            PoliceCar Car = new PoliceCar(plate, withRadar, this);
            Cars.Add(Car);
            Console.WriteLine(WriteMessage($"Registered police car with plate {plate}"));
            return Car;
        }

        public override string ToString()
        {
            return $"Police Station";
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }

        public string GetInfractor()
        {
            return infractor;
        }
    }
}