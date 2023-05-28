using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLRenderPassColorAttachmentDescriptorArray", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLRenderPassColorAttachmentDescriptorArray : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndexedSubscript_ = "objectAtIndexedSubscript:";

	private static readonly IntPtr selObjectAtIndexedSubscript_Handle = Selector.GetHandle("objectAtIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_AtIndexedSubscript_ = "setObject:atIndexedSubscript:";

	private static readonly IntPtr selSetObject_AtIndexedSubscript_Handle = Selector.GetHandle("setObject:atIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLRenderPassColorAttachmentDescriptorArray");

	public MTLRenderPassColorAttachmentDescriptor this[nint idx]
	{
		get
		{
			return ObjectAtIndexedSubscript((nuint)idx);
		}
		set
		{
			SetObject(value, (nuint)idx);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLRenderPassColorAttachmentDescriptorArray()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MTLRenderPassColorAttachmentDescriptorArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLRenderPassColorAttachmentDescriptorArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("objectAtIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual MTLRenderPassColorAttachmentDescriptor ObjectAtIndexedSubscript(nuint attachmentIndex)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MTLRenderPassColorAttachmentDescriptor>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selObjectAtIndexedSubscript_Handle, attachmentIndex));
		}
		return Runtime.GetNSObject<MTLRenderPassColorAttachmentDescriptor>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selObjectAtIndexedSubscript_Handle, attachmentIndex));
	}

	[Export("setObject:atIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void SetObject(MTLRenderPassColorAttachmentDescriptor attachment, nuint attachmentIndex)
	{
		if (attachment == null)
		{
			throw new ArgumentNullException("attachment");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selSetObject_AtIndexedSubscript_Handle, attachment.Handle, attachmentIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selSetObject_AtIndexedSubscript_Handle, attachment.Handle, attachmentIndex);
		}
	}
}
