using System.Text;

namespace DesignPatterns.Template
{
    internal class Instagram : Social
    {
        public Instagram(string username, string password) : base(username, password)
        {
        }

        public override bool Login(string username, string password)
        {
            Console.WriteLine("Login success on Instagram");
            return true;
        }

        public override void Logout()
        {
            Console.WriteLine($"{username} was logged out from Instagram");
        }

        public override bool SendData(byte[] data)
        {
            Console.WriteLine($"Message: {Encoding.UTF8.GetString(data)} was posted on Instagram");
            return true;
        }
    }
}
