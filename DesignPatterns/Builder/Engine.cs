namespace DesignPatterns.Builder
{
    internal class Engine
    {
        public double Volume { get; }
        public double Kilometers { get; set; }
        public bool Started { get; set; }

        public void On()
        {
            Started = true;
        }

        public void Off()
        {
            Started = false;
        }

        public void Go(double kilometers)
        {
            if (Started)
            {
                Kilometers += kilometers;
            }
            else
            {
                Console.WriteLine("Cannot Go(), you must start engine first");
            }
        }


    }
}
