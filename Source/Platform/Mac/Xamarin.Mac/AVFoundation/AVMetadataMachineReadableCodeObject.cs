using System;
using System.ComponentModel;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMetadataMachineReadableCodeObject", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class AVMetadataMachineReadableCodeObject : AVMetadataObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCorners = "corners";

	private static readonly IntPtr selCornersHandle = Selector.GetHandle("corners");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptor = "descriptor";

	private static readonly IntPtr selDescriptorHandle = Selector.GetHandle("descriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringValue = "stringValue";

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMetadataMachineReadableCodeObject");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual CIBarcodeDescriptor? Descriptor
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("descriptor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIBarcodeDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selDescriptorHandle));
			}
			return Runtime.GetNSObject<CIBarcodeDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDescriptorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? StringValue
	{
		[Export("stringValue", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary[] WeakCorners
	{
		[Export("corners", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selCornersHandle));
			}
			return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCornersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMetadataMachineReadableCodeObject()
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
	protected AVMetadataMachineReadableCodeObject(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMetadataMachineReadableCodeObject(IntPtr handle)
		: base(handle)
	{
	}
}
