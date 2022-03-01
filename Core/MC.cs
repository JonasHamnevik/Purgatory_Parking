namespace Core
{
    internal class MC : IVehicle
    {
        public string RegNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UnitSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OwnerFirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OwnerLastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MC(string regNumber, string firstName, string lastName)
        {
            RegNumber = regNumber;
            UnitSize = 2;
            OwnerFirstName = firstName;
            OwnerLastName = lastName;
        }
    }
}
