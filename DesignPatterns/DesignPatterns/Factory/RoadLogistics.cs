namespace DesignPatterns.Factory
{
    public class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
