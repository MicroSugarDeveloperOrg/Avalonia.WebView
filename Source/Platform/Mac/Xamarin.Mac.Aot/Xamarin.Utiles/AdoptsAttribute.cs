using System;
using System.Runtime.InteropServices;

namespace Xamarin.Utiles;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class AdoptsAttribute : Attribute
{
    private IntPtr handle;

    public string ProtocolType { get; private set; }

    public IntPtr ProtocolHandle
    {
        get
        {
            if (handle == IntPtr.Zero && ProtocolType != null)
            {
                handle = objc_getProtocol(ProtocolType);
            }
            return handle;
        }
    }

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern IntPtr objc_getProtocol(string proto);

    public AdoptsAttribute(string protocolType)
    {
        ProtocolType = protocolType;
    }
}
