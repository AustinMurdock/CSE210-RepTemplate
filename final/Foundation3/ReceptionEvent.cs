
class ReceptionEvent : Event
{
    private string email;

    public ReceptionEvent(string eventTitle, string description, string date, string time, Address address, string rsvpEmail) : base(eventTitle, description, date, time, address) {
        this.email = rsvpEmail;
    }
    public ReceptionEvent(string eventTitle, string description, string date, string time, string streetAddress, string city, string stateOrProvince, string country, string rsvpEmail) : base(eventTitle, description, date, time, streetAddress, city, stateOrProvince, country) {
        this.email = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        // "Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather."
        return $"{this.GetType()}: {base.GetStandardDetails()} - RSVP with {this.email}";
    }
}