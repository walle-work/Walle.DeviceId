# Walle.DeviceId

Create unique device id by hardware.

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

