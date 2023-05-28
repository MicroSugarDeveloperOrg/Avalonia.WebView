using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNLossDataDescriptor", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnLossDataDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytesPerImage = "bytesPerImage";

	private static readonly IntPtr selBytesPerImageHandle = Selector.GetHandle("bytesPerImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytesPerRow = "bytesPerRow";

	private static readonly IntPtr selBytesPerRowHandle = Selector.GetHandle("bytesPerRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCnnLossDataDescriptorWithData_Layout_Size_ = "cnnLossDataDescriptorWithData:layout:size:";

	private static readonly IntPtr selCnnLossDataDescriptorWithData_Layout_Size_Handle = Selector.GetHandle("cnnLossDataDescriptorWithData:layout:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayout = "layout";

	private static readonly IntPtr selLayoutHandle = Selector.GetHandle("layout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBytesPerImage_ = "setBytesPerImage:";

	private static readonly IntPtr selSetBytesPerImage_Handle = Selector.GetHandle("setBytesPerImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBytesPerRow_ = "setBytesPerRow:";

	private static readonly IntPtr selSetBytesPerRow_Handle = Selector.GetHandle("setBytesPerRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNLossDataDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BytesPerImage
	{
		[Export("bytesPerImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBytesPerImageHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBytesPerImageHandle);
		}
		[Export("setBytesPerImage:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetBytesPerImage_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetBytesPerImage_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BytesPerRow
	{
		[Export("bytesPerRow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBytesPerRowHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBytesPerRowHandle);
		}
		[Export("setBytesPerRow:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetBytesPerRow_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetBytesPerRow_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSDataLayout Layout
	{
		[Export("layout")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSDataLayout)Messaging.UInt64_objc_msgSend(base.Handle, selLayoutHandle);
			}
			return (MPSDataLayout)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLayoutHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLSize Size
	{
		[Export("size")]
		get
		{
			MTLSize retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLSize_objc_msgSend_stret(out retval, base.Handle, selSizeHandle);
			}
			else
			{
				Messaging.MTLSize_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSizeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnLossDataDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnLossDataDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("cnnLossDataDescriptorWithData:layout:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnLossDataDescriptor? Create(NSData data, MPSDataLayout layout, MTLSize size)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<MPSCnnLossDataDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_MTLSize(class_ptr, selCnnLossDataDescriptorWithData_Layout_Size_Handle, data.Handle, (ulong)layout, size));
	}
}
