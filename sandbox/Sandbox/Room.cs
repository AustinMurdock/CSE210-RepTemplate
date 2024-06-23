
using System.Text;

class Room
{
    private List<SmartDevice> devices = new();

    public Room() {
        this.devices = new();
    }
    public Room(List<SmartDevice> devices) {
        // foreach (SmartDevice device in devices) {
        //     this.devices.Add(device);
        // }
        this.devices = devices;
    }

    public void ToggleAllLights() {
        foreach (SmartLight light in this.devices.OfType<SmartLight>()) {
            light.ToggleState();
        }
    }
    public void ToggleAllLights(bool setState) {
        foreach (SmartLight light in this.devices.OfType<SmartLight>()) {
            light.ToggleState(setState);
        }
    }

    public void ToggleDevice(string name) {
        foreach (SmartDevice device in this.devices) {
            if (device.GetName() == name) {
                device.ToggleState();
            }
        }
    }

    public void ToggleAllDevices() {
        foreach (SmartDevice device in this.devices) {
            device.ToggleState();
        }
    }
    public void ToggleAllDevices(bool setState) {
        foreach (SmartDevice device in this.devices) {
            device.ToggleState(setState);
        }
    }
    
    public string ReportAll() {
        string currentString = "";

        foreach (SmartDevice device in this.devices) {
            currentString += $"{device.GetName()},{device.GetState()};";
        }

        return currentString;
    }

    public string ReportAllRunning() {
        string currentString = "";

        foreach (SmartDevice device in this.devices) {
            if (device.GetState() == true) {
                currentString += $"{device.GetName()};";
            }
        }

        return currentString;
    }

    public string ReportLongestRunning() {
        float maxLength = 0;
        string maxLengthName = "";

        foreach (SmartDevice device in this.devices) {
            if (device.GetRunLength() >= maxLength) {
                maxLength = device.GetRunLength();
                maxLengthName = device.GetName();
            }
        }

        return maxLengthName;
    }

    public List<SmartDevice> GetDevices() {
        return this.devices;
    }
}