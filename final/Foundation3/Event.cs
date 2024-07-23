
abstract class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public Event(string eventTitle, string description, string date, string time, Address address) {
        this.title = eventTitle;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }
    public Event(string eventTitle, string description, string date, string time, string streetAddress, string city, string stateOrProvince, string country) {
        this.title = eventTitle;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = new Address(streetAddress, city, stateOrProvince, country);
    }

    public string GetStandardDetails() {
        // "Standard details - Lists the title, description, date, time, and address."
        return $"{this.title}: {this.description} - {this.date}, @ {this.time} {this.address.GetAllInlineF()}";
    }
    
    public virtual string GetFullDetails() {
        // "Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather."
        return $"{this.GetType()}: {this.GetStandardDetails()}";
    }

    public string GetShortDetails() {
        // "Short description - Lists the type of event, title, and the date."
        return $"{this.GetType()}: {this.title} - {this.date}";
    }

}