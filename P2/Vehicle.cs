namespace P2
{
    abstract class Vehicle : IMessageWritter
    {
        private string typeOfVehicle;
        private string plate;
        private int speed;

        public Vehicle(string typeOfVehicle, string plate)
        {
            this.typeOfVehicle = typeOfVehicle;
            this.plate = plate;
            speed = 0;
        }

        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }

        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }

        public string GetPlate()
        {
            return plate;
        }


        public int GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }

        //Implment interface with Vechicle message structure
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}
