namespace P2
{
    public class PoliceStation
    {
        private List<PoliceCar> Cars = new List<PoliceCar>();
        private bool alert = false;

        public void StartAlarm(string plate)
        {
            alert = true;
            SendInfractor(plate);
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

        public void RegisterCar(string plate)
        {
            PoliceCar Car = new PoliceCar(plate, true, this);
            Cars.Add(Car);
        }
    }
}