using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSNib", true)]
public class NSNib : NSObject
{
	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	private static readonly IntPtr selInitWithNibNamedBundle_Handle = Selector.GetHandle("initWithNibNamed:bundle:");

	private static readonly IntPtr selInstantiateNibWithExternalNameTable_Handle = Selector.GetHandle("instantiateNibWithExternalNameTable:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSNib");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNib()
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
	public NSNib(NSCoder coder)
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
	public NSNib(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNib(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentsOfURL:")]
	public NSNib(NSUrl nibFileUrl)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (nibFileUrl == null)
		{
			throw new ArgumentNullException("nibFileUrl");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, nibFileUrl.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, nibFileUrl.Handle);
		}
	}

	[Export("initWithNibNamed:bundle:")]
	public NSNib(string nibName, NSBundle bundle)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (nibName == null)
		{
			throw new ArgumentNullException("nibName");
		}
		if (bundle == null)
		{
			throw new ArgumentNullException("bundle");
		}
		IntPtr arg = NSString.CreateNative(nibName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibNamedBundle_Handle, arg, bundle.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibNamedBundle_Handle, arg, bundle.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("instantiateNibWithExternalNameTable:")]
	public virtual bool InstantiateNib(NSDictionary externalNameTable)
	{
		NSApplication.EnsureUIThread();
		if (externalNameTable == null)
		{
			throw new ArgumentNullException("externalNameTable");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selInstantiateNibWithExternalNameTable_Handle, externalNameTable.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selInstantiateNibWithExternalNameTable_Handle, externalNameTable.Handle);
	}
}
