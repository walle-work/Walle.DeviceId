using System.Security.Cryptography;
using System.Text;

namespace Walle.DeviceId
{
    public class DeviceIdBuilder
    {
        private string content = string.Empty;

        public DeviceIdBuilder()
        {
            this.content = Environment.MachineName;
        }

        internal void Append(string text)
        {
            this.content += text;
        }

        public override string ToString()
        {
            var content_bytes = Encoding.ASCII.GetBytes(this.content);
            MD5 md5 = MD5.Create();
            var md5_bytes = md5.ComputeHash(content_bytes);
            var sb = new StringBuilder();
            foreach (byte b in md5_bytes)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }

        public string Build()
        {
            return this.ToString();
        }


        public static DeviceIdBuilder CreateBuilder()
        {
            return new DeviceIdBuilder();
        }
    }
}