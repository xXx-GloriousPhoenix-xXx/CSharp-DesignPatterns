namespace DesignPatterns.Factory.Transport
{
    public class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
