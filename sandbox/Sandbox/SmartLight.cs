
class SmartLight : SmartDevice
{
    // there's probably a better way to set this up, 
    // but neither of these are required anyway:
    private float brightness;
    private List<int> rgb = new();

    public SmartLight(string name) : base(name) {
        this.brightness = 0;
        this.rgb = new([0, 0, 0]);
    }
}