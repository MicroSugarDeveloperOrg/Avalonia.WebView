using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(5, 0)]
public class SecIdentity2 : NativeObject
{
	internal delegate void AccessCertificatesHandler(IntPtr block, IntPtr cert);

	private static readonly AccessCertificatesHandler access = TrampolineAccessCertificates;

	public SecIdentity Identity => new SecIdentity(sec_identity_copy_ref(GetCheckedHandle()), owns: true);

	public SecCertificate[] Certificates
	{
		get
		{
			IntPtr obj = sec_identity_copy_certificates_ref(GetCheckedHandle());
			int num = (int)NSArray.GetCount(obj);
			SecCertificate[] array = new SecCertificate[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new SecCertificate(NSArray.GetAtIndex(obj, (nuint)i), owns: false);
			}
			CFObject.CFRelease(obj);
			return array;
		}
	}

	internal SecIdentity2(IntPtr handle)
		: base(handle, owns: false)
	{
	}

	public SecIdentity2(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr sec_identity_create(IntPtr secidentityHandle);

	public SecIdentity2(SecIdentity identity)
	{
		if (identity == null)
		{
			throw new ArgumentNullException("identity");
		}
		InitializeHandle(sec_identity_create(identity.Handle));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr sec_identity_create_with_certificates(IntPtr secidentityHandle, IntPtr arrayHandle);

	public SecIdentity2(SecIdentity identity, params SecCertificate[] certificates)
	{
		if (identity == null)
		{
			throw new ArgumentNullException("identity");
		}
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		using NSArray nSArray = NSArray.FromObjects(certificates);
		InitializeHandle(sec_identity_create_with_certificates(identity.Handle, nSArray.Handle));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr sec_identity_copy_ref(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr sec_identity_copy_certificates_ref(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern bool sec_identity_access_certificates(IntPtr identity, ref BlockLiteral block);

	[MonoPInvokeCallback(typeof(AccessCertificatesHandler))]
	private static void TrampolineAccessCertificates(IntPtr block, IntPtr cert)
	{
		BlockLiteral.GetTarget<Action<SecCertificate2>>(block)?.Invoke(new SecCertificate2(cert, owns: false));
	}

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public bool AccessCertificates(Action<SecCertificate2> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral block = default(BlockLiteral);
		try
		{
			block.SetupBlockUnsafe(access, handler);
			return sec_identity_access_certificates(GetCheckedHandle(), ref block);
		}
		finally
		{
			block.CleanupBlock();
		}
	}
}
