using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSTemporaryVector", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
public class MPSTemporaryVector : MPSVector
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrefetchStorageWithCommandBuffer_DescriptorList_ = "prefetchStorageWithCommandBuffer:descriptorList:";

	private static readonly IntPtr selPrefetchStorageWithCommandBuffer_DescriptorList_Handle = Selector.GetHandle("prefetchStorageWithCommandBuffer:descriptorList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadCount = "readCount";

	private static readonly IntPtr selReadCountHandle = Selector.GetHandle("readCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReadCount_ = "setReadCount:";

	private static readonly IntPtr selSetReadCount_Handle = Selector.GetHandle("setReadCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryVectorWithCommandBuffer_Descriptor_ = "temporaryVectorWithCommandBuffer:descriptor:";

	private static readonly IntPtr selTemporaryVectorWithCommandBuffer_Descriptor_Handle = Selector.GetHandle("temporaryVectorWithCommandBuffer:descriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSTemporaryVector");

	public override IntPtr ClassHandle => class_ptr;

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
	protected MPSTemporaryVector(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSTemporaryVector(IntPtr handle)
		: base(handle)
	{
	}

	[Export("temporaryVectorWithCommandBuffer:descriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSTemporaryVector Create(IMTLCommandBuffer commandBuffer, MPSVectorDescriptor descriptor)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetNSObject<MPSTemporaryVector>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemporaryVectorWithCommandBuffer_Descriptor_Handle, commandBuffer.Handle, descriptor.Handle));
	}

	[Export("prefetchStorageWithCommandBuffer:descriptorList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PrefetchStorage(IMTLCommandBuffer commandBuffer, MPSVectorDescriptor[] descriptorList)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (descriptorList == null)
		{
			throw new ArgumentNullException("descriptorList");
		}
		NSArray nSArray = NSArray.FromNSObjects(descriptorList);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selPrefetchStorageWithCommandBuffer_DescriptorList_Handle, commandBuffer.Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}
