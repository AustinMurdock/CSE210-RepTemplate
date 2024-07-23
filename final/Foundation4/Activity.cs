
abstract class Activity
{
    private string date;
    protected int minutes;

    public Activity(string date, int lengthMinutes) {
        this.date = date;
        this.minutes = lengthMinutes;
    }

    public abstract float GetDistanceKm();

    public abstract float GetSpeedKmph();

    public float GetPaceMPKm() {
        return this.GetSpeedKmph() / this.GetDistanceKm();
    }

    public string GetSummary() {
        return $"{this.date} {this.GetType} ({this.minutes}): Distance {Math.Round(this.GetDistanceKm(), 2)} km, Speed {Math.Round(this.GetSpeedKmph(), 2)} kph, Pace {Math.Round(this.GetPaceMPKm(), 2)} min per km";
    }
}