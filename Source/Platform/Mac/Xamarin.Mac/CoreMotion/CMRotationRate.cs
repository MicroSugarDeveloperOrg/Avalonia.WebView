namespace CoreMotion;
public struct CMRotationRate
{
    public double x;

    public double y;

    public double z;

    public CMRotationRate(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()
    {
        return $"rotationRate=({x},{y},{z}";
    }
}