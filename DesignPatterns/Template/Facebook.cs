using System.Text;

namespace DesignPatterns.Template
{
    internal class Facebook : Social
    {
        public Facebook(string username, string password) : base(username, password)
        {
        }

        public override bool Login(string username, string password)
        {
            Console.WriteLine("Login success on Facebook");
            return true;
        }

        public override void Logout()
        {
            Console.WriteLine($"{username} was logged out from Facebook");
        }

        public override bool SendData(byte[] data)
        {
            Console.WriteLine($"Message: {Encoding.UTF8.GetString(data)} was posted on Facebook");
            return true;
        }
    }
}
