using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDraggingItem", true)]
public class NSDraggingItem : NSObject
{
	private static readonly IntPtr selItemHandle = Selector.GetHandle("item");

	private static readonly IntPtr selDraggingFrameHandle = Selector.GetHandle("draggingFrame");

	private static readonly IntPtr selSetDraggingFrame_Handle = Selector.GetHandle("setDraggingFrame:");

	private static readonly IntPtr selImageComponentsHandle = Selector.GetHandle("imageComponents");

	private static readonly IntPtr selInitWithPasteboardWriter_Handle = Selector.GetHandle("initWithPasteboardWriter:");

	private static readonly IntPtr selSetImageComponentsProvider_Handle = Selector.GetHandle("setImageComponentsProvider:");

	private static readonly IntPtr selSetDraggingFrameContents_Handle = Selector.GetHandle("setDraggingFrame:contents:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDraggingItem");

	private object __mt_Item_var;

	private object __mt_ImageComponents_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject Item
	{
		[Export("item")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Item_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selItemHandle))));
		}
	}

	public virtual CGRect DraggingFrame
	{
		[Export("draggingFrame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selDraggingFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDraggingFrameHandle);
			}
			return retval;
		}
		[Export("setDraggingFrame:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetDraggingFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetDraggingFrame_Handle, value);
			}
		}
	}

	public virtual NSDraggingImageComponent[] ImageComponents
	{
		[Export("imageComponents")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDraggingImageComponent[])(__mt_ImageComponents_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSDraggingImageComponent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageComponentsHandle)) : NSArray.ArrayFromHandle<NSDraggingImageComponent>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageComponentsHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDraggingItem()
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
	public NSDraggingItem(NSCoder coder)
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
	public NSDraggingItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDraggingItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPasteboardWriter:")]
	public NSDraggingItem(NSPasteboardWriting pasteboardWriter)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (pasteboardWriter == null)
		{
			throw new ArgumentNullException("pasteboardWriter");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPasteboardWriter_Handle, pasteboardWriter.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPasteboardWriter_Handle, pasteboardWriter.Handle);
		}
	}

	[Export("setImageComponentsProvider:")]
	public unsafe virtual void SetImagesContentProvider(NSDraggingItemImagesContentProvider provider)
	{
		NSApplication.EnsureUIThread();
		BlockLiteral* ptr;
		if (provider == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlock(Trampolines.SDNSDraggingItemImagesContentProvider.Handler, provider);
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImageComponentsProvider_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImageComponentsProvider_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("setDraggingFrame:contents:")]
	public virtual void SetDraggingFrame(CGRect frame, NSObject contents)
	{
		NSApplication.EnsureUIThread();
		if (contents == null)
		{
			throw new ArgumentNullException("contents");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selSetDraggingFrameContents_Handle, frame, contents.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selSetDraggingFrameContents_Handle, frame, contents.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Item_var = null;
			__mt_ImageComponents_var = null;
		}
	}
}
