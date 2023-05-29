using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIPlugIn", true)]
public class CIPlugIn : NSObject
{
	private static readonly IntPtr selLoadAllPlugInsHandle = Selector.GetHandle("loadAllPlugIns");

	private static readonly IntPtr selLoadNonExecutablePlugInsHandle = Selector.GetHandle("loadNonExecutablePlugIns");

	private static readonly IntPtr selLoadPlugInAllowNonExecutable_Handle = Selector.GetHandle("loadPlugIn:allowNonExecutable:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIPlugIn");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CIPlugIn()
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
	public CIPlugIn(NSCoder coder)
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
	public CIPlugIn(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIPlugIn(IntPtr handle)
		: base(handle)
	{
	}

	[Export("loadAllPlugIns")]
	public static void LoadAllPlugIns()
	{
		Messaging.void_objc_msgSend(class_ptr, selLoadAllPlugInsHandle);
	}

	[Export("loadNonExecutablePlugIns")]
	public static void LoadNonExecutablePlugIns()
	{
		Messaging.void_objc_msgSend(class_ptr, selLoadNonExecutablePlugInsHandle);
	}

	[Export("loadPlugIn:allowNonExecutable:")]
	public static void LoadPlugIn(NSUrl pluginUrl, bool allowNonExecutable)
	{
		if (pluginUrl == null)
		{
			throw new ArgumentNullException("pluginUrl");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(class_ptr, selLoadPlugInAllowNonExecutable_Handle, pluginUrl.Handle, allowNonExecutable);
	}
}
