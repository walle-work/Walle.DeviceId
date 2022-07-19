using System.Diagnostics;
using System.Management;

namespace Walle.DeviceId
{
    public static class Extensions
    {
        public static DeviceIdBuilder UseBaseBoard(this DeviceIdBuilder builder)
        {
            var result = "";
            if (OperatingSystem.IsWindows())
            {
                ManagementClass management = new ManagementClass("Win32_BaseBoard");
                ManagementObjectCollection collection = management.GetInstances();
                foreach (var instance in collection)
                {
                    var id = instance.Properties["SerialNumber"].Value.ToString().Trim();
                    result += id;
                    instance.Dispose();
                    Debug.WriteLine($"SerialNumber:{id}", "Win32_BaseBoard");
                }
                management.Dispose();
            }
            builder.Append(result);
            return builder;
        }

        public static DeviceIdBuilder UseProcessor(this DeviceIdBuilder builder)
        {
            var result = "";
            if (OperatingSystem.IsWindows())
            {
                ManagementClass management = new ManagementClass("Win32_Processor");
                ManagementObjectCollection collection = management.GetInstances();
                foreach (var instance in collection)
                {
                    var id = instance.Properties["ProcessorId"].Value.ToString().Trim();
                    result += id;
                    instance.Dispose();
                    Debug.WriteLine($"ProcessorId:{id}", "Win32_Processor");
                }
                management.Dispose();
            }
            builder.Append(result);
            return builder;
        }


        public static DeviceIdBuilder UseHarddisk(this DeviceIdBuilder builder)
        {
            var result = "";
            if (OperatingSystem.IsWindows())
            {
                ManagementClass management = new ManagementClass("Win32_PhysicalMedia");
                ManagementObjectCollection collection = management.GetInstances();
                foreach (var instance in collection)
                {
                    var id = instance.Properties["SerialNumber"].Value.ToString().Trim();
                    result += id;
                    instance.Dispose();
                    Debug.WriteLine($"SerialNumber:{id}", "Win32_PhysicalMedia");
                }
                management.Dispose();
            }
            builder.Append(result);
            return builder;
        }

        public static DeviceIdBuilder UseBIOS(this DeviceIdBuilder builder)
        {
            var result = "";
            if (OperatingSystem.IsWindows())
            {
                ManagementClass management = new ManagementClass("Win32_BIOS");
                ManagementObjectCollection collection = management.GetInstances();
                foreach (var instance in collection)
                {
                    var id = instance.Properties["SerialNumber"].Value.ToString().Trim();
                    result += id;
                    instance.Dispose();
                    Debug.WriteLine($"SerialNumber:{id}", "Win32_BIOS");
                }
                management.Dispose();
            }
            builder.Append(result);
            return builder;
        }

    }
}
