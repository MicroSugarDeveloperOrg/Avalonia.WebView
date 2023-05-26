using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionLayoutDimension", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionLayoutDimension : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAbsoluteDimension_ = "absoluteDimension:";

	private static readonly IntPtr selAbsoluteDimension_Handle = Selector.GetHandle("absoluteDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDimension = "dimension";

	private static readonly IntPtr selDimensionHandle = Selector.GetHandle("dimension");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimatedDimension_ = "estimatedDimension:";

	private static readonly IntPtr selEstimatedDimension_Handle = Selector.GetHandle("estimatedDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFractionalHeightDimension_ = "fractionalHeightDimension:";

	private static readonly IntPtr selFractionalHeightDimension_Handle = Selector.GetHandle("fractionalHeightDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFractionalWidthDimension_ = "fractionalWidthDimension:";

	private static readonly IntPtr selFractionalWidthDimension_Handle = Selector.GetHandle("fractionalWidthDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAbsolute = "isAbsolute";

	private static readonly IntPtr selIsAbsoluteHandle = Selector.GetHandle("isAbsolute");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEstimated = "isEstimated";

	private static readonly IntPtr selIsEstimatedHandle = Selector.GetHandle("isEstimated");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFractionalHeight = "isFractionalHeight";

	private static readonly IntPtr selIsFractionalHeightHandle = Selector.GetHandle("isFractionalHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFractionalWidth = "isFractionalWidth";

	private static readonly IntPtr selIsFractionalWidthHandle = Selector.GetHandle("isFractionalWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionLayoutDimension");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Dimension
	{
		[Export("dimension")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selDimensionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDimensionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAbsolute
	{
		[Export("isAbsolute")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAbsoluteHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAbsoluteHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEstimated
	{
		[Export("isEstimated")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEstimatedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEstimatedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFractionalHeight
	{
		[Export("isFractionalHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFractionalHeightHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFractionalHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFractionalWidth
	{
		[Export("isFractionalWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFractionalWidthHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFractionalWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionLayoutDimension(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionLayoutDimension(IntPtr handle)
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

	[Export("absoluteDimension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutDimension CreateAbsoluteDimension(nfloat absoluteDimension)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCollectionLayoutDimension>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selAbsoluteDimension_Handle, absoluteDimension));
	}

	[Export("estimatedDimension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutDimension CreateEstimatedDimension(nfloat estimatedDimension)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCollectionLayoutDimension>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selEstimatedDimension_Handle, estimatedDimension));
	}

	[Export("fractionalHeightDimension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutDimension CreateFractionalHeightDimension(nfloat fractionalHeight)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCollectionLayoutDimension>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selFractionalHeightDimension_Handle, fractionalHeight));
	}

	[Export("fractionalWidthDimension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutDimension CreateFractionalWidthDimension(nfloat fractionalWidth)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCollectionLayoutDimension>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selFractionalWidthDimension_Handle, fractionalWidth));
	}
}
