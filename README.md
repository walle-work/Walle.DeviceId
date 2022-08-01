# Walle.DeviceId

Create unique device id by hardware.

[![dotNetStandard](https://github.com/walle-work/Walle.DeviceId/actions/workflows/NetStandard.yml/badge.svg)](https://github.com/walle-work/Walle.DeviceId/actions/workflows/NetStandard.yml)
---

sample:

```csharp
 var deviceId = DeviceIdBuilder.CreateBuilder()
                  .UseBaseBoard()
                  .UseProcessor()
                  .UseHarddisk()
                  .UseBIOS()
                  .Build();
```

