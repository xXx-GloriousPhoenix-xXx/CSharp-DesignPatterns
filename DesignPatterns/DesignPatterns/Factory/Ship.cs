namespace DesignPatterns.Factory
{
    public class Ship : ITransport
    {
        public string Deliver() => "Груз доставлен по морю на корабле.";
    }
}
