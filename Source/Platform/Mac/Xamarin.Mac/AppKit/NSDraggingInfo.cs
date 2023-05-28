using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol]
[Register("NSDraggingInfo", true)]
public class NSDraggingInfo : NSObject, INSDraggingInfo, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimatesToDestination = "animatesToDestination";

	private static readonly IntPtr selAnimatesToDestinationHandle = Selector.GetHandle("animatesToDestination");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage = "draggedImage";

	private static readonly IntPtr selDraggedImageHandle = Selector.GetHandle("draggedImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImageLocation = "draggedImageLocation";

	private static readonly IntPtr selDraggedImageLocationHandle = Selector.GetHandle("draggedImageLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingDestinationWindow = "draggingDestinationWindow";

	private static readonly IntPtr selDraggingDestinationWindowHandle = Selector.GetHandle("draggingDestinationWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingFormation = "draggingFormation";

	private static readonly IntPtr selDraggingFormationHandle = Selector.GetHandle("draggingFormation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingLocation = "draggingLocation";

	private static readonly IntPtr selDraggingLocationHandle = Selector.GetHandle("draggingLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingPasteboard = "draggingPasteboard";

	private static readonly IntPtr selDraggingPasteboardHandle = Selector.GetHandle("draggingPasteboard");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingSequenceNumber = "draggingSequenceNumber";

	private static readonly IntPtr selDraggingSequenceNumberHandle = Selector.GetHandle("draggingSequenceNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingSource = "draggingSource";

	private static readonly IntPtr selDraggingSourceHandle = Selector.GetHandle("draggingSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingSourceOperationMask = "draggingSourceOperationMask";

	private static readonly IntPtr selDraggingSourceOperationMaskHandle = Selector.GetHandle("draggingSourceOperationMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateDraggingItemsWithOptions_ForView_Classes_SearchOptions_UsingBlock_ = "enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:";

	private static readonly IntPtr selEnumerateDraggingItemsWithOptions_ForView_Classes_SearchOptions_UsingBlock_Handle = Selector.GetHandle("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNamesOfPromisedFilesDroppedAtDestination_ = "namesOfPromisedFilesDroppedAtDestination:";

	private static readonly IntPtr selNamesOfPromisedFilesDroppedAtDestination_Handle = Selector.GetHandle("namesOfPromisedFilesDroppedAtDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfValidItemsForDrop = "numberOfValidItemsForDrop";

	private static readonly IntPtr selNumberOfValidItemsForDropHandle = Selector.GetHandle("numberOfValidItemsForDrop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetSpringLoading = "resetSpringLoading";

	private static readonly IntPtr selResetSpringLoadingHandle = Selector.GetHandle("resetSpringLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimatesToDestination_ = "setAnimatesToDestination:";

	private static readonly IntPtr selSetAnimatesToDestination_Handle = Selector.GetHandle("setAnimatesToDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingFormation_ = "setDraggingFormation:";

	private static readonly IntPtr selSetDraggingFormation_Handle = Selector.GetHandle("setDraggingFormation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfValidItemsForDrop_ = "setNumberOfValidItemsForDrop:";

	private static readonly IntPtr selSetNumberOfValidItemsForDrop_Handle = Selector.GetHandle("setNumberOfValidItemsForDrop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSlideDraggedImageTo_ = "slideDraggedImageTo:";

	private static readonly IntPtr selSlideDraggedImageTo_Handle = Selector.GetHandle("slideDraggedImageTo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpringLoadingHighlight = "springLoadingHighlight";

	private static readonly IntPtr selSpringLoadingHighlightHandle = Selector.GetHandle("springLoadingHighlight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDraggingInfo");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AnimatesToDestination
	{
		[Export("animatesToDestination")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAnimatesToDestinationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAnimatesToDestinationHandle);
		}
		[Export("setAnimatesToDestination:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAnimatesToDestination_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAnimatesToDestination_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'NSDraggingItem' objects instead.")]
	public virtual NSImage DraggedImage
	{
		[Export("draggedImage")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggedImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggedImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint DraggedImageLocation
	{
		[Export("draggedImageLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selDraggedImageLocationHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selDraggedImageLocationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow DraggingDestinationWindow
	{
		[Export("draggingDestinationWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingDestinationWindowHandle));
			}
			return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingDestinationWindowHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDraggingFormation DraggingFormation
	{
		[Export("draggingFormation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSDraggingFormation)Messaging.Int64_objc_msgSend(base.Handle, selDraggingFormationHandle);
			}
			return (NSDraggingFormation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggingFormationHandle);
		}
		[Export("setDraggingFormation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDraggingFormation_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDraggingFormation_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint DraggingLocation
	{
		[Export("draggingLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selDraggingLocationHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selDraggingLocationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPasteboard DraggingPasteboard
	{
		[Export("draggingPasteboard")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPasteboard>(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingPasteboardHandle));
			}
			return Runtime.GetNSObject<NSPasteboard>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingPasteboardHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint DraggingSequenceNumber
	{
		[Export("draggingSequenceNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDraggingSequenceNumberHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDraggingSequenceNumberHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject DraggingSource
	{
		[Export("draggingSource")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingSourceHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingSourceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation DraggingSourceOperationMask
	{
		[Export("draggingSourceOperationMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSDragOperation)Messaging.UInt64_objc_msgSend(base.Handle, selDraggingSourceOperationMaskHandle);
			}
			return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDraggingSourceOperationMaskHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfValidItemsForDrop
	{
		[Export("numberOfValidItemsForDrop")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfValidItemsForDropHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfValidItemsForDropHandle);
		}
		[Export("setNumberOfValidItemsForDrop:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetNumberOfValidItemsForDrop_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetNumberOfValidItemsForDrop_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSSpringLoadingHighlight SpringLoadingHighlight
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("springLoadingHighlight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSSpringLoadingHighlight)Messaging.Int64_objc_msgSend(base.Handle, selSpringLoadingHighlightHandle);
			}
			return (NSSpringLoadingHighlight)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSpringLoadingHighlightHandle);
		}
	}

	public void EnumerateDraggingItems(NSDraggingItemEnumerationOptions enumOpts, NSView view, NSPasteboardReading[] classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
	{
		NSArray nSArray = NSArray.FromNSObjects(classArray);
		EnumerateDraggingItems(enumOpts, view, nSArray.Handle, searchOptions, enumerator);
		nSArray.Dispose();
	}

	public void EnumerateDraggingItems(NSDraggingItemEnumerationOptions enumOpts, NSView view, NSArray classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
	{
		EnumerateDraggingItems(enumOpts, view, classArray.Handle, searchOptions, enumerator);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDraggingInfo()
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
	protected NSDraggingInfo(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDraggingInfo(IntPtr handle)
		: base(handle)
	{
	}

	[Export("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe virtual void EnumerateDraggingItems(NSDraggingItemEnumerationOptions enumOpts, NSView view, IntPtr classArray, NSDictionary searchOptions, [BlockProxy(typeof(Trampolines.NIDNSDraggingEnumerator))] NSDraggingEnumerator enumerator)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (searchOptions == null)
		{
			throw new ArgumentNullException("searchOptions");
		}
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDraggingEnumerator.Handler, enumerator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEnumerateDraggingItemsWithOptions_ForView_Classes_SearchOptions_UsingBlock_Handle, (ulong)enumOpts, view.Handle, classArray, searchOptions.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEnumerateDraggingItemsWithOptions_ForView_Classes_SearchOptions_UsingBlock_Handle, (ulong)enumOpts, view.Handle, classArray, searchOptions.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("namesOfPromisedFilesDroppedAtDestination:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use NSFilePromiseProvider objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] PromisedFilesDroppedAtDestination(NSUrl dropDestination)
	{
		NSApplication.EnsureUIThread();
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
	}

	[Export("resetSpringLoading")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResetSpringLoading()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetSpringLoadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetSpringLoadingHandle);
		}
	}

	[Export("slideDraggedImageTo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SlideDraggedImageTo(CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selSlideDraggedImageTo_Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSlideDraggedImageTo_Handle, screenPoint);
		}
	}
}
