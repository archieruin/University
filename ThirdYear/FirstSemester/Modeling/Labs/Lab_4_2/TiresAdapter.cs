namespace Lab_4_2
{
    public interface IConnectTires
    {
        string Connect();
    }
    
    class LightCarTires : IConnectTires
    {
        public string Connect()
        {
            return "Light car tires has been connected.";
        }
    }
    
    class BusTires : IConnectTires
    {
        public string Connect()
        {
            return "Bus tires has been connected.";
        }
    }

    class KamazTires
    {
        public string KamazTiresConnect()
        {
            return "Kamaz tires has been connected.";
        }
    }
    
    class KamazTiresAdapter : IConnectTires
    {
        private readonly KamazTires _kamazTires;

        public KamazTiresAdapter(KamazTires kamazTires)
        {
            _kamazTires = kamazTires;
        }

        public string Connect()
        {
            return _kamazTires.KamazTiresConnect();
        }
    }
}