using ObjCRuntime;

namespace AVFoundation;

[iOS(9, 0)]
[Mac(10, 11)]
public struct AVAudioConverterPrimeInfo
{
    public uint LeadingFrames;

    public uint TrailingFrames;

    public AVAudioConverterPrimeInfo(uint leadingFrames, uint trailingFrames)
    {
        LeadingFrames = leadingFrames;
        TrailingFrames = trailingFrames;
    }

    public override string ToString()
    {
        return $"({LeadingFrames}:{TrailingFrames})";
    }

    public static bool operator ==(AVAudioConverterPrimeInfo left, AVAudioConverterPrimeInfo right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(AVAudioConverterPrimeInfo left, AVAudioConverterPrimeInfo right)
    {
        return !left.Equals(right);
    }

    public override bool Equals(object obj)
    {
        if (!(obj is AVAudioConverterPrimeInfo))
        {
            return false;
        }
        return Equals((AVAudioConverterPrimeInfo)obj);
    }

    public bool Equals(AVAudioConverterPrimeInfo other)
    {
        return LeadingFrames == other.LeadingFrames && TrailingFrames == other.TrailingFrames;
    }

    public override int GetHashCode()
    {
        return LeadingFrames.GetHashCode() ^ TrailingFrames.GetHashCode();
    }
}