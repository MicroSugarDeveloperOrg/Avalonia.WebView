using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMNodeIterator", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomNodeIterator : DomObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetach = "detach";

	private static readonly IntPtr selDetachHandle = Selector.GetHandle("detach");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpandEntityReferences = "expandEntityReferences";

	private static readonly IntPtr selExpandEntityReferencesHandle = Selector.GetHandle("expandEntityReferences");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilter = "filter";

	private static readonly IntPtr selFilterHandle = Selector.GetHandle("filter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextNode = "nextNode";

	private static readonly IntPtr selNextNodeHandle = Selector.GetHandle("nextNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointerBeforeReferenceNode = "pointerBeforeReferenceNode";

	private static readonly IntPtr selPointerBeforeReferenceNodeHandle = Selector.GetHandle("pointerBeforeReferenceNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousNode = "previousNode";

	private static readonly IntPtr selPreviousNodeHandle = Selector.GetHandle("previousNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReferenceNode = "referenceNode";

	private static readonly IntPtr selReferenceNodeHandle = Selector.GetHandle("referenceNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRoot = "root";

	private static readonly IntPtr selRootHandle = Selector.GetHandle("root");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWhatToShow = "whatToShow";

	private static readonly IntPtr selWhatToShowHandle = Selector.GetHandle("whatToShow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMNodeIterator");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExpandEntityReferences
	{
		[Export("expandEntityReferences")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selExpandEntityReferencesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selExpandEntityReferencesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IDomNodeFilter Filter
	{
		[Export("filter", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IDomNodeFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterHandle), owns: false);
			}
			return Runtime.GetINativeObject<IDomNodeFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode NextNode
	{
		[Export("nextNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selNextNodeHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PointerBeforeReferenceNode
	{
		[Export("pointerBeforeReferenceNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPointerBeforeReferenceNodeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPointerBeforeReferenceNodeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode PreviousNode
	{
		[Export("previousNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousNodeHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode ReferenceNode
	{
		[Export("referenceNode", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selReferenceNodeHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReferenceNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode Root
	{
		[Export("root", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selRootHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRootHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint WhatToShow
	{
		[Export("whatToShow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selWhatToShowHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selWhatToShowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomNodeIterator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomNodeIterator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("detach")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Detach()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDetachHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDetachHandle);
		}
	}
}
