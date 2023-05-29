using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSComboBoxCellDataSource", true)]
[Model]
public class NSComboBoxCellDataSource : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSComboBoxCellDataSource()
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
	public NSComboBoxCellDataSource(NSCoder coder)
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
	public NSComboBoxCellDataSource(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSComboBoxCellDataSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("comboBoxCell:objectValueForItemAtIndex:")]
	public virtual NSObject ObjectValueForItem(NSComboBoxCell comboBox, int index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("numberOfItemsInComboBoxCell:")]
	public virtual int ItemCount(NSComboBoxCell comboBox)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("comboBoxCell:completedString:")]
	public virtual string CompletedString(NSComboBoxCell comboBox, string uncompletedString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("comboBoxCell:indexOfItemWithStringValue:")]
	public virtual uint IndexOfItem(NSComboBoxCell comboBox, string value)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
