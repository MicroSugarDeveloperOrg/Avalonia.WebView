using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLVertexAttributeData", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLVertexAttributeData : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBufferSize = "bufferSize";

	private static readonly IntPtr selBufferSizeHandle = Selector.GetHandle("bufferSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataStart = "dataStart";

	private static readonly IntPtr selDataStartHandle = Selector.GetHandle("dataStart");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormat = "format";

	private static readonly IntPtr selFormatHandle = Selector.GetHandle("format");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMap = "map";

	private static readonly IntPtr selMapHandle = Selector.GetHandle("map");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBufferSize_ = "setBufferSize:";

	private static readonly IntPtr selSetBufferSize_Handle = Selector.GetHandle("setBufferSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataStart_ = "setDataStart:";

	private static readonly IntPtr selSetDataStart_Handle = Selector.GetHandle("setDataStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormat_ = "setFormat:";

	private static readonly IntPtr selSetFormat_Handle = Selector.GetHandle("setFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMap_ = "setMap:";

	private static readonly IntPtr selSetMap_Handle = Selector.GetHandle("setMap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStride_ = "setStride:";

	private static readonly IntPtr selSetStride_Handle = Selector.GetHandle("setStride:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStride = "stride";

	private static readonly IntPtr selStrideHandle = Selector.GetHandle("stride");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLVertexAttributeData");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	public virtual nuint BufferSize
	{
		[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Export("bufferSize", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBufferSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBufferSizeHandle);
		}
		[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Export("setBufferSize:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetBufferSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetBufferSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr DataStart
	{
		[Export("dataStart", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selDataStartHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataStartHandle);
		}
		[Export("setDataStart:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataStart_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataStart_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLVertexFormat Format
	{
		[Export("format", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLVertexFormat)Messaging.UInt64_objc_msgSend(base.Handle, selFormatHandle);
			}
			return (MDLVertexFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFormatHandle);
		}
		[Export("setFormat:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFormat_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFormat_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMeshBufferMap? Map
	{
		[Export("map", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMeshBufferMap>(Messaging.IntPtr_objc_msgSend(base.Handle, selMapHandle));
			}
			return Runtime.GetNSObject<MDLMeshBufferMap>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMapHandle));
		}
		[Export("setMap:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMap_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMap_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Stride
	{
		[Export("stride", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStrideHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStrideHandle);
		}
		[Export("setStride:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetStride_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetStride_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLVertexAttributeData(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLVertexAttributeData(IntPtr handle)
		: base(handle)
	{
	}
}
