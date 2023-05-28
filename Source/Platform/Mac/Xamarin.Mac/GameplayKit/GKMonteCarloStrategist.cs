using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKMonteCarloStrategist", true)]
[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKMonteCarloStrategist : NSObject, IGKStrategist, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBestMoveForActivePlayer = "bestMoveForActivePlayer";

	private static readonly IntPtr selBestMoveForActivePlayerHandle = Selector.GetHandle("bestMoveForActivePlayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBudget = "budget";

	private static readonly IntPtr selBudgetHandle = Selector.GetHandle("budget");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExplorationParameter = "explorationParameter";

	private static readonly IntPtr selExplorationParameterHandle = Selector.GetHandle("explorationParameter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGameModel = "gameModel";

	private static readonly IntPtr selGameModelHandle = Selector.GetHandle("gameModel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRandomSource = "randomSource";

	private static readonly IntPtr selRandomSourceHandle = Selector.GetHandle("randomSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBudget_ = "setBudget:";

	private static readonly IntPtr selSetBudget_Handle = Selector.GetHandle("setBudget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExplorationParameter_ = "setExplorationParameter:";

	private static readonly IntPtr selSetExplorationParameter_Handle = Selector.GetHandle("setExplorationParameter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGameModel_ = "setGameModel:";

	private static readonly IntPtr selSetGameModel_Handle = Selector.GetHandle("setGameModel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRandomSource_ = "setRandomSource:";

	private static readonly IntPtr selSetRandomSource_Handle = Selector.GetHandle("setRandomSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKMonteCarloStrategist");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Budget
	{
		[Export("budget")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBudgetHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBudgetHandle);
		}
		[Export("setBudget:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetBudget_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetBudget_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ExplorationParameter
	{
		[Export("explorationParameter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selExplorationParameterHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selExplorationParameterHandle);
		}
		[Export("setExplorationParameter:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetExplorationParameter_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetExplorationParameter_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual IGKGameModel? GameModel
	{
		[Export("gameModel", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IGKGameModel>(Messaging.IntPtr_objc_msgSend(base.Handle, selGameModelHandle), owns: false);
			}
			return Runtime.GetINativeObject<IGKGameModel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGameModelHandle), owns: false);
		}
		[Export("setGameModel:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGameModel_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGameModel_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual IGKRandom? RandomSource
	{
		[Export("randomSource", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IGKRandom>(Messaging.IntPtr_objc_msgSend(base.Handle, selRandomSourceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IGKRandom>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRandomSourceHandle), owns: false);
		}
		[Export("setRandomSource:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRandomSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRandomSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKMonteCarloStrategist()
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
	protected GKMonteCarloStrategist(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKMonteCarloStrategist(IntPtr handle)
		: base(handle)
	{
	}

	[Export("bestMoveForActivePlayer")]
	[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IGKGameModelUpdate GetBestMoveForActivePlayer()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IGKGameModelUpdate>(Messaging.IntPtr_objc_msgSend(base.Handle, selBestMoveForActivePlayerHandle), owns: false);
		}
		return Runtime.GetINativeObject<IGKGameModelUpdate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBestMoveForActivePlayerHandle), owns: false);
	}
}
