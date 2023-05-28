using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[iOS(8, 0)]
[TV(10, 2)]
public class VTSession : INativeObject, IDisposable
{
	private IntPtr handle;

	public IntPtr Handle => handle;

	protected internal VTSession(IntPtr handle)
	{
		this.handle = handle;
		CFObject.CFRetain(this.handle);
	}

	[Preserve(Conditional = true)]
	internal VTSession(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(this.handle);
		}
	}

	~VTSession()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTSessionSetProperty(IntPtr handle, IntPtr propertyKey, IntPtr value);

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTSessionCopyProperty(IntPtr handle, IntPtr propertyKey, IntPtr allocator, out IntPtr propertyValueOut);

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	internal static extern VTStatus VTSessionSetProperties(IntPtr handle, IntPtr propertyDictionary);

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTSessionCopySerializableProperties(IntPtr handle, IntPtr allocator, out IntPtr dictionaryOut);

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTSessionCopySupportedPropertyDictionary(IntPtr session, out IntPtr supportedPropertyDictionaryOut);

	public VTStatus SetProperties(VTPropertyOptions options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return VTSessionSetProperties(handle, options.Dictionary.Handle);
	}

	public VTStatus SetProperty(NSString propertyKey, NSObject value)
	{
		if (propertyKey == null)
		{
			throw new ArgumentNullException("propertyKey");
		}
		return VTSessionSetProperty(handle, propertyKey.Handle, value?.Handle ?? IntPtr.Zero);
	}

	public VTPropertyOptions GetProperties()
	{
		if (VTSessionCopySerializableProperties(handle, IntPtr.Zero, out var dictionaryOut) != 0 || dictionaryOut == IntPtr.Zero)
		{
			return null;
		}
		NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(dictionaryOut);
		return new VTPropertyOptions(nSObject);
	}

	public NSObject GetProperty(NSString propertyKey)
	{
		if (propertyKey == null)
		{
			throw new ArgumentNullException("propertyKey");
		}
		if (VTSessionCopyProperty(handle, propertyKey.Handle, IntPtr.Zero, out var propertyValueOut) != 0 || propertyValueOut == IntPtr.Zero)
		{
			return null;
		}
		NSObject nSObject = Runtime.GetNSObject(propertyValueOut);
		nSObject.DangerousRelease();
		return nSObject;
	}

	public NSDictionary GetSerializableProperties()
	{
		if (VTSessionCopySerializableProperties(Handle, IntPtr.Zero, out var dictionaryOut) != 0 || dictionaryOut == IntPtr.Zero)
		{
			return null;
		}
		NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(dictionaryOut);
		nSObject.DangerousRelease();
		return nSObject;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDictionary GetSupportedProperties()
	{
		if (VTSessionCopySupportedPropertyDictionary(Handle, out var supportedPropertyDictionaryOut) != 0 || supportedPropertyDictionaryOut == IntPtr.Zero)
		{
			return null;
		}
		NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(supportedPropertyDictionaryOut);
		nSObject.DangerousRelease();
		return nSObject;
	}
}
