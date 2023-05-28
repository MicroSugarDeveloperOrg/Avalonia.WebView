using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSUserInterfaceCompressionOptions", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class NSUserInterfaceCompressionOptions : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBreakEqualWidthsOption = "breakEqualWidthsOption";

	private static readonly IntPtr selBreakEqualWidthsOptionHandle = Selector.GetHandle("breakEqualWidthsOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsOptions_ = "containsOptions:";

	private static readonly IntPtr selContainsOptions_Handle = Selector.GetHandle("containsOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHideImagesOption = "hideImagesOption";

	private static readonly IntPtr selHideImagesOptionHandle = Selector.GetHandle("hideImagesOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHideTextOption = "hideTextOption";

	private static readonly IntPtr selHideTextOptionHandle = Selector.GetHandle("hideTextOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCompressionOptions_ = "initWithCompressionOptions:";

	private static readonly IntPtr selInitWithCompressionOptions_Handle = Selector.GetHandle("initWithCompressionOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_ = "initWithIdentifier:";

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectsOptions_ = "intersectsOptions:";

	private static readonly IntPtr selIntersectsOptions_Handle = Selector.GetHandle("intersectsOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEmpty = "isEmpty";

	private static readonly IntPtr selIsEmptyHandle = Selector.GetHandle("isEmpty");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptionsByAddingOptions_ = "optionsByAddingOptions:";

	private static readonly IntPtr selOptionsByAddingOptions_Handle = Selector.GetHandle("optionsByAddingOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptionsByRemovingOptions_ = "optionsByRemovingOptions:";

	private static readonly IntPtr selOptionsByRemovingOptions_Handle = Selector.GetHandle("optionsByRemovingOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReduceMetricsOption = "reduceMetricsOption";

	private static readonly IntPtr selReduceMetricsOptionHandle = Selector.GetHandle("reduceMetricsOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardOptions = "standardOptions";

	private static readonly IntPtr selStandardOptionsHandle = Selector.GetHandle("standardOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUserInterfaceCompressionOptions");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUserInterfaceCompressionOptions BreakEqualWidthsOption
	{
		[Export("breakEqualWidthsOption", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend(class_ptr, selBreakEqualWidthsOptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Empty
	{
		[Export("isEmpty")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEmptyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEmptyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUserInterfaceCompressionOptions HideImagesOption
	{
		[Export("hideImagesOption", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend(class_ptr, selHideImagesOptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUserInterfaceCompressionOptions HideTextOption
	{
		[Export("hideTextOption", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend(class_ptr, selHideTextOptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUserInterfaceCompressionOptions ReduceMetricsOption
	{
		[Export("reduceMetricsOption", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend(class_ptr, selReduceMetricsOptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUserInterfaceCompressionOptions StandardOptions
	{
		[Export("standardOptions", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend(class_ptr, selStandardOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUserInterfaceCompressionOptions()
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
	public NSUserInterfaceCompressionOptions(NSCoder coder)
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
	protected NSUserInterfaceCompressionOptions(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUserInterfaceCompressionOptions(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUserInterfaceCompressionOptions(string identifier)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithCompressionOptions:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUserInterfaceCompressionOptions(NSSet<NSUserInterfaceCompressionOptions> options)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCompressionOptions_Handle, options.Handle), "initWithCompressionOptions:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCompressionOptions_Handle, options.Handle), "initWithCompressionOptions:");
		}
	}

	[Export("containsOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(NSUserInterfaceCompressionOptions options)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsOptions_Handle, options.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsOptions_Handle, options.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
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

	[Export("optionsByAddingOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUserInterfaceCompressionOptions GetOptionsByAdding(NSUserInterfaceCompressionOptions options)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selOptionsByAddingOptions_Handle, options.Handle));
		}
		return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selOptionsByAddingOptions_Handle, options.Handle));
	}

	[Export("optionsByRemovingOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUserInterfaceCompressionOptions GetOptionsByRemoving(NSUserInterfaceCompressionOptions options)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selOptionsByRemovingOptions_Handle, options.Handle));
		}
		return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selOptionsByRemovingOptions_Handle, options.Handle));
	}

	[Export("intersectsOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Intersects(NSUserInterfaceCompressionOptions options)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIntersectsOptions_Handle, options.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectsOptions_Handle, options.Handle);
	}
}
