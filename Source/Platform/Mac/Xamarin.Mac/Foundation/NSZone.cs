using ObjCRuntime;
using System.Runtime.InteropServices;

namespace Foundation;
public class NSZone : INativeObject
{
    public static readonly NSZone Default = new NSZone(NSDefaultMallocZone());

    internal NSZone()
    {
    }

    public NSZone(IntPtr handle)
    {
        Handle = handle;
    }

    [Preserve(Conditional = true)]
    public NSZone(IntPtr handle, bool owns)
        : this(handle)
    {
    }

    public IntPtr Handle { get; private set; }

    public string Name
    {
        get
        {
            return new NSString(NSZoneName(Handle)).ToString();
        }
        set
        {
            using NSString nSString = new NSString(value);
            NSSetZoneName(Handle, nSString.Handle);
        }
    }

    [DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
    private static extern IntPtr NSDefaultMallocZone();

    [DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
    private static extern IntPtr NSZoneName(IntPtr zone);

    [DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
    private static extern void NSSetZoneName(IntPtr zone, IntPtr name);
}