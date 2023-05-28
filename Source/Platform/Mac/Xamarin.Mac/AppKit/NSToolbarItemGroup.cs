using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSToolbarItemGroup", true)]
public class NSToolbarItemGroup : NSToolbarItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlRepresentation = "controlRepresentation";

	private static readonly IntPtr selControlRepresentationHandle = Selector.GetHandle("controlRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupWithItemIdentifier_Images_SelectionMode_Labels_Target_Action_ = "groupWithItemIdentifier:images:selectionMode:labels:target:action:";

	private static readonly IntPtr selGroupWithItemIdentifier_Images_SelectionMode_Labels_Target_Action_Handle = Selector.GetHandle("groupWithItemIdentifier:images:selectionMode:labels:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupWithItemIdentifier_Titles_SelectionMode_Labels_Target_Action_ = "groupWithItemIdentifier:titles:selectionMode:labels:target:action:";

	private static readonly IntPtr selGroupWithItemIdentifier_Titles_SelectionMode_Labels_Target_Action_Handle = Selector.GetHandle("groupWithItemIdentifier:titles:selectionMode:labels:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithItemIdentifier_ = "initWithItemIdentifier:";

	private static readonly IntPtr selInitWithItemIdentifier_Handle = Selector.GetHandle("initWithItemIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelectedAtIndex_ = "isSelectedAtIndex:";

	private static readonly IntPtr selIsSelectedAtIndex_Handle = Selector.GetHandle("isSelectedAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedIndex = "selectedIndex";

	private static readonly IntPtr selSelectedIndexHandle = Selector.GetHandle("selectedIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionMode = "selectionMode";

	private static readonly IntPtr selSelectionModeHandle = Selector.GetHandle("selectionMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControlRepresentation_ = "setControlRepresentation:";

	private static readonly IntPtr selSetControlRepresentation_Handle = Selector.GetHandle("setControlRepresentation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelected_AtIndex_ = "setSelected:atIndex:";

	private static readonly IntPtr selSetSelected_AtIndex_Handle = Selector.GetHandle("setSelected:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedIndex_ = "setSelectedIndex:";

	private static readonly IntPtr selSetSelectedIndex_Handle = Selector.GetHandle("setSelectedIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionMode_ = "setSelectionMode:";

	private static readonly IntPtr selSetSelectionMode_Handle = Selector.GetHandle("setSelectionMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubitems_ = "setSubitems:";

	private static readonly IntPtr selSetSubitems_Handle = Selector.GetHandle("setSubitems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubitems = "subitems";

	private static readonly IntPtr selSubitemsHandle = Selector.GetHandle("subitems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSToolbarItemGroup");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual NSToolbarItemGroupControlRepresentation ControlRepresentation
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("controlRepresentation", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSToolbarItemGroupControlRepresentation)Messaging.Int64_objc_msgSend(base.Handle, selControlRepresentationHandle);
			}
			return (NSToolbarItemGroupControlRepresentation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selControlRepresentationHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setControlRepresentation:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetControlRepresentation_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetControlRepresentation_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual nint SelectedIndex
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("selectedIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSelectedIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSelectedIndexHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setSelectedIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSelectedIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSelectedIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual NSToolbarItemGroupSelectionMode SelectionMode
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("selectionMode", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSToolbarItemGroupSelectionMode)Messaging.Int64_objc_msgSend(base.Handle, selSelectionModeHandle);
			}
			return (NSToolbarItemGroupSelectionMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSelectionModeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setSelectionMode:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSelectionMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSelectionMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSToolbarItem[] Subitems
	{
		[Export("subitems", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSToolbarItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubitemsHandle));
			}
			return NSArray.ArrayFromHandle<NSToolbarItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubitemsHandle));
		}
		[Export("setSubitems:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubitems_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubitems_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSToolbarItemGroup()
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
	protected NSToolbarItemGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSToolbarItemGroup(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithItemIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSToolbarItemGroup(string itemIdentifier)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		IntPtr arg = NSString.CreateNative(itemIdentifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithItemIdentifier_Handle, arg), "initWithItemIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithItemIdentifier_Handle, arg), "initWithItemIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("groupWithItemIdentifier:titles:selectionMode:labels:target:action:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSToolbarItemGroup Create(string itemIdentifier, string[] titles, NSToolbarItemGroupSelectionMode selectionMode, string[]? labels, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		if (titles == null)
		{
			throw new ArgumentNullException("titles");
		}
		IntPtr arg = NSString.CreateNative(itemIdentifier);
		NSArray nSArray = NSArray.FromStrings(titles);
		NSArray nSArray2 = ((labels == null) ? null : NSArray.FromStrings(labels));
		NSToolbarItemGroup nSObject = Runtime.GetNSObject<NSToolbarItemGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr_IntPtr_IntPtr(class_ptr, selGroupWithItemIdentifier_Titles_SelectionMode_Labels_Target_Action_Handle, arg, nSArray.Handle, (long)selectionMode, nSArray2?.Handle ?? IntPtr.Zero, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		nSArray2?.Dispose();
		return nSObject;
	}

	[Export("groupWithItemIdentifier:images:selectionMode:labels:target:action:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSToolbarItemGroup Create(string itemIdentifier, NSImage[] images, NSToolbarItemGroupSelectionMode selectionMode, string[]? labels, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		if (images == null)
		{
			throw new ArgumentNullException("images");
		}
		IntPtr arg = NSString.CreateNative(itemIdentifier);
		NSArray nSArray = NSArray.FromNSObjects(images);
		NSArray nSArray2 = ((labels == null) ? null : NSArray.FromStrings(labels));
		NSToolbarItemGroup nSObject = Runtime.GetNSObject<NSToolbarItemGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr_IntPtr_IntPtr(class_ptr, selGroupWithItemIdentifier_Images_SelectionMode_Labels_Target_Action_Handle, arg, nSArray.Handle, (long)selectionMode, nSArray2?.Handle ?? IntPtr.Zero, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		nSArray2?.Dispose();
		return nSObject;
	}

	[Export("isSelectedAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetSelected(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selIsSelectedAtIndex_Handle, index);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selIsSelectedAtIndex_Handle, index);
	}

	[Export("setSelected:atIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelected(bool selected, nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_nint(base.Handle, selSetSelected_AtIndex_Handle, selected, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_nint(base.SuperHandle, selSetSelected_AtIndex_Handle, selected, index);
		}
	}
}
