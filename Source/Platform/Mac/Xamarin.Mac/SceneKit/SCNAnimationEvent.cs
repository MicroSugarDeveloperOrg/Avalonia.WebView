using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNAnimationEvent", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNAnimationEvent : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationEventWithKeyTime_Block_ = "animationEventWithKeyTime:block:";

	private static readonly IntPtr selAnimationEventWithKeyTime_Block_Handle = Selector.GetHandle("animationEventWithKeyTime:block:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNAnimationEvent");

	public override IntPtr ClassHandle => class_ptr;

	public static SCNAnimationEvent Create(nfloat keyTime, SCNAnimationEventHandler eventHandler)
	{
		Action<IntPtr, NSObject, bool> handler = delegate(IntPtr animationPtr, NSObject animatedObject, bool playingBackward)
		{
			CAAnimation iNativeObject = Runtime.GetINativeObject<CAAnimation>(animationPtr, owns: true);
			eventHandler(iNativeObject, animatedObject, playingBackward);
		};
		return Create(keyTime, handler);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNAnimationEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNAnimationEvent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animationEventWithKeyTime:block:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe static SCNAnimationEvent Create(nfloat keyTime, [BlockProxy(typeof(Trampolines.NIDActionArity3V5))] Action<IntPtr, NSObject, bool> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity3V5.Handler, handler);
		SCNAnimationEvent nSObject = Runtime.GetNSObject<SCNAnimationEvent>(Messaging.IntPtr_objc_msgSend_nfloat_IntPtr(class_ptr, selAnimationEventWithKeyTime_Block_Handle, keyTime, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}
}
