using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionLayoutSize", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionLayoutSize : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeightDimension = "heightDimension";

	private static readonly IntPtr selHeightDimensionHandle = Selector.GetHandle("heightDimension");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeWithWidthDimension_HeightDimension_ = "sizeWithWidthDimension:heightDimension:";

	private static readonly IntPtr selSizeWithWidthDimension_HeightDimension_Handle = Selector.GetHandle("sizeWithWidthDimension:heightDimension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidthDimension = "widthDimension";

	private static readonly IntPtr selWidthDimensionHandle = Selector.GetHandle("widthDimension");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionLayoutSize");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutDimension HeightDimension
	{
		[Export("heightDimension")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionLayoutDimension>(Messaging.IntPtr_objc_msgSend(base.Handle, selHeightDimensionHandle));
			}
			return Runtime.GetNSObject<NSCollectionLayoutDimension>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHeightDimensionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutDimension WidthDimension
	{
		[Export("widthDimension")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionLayoutDimension>(Messaging.IntPtr_objc_msgSend(base.Handle, selWidthDimensionHandle));
			}
			return Runtime.GetNSObject<NSCollectionLayoutDimension>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWidthDimensionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionLayoutSize(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionLayoutSize(IntPtr handle)
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

	[Export("sizeWithWidthDimension:heightDimension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutSize Create(NSCollectionLayoutDimension width, NSCollectionLayoutDimension height)
	{
		NSApplication.EnsureUIThread();
		if (width == null)
		{
			throw new ArgumentNullException("width");
		}
		if (height == null)
		{
			throw new ArgumentNullException("height");
		}
		return Runtime.GetNSObject<NSCollectionLayoutSize>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selSizeWithWidthDimension_HeightDimension_Handle, width.Handle, height.Handle));
	}
}
