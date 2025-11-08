namespace DesignPatterns.Factory.Transport
{
    public abstract class Logistics
    {
        public abstract ITransport CreateTransport();
    }
}
