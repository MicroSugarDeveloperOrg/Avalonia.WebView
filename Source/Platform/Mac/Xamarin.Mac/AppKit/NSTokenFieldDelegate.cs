using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTokenFieldDelegate", true)]
[Model]
public class NSTokenFieldDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTokenFieldDelegate()
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
	public NSTokenFieldDelegate(NSCoder coder)
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
	public NSTokenFieldDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTokenFieldDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("tokenField:completionsForSubstring:indexOfToken:indexOfSelectedItem:")]
	public virtual string[] GetCompletionStrings(NSTokenField tokenField, string substring, long tokenIndex, long selectedIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:shouldAddObjects:atIndex:")]
	public virtual NSTokenField[] ShouldAddObjects(NSTokenField tokenField, NSTokenField[] tokens, uint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:displayStringForRepresentedObject:")]
	public virtual string GetDisplayString(NSTokenField tokenField, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:editingStringForRepresentedObject:")]
	public virtual string GetEditingString(NSTokenField tokenField, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:representedObjectForEditingString:")]
	public virtual NSObject GetRepresentedObject(NSTokenField tokenField, string editingString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:writeRepresentedObjects:toPasteboard:")]
	public virtual bool WriteRepresented(NSTokenField tokenField, NSArray objects, NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:readFromPasteboard:")]
	public virtual NSObject[] Read(NSTokenField tokenField, NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:menuForRepresentedObject:")]
	public virtual NSMenu GetMenu(NSTokenField tokenField, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:hasMenuForRepresentedObject:")]
	public virtual bool HasMenu(NSTokenField tokenField, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:styleForRepresentedObject:")]
	public virtual NSTokenStyle GetStyle(NSTokenField tokenField, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
