using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSAppleScript", true)]
public class NSAppleScript : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompileAndReturnError_ = "compileAndReturnError:";

	private static readonly IntPtr selCompileAndReturnError_Handle = Selector.GetHandle("compileAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecuteAndReturnError_ = "executeAndReturnError:";

	private static readonly IntPtr selExecuteAndReturnError_Handle = Selector.GetHandle("executeAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecuteAppleEvent_Error_ = "executeAppleEvent:error:";

	private static readonly IntPtr selExecuteAppleEvent_Error_Handle = Selector.GetHandle("executeAppleEvent:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_Error_ = "initWithContentsOfURL:error:";

	private static readonly IntPtr selInitWithContentsOfURL_Error_Handle = Selector.GetHandle("initWithContentsOfURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_ = "initWithSource:";

	private static readonly IntPtr selInitWithSource_Handle = Selector.GetHandle("initWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCompiled = "isCompiled";

	private static readonly IntPtr selIsCompiledHandle = Selector.GetHandle("isCompiled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRichTextSource = "richTextSource";

	private static readonly IntPtr selRichTextSourceHandle = Selector.GetHandle("richTextSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSource = "source";

	private static readonly IntPtr selSourceHandle = Selector.GetHandle("source");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAppleScript");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Compiled
	{
		[Export("isCompiled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCompiledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCompiledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString RichTextSource
	{
		[Export("richTextSource", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selRichTextSourceHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRichTextSourceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Source
	{
		[Export("source")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSAppleScript(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAppleScript(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentsOfURL:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAppleScript(NSUrl url, out NSDictionary errorInfo)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithContentsOfURL_Error_Handle, url.Handle, ref arg), "initWithContentsOfURL:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Error_Handle, url.Handle, ref arg), "initWithContentsOfURL:error:");
		}
		errorInfo = Runtime.GetNSObject<NSDictionary>(arg);
	}

	[Export("initWithSource:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAppleScript(string source)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		IntPtr arg = NSString.CreateNative(source);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSource_Handle, arg), "initWithSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSource_Handle, arg), "initWithSource:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("compileAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CompileAndReturnError(out NSDictionary errorInfo)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selCompileAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selCompileAndReturnError_Handle, ref arg));
		errorInfo = Runtime.GetNSObject<NSDictionary>(arg);
		return result;
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("executeAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor ExecuteAndReturnError(out NSDictionary errorInfo)
	{
		IntPtr arg = IntPtr.Zero;
		NSAppleEventDescriptor result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selExecuteAndReturnError_Handle, ref arg)) : Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_ref_IntPtr(base.Handle, selExecuteAndReturnError_Handle, ref arg)));
		errorInfo = Runtime.GetNSObject<NSDictionary>(arg);
		return result;
	}

	[Export("executeAppleEvent:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor ExecuteAppleEvent(NSAppleEventDescriptor eventDescriptor, out NSDictionary errorInfo)
	{
		if (eventDescriptor == null)
		{
			throw new ArgumentNullException("eventDescriptor");
		}
		IntPtr arg = IntPtr.Zero;
		NSAppleEventDescriptor result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selExecuteAppleEvent_Error_Handle, eventDescriptor.Handle, ref arg)) : Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selExecuteAppleEvent_Error_Handle, eventDescriptor.Handle, ref arg)));
		errorInfo = Runtime.GetNSObject<NSDictionary>(arg);
		return result;
	}
}
