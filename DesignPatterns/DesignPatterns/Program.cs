using DesignPatterns.Builder;
using DesignPatterns.Factory;

namespace DesignPatterns
{
    public static class MyClass
    {
        public static void Main()
        {
            var standardHouse = ConstructionEngineer.ConstructStandardHouse();
            Console.WriteLine(standardHouse.DisplayInfo());

            var luxuryHouse = ConstructionEngineer.ConstructLuxuryHouse();
            Console.WriteLine(luxuryHouse.DisplayInfo());
        }
    }
}