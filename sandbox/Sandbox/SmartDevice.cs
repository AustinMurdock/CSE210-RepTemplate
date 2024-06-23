
abstract class SmartDevice
{
    protected bool isRunning;
    protected float currentRunLength;
    protected string name;

    public SmartDevice(string name) {
        isRunning = false;
        currentRunLength = 0;
        this.name = name;
    }

    public void ToggleState() {
        this.isRunning = !isRunning;
    }
    public void ToggleState(bool setState) {
        this.isRunning = setState;
    }

    public bool GetState() {
        return this.isRunning;
    }

    public float GetRunLength() {
        return this.currentRunLength;
    }

    public string GetName() {
        return this.name;
    }
}