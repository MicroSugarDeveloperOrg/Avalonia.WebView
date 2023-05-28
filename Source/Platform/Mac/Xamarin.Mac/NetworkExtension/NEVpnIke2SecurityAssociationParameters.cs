using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEVPNIKEv2SecurityAssociationParameters", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NEVpnIke2SecurityAssociationParameters : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiffieHellmanGroup = "diffieHellmanGroup";

	private static readonly IntPtr selDiffieHellmanGroupHandle = Selector.GetHandle("diffieHellmanGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncryptionAlgorithm = "encryptionAlgorithm";

	private static readonly IntPtr selEncryptionAlgorithmHandle = Selector.GetHandle("encryptionAlgorithm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntegrityAlgorithm = "integrityAlgorithm";

	private static readonly IntPtr selIntegrityAlgorithmHandle = Selector.GetHandle("integrityAlgorithm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLifetimeMinutes = "lifetimeMinutes";

	private static readonly IntPtr selLifetimeMinutesHandle = Selector.GetHandle("lifetimeMinutes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDiffieHellmanGroup_ = "setDiffieHellmanGroup:";

	private static readonly IntPtr selSetDiffieHellmanGroup_Handle = Selector.GetHandle("setDiffieHellmanGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEncryptionAlgorithm_ = "setEncryptionAlgorithm:";

	private static readonly IntPtr selSetEncryptionAlgorithm_Handle = Selector.GetHandle("setEncryptionAlgorithm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIntegrityAlgorithm_ = "setIntegrityAlgorithm:";

	private static readonly IntPtr selSetIntegrityAlgorithm_Handle = Selector.GetHandle("setIntegrityAlgorithm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLifetimeMinutes_ = "setLifetimeMinutes:";

	private static readonly IntPtr selSetLifetimeMinutes_Handle = Selector.GetHandle("setLifetimeMinutes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEVPNIKEv2SecurityAssociationParameters");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEVpnIke2DiffieHellman DiffieHellmanGroup
	{
		[Export("diffieHellmanGroup")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NEVpnIke2DiffieHellman)Messaging.Int64_objc_msgSend(base.Handle, selDiffieHellmanGroupHandle);
			}
			return (NEVpnIke2DiffieHellman)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDiffieHellmanGroupHandle);
		}
		[Export("setDiffieHellmanGroup:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDiffieHellmanGroup_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDiffieHellmanGroup_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEVpnIke2EncryptionAlgorithm EncryptionAlgorithm
	{
		[Export("encryptionAlgorithm")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NEVpnIke2EncryptionAlgorithm)Messaging.Int64_objc_msgSend(base.Handle, selEncryptionAlgorithmHandle);
			}
			return (NEVpnIke2EncryptionAlgorithm)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEncryptionAlgorithmHandle);
		}
		[Export("setEncryptionAlgorithm:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetEncryptionAlgorithm_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetEncryptionAlgorithm_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEVpnIke2IntegrityAlgorithm IntegrityAlgorithm
	{
		[Export("integrityAlgorithm")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NEVpnIke2IntegrityAlgorithm)Messaging.Int64_objc_msgSend(base.Handle, selIntegrityAlgorithmHandle);
			}
			return (NEVpnIke2IntegrityAlgorithm)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selIntegrityAlgorithmHandle);
		}
		[Export("setIntegrityAlgorithm:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetIntegrityAlgorithm_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetIntegrityAlgorithm_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int LifetimeMinutes
	{
		[Export("lifetimeMinutes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLifetimeMinutesHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLifetimeMinutesHandle);
		}
		[Export("setLifetimeMinutes:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetLifetimeMinutes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetLifetimeMinutes_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NEVpnIke2SecurityAssociationParameters()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NEVpnIke2SecurityAssociationParameters(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEVpnIke2SecurityAssociationParameters(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEVpnIke2SecurityAssociationParameters(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}
