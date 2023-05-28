using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDraggingItem", true)]
public class NSDraggingItem : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingFrame = "draggingFrame";

	private static readonly IntPtr selDraggingFrameHandle = Selector.GetHandle("draggingFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageComponents = "imageComponents";

	private static readonly IntPtr selImageComponentsHandle = Selector.GetHandle("imageComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPasteboardWriter_ = "initWithPasteboardWriter:";

	private static readonly IntPtr selInitWithPasteboardWriter_Handle = Selector.GetHandle("initWithPasteboardWriter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItem = "item";

	private static readonly IntPtr selItemHandle = Selector.GetHandle("item");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingFrame_ = "setDraggingFrame:";

	private static readonly IntPtr selSetDraggingFrame_Handle = Selector.GetHandle("setDraggingFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingFrame_Contents_ = "setDraggingFrame:contents:";

	private static readonly IntPtr selSetDraggingFrame_Contents_Handle = Selector.GetHandle("setDraggingFrame:contents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageComponentsProvider_ = "setImageComponentsProvider:";

	private static readonly IntPtr selSetImageComponentsProvider_Handle = Selector.GetHandle("setImageComponentsProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDraggingItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect DraggingFrame
	{
		[Export("draggingFrame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetDraggingFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetDraggingFrame_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDraggingImageComponent[] ImageComponents
	{
		[Export("imageComponents", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSDraggingImageComponent>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageComponentsHandle));
			}
			return NSArray.ArrayFromHandle<NSDraggingImageComponent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageComponentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Item
	{
		[Export("item", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selItemHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemHandle));
		}
	}

	public NSDraggingItem(NSPasteboardWriting pasteboardWriter)
		: this((INSPasteboardWriting)pasteboardWriter)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDraggingItem()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSDraggingItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDraggingItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPasteboardWriter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDraggingItem(INSPasteboardWriting pasteboardWriter)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (pasteboardWriter == null)
		{
			throw new ArgumentNullException("pasteboardWriter");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPasteboardWriter_Handle, pasteboardWriter.Handle), "initWithPasteboardWriter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPasteboardWriter_Handle, pasteboardWriter.Handle), "initWithPasteboardWriter:");
		}
	}

	[Export("setDraggingFrame:contents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDraggingFrame(CGRect frame, NSObject contents)
	{
		NSApplication.EnsureUIThread();
		if (contents == null)
		{
			throw new ArgumentNullException("contents");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selSetDraggingFrame_Contents_Handle, frame, contents.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selSetDraggingFrame_Contents_Handle, frame, contents.Handle);
		}
	}

	[Export("setImageComponentsProvider:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetImagesContentProvider([BlockProxy(typeof(Trampolines.NIDNSDraggingItemImagesContentProvider))] NSDraggingItemImagesContentProvider? provider)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDraggingItemImagesContentProvider.Handler, provider);
		}
		if (base.IsDirectBinding)
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
}
