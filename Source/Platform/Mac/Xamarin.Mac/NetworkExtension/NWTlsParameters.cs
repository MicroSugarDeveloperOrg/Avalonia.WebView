using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace NetworkExtension;

[Register("NWTLSParameters", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NWTlsParameters : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSSLCipherSuites = "SSLCipherSuites";

	private static readonly IntPtr selSSLCipherSuitesHandle = Selector.GetHandle("SSLCipherSuites");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTLSSessionID = "TLSSessionID";

	private static readonly IntPtr selTLSSessionIDHandle = Selector.GetHandle("TLSSessionID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumSSLProtocolVersion = "maximumSSLProtocolVersion";

	private static readonly IntPtr selMaximumSSLProtocolVersionHandle = Selector.GetHandle("maximumSSLProtocolVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumSSLProtocolVersion = "minimumSSLProtocolVersion";

	private static readonly IntPtr selMinimumSSLProtocolVersionHandle = Selector.GetHandle("minimumSSLProtocolVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumSSLProtocolVersion_ = "setMaximumSSLProtocolVersion:";

	private static readonly IntPtr selSetMaximumSSLProtocolVersion_Handle = Selector.GetHandle("setMaximumSSLProtocolVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumSSLProtocolVersion_ = "setMinimumSSLProtocolVersion:";

	private static readonly IntPtr selSetMinimumSSLProtocolVersion_Handle = Selector.GetHandle("setMinimumSSLProtocolVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSSLCipherSuites_ = "setSSLCipherSuites:";

	private static readonly IntPtr selSetSSLCipherSuites_Handle = Selector.GetHandle("setSSLCipherSuites:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTLSSessionID_ = "setTLSSessionID:";

	private static readonly IntPtr selSetTLSSessionID_Handle = Selector.GetHandle("setTLSSessionID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NWTLSParameters");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MaximumSslProtocolVersion
	{
		[Export("maximumSSLProtocolVersion", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMaximumSSLProtocolVersionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMaximumSSLProtocolVersionHandle);
		}
		[Export("setMaximumSSLProtocolVersion:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMaximumSSLProtocolVersion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMaximumSSLProtocolVersion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MinimumSslProtocolVersion
	{
		[Export("minimumSSLProtocolVersion", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMinimumSSLProtocolVersionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMinimumSSLProtocolVersionHandle);
		}
		[Export("setMinimumSSLProtocolVersion:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMinimumSSLProtocolVersion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMinimumSSLProtocolVersion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet<NSNumber>? SslCipherSuites
	{
		[Export("SSLCipherSuites", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet<NSNumber>>(Messaging.IntPtr_objc_msgSend(base.Handle, selSSLCipherSuitesHandle));
			}
			return Runtime.GetNSObject<NSSet<NSNumber>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSSLCipherSuitesHandle));
		}
		[Export("setSSLCipherSuites:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSSLCipherSuites_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSSLCipherSuites_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? TlsSessionID
	{
		[Export("TLSSessionID", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selTLSSessionIDHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTLSSessionIDHandle));
		}
		[Export("setTLSSessionID:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTLSSessionID_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTLSSessionID_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NWTlsParameters()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NWTlsParameters(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NWTlsParameters(IntPtr handle)
		: base(handle)
	{
	}
}
