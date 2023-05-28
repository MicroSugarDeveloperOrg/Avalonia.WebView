using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol]
[Register("NSComboBoxCellDataSource", false)]
[Model]
public class NSComboBoxCellDataSource : NSObject, INSComboBoxCellDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSComboBoxCellDataSource()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSComboBoxCellDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSComboBoxCellDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("comboBoxCell:completedString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CompletedString(NSComboBoxCell comboBox, string uncompletedString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("comboBoxCell:indexOfItemWithStringValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint IndexOfItem(NSComboBoxCell comboBox, string value)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("numberOfItemsInComboBoxCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ItemCount(NSComboBoxCell comboBox)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("comboBoxCell:objectValueForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectValueForItem(NSComboBoxCell comboBox, nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
