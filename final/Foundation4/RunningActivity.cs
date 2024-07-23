
class RunningActivity : Activity
{
    private float distance;

    public RunningActivity(string date, int lengthMinutes, float distance) : base(date, lengthMinutes) {
        this.distance = distance;
    }

    public override float GetDistanceKm() {
        return this.distance;
    }

    public override float GetSpeedKmph() {
        return distance / base.minutes;
    }
}