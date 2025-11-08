namespace DesignPatterns.Builder
{
    public class HouseBuilder : IHouseBuilder
    {
        private readonly House house = new();
        
        public IHouseBuilder SetFloors(int floors)
        {
            house.Floors = floors;
            return this;
        }

        public IHouseBuilder SetRoofType(string roofType)
        {
            house.RoofType = roofType;
            return this;
        }

        public IHouseBuilder SetRooms(int rooms)
        {
            house.Rooms = rooms;
            return this;
        }
        public IHouseBuilder AddGarage()
        {
            house.HasGarage = true;
            return this;
        }

        public IHouseBuilder AddGarden()
        {
            house.HasGarden = true;
            return this;
        }

        public IHouseBuilder AddSwimmingPool()
        {
            house.HasSwimmingPool = true;
            return this;
        }

        public House Build()
        {
            return house;
        }        
    }
}
