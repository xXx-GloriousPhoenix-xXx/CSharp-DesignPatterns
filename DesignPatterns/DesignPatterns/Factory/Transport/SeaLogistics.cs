namespace DesignPatterns.Factory.Transport
{
    public class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
