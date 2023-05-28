using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

internal sealed class MDLObjectContainerComponentWrapper : BaseWrapper, IMDLObjectContainerComponent, INativeObject, IDisposable, IMDLComponent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLObject[] Objects
	{
		[Export("objects", ArgumentSemantic.Retain)]
		get
		{
			return NSArray.ArrayFromHandle<MDLObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("objects")));
		}
	}

	[Preserve(Conditional = true)]
	public MDLObjectContainerComponentWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("addObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AddObject(MDLObject @object)
	{
		if (@object == null)
		{
			throw new ArgumentNullException("@object");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("addObject:"), @object.Handle);
	}

	[Export("removeObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RemoveObject(MDLObject @object)
	{
		if (@object == null)
		{
			throw new ArgumentNullException("@object");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("removeObject:"), @object.Handle);
	}
}
