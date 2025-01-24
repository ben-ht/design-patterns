namespace DesignPatterns.Builder
{
    internal class GPSNavigator
    {
        public string Route { get; }

        public GPSNavigator()
        {
            Route = "Av. Gustave Eiffel, 75007 Paris";
        }

        public GPSNavigator(string route)
        {
            Route = route;
        }
    }
}
