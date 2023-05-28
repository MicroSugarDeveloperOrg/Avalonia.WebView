using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSScriptCommand", true)]
public class NSScriptCommand : NSObject, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppleEvent = "appleEvent";

	private static readonly IntPtr selAppleEventHandle = Selector.GetHandle("appleEvent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentCommand = "currentCommand";

	private static readonly IntPtr selCurrentCommandHandle = Selector.GetHandle("currentCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluatedReceivers = "evaluatedReceivers";

	private static readonly IntPtr selEvaluatedReceiversHandle = Selector.GetHandle("evaluatedReceivers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecuteCommand = "executeCommand";

	private static readonly IntPtr selExecuteCommandHandle = Selector.GetHandle("executeCommand");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCommandDescription_ = "initWithCommandDescription:";

	private static readonly IntPtr selInitWithCommandDescription_Handle = Selector.GetHandle("initWithCommandDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSScriptCommand");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor AppleEvent
	{
		[Export("appleEvent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selAppleEventHandle));
			}
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppleEventHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject EvaluatedReceivers
	{
		[Export("evaluatedReceivers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEvaluatedReceiversHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEvaluatedReceiversHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSScriptCommand(NSCoder coder)
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
	protected NSScriptCommand(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSScriptCommand(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCommandDescription:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSScriptCommand(NSScriptCommandDescription cmdDescription)
		: base(NSObjectFlag.Empty)
	{
		if (cmdDescription == null)
		{
			throw new ArgumentNullException("cmdDescription");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCommandDescription_Handle, cmdDescription.Handle), "initWithCommandDescription:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCommandDescription_Handle, cmdDescription.Handle), "initWithCommandDescription:");
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("executeCommand")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr Execute()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selExecuteCommandHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExecuteCommandHandle);
	}

	[Export("currentCommand")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr GetCurrentCommand()
	{
		return Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentCommandHandle);
	}
}
