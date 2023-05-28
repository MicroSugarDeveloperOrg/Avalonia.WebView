using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Security;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(5, 0)]
public class SecTrust2 : NativeObject
{
	public SecTrust Trust => new SecTrust(sec_trust_copy_ref(GetCheckedHandle()), owns: true);

	internal SecTrust2(IntPtr handle)
		: base(handle, owns: false)
	{
	}

	public SecTrust2(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr sec_trust_create(IntPtr sectrustHandle);

	public SecTrust2(SecTrust trust)
	{
		if (trust == null)
		{
			throw new ArgumentNullException("trust");
		}
		base.Handle = sec_trust_create(trust.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr sec_trust_copy_ref(IntPtr handle);
}
