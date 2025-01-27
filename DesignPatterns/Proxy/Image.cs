namespace DesignPatterns.Proxy
{
    internal class Image : IImage
    {
        private readonly string fileName;

        public Image(string fileName)
        {
            this.fileName = fileName;
            LoadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying " + fileName);
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine($"Loading {fileName} from disk");
        }
    }
}
