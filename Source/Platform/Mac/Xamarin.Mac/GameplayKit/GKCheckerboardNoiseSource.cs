using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKCheckerboardNoiseSource", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKCheckerboardNoiseSource : GKNoiseSource
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckerboardNoiseWithSquareSize_ = "checkerboardNoiseWithSquareSize:";

	private static readonly IntPtr selCheckerboardNoiseWithSquareSize_Handle = Selector.GetHandle("checkerboardNoiseWithSquareSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSquareSize_ = "initWithSquareSize:";

	private static readonly IntPtr selInitWithSquareSize_Handle = Selector.GetHandle("initWithSquareSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSquareSize_ = "setSquareSize:";

	private static readonly IntPtr selSetSquareSize_Handle = Selector.GetHandle("setSquareSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareSize = "squareSize";

	private static readonly IntPtr selSquareSizeHandle = Selector.GetHandle("squareSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKCheckerboardNoiseSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double SquareSize
	{
		[Export("squareSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSquareSizeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSquareSizeHandle);
		}
		[Export("setSquareSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetSquareSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetSquareSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKCheckerboardNoiseSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKCheckerboardNoiseSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSquareSize:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKCheckerboardNoiseSource(double squareSize)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selInitWithSquareSize_Handle, squareSize), "initWithSquareSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selInitWithSquareSize_Handle, squareSize), "initWithSquareSize:");
		}
	}

	[Export("checkerboardNoiseWithSquareSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKCheckerboardNoiseSource Create(double squareSize)
	{
		return Runtime.GetNSObject<GKCheckerboardNoiseSource>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selCheckerboardNoiseWithSquareSize_Handle, squareSize));
	}
}
