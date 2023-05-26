using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMutableFontCollection", true)]
public class NSMutableFontCollection : NSFontCollection
{
	private static readonly IntPtr selSetQueryDescriptors_Handle = Selector.GetHandle("setQueryDescriptors:");

	private static readonly IntPtr selSetExclusionDescriptors_Handle = Selector.GetHandle("setExclusionDescriptors:");

	private static readonly IntPtr selAddQueryForDescriptors_Handle = Selector.GetHandle("addQueryForDescriptors:");

	private static readonly IntPtr selRemoveQueryForDescriptors_Handle = Selector.GetHandle("removeQueryForDescriptors:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableFontCollection");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableFontCollection()
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
	public NSMutableFontCollection(NSCoder coder)
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
	public NSMutableFontCollection(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableFontCollection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setQueryDescriptors:")]
	public virtual void SetQueryDescriptors(NSFontDescriptor[] descriptors)
	{
		NSApplication.EnsureUIThread();
		if (descriptors == null)
		{
			throw new ArgumentNullException("descriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(descriptors);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetQueryDescriptors_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetQueryDescriptors_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("setExclusionDescriptors:")]
	public virtual void SetExclusionDescriptors(NSFontDescriptor[] descriptors)
	{
		NSApplication.EnsureUIThread();
		if (descriptors == null)
		{
			throw new ArgumentNullException("descriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(descriptors);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExclusionDescriptors_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExclusionDescriptors_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("addQueryForDescriptors:")]
	public virtual void AddQueryForDescriptors(NSFontDescriptor[] descriptors)
	{
		NSApplication.EnsureUIThread();
		if (descriptors == null)
		{
			throw new ArgumentNullException("descriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(descriptors);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddQueryForDescriptors_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddQueryForDescriptors_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeQueryForDescriptors:")]
	public virtual void RemoveQueryForDescriptors(NSFontDescriptor[] descriptors)
	{
		NSApplication.EnsureUIThread();
		if (descriptors == null)
		{
			throw new ArgumentNullException("descriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(descriptors);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveQueryForDescriptors_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveQueryForDescriptors_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}
}
