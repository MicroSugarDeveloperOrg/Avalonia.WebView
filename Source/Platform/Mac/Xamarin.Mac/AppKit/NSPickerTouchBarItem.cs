using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPickerTouchBarItem", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSPickerTouchBarItem : NSTouchBarItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAction = "action";

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapsedRepresentationImage = "collapsedRepresentationImage";

	private static readonly IntPtr selCollapsedRepresentationImageHandle = Selector.GetHandle("collapsedRepresentationImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapsedRepresentationLabel = "collapsedRepresentationLabel";

	private static readonly IntPtr selCollapsedRepresentationLabelHandle = Selector.GetHandle("collapsedRepresentationLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlRepresentation = "controlRepresentation";

	private static readonly IntPtr selControlRepresentationHandle = Selector.GetHandle("controlRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomizationLabel = "customizationLabel";

	private static readonly IntPtr selCustomizationLabelHandle = Selector.GetHandle("customizationLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageAtIndex_ = "imageAtIndex:";

	private static readonly IntPtr selImageAtIndex_Handle = Selector.GetHandle("imageAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabledAtIndex_ = "isEnabledAtIndex:";

	private static readonly IntPtr selIsEnabledAtIndex_Handle = Selector.GetHandle("isEnabledAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelAtIndex_ = "labelAtIndex:";

	private static readonly IntPtr selLabelAtIndex_Handle = Selector.GetHandle("labelAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfOptions = "numberOfOptions";

	private static readonly IntPtr selNumberOfOptionsHandle = Selector.GetHandle("numberOfOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPickerTouchBarItemWithIdentifier_Images_SelectionMode_Target_Action_ = "pickerTouchBarItemWithIdentifier:images:selectionMode:target:action:";

	private static readonly IntPtr selPickerTouchBarItemWithIdentifier_Images_SelectionMode_Target_Action_Handle = Selector.GetHandle("pickerTouchBarItemWithIdentifier:images:selectionMode:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPickerTouchBarItemWithIdentifier_Labels_SelectionMode_Target_Action_ = "pickerTouchBarItemWithIdentifier:labels:selectionMode:target:action:";

	private static readonly IntPtr selPickerTouchBarItemWithIdentifier_Labels_SelectionMode_Target_Action_Handle = Selector.GetHandle("pickerTouchBarItemWithIdentifier:labels:selectionMode:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedIndex = "selectedIndex";

	private static readonly IntPtr selSelectedIndexHandle = Selector.GetHandle("selectedIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionColor = "selectionColor";

	private static readonly IntPtr selSelectionColorHandle = Selector.GetHandle("selectionColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionMode = "selectionMode";

	private static readonly IntPtr selSelectionModeHandle = Selector.GetHandle("selectionMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAction_ = "setAction:";

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollapsedRepresentationImage_ = "setCollapsedRepresentationImage:";

	private static readonly IntPtr selSetCollapsedRepresentationImage_Handle = Selector.GetHandle("setCollapsedRepresentationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollapsedRepresentationLabel_ = "setCollapsedRepresentationLabel:";

	private static readonly IntPtr selSetCollapsedRepresentationLabel_Handle = Selector.GetHandle("setCollapsedRepresentationLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControlRepresentation_ = "setControlRepresentation:";

	private static readonly IntPtr selSetControlRepresentation_Handle = Selector.GetHandle("setControlRepresentation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomizationLabel_ = "setCustomizationLabel:";

	private static readonly IntPtr selSetCustomizationLabel_Handle = Selector.GetHandle("setCustomizationLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_AtIndex_ = "setEnabled:atIndex:";

	private static readonly IntPtr selSetEnabled_AtIndex_Handle = Selector.GetHandle("setEnabled:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImage_AtIndex_ = "setImage:atIndex:";

	private static readonly IntPtr selSetImage_AtIndex_Handle = Selector.GetHandle("setImage:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLabel_AtIndex_ = "setLabel:atIndex:";

	private static readonly IntPtr selSetLabel_AtIndex_Handle = Selector.GetHandle("setLabel:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfOptions_ = "setNumberOfOptions:";

	private static readonly IntPtr selSetNumberOfOptions_Handle = Selector.GetHandle("setNumberOfOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedIndex_ = "setSelectedIndex:";

	private static readonly IntPtr selSetSelectedIndex_Handle = Selector.GetHandle("setSelectedIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionColor_ = "setSelectionColor:";

	private static readonly IntPtr selSetSelectionColor_Handle = Selector.GetHandle("setSelectionColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionMode_ = "setSelectionMode:";

	private static readonly IntPtr selSetSelectionMode_Handle = Selector.GetHandle("setSelectionMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTarget_ = "setTarget:";

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTarget = "target";

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPickerTouchBarItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Target_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Selector? Action
	{
		[Export("action", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionHandle));
		}
		[Export("setAction:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage? CollapsedRepresentationImage
	{
		[Export("collapsedRepresentationImage", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selCollapsedRepresentationImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollapsedRepresentationImageHandle));
		}
		[Export("setCollapsedRepresentationImage:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCollapsedRepresentationImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCollapsedRepresentationImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CollapsedRepresentationLabel
	{
		[Export("collapsedRepresentationLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCollapsedRepresentationLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollapsedRepresentationLabelHandle));
		}
		[Export("setCollapsedRepresentationLabel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCollapsedRepresentationLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCollapsedRepresentationLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPickerTouchBarItemControlRepresentation ControlRepresentation
	{
		[Export("controlRepresentation", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSPickerTouchBarItemControlRepresentation)Messaging.Int64_objc_msgSend(base.Handle, selControlRepresentationHandle);
			}
			return (NSPickerTouchBarItemControlRepresentation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selControlRepresentationHandle);
		}
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
	public new virtual string CustomizationLabel
	{
		[Export("customizationLabel", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomizationLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomizationLabelHandle));
		}
		[Export("setCustomizationLabel:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomizationLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomizationLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfOptions
	{
		[Export("numberOfOptions")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfOptionsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfOptionsHandle);
		}
		[Export("setNumberOfOptions:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetNumberOfOptions_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetNumberOfOptions_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedIndex
	{
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
	public virtual NSColor? SelectionColor
	{
		[Export("selectionColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionColorHandle));
		}
		[Export("setSelectionColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectionColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPickerTouchBarItemSelectionMode SelectionMode
	{
		[Export("selectionMode", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSPickerTouchBarItemSelectionMode)Messaging.Int64_objc_msgSend(base.Handle, selSelectionModeHandle);
			}
			return (NSPickerTouchBarItemSelectionMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSelectionModeHandle);
		}
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
	public virtual NSObject? Target
	{
		[Export("target", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle)));
			MarkDirty();
			__mt_Target_var = nSObject;
			return nSObject;
		}
		[Export("setTarget:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Target_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSPickerTouchBarItem(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPickerTouchBarItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPickerTouchBarItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("pickerTouchBarItemWithIdentifier:labels:selectionMode:target:action:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPickerTouchBarItem Create(NSTouchBarItemIdentifier identifier, string[] labels, NSPickerTouchBarItemSelectionMode selectionMode, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		NSArray nSArray = NSArray.FromStrings(labels);
		NSPickerTouchBarItem nSObject = Runtime.GetNSObject<NSPickerTouchBarItem>(Messaging.IntPtr_objc_msgSend_int_IntPtr_Int64_IntPtr_IntPtr(class_ptr, selPickerTouchBarItemWithIdentifier_Labels_SelectionMode_Target_Action_Handle, (int)identifier, nSArray.Handle, (long)selectionMode, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("pickerTouchBarItemWithIdentifier:images:selectionMode:target:action:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPickerTouchBarItem Create(NSTouchBarItemIdentifier identifier, NSImage[] images, NSPickerTouchBarItemSelectionMode selectionMode, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		if (images == null)
		{
			throw new ArgumentNullException("images");
		}
		NSArray nSArray = NSArray.FromNSObjects(images);
		NSPickerTouchBarItem nSObject = Runtime.GetNSObject<NSPickerTouchBarItem>(Messaging.IntPtr_objc_msgSend_int_IntPtr_Int64_IntPtr_IntPtr(class_ptr, selPickerTouchBarItemWithIdentifier_Images_SelectionMode_Target_Action_Handle, (int)identifier, nSArray.Handle, (long)selectionMode, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("isEnabledAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetEnabled(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selIsEnabledAtIndex_Handle, index);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selIsEnabledAtIndex_Handle, index);
	}

	[Export("imageAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage? GetImage(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selImageAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selImageAtIndex_Handle, index));
	}

	[Export("labelAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetLabel(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selLabelAtIndex_Handle, index));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selLabelAtIndex_Handle, index));
	}

	[Export("setEnabled:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetEnabled(bool enabled, nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_nint(base.Handle, selSetEnabled_AtIndex_Handle, enabled, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_nint(base.SuperHandle, selSetEnabled_AtIndex_Handle, enabled, index);
		}
	}

	[Export("setImage:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetImage(NSImage? image, nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetImage_AtIndex_Handle, image?.Handle ?? IntPtr.Zero, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetImage_AtIndex_Handle, image?.Handle ?? IntPtr.Zero, index);
		}
	}

	[Export("setLabel:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLabel(string label, nint index)
	{
		NSApplication.EnsureUIThread();
		if (label == null)
		{
			throw new ArgumentNullException("label");
		}
		IntPtr arg = NSString.CreateNative(label);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetLabel_AtIndex_Handle, arg, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetLabel_AtIndex_Handle, arg, index);
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Target_var = null;
		}
	}
}
