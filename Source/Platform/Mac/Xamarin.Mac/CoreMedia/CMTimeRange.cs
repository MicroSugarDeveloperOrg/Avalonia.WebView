using Foundation;
using ObjCRuntime;
using System.Runtime.InteropServices;

namespace CoreMedia;

[Watch(6, 0)]
public struct CMTimeRange
{
    public CMTime Start;

    public CMTime Duration;

    public static readonly CMTimeRange Zero;

    [Obsolete("Use 'InvalidRange'.")]
    public static readonly CMTimeRange Invalid;

    public static readonly CMTimeRange InvalidRange;

    [iOS(9, 0)]
    [Mac(10, 11)]
    public static readonly CMTimeRange InvalidMapping;

    [iOS(9, 0)]
    [Mac(10, 11)]
    public static NSString TimeMappingSourceKey { get; private set; }

    [iOS(9, 0)]
    [Mac(10, 11)]
    public static NSString TimeMappingTargetKey { get; private set; }

    static CMTimeRange()
    {
        IntPtr handle = Libraries.CoreMedia.Handle;
        IntPtr ptr = Dlfcn.dlsym(handle, "kCMTimeRangeZero");
        Zero = (CMTimeRange)Marshal.PtrToStructure(ptr, typeof(CMTimeRange));
        IntPtr ptr2 = Dlfcn.dlsym(handle, "kCMTimeRangeInvalid");
        Invalid = (CMTimeRange)Marshal.PtrToStructure(ptr2, typeof(CMTimeRange));
        InvalidRange = (CMTimeRange)Marshal.PtrToStructure(ptr2, typeof(CMTimeRange));
        IntPtr intPtr = Dlfcn.dlsym(handle, "kCMTimeMappingInvalid");
        if (intPtr != IntPtr.Zero)
        {
            InvalidMapping = (CMTimeRange)Marshal.PtrToStructure(intPtr, typeof(CMTimeRange));
        }
        TimeMappingSourceKey = Dlfcn.GetStringConstant(handle, "kCMTimeMappingSourceKey");
        TimeMappingTargetKey = Dlfcn.GetStringConstant(handle, "kCMTimeMappingTargetKey");
    }
}