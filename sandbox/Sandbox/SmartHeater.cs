
class SmartHeater : SmartDevice
{
    // also not required:
    private float currentTemp;
    private float requestedTemp;

    public SmartHeater(string name) : base(name) {
        // only activate temps when set by user
    }
}