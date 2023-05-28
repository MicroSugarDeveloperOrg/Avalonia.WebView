using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Security;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(5, 0)]
public class SecCertificate2 : NativeObject
{
	public SecCertificate Certificate => new SecCertificate(sec_certificate_copy_ref(GetCheckedHandle()), owns: true);

	public SecCertificate2(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr sec_certificate_create(IntPtr seccertificateHandle);

	public SecCertificate2(SecCertificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		InitializeHandle(sec_certificate_create(certificate.Handle));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr sec_certificate_copy_ref(IntPtr handle);
}
