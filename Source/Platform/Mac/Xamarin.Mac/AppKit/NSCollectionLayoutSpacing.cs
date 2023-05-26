using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionLayoutSpacing", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionLayoutSpacing : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFixedSpacing_ = "fixedSpacing:";

	private static readonly IntPtr selFixedSpacing_Handle = Selector.GetHandle("fixedSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlexibleSpacing_ = "flexibleSpacing:";

	private static readonly IntPtr selFlexibleSpacing_Handle = Selector.GetHandle("flexibleSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFixedSpacing = "isFixedSpacing";

	private static readonly IntPtr selIsFixedSpacingHandle = Selector.GetHandle("isFixedSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFlexibleSpacing = "isFlexibleSpacing";

	private static readonly IntPtr selIsFlexibleSpacingHandle = Selector.GetHandle("isFlexibleSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpacing = "spacing";

	private static readonly IntPtr selSpacingHandle = Selector.GetHandle("spacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionLayoutSpacing");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFixedSpacing
	{
		[Export("isFixedSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFixedSpacingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFixedSpacingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFlexibleSpacing
	{
		[Export("isFlexibleSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlexibleSpacingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlexibleSpacingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Spacing
	{
		[Export("spacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selSpacingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionLayoutSpacing(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionLayoutSpacing(IntPtr handle)
		: base(handle)
	{
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

	[Export("fixedSpacing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutSpacing CreateFixedSpacing(nfloat fixedSpacing)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selFixedSpacing_Handle, fixedSpacing));
	}

	[Export("flexibleSpacing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutSpacing CreateFlexibleSpacing(nfloat flexibleSpacing)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selFlexibleSpacing_Handle, flexibleSpacing));
	}
}
