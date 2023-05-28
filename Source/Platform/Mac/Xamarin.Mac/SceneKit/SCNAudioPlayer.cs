using System;
using System.ComponentModel;
using AVFoundation;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNAudioPlayer", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class SCNAudioPlayer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioNode = "audioNode";

	private static readonly IntPtr selAudioNodeHandle = Selector.GetHandle("audioNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioPlayerWithAVAudioNode_ = "audioPlayerWithAVAudioNode:";

	private static readonly IntPtr selAudioPlayerWithAVAudioNode_Handle = Selector.GetHandle("audioPlayerWithAVAudioNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioPlayerWithSource_ = "audioPlayerWithSource:";

	private static readonly IntPtr selAudioPlayerWithSource_Handle = Selector.GetHandle("audioPlayerWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioSource = "audioSource";

	private static readonly IntPtr selAudioSourceHandle = Selector.GetHandle("audioSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidFinishPlayback = "didFinishPlayback";

	private static readonly IntPtr selDidFinishPlaybackHandle = Selector.GetHandle("didFinishPlayback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAVAudioNode_ = "initWithAVAudioNode:";

	private static readonly IntPtr selInitWithAVAudioNode_Handle = Selector.GetHandle("initWithAVAudioNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_ = "initWithSource:";

	private static readonly IntPtr selInitWithSource_Handle = Selector.GetHandle("initWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDidFinishPlayback_ = "setDidFinishPlayback:";

	private static readonly IntPtr selSetDidFinishPlayback_Handle = Selector.GetHandle("setDidFinishPlayback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWillStartPlayback_ = "setWillStartPlayback:";

	private static readonly IntPtr selSetWillStartPlayback_Handle = Selector.GetHandle("setWillStartPlayback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillStartPlayback = "willStartPlayback";

	private static readonly IntPtr selWillStartPlaybackHandle = Selector.GetHandle("willStartPlayback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNAudioPlayer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioNode? AudioNode
	{
		[Export("audioNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioNodeHandle));
			}
			return Runtime.GetNSObject<AVAudioNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNAudioSource? AudioSource
	{
		[Export("audioSource")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNAudioSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioSourceHandle));
			}
			return Runtime.GetNSObject<SCNAudioSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioSourceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action DidFinishPlayback
	{
		[Export("didFinishPlayback")]
		[return: DelegateProxy(typeof(Trampolines.SDAction))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDidFinishPlaybackHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selDidFinishPlaybackHandle));
			return Trampolines.NIDAction.Create(block);
		}
		[Export("setDidFinishPlayback:")]
		[param: BlockProxy(typeof(Trampolines.NIDAction))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDidFinishPlayback_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDidFinishPlayback_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action WillStartPlayback
	{
		[Export("willStartPlayback")]
		[return: DelegateProxy(typeof(Trampolines.SDAction))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWillStartPlaybackHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selWillStartPlaybackHandle));
			return Trampolines.NIDAction.Create(block);
		}
		[Export("setWillStartPlayback:")]
		[param: BlockProxy(typeof(Trampolines.NIDAction))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWillStartPlayback_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWillStartPlayback_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNAudioPlayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNAudioPlayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNAudioPlayer(SCNAudioSource source)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSource_Handle, source.Handle), "initWithSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSource_Handle, source.Handle), "initWithSource:");
		}
	}

	[Export("initWithAVAudioNode:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNAudioPlayer(AVAudioNode audioNode)
		: base(NSObjectFlag.Empty)
	{
		if (audioNode == null)
		{
			throw new ArgumentNullException("audioNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAVAudioNode_Handle, audioNode.Handle), "initWithAVAudioNode:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAVAudioNode_Handle, audioNode.Handle), "initWithAVAudioNode:");
		}
	}

	[Export("audioPlayerWithAVAudioNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAudioPlayer AVAudioNode(AVAudioNode audioNode)
	{
		if (audioNode == null)
		{
			throw new ArgumentNullException("audioNode");
		}
		return Runtime.GetNSObject<SCNAudioPlayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAudioPlayerWithAVAudioNode_Handle, audioNode.Handle));
	}

	[Export("audioPlayerWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAudioPlayer FromSource(SCNAudioSource source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return Runtime.GetNSObject<SCNAudioPlayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAudioPlayerWithSource_Handle, source.Handle));
	}
}
