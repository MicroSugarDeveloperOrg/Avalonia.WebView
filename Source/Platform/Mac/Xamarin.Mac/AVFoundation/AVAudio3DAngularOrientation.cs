namespace AVFoundation;

public struct AVAudio3DAngularOrientation
{
    public float Yaw;

    public float Pitch;

    public float Roll;

    public override string ToString()
    {
        return $"(Yaw={Yaw},Pitch={Pitch},Roll={Roll})";
    }

    public static bool operator ==(AVAudio3DAngularOrientation left, AVAudio3DAngularOrientation right)
    {
        return left.Yaw == right.Yaw && left.Pitch == right.Pitch && left.Roll == right.Roll;
    }

    public static bool operator !=(AVAudio3DAngularOrientation left, AVAudio3DAngularOrientation right)
    {
        return left.Yaw != right.Yaw || left.Pitch != right.Pitch || left.Roll != right.Roll;
    }

    public override bool Equals(object obj)
    {
        if (!(obj is AVAudio3DAngularOrientation))
        {
            return false;
        }
        return Equals((AVAudio3DAngularOrientation)obj);
    }

    public bool Equals(AVAudio3DAngularOrientation other)
    {
        return this == other;
    }

    public override int GetHashCode()
    {
        return Yaw.GetHashCode() ^ Pitch.GetHashCode() ^ Roll.GetHashCode();
    }
}
