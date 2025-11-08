namespace DesignPatterns.Factory.Transport
{
    public class Ship : ITransport
    {
        public string Deliver() => "Груз доставлен по морю на корабле.";
    }
}
