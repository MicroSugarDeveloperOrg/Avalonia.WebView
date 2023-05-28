using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureOutput", true)]
public class QTCaptureOutput : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnections = "connections";

	private static readonly IntPtr selConnectionsHandle = Selector.GetHandle("connections");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTCaptureOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTCaptureConnection[] Connections
	{
		[Export("connections")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<QTCaptureConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionsHandle));
			}
			return NSArray.ArrayFromHandle<QTCaptureConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QTCaptureOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCaptureOutput(IntPtr handle)
		: base(handle)
	{
	}
}
