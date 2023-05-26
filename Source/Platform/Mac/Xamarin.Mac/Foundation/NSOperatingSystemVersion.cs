namespace Foundation;
public struct NSOperatingSystemVersion
{
    public nint Major;

    public nint Minor;

    public nint PatchVersion;

    public NSOperatingSystemVersion(nint major, nint minor, nint patchVersion)
    {
        Major = major;
        Minor = minor;
        PatchVersion = patchVersion;
    }

    public override string ToString()
    {
        string[] array = new string[5];
        nint major = Major;
        array[0] = major.ToString();
        array[1] = ".";
        major = Minor;
        array[2] = major.ToString();
        array[3] = ".";
        major = PatchVersion;
        array[4] = major.ToString();
        return string.Concat(array);
    }
}