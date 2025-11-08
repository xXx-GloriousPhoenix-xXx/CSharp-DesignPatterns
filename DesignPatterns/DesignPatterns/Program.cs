using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Prototype;

namespace DesignPatterns
{
    public static class MyClass
    {
        public static void Main()
        {
            //Create custom circle
            var myCircle = new Circle()
            {
                Color = "Red",
                Radius = 10,
                X = 5
            };
            Console.WriteLine(myCircle.GetInfo());

            //Copy circle
            var myCircleCopy = myCircle.Clone();
            Console.WriteLine(myCircleCopy.GetInfo());

            //Initialize shape registry & Load default shapes
            var registry = new ShapeRegistry();
            registry.LoadDefaultShapes();

            //Get default rectangle from registry
            var defaultRectangle = registry.GetPrototype("Rectangle");
            Console.WriteLine(defaultRectangle.GetInfo());

            //Changing clone without changing original instance
            // ?
        }
    }
}