using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSTokenFieldDelegate", false)]
[Model]
public class NSTokenFieldDelegate : NSObject, INSTokenFieldDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTokenFieldDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTokenFieldDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTokenFieldDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("tokenField:completionsForSubstring:indexOfToken:indexOfSelectedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetCompletionStrings(NSTokenField tokenField, string substring, nint tokenIndex, nint selectedIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:displayStringForRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetDisplayString(NSTokenField tokenField, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:editingStringForRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetEditingString(NSTokenField tokenField, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:menuForRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu GetMenu(NSTokenField tokenField, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:representedObjectForEditingString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? GetRepresentedObject(NSTokenField tokenField, string editingString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:styleForRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTokenStyle GetStyle(NSTokenField tokenField, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:hasMenuForRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasMenu(NSTokenField tokenField, NSObject representedObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:readFromPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] Read(NSTokenField tokenField, NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:shouldAddObjects:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray ShouldAddObjects(NSTokenField tokenField, NSArray tokens, nuint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tokenField:writeRepresentedObjects:toPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteRepresented(NSTokenField tokenField, NSArray objects, NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
