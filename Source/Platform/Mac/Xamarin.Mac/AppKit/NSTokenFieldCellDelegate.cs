using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol]
[Register("NSTokenFieldCellDelegate", false)]
[Model]
public class NSTokenFieldCellDelegate : NSObject, INSTokenFieldCellDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTokenFieldCellDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTokenFieldCellDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTokenFieldCellDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("tokenFieldCell:completionsForSubstring:indexOfToken:indexOfSelectedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray GetCompletionStrings(NSTokenFieldCell tokenFieldCell, string substring, nint tokenIndex, ref nint selectedIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenFieldCell:displayStringForRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetDisplayString(NSTokenFieldCell tokenFieldCell, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenFieldCell:editingStringForRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetEditingString(NSTokenFieldCell tokenFieldCell, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenFieldCell:menuForRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu GetMenu(NSTokenFieldCell tokenFieldCell, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenFieldCell:representedObjectForEditingString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? GetRepresentedObject(NSTokenFieldCell tokenFieldCell, string editingString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenFieldCell:styleForRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTokenStyle GetStyle(NSTokenFieldCell tokenFieldCell, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenFieldCell:hasMenuForRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasMenu(NSTokenFieldCell tokenFieldCell, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenFieldCell:readFromPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] Read(NSTokenFieldCell tokenFieldCell, NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenFieldCell:shouldAddObjects:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray ShouldAddObjects(NSTokenFieldCell tokenFieldCell, NSObject[] tokens, nuint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenFieldCell:writeRepresentedObjects:toPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteRepresentedObjects(NSTokenFieldCell tokenFieldCell, NSObject[] objects, NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
