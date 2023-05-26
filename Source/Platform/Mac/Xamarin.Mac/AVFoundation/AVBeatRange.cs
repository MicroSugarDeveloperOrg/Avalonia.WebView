namespace AVFoundation;

[iOS(9, 0)]
[Mac(10, 11)]
public struct AVBeatRange
{
    public double Start;

    public double Length;

    public AVBeatRange(double startBeat, double lengthInBeats)
    {
        Start = startBeat;
        Length = lengthInBeats;
    }

    public override string ToString()
    {
        return $"(Start={Start},Length={Length})";
    }

    public static bool operator ==(AVBeatRange left, AVBeatRange right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(AVBeatRange left, AVBeatRange right)
    {
        return !left.Equals(right);
    }

    public override bool Equals(object obj)
    {
        if (!(obj is AVBeatRange))
        {
            return false;
        }
        return Equals((AVBeatRange)obj);
    }

    public bool Equals(AVBeatRange other)
    {
        return Start == other.Start && Length == other.Length;
    }

    public override int GetHashCode()
    {
        return Start.GetHashCode() ^ Length.GetHashCode();
    }
}