using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ScriptingBridge;

[Register("SBObject", true)]
public class SBObject : NSObject
{
	private static readonly IntPtr selGetHandle = Selector.GetHandle("get");

	private static readonly IntPtr selLastErrorHandle = Selector.GetHandle("lastError");

	private static readonly IntPtr selInitWithProperties_Handle = Selector.GetHandle("initWithProperties:");

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	private static readonly IntPtr class_ptr = Class.GetHandle("SBObject");

	private object __mt_Get_var;

	private object __mt_LastError_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject Get
	{
		[Export("get")]
		get
		{
			return (NSObject)(__mt_Get_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selGetHandle))));
		}
	}

	public virtual NSError LastError
	{
		[Export("lastError")]
		get
		{
			return (NSError)(__mt_LastError_var = ((!IsDirectBinding) ? ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastErrorHandle))) : ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLastErrorHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SBObject()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SBObject(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public SBObject(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public SBObject(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithProperties:")]
	public SBObject(NSDictionary properties)
		: base(NSObjectFlag.Empty)
	{
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithProperties_Handle, properties.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithProperties_Handle, properties.Handle);
		}
	}

	[Export("initWithData:")]
	public SBObject(NSObject data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Get_var = null;
			__mt_LastError_var = null;
		}
	}
}
