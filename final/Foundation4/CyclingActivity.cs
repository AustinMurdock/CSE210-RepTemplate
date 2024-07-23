
class CyclingActivity : Activity
{
    private float speed;

    public CyclingActivity(string date, int lengthMinutes, float speed) : base(date, lengthMinutes) {
        this.speed = speed;
    }

    public override float GetDistanceKm() {
        return this.speed * base.minutes/60;
    }

    public override float GetSpeedKmph() {
        return this.speed;
    }
}