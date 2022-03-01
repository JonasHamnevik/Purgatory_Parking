namespace Core
{
    internal class Car : IVehicle
    {
        public string RegNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UnitSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OwnerFirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OwnerLastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car(string regNumber, string firstName, string lastName)
        {
            RegNumber = regNumber;
            UnitSize = 4;
            OwnerFirstName = firstName;
            OwnerLastName = lastName;
        }
    }


}
