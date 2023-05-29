using Foundation;
using System.Runtime.InteropServices;

namespace Xamarin.Utiles;
internal class LogHelper
{
    [DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSLog")]
    private static extern void NSLog_impl(IntPtr format, [MarshalAs(UnmanagedType.LPStr)] string s);

    internal static void NSLog(string format, params object[] args)
    {
        IntPtr intPtr = NSString.CreateNative("%s");
        string s = ((args == null || args.Length == 0) ? format : string.Format(format, args));
        NSLog(intPtr, s);
        NSString.ReleaseNative(intPtr);
    }

    private static void NSLog(IntPtr format, string s)
    {
        if (PlatformHelper.CheckSystemVersion(10, 12))
            Console.WriteLine(s);
        else
            NSLog_impl(format, s);
    }
}
