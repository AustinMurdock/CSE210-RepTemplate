
class SmartTv : SmartDevice
{
    // also not required:
    private string currentMode;
    private string channel;
    private int volume;

    public SmartTv(string name) : base(name) {
        this.currentMode = "display";
        this.channel = "";
        this.volume = 28;
    }
}