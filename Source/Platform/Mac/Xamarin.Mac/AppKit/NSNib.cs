using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSNib", true)]
public class NSNib : NSObject, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_ = "initWithContentsOfURL:";

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibData_Bundle_ = "initWithNibData:bundle:";

	private static readonly IntPtr selInitWithNibData_Bundle_Handle = Selector.GetHandle("initWithNibData:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibNamed_Bundle_ = "initWithNibNamed:bundle:";

	private static readonly IntPtr selInitWithNibNamed_Bundle_Handle = Selector.GetHandle("initWithNibNamed:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstantiateNibWithExternalNameTable_ = "instantiateNibWithExternalNameTable:";

	private static readonly IntPtr selInstantiateNibWithExternalNameTable_Handle = Selector.GetHandle("instantiateNibWithExternalNameTable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstantiateWithOwner_TopLevelObjects_ = "instantiateWithOwner:topLevelObjects:";

	private static readonly IntPtr selInstantiateWithOwner_TopLevelObjects_Handle = Selector.GetHandle("instantiateWithOwner:topLevelObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSNib");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNib()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSNib(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSNib(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSNib(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentsOfURL:")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNib(NSUrl nibFileUrl)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (nibFileUrl == null)
		{
			throw new ArgumentNullException("nibFileUrl");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, nibFileUrl.Handle), "initWithContentsOfURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, nibFileUrl.Handle), "initWithContentsOfURL:");
		}
	}

	[Export("initWithNibNamed:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNib(string nibName, NSBundle? bundle)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (nibName == null)
		{
			throw new ArgumentNullException("nibName");
		}
		IntPtr arg = NSString.CreateNative(nibName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibNamed_Bundle_Handle, arg, bundle?.Handle ?? IntPtr.Zero), "initWithNibNamed:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibNamed_Bundle_Handle, arg, bundle?.Handle ?? IntPtr.Zero), "initWithNibNamed:bundle:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithNibData:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNib(NSData nibData, NSBundle bundle)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (nibData == null)
		{
			throw new ArgumentNullException("nibData");
		}
		if (bundle == null)
		{
			throw new ArgumentNullException("bundle");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibData_Bundle_Handle, nibData.Handle, bundle.Handle), "initWithNibData:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibData_Bundle_Handle, nibData.Handle, bundle.Handle), "initWithNibData:bundle:");
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
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

	[Export("instantiateNibWithExternalNameTable:")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InstantiateNib(NSDictionary externalNameTable)
	{
		NSApplication.EnsureUIThread();
		if (externalNameTable == null)
		{
			throw new ArgumentNullException("externalNameTable");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selInstantiateNibWithExternalNameTable_Handle, externalNameTable.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selInstantiateNibWithExternalNameTable_Handle, externalNameTable.Handle);
	}

	[Export("instantiateWithOwner:topLevelObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InstantiateNibWithOwner(NSObject? owner, out NSArray topLevelObjects)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInstantiateWithOwner_TopLevelObjects_Handle, owner?.Handle ?? IntPtr.Zero, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInstantiateWithOwner_TopLevelObjects_Handle, owner?.Handle ?? IntPtr.Zero, ref arg));
		topLevelObjects = Runtime.GetNSObject<NSArray>(arg);
		return result;
	}
}
