namespace DesignPatterns.Builder
{
    public static class ConstructionEngineer
    {
        public static House ConstructStandardHouse()
        {
            return new HouseBuilder()
                .SetFloors(1)
                .SetRooms(3)
                .SetRoofType("Скатная")
                .Build();
        }
        public static House ConstructLuxuryHouse()
        {
            return new HouseBuilder()
                .SetFloors(2)
                .SetRooms(5)
                .SetRoofType("Мансардная")
                .AddGarage()
                .AddGarden()
                .AddSwimmingPool()
                .Build();
        }
    }
}
