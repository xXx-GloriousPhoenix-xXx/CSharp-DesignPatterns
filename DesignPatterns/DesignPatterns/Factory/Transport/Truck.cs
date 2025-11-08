namespace DesignPatterns.Factory.Transport
{
    public class Truck : ITransport
    {
        public string Deliver() => "Груз доставлен по земле в фуре.";
    }
}
