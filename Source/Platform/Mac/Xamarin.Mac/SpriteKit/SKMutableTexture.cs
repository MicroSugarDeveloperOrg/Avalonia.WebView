using System;
using System.ComponentModel;
using CoreGraphics;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKMutableTexture", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class SKMutableTexture : SKTexture
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSize_ = "initWithSize:";

	private static readonly IntPtr selInitWithSize_Handle = Selector.GetHandle("initWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSize_PixelFormat_ = "initWithSize:pixelFormat:";

	private static readonly IntPtr selInitWithSize_PixelFormat_Handle = Selector.GetHandle("initWithSize:pixelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModifyPixelDataWithBlock_ = "modifyPixelDataWithBlock:";

	private static readonly IntPtr selModifyPixelDataWithBlock_Handle = Selector.GetHandle("modifyPixelDataWithBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableTextureWithSize_ = "mutableTextureWithSize:";

	private static readonly IntPtr selMutableTextureWithSize_Handle = Selector.GetHandle("mutableTextureWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKMutableTexture");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKMutableTexture(NSCoder coder)
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
	protected SKMutableTexture(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKMutableTexture(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKMutableTexture(CGSize size)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGSize(base.Handle, selInitWithSize_Handle, size), "initWithSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGSize(base.SuperHandle, selInitWithSize_Handle, size), "initWithSize:");
		}
	}

	[Export("initWithSize:pixelFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKMutableTexture(CGSize size, CVPixelFormatType pixelFormat)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGSize_UInt32(base.Handle, selInitWithSize_PixelFormat_Handle, size, (uint)pixelFormat), "initWithSize:pixelFormat:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGSize_UInt32(base.SuperHandle, selInitWithSize_PixelFormat_Handle, size, (uint)pixelFormat), "initWithSize:pixelFormat:");
		}
	}

	[Export("mutableTextureWithSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKMutableTexture Create(CGSize size)
	{
		return Runtime.GetNSObject<SKMutableTexture>(Messaging.IntPtr_objc_msgSend_CGSize(class_ptr, selMutableTextureWithSize_Handle, size));
	}

	[Export("modifyPixelDataWithBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ModifyPixelData([BlockProxy(typeof(Trampolines.NIDSKTextureModify))] SKTextureModify modifyMethod)
	{
		if (modifyMethod == null)
		{
			throw new ArgumentNullException("modifyMethod");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSKTextureModify.Handler, modifyMethod);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selModifyPixelDataWithBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selModifyPixelDataWithBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}
