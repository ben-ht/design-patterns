namespace DesignPatterns.Proxy
{
    internal class ImageProxy : IImage
    {
        private readonly string fileName;
        private Image? image;

        public ImageProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            image ??= new Image(fileName);
            image.Display();
        }
    }
}
