namespace DesignPatterns.Builder
{
    public interface IHouseBuilder
    {
        public IHouseBuilder SetFloors(int floors);
        public IHouseBuilder SetRoofType(string roofType);
        public IHouseBuilder SetRooms(int rooms);
        public IHouseBuilder AddGarage();
        public IHouseBuilder AddGarden();
        public IHouseBuilder AddSwimmingPool();
        public House Build();
    }
}
