namespace P2
{
    class SpeedRadar : IMessageWritter
    {
        //Radar doesn't know about Vechicles, just speed and plates
        private string plate;
        private int speed;
        private int legalSpeed = 50;
        public List<int> SpeedHistory { get; private set; }

        public SpeedRadar()
        {
            plate = "";
            speed = 0;
            SpeedHistory = new List<int>();
        }

        public bool TriggerRadar(VehicleWithPlate vehicle)
        {
            plate = vehicle.GetPlate();
            speed = vehicle.GetSpeed();
            SpeedHistory.Add(speed);
            if (speed > legalSpeed)
            {
                return true;
            }
            return false;
        }

        public string GetLastReading()
        {
            if (speed > legalSpeed)
            {
                return WriteMessage("Catched above legal speed.");
            }
            else
            {
                return WriteMessage("Driving legally.");
            }
        }

        public virtual string WriteMessage(string radarReading)
        {
            return $"Vehicle with plate {plate} at {speed.ToString()} km/h. {radarReading}";
        }
    }
}