namespace Walle.DeviceId.Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new object();
            var last = string.Empty;
            while (true)
            {
                Task.Factory.StartNew(() =>
                {
                    var deviceId = DeviceIdBuilder.CreateBuilder()
                      .UseBaseBoard()
                      .UseProcessor()
                      .UseHarddisk()
                      .UseBIOS()
                      .Build();

                    lock (obj)
                    {
                        if (deviceId != last)
                        {
                            Console.WriteLine(deviceId);
                            last = deviceId;
                        }
                    }

                });
            }
            Console.ReadLine();
        }
    }
}