using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

internal sealed class GKStrategistWrapper : BaseWrapper, IGKStrategist, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKGameModel? GameModel
	{
		[Export("gameModel", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetINativeObject<IGKGameModel>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("gameModel")), owns: false);
		}
		[Export("setGameModel:", ArgumentSemantic.Retain)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setGameModel:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKRandom? RandomSource
	{
		[Export("randomSource", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetINativeObject<IGKRandom>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("randomSource")), owns: false);
		}
		[Export("setRandomSource:", ArgumentSemantic.Retain)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setRandomSource:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[Preserve(Conditional = true)]
	public GKStrategistWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("bestMoveForActivePlayer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKGameModelUpdate GetBestMoveForActivePlayer()
	{
		return Runtime.GetINativeObject<IGKGameModelUpdate>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("bestMoveForActivePlayer")), owns: false);
	}
}
