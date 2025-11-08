namespace DesignPatterns.Factory
{
    public class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
