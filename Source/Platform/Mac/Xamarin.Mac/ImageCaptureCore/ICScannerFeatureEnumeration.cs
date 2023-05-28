using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICScannerFeatureEnumeration", true)]
public class ICScannerFeatureEnumeration : ICScannerFeature
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentValue = "currentValue";

	private static readonly IntPtr selCurrentValueHandle = Selector.GetHandle("currentValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultValue = "defaultValue";

	private static readonly IntPtr selDefaultValueHandle = Selector.GetHandle("defaultValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuItemLabels = "menuItemLabels";

	private static readonly IntPtr selMenuItemLabelsHandle = Selector.GetHandle("menuItemLabels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuItemLabelsTooltips = "menuItemLabelsTooltips";

	private static readonly IntPtr selMenuItemLabelsTooltipsHandle = Selector.GetHandle("menuItemLabelsTooltips");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentValue_ = "setCurrentValue:";

	private static readonly IntPtr selSetCurrentValue_Handle = Selector.GetHandle("setCurrentValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValues = "values";

	private static readonly IntPtr selValuesHandle = Selector.GetHandle("values");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICScannerFeatureEnumeration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_CurrentValue_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject CurrentValue
	{
		[Export("currentValue", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentValueHandle)));
			MarkDirty();
			__mt_CurrentValue_var = nSObject;
			return nSObject;
		}
		[Export("setCurrentValue:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrentValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrentValue_Handle, value.Handle);
			}
			MarkDirty();
			__mt_CurrentValue_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject DefaultValue
	{
		[Export("defaultValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] MenuItemLabels
	{
		[Export("menuItemLabels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuItemLabelsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuItemLabelsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] MenuItemLabelsTooltips
	{
		[Export("menuItemLabelsTooltips")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuItemLabelsTooltipsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuItemLabelsTooltipsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] Values
	{
		[Export("values")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selValuesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValuesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICScannerFeatureEnumeration(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICScannerFeatureEnumeration(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_CurrentValue_var = null;
		}
	}
}
