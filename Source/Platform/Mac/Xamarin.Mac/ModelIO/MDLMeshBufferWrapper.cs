using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

internal sealed class MDLMeshBufferWrapper : BaseWrapper, IMDLMeshBuffer, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMeshBufferMap Map
	{
		[Export("map")]
		get
		{
			return Runtime.GetNSObject<MDLMeshBufferMap>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("map")));
		}
	}

	[Preserve(Conditional = true)]
	public MDLMeshBufferWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("fillData:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FillData(NSData data, nuint offset)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("fillData:offset:"), data.Handle, offset);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("copyWithZone:"), zone?.Handle ?? IntPtr.Zero));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
