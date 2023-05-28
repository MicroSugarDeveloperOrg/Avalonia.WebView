using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSTemporaryMatrix", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSTemporaryMatrix : MPSMatrix
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrefetchStorageWithCommandBuffer_MatrixDescriptorList_ = "prefetchStorageWithCommandBuffer:matrixDescriptorList:";

	private static readonly IntPtr selPrefetchStorageWithCommandBuffer_MatrixDescriptorList_Handle = Selector.GetHandle("prefetchStorageWithCommandBuffer:matrixDescriptorList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadCount = "readCount";

	private static readonly IntPtr selReadCountHandle = Selector.GetHandle("readCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReadCount_ = "setReadCount:";

	private static readonly IntPtr selSetReadCount_Handle = Selector.GetHandle("setReadCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryMatrixWithCommandBuffer_MatrixDescriptor_ = "temporaryMatrixWithCommandBuffer:matrixDescriptor:";

	private static readonly IntPtr selTemporaryMatrixWithCommandBuffer_MatrixDescriptor_Handle = Selector.GetHandle("temporaryMatrixWithCommandBuffer:matrixDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSTemporaryMatrix");

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
	protected MPSTemporaryMatrix(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSTemporaryMatrix(IntPtr handle)
		: base(handle)
	{
	}

	[Export("temporaryMatrixWithCommandBuffer:matrixDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSTemporaryMatrix Create(IMTLCommandBuffer commandBuffer, MPSMatrixDescriptor matrixDescriptor)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (matrixDescriptor == null)
		{
			throw new ArgumentNullException("matrixDescriptor");
		}
		return Runtime.GetNSObject<MPSTemporaryMatrix>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemporaryMatrixWithCommandBuffer_MatrixDescriptor_Handle, commandBuffer.Handle, matrixDescriptor.Handle));
	}

	[Export("prefetchStorageWithCommandBuffer:matrixDescriptorList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PrefetchStorage(IMTLCommandBuffer commandBuffer, MPSMatrixDescriptor[] descriptorList)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selPrefetchStorageWithCommandBuffer_MatrixDescriptorList_Handle, commandBuffer.Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}
