namespace Depedency;

public class Switch //SWITCH INI BISA DI PAKAI DI PC, maka ganti bulb
{

    private IDevice _device;

    #region  LAWAS
    // private LightBulb _bulb = new();
    //kalau punya private, maka aksesnya pake method yg public.

    #endregion

    public Switch(IDevice device)
    {
        _device = device;
    }
    public void Operate()
    {
        _device.TurnOn();
        // _bulb.TurnOn();
    }
}
