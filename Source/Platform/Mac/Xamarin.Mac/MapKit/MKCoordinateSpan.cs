namespace MapKit;

public struct MKCoordinateSpan
{
    public double LatitudeDelta;

    public double LongitudeDelta;

    public MKCoordinateSpan(double latitudeDelta, double longitudeDelta)
    {
        LatitudeDelta = latitudeDelta;
        LongitudeDelta = longitudeDelta;
    }

    public override string ToString()
    {
        return $"(LatitudeDelta={LatitudeDelta}, LongitudeDelta={LongitudeDelta}";
    }
}
