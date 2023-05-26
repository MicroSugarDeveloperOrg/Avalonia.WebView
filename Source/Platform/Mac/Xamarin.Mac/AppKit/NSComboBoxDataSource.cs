using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSComboBoxDataSource", true)]
[Model]
public class NSComboBoxDataSource : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSComboBoxDataSource()
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
	public NSComboBoxDataSource(NSCoder coder)
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
	public NSComboBoxDataSource(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSComboBoxDataSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("comboBox:objectValueForItemAtIndex:")]
	public virtual NSObject ObjectValueForItem(NSComboBox comboBox, long index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("numberOfItemsInComboBox:")]
	public virtual long ItemCount(NSComboBox comboBox)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("comboBox:completedString:")]
	public virtual string CompletedString(NSComboBox comboBox, string uncompletedString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("comboBox:indexOfItemWithStringValue:")]
	public virtual long IndexOfItem(NSComboBox comboBox, string value)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
