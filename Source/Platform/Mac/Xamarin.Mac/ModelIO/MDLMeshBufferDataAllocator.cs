using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLMeshBufferDataAllocator", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLMeshBufferDataAllocator : NSObject, IMDLMeshBufferAllocator, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewBuffer_Type_ = "newBuffer:type:";

	private static readonly IntPtr selNewBuffer_Type_Handle = Selector.GetHandle("newBuffer:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewBufferFromZone_Data_Type_ = "newBufferFromZone:data:type:";

	private static readonly IntPtr selNewBufferFromZone_Data_Type_Handle = Selector.GetHandle("newBufferFromZone:data:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewBufferFromZone_Length_Type_ = "newBufferFromZone:length:type:";

	private static readonly IntPtr selNewBufferFromZone_Length_Type_Handle = Selector.GetHandle("newBufferFromZone:length:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewBufferWithData_Type_ = "newBufferWithData:type:";

	private static readonly IntPtr selNewBufferWithData_Type_Handle = Selector.GetHandle("newBufferWithData:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewZone_ = "newZone:";

	private static readonly IntPtr selNewZone_Handle = Selector.GetHandle("newZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewZoneForBuffersWithSize_AndType_ = "newZoneForBuffersWithSize:andType:";

	private static readonly IntPtr selNewZoneForBuffersWithSize_AndType_Handle = Selector.GetHandle("newZoneForBuffersWithSize:andType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLMeshBufferDataAllocator");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLMeshBufferDataAllocator()
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
	protected MDLMeshBufferDataAllocator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLMeshBufferDataAllocator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("newBuffer:type:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer CreateBuffer(nuint length, MDLMeshBufferType type)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend_nuint_UInt64(base.Handle, selNewBuffer_Type_Handle, length, (ulong)type), owns: false);
		}
		return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper_nuint_UInt64(base.SuperHandle, selNewBuffer_Type_Handle, length, (ulong)type), owns: false);
	}

	[Export("newBufferWithData:type:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer CreateBuffer(NSData data, MDLMeshBufferType type)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selNewBufferWithData_Type_Handle, data.Handle, (ulong)type), owns: false);
		}
		return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selNewBufferWithData_Type_Handle, data.Handle, (ulong)type), owns: false);
	}

	[Export("newBufferFromZone:length:type:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer? CreateBuffer(IMDLMeshBufferZone? zone, nuint length, MDLMeshBufferType type)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_UInt64(base.Handle, selNewBufferFromZone_Length_Type_Handle, zone?.Handle ?? IntPtr.Zero, length, (ulong)type), owns: false);
		}
		return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_UInt64(base.SuperHandle, selNewBufferFromZone_Length_Type_Handle, zone?.Handle ?? IntPtr.Zero, length, (ulong)type), owns: false);
	}

	[Export("newBufferFromZone:data:type:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer? CreateBuffer(IMDLMeshBufferZone? zone, NSData data, MDLMeshBufferType type)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selNewBufferFromZone_Data_Type_Handle, zone?.Handle ?? IntPtr.Zero, data.Handle, (ulong)type), owns: false);
		}
		return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selNewBufferFromZone_Data_Type_Handle, zone?.Handle ?? IntPtr.Zero, data.Handle, (ulong)type), owns: false);
	}

	[Export("newZone:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBufferZone CreateZone(nuint capacity)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMDLMeshBufferZone>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selNewZone_Handle, capacity), owns: false);
		}
		return Runtime.GetINativeObject<IMDLMeshBufferZone>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selNewZone_Handle, capacity), owns: false);
	}

	[Export("newZoneForBuffersWithSize:andType:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBufferZone CreateZone(NSNumber[] sizes, NSNumber[] types)
	{
		if (sizes == null)
		{
			throw new ArgumentNullException("sizes");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromNSObjects(sizes);
		NSArray nSArray2 = NSArray.FromNSObjects(types);
		IMDLMeshBufferZone result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMDLMeshBufferZone>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selNewZoneForBuffersWithSize_AndType_Handle, nSArray.Handle, nSArray2.Handle), owns: false) : Runtime.GetINativeObject<IMDLMeshBufferZone>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selNewZoneForBuffersWithSize_AndType_Handle, nSArray.Handle, nSArray2.Handle), owns: false));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}
}
