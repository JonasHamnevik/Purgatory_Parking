namespace Core
{
    internal interface IVehicle
    {
        public string RegNumber { get; set; }
        public int UnitSize { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
    }
}
