using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKMinmaxStrategist", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKMinMaxStrategist : NSObject, IGKStrategist, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBestMoveForActivePlayer = "bestMoveForActivePlayer";

	private static readonly IntPtr selBestMoveForActivePlayerHandle = Selector.GetHandle("bestMoveForActivePlayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBestMoveForPlayer_ = "bestMoveForPlayer:";

	private static readonly IntPtr selBestMoveForPlayer_Handle = Selector.GetHandle("bestMoveForPlayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGameModel = "gameModel";

	private static readonly IntPtr selGameModelHandle = Selector.GetHandle("gameModel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxLookAheadDepth = "maxLookAheadDepth";

	private static readonly IntPtr selMaxLookAheadDepthHandle = Selector.GetHandle("maxLookAheadDepth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRandomMoveForPlayer_FromNumberOfBestMoves_ = "randomMoveForPlayer:fromNumberOfBestMoves:";

	private static readonly IntPtr selRandomMoveForPlayer_FromNumberOfBestMoves_Handle = Selector.GetHandle("randomMoveForPlayer:fromNumberOfBestMoves:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRandomSource = "randomSource";

	private static readonly IntPtr selRandomSourceHandle = Selector.GetHandle("randomSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGameModel_ = "setGameModel:";

	private static readonly IntPtr selSetGameModel_Handle = Selector.GetHandle("setGameModel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxLookAheadDepth_ = "setMaxLookAheadDepth:";

	private static readonly IntPtr selSetMaxLookAheadDepth_Handle = Selector.GetHandle("setMaxLookAheadDepth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRandomSource_ = "setRandomSource:";

	private static readonly IntPtr selSetRandomSource_Handle = Selector.GetHandle("setRandomSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKMinmaxStrategist");

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual nint MaxLookAheadDepth
	{
		[Export("maxLookAheadDepth", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaxLookAheadDepthHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaxLookAheadDepthHandle);
		}
		[Export("setMaxLookAheadDepth:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaxLookAheadDepth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaxLookAheadDepth_Handle, value);
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
	public GKMinMaxStrategist()
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
	protected GKMinMaxStrategist(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKMinMaxStrategist(IntPtr handle)
		: base(handle)
	{
	}

	[Export("bestMoveForPlayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IGKGameModelUpdate? GetBestMove(IGKGameModelPlayer player)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IGKGameModelUpdate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selBestMoveForPlayer_Handle, player.Handle), owns: false);
		}
		return Runtime.GetINativeObject<IGKGameModelUpdate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selBestMoveForPlayer_Handle, player.Handle), owns: false);
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

	[Export("randomMoveForPlayer:fromNumberOfBestMoves:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IGKGameModelUpdate? GetRandomMove(IGKGameModelPlayer player, nint numMovesToConsider)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IGKGameModelUpdate>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(base.Handle, selRandomMoveForPlayer_FromNumberOfBestMoves_Handle, player.Handle, numMovesToConsider), owns: false);
		}
		return Runtime.GetINativeObject<IGKGameModelUpdate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selRandomMoveForPlayer_FromNumberOfBestMoves_Handle, player.Handle, numMovesToConsider), owns: false);
	}
}
