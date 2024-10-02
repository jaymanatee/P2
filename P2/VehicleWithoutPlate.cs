namespace P2
{
    class VehicleWithoutPlate : Vehicle
    {

        public VehicleWithoutPlate(string typeOfVehicle) : base(typeOfVehicle) { }
        public override string ToString()
        {
            return $"{GetTypeOfVehicle(): has no plate}";
        }
    }
}
