using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

[Register("MTLIndirectCommandBufferDescriptor", true)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
public class MTLIndirectCommandBufferDescriptor : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommandTypes = "commandTypes";

	private static readonly IntPtr selCommandTypesHandle = Selector.GetHandle("commandTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInheritBuffers = "inheritBuffers";

	private static readonly IntPtr selInheritBuffersHandle = Selector.GetHandle("inheritBuffers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInheritPipelineState = "inheritPipelineState";

	private static readonly IntPtr selInheritPipelineStateHandle = Selector.GetHandle("inheritPipelineState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxFragmentBufferBindCount = "maxFragmentBufferBindCount";

	private static readonly IntPtr selMaxFragmentBufferBindCountHandle = Selector.GetHandle("maxFragmentBufferBindCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxVertexBufferBindCount = "maxVertexBufferBindCount";

	private static readonly IntPtr selMaxVertexBufferBindCountHandle = Selector.GetHandle("maxVertexBufferBindCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCommandTypes_ = "setCommandTypes:";

	private static readonly IntPtr selSetCommandTypes_Handle = Selector.GetHandle("setCommandTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInheritBuffers_ = "setInheritBuffers:";

	private static readonly IntPtr selSetInheritBuffers_Handle = Selector.GetHandle("setInheritBuffers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInheritPipelineState_ = "setInheritPipelineState:";

	private static readonly IntPtr selSetInheritPipelineState_Handle = Selector.GetHandle("setInheritPipelineState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxFragmentBufferBindCount_ = "setMaxFragmentBufferBindCount:";

	private static readonly IntPtr selSetMaxFragmentBufferBindCount_Handle = Selector.GetHandle("setMaxFragmentBufferBindCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxVertexBufferBindCount_ = "setMaxVertexBufferBindCount:";

	private static readonly IntPtr selSetMaxVertexBufferBindCount_Handle = Selector.GetHandle("setMaxVertexBufferBindCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLIndirectCommandBufferDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLIndirectCommandType CommandTypes
	{
		[Export("commandTypes", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLIndirectCommandType)Messaging.UInt64_objc_msgSend(base.Handle, selCommandTypesHandle);
			}
			return (MTLIndirectCommandType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCommandTypesHandle);
		}
		[Export("setCommandTypes:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCommandTypes_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCommandTypes_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InheritBuffers
	{
		[Export("inheritBuffers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selInheritBuffersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selInheritBuffersHandle);
		}
		[Export("setInheritBuffers:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetInheritBuffers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetInheritBuffers_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool InheritPipelineState
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("inheritPipelineState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selInheritPipelineStateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selInheritPipelineStateHandle);
		}
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setInheritPipelineState:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetInheritPipelineState_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetInheritPipelineState_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MaxFragmentBufferBindCount
	{
		[Export("maxFragmentBufferBindCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMaxFragmentBufferBindCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMaxFragmentBufferBindCountHandle);
		}
		[Export("setMaxFragmentBufferBindCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMaxFragmentBufferBindCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMaxFragmentBufferBindCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MaxVertexBufferBindCount
	{
		[Export("maxVertexBufferBindCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMaxVertexBufferBindCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMaxVertexBufferBindCountHandle);
		}
		[Export("setMaxVertexBufferBindCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMaxVertexBufferBindCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMaxVertexBufferBindCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLIndirectCommandBufferDescriptor()
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
	protected MTLIndirectCommandBufferDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLIndirectCommandBufferDescriptor(IntPtr handle)
		: base(handle)
	{
	}
}
