using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameController;

[Register("GCControllerDirectionPad", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class GCControllerDirectionPad : GCControllerElement
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDown = "down";

	private static readonly IntPtr selDownHandle = Selector.GetHandle("down");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeft = "left";

	private static readonly IntPtr selLeftHandle = Selector.GetHandle("left");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRight = "right";

	private static readonly IntPtr selRightHandle = Selector.GetHandle("right");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValueChangedHandler_ = "setValueChangedHandler:";

	private static readonly IntPtr selSetValueChangedHandler_Handle = Selector.GetHandle("setValueChangedHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValueForXAxis_YAxis_ = "setValueForXAxis:yAxis:";

	private static readonly IntPtr selSetValueForXAxis_YAxis_Handle = Selector.GetHandle("setValueForXAxis:yAxis:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUp = "up";

	private static readonly IntPtr selUpHandle = Selector.GetHandle("up");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueChangedHandler = "valueChangedHandler";

	private static readonly IntPtr selValueChangedHandlerHandle = Selector.GetHandle("valueChangedHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXAxis = "xAxis";

	private static readonly IntPtr selXAxisHandle = Selector.GetHandle("xAxis");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYAxis = "yAxis";

	private static readonly IntPtr selYAxisHandle = Selector.GetHandle("yAxis");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GCControllerDirectionPad");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerButtonInput Down
	{
		[Export("down")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selDownHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerButtonInput Left
	{
		[Export("left")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerButtonInput Right
	{
		[Export("right")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerButtonInput Up
	{
		[Export("up")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selUpHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUpHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual GCControllerDirectionPadValueChangedHandler? ValueChangedHandler
	{
		[Export("valueChangedHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDGCControllerDirectionPadValueChangedHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueChangedHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selValueChangedHandlerHandle));
			return Trampolines.NIDGCControllerDirectionPadValueChangedHandler.Create(block);
		}
		[Export("setValueChangedHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDGCControllerDirectionPadValueChangedHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGCControllerDirectionPadValueChangedHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValueChangedHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValueChangedHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerAxisInput XAxis
	{
		[Export("xAxis")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerAxisInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selXAxisHandle));
			}
			return Runtime.GetNSObject<GCControllerAxisInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selXAxisHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerAxisInput YAxis
	{
		[Export("yAxis")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerAxisInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selYAxisHandle));
			}
			return Runtime.GetNSObject<GCControllerAxisInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selYAxisHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GCControllerDirectionPad(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GCControllerDirectionPad(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setValueForXAxis:yAxis:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(float xAxis, float yAxis)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_float(base.Handle, selSetValueForXAxis_YAxis_Handle, xAxis, yAxis);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_float(base.SuperHandle, selSetValueForXAxis_YAxis_Handle, xAxis, yAxis);
		}
	}
}
