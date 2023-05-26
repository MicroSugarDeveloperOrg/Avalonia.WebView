using ObjCRuntime;
using System.Runtime.InteropServices;
using System.Text;

namespace Utils;
internal class MarshalHelper
{
    internal static IntPtr NativeUtf8FromString(string managedString)
    {
        byte[] array = new byte[Encoding.UTF8.GetByteCount(managedString) + 1];
        Encoding.UTF8.GetBytes(managedString, 0, managedString.Length, array, 0);
        IntPtr intPtr = Marshal.AllocHGlobal(array.Length);
        Marshal.Copy(array, 0, intPtr, array.Length);
        return intPtr;
    }

    internal static string StringFromNativeUtf8(IntPtr nativeUtf8)
    {
        int i;
        for (i = 0; Marshal.ReadByte(nativeUtf8, i) != 0; i++)
        {
        }
        byte[] array = new byte[i];
        Marshal.Copy(nativeUtf8, array, 0, array.Length);
        return Encoding.UTF8.GetString(array);
    }

    public unsafe static string PtrToStringUTF8(IntPtr ptr)
    {
        return StringFromNativeUtf8(ptr);
    }

    public unsafe static string PtrToStringUTF8(IntPtr ptr, int byteLength)
    {
        byte* pBuffer = (byte*)ptr.ToPointer();
        return Encoding.UTF8.GetString(pBuffer, byteLength);
    }
}
