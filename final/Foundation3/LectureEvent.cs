
class LectureEvent : Event
{
    private string name;
    private int capacity;

    public LectureEvent(string eventTitle, string description, string date, string time, Address address, string speakerName, int attendanceCapacity) : base(eventTitle, description, date, time, address) {
        this.name = speakerName;
        this.capacity = attendanceCapacity;
    }
    public LectureEvent(string eventTitle, string description, string date, string time, string streetAddress, string city, string stateOrProvince, string country, string speakerName, int attendanceCapacity) : base(eventTitle, description, date, time, streetAddress, city, stateOrProvince, country) {
        this.name = speakerName;
        this.capacity = attendanceCapacity;
    }

    public override string GetFullDetails()
    {
        // "Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather."
        return $"{this.GetType()}: {base.GetStandardDetails()} - Capacity {this.capacity}, Speaker: {this.name}";
    }
}