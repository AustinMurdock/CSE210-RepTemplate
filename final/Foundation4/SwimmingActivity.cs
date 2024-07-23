
class SwimmingActivity : Activity
{
    private float laps;

    public SwimmingActivity(string date, int lengthMinutes, float laps) : base(date, lengthMinutes) {
        this.laps = laps;
    }

    public override float GetDistanceKm() {
        return this.laps * 50/1000;
    }

    public override float GetSpeedKmph() {
        return this.GetDistanceKm() / base.minutes/60;
    }
}