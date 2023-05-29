using Foundation;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Xamarin.Utiles;
public static class PlatformHelper
{
    private static Platform? hostApiPlatform;

    private const int sys1 = 1937339185;

    private const int sys2 = 1937339186;

    private static int osx_major;

    private static int osx_minor;

    public static bool IsValid(this Platform platform)
    {
        switch (platform.ToMacVersion())
        {
            default:
                return false;
            case Platform.None:
            case Platform.Mac_10_0:
            case Platform.Mac_10_1:
            case Platform.Mac_10_2:
            case Platform.Mac_10_3:
            case Platform.Mac_10_4:
            case Platform.Mac_10_5:
            case Platform.Mac_10_6:
            case Platform.Mac_10_7:
            case Platform.Mac_10_8:
            case Platform.Mac_10_9:
            case Platform.Mac_10_10:
            case Platform.Mac_10_10_3:
            case Platform.Mac_10_11:
            case Platform.Mac_10_12:
            case Platform.Mac_Version:
                switch (platform.ToIosVersion())
                {
                    default:
                        return false;
                    case Platform.None:
                    case Platform.iOS_2_0:
                    case Platform.iOS_2_2:
                    case Platform.iOS_3_0:
                    case Platform.iOS_3_1:
                    case Platform.iOS_3_2:
                    case Platform.iOS_4_0:
                    case Platform.iOS_4_1:
                    case Platform.iOS_4_2:
                    case Platform.iOS_4_3:
                    case Platform.iOS_5_0:
                    case Platform.iOS_5_1:
                    case Platform.iOS_6_0:
                    case Platform.iOS_6_1:
                    case Platform.iOS_7_0:
                    case Platform.iOS_7_1:
                    case Platform.iOS_8_0:
                    case Platform.iOS_8_1:
                    case Platform.iOS_8_2:
                    case Platform.iOS_8_3:
                    case Platform.iOS_8_4:
                    case Platform.iOS_9_0:
                    case Platform.iOS_9_1:
                    case Platform.iOS_9_2:
                    case Platform.iOS_Version:
                        return true;
                }
        }
    }

    public static Platform ToVersion(this Platform platform)
    {
        return platform & (Platform.iOS_Version | Platform.Mac_Version);
    }

    public static Platform ToMacVersion(this Platform platform)
    {
        return platform & Platform.Mac_Version;
    }

    public static Platform ToIosVersion(this Platform platform)
    {
        return platform & Platform.iOS_Version;
    }

    public static Platform ToArch(this Platform platform)
    {
        return platform & (Platform.Mac_Arch | Platform.iOS_Arch);
    }

    public static Platform ToMacArch(this Platform platform)
    {
        return platform & Platform.Mac_Arch;
    }

    public static Platform ToIosArch(this Platform platform)
    {
        return platform & Platform.iOS_Arch;
    }

    public static int CompareMacVersion(this Platform a, Platform b)
    {
        return ((ulong)a.ToMacVersion()).CompareTo((ulong)b.ToMacVersion());
    }

    public static int CompareIosVersion(this Platform a, Platform b)
    {
        return ((uint)a.ToIosVersion()).CompareTo((uint)b.ToIosVersion());
    }

    public static bool IsMac(this Platform platform)
    {
        return platform.ToMacVersion() != Platform.None;
    }

    public static bool IsIos(this Platform platform)
    {
        return platform.ToIosVersion() != Platform.None;
    }

    public static bool Is64BitOnlyOnCurrentPlatform(this Platform platform)
    {
        return platform.ToMacArch() == Platform.Mac_Arch64;
    }

    public static Platform GetHostApiPlatform()
    {
        if (hostApiPlatform.HasValue && hostApiPlatform.HasValue)
        {
            return hostApiPlatform.Value;
        }
        using NSDictionary nSDictionary = NSDictionary.FromFile("/System/Library/CoreServices/SystemVersion.plist");
        Platform? platform = (hostApiPlatform = ParseApiPlatform((NSString)nSDictionary["ProductName"], (NSString)nSDictionary["ProductVersion"]));
        return platform.Value;
    }

    public static Platform ParseApiPlatform(string productName, string productVersion)
    {
        if (productName == null)
        {
            throw new ArgumentNullException("productName");
        }
        if (productVersion == null)
        {
            throw new ArgumentNullException("productVersion");
        }
        string text = productName.Replace(" ", string.Empty).ToLowerInvariant();
        string[] array = productVersion.Split(new char[] { '.' }, StringSplitOptions.None);
        CultureInfo invariantCulture = CultureInfo.InvariantCulture;
        if (!byte.TryParse(array[0], NumberStyles.Integer, invariantCulture, out var result) || !byte.TryParse(array[1], NumberStyles.Integer, invariantCulture, out var result2))
        {
            throw new FormatException("Bad version format: " + productVersion);
        }
        if (text.StartsWith("mac", StringComparison.Ordinal))
        {
            return (Platform)(((ulong)result << 48) | ((ulong)result2 << 40));
        }
        if (text.StartsWith("iphone", StringComparison.Ordinal) || text.StartsWith("ios", StringComparison.Ordinal))
        {
            return (Platform)(((ulong)result << 16) | ((ulong)result2 << 8));
        }
        throw new FormatException("Unknown product name: " + productName);
    }

    [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
    private static extern int Gestalt(int selector, out int result);

    public static bool CheckSystemVersion(int major, int minor)
    {
        if (osx_major == 0)
        {
            Gestalt(1937339185, out osx_major);
            Gestalt(1937339186, out osx_minor);
        }
        return osx_major > major || (osx_major == major && osx_minor >= minor);
    }
}