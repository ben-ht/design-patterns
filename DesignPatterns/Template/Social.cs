using System.Text;

namespace DesignPatterns.Template
{
    internal abstract class Social
    {
        protected string username;
        protected string password;

        protected Social(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool Post(string message)
        {
            if (Login(username, password))
            {
                bool result = SendData(Encoding.UTF8.GetBytes(message));
                Logout();
                return result;
            }

            return false;
        }

        public abstract bool Login(string username, string password);
        public abstract void Logout();
        public abstract bool SendData(byte[] data);
    }
}
