using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSTemporaryNDArray", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MPSTemporaryNDArray : MPSNDArray
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultAllocator = "defaultAllocator";

	private static readonly IntPtr selDefaultAllocatorHandle = Selector.GetHandle("defaultAllocator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadCount = "readCount";

	private static readonly IntPtr selReadCountHandle = Selector.GetHandle("readCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReadCount_ = "setReadCount:";

	private static readonly IntPtr selSetReadCount_Handle = Selector.GetHandle("setReadCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryNDArrayWithCommandBuffer_Descriptor_ = "temporaryNDArrayWithCommandBuffer:descriptor:";

	private static readonly IntPtr selTemporaryNDArrayWithCommandBuffer_Descriptor_Handle = Selector.GetHandle("temporaryNDArrayWithCommandBuffer:descriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSTemporaryNDArray");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static IMPSNDArrayAllocator DefaultAllocator
	{
		[Export("defaultAllocator")]
		get
		{
			return Runtime.GetINativeObject<IMPSNDArrayAllocator>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultAllocatorHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ReadCount
	{
		[Export("readCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selReadCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selReadCountHandle);
		}
		[Export("setReadCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetReadCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetReadCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSTemporaryNDArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSTemporaryNDArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("temporaryNDArrayWithCommandBuffer:descriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSTemporaryNDArray Create(IMTLCommandBuffer commandBuffer, MPSNDArrayDescriptor descriptor)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetNSObject<MPSTemporaryNDArray>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemporaryNDArrayWithCommandBuffer_Descriptor_Handle, commandBuffer.Handle, descriptor.Handle));
	}
}
