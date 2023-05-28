using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSComboBoxDataSource", false)]
[Model]
public class NSComboBoxDataSource : NSObject, INSComboBoxDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSComboBoxDataSource()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSComboBoxDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSComboBoxDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("comboBox:completedString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CompletedString(NSComboBox comboBox, string uncompletedString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("comboBox:indexOfItemWithStringValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfItem(NSComboBox comboBox, string value)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("numberOfItemsInComboBox:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ItemCount(NSComboBox comboBox)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("comboBox:objectValueForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectValueForItem(NSComboBox comboBox, nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
