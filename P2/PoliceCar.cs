namespace P2
{
    class PoliceCar : VehicleWithPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling;
        private SpeedRadar? speedRadar;
        private PoliceStation Station;
        private string infractor = "";
        private bool chasing = false;

        public PoliceCar(string plate, bool withRadar, PoliceStation Station) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            if (withRadar)
            {
                speedRadar = new SpeedRadar();
            }
            this.Station = Station;
        }

        public void SetInfractor(string plate)
        {
            infractor = plate;
            chasing = true;
        }

        public void UseRadar(VehicleWithPlate vehicle)
        {
            if (speedRadar is null)
            {
                Console.WriteLine(WriteMessage("has no radar"));
            }
            else
            {
                if (isPatrolling)
                {
                    bool aboveSped = speedRadar.TriggerRadar(vehicle);
                    if (aboveSped)
                    {
                        Station.StartAlarm(vehicle.GetPlate());
                    }
                    string meassurement = speedRadar.GetLastReading();
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
                }
                else
                {
                    Console.WriteLine(WriteMessage($"has no active radar."));
                }

            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            if (speedRadar is null)
            {
                Console.WriteLine(WriteMessage("has no radar"));
            }
            else
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
        }
    }
}