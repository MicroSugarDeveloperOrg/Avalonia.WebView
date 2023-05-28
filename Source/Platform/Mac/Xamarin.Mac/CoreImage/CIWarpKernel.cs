using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIWarpKernel", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CIWarpKernel : CIKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyWithExtent_RoiCallback_InputImage_Arguments_ = "applyWithExtent:roiCallback:inputImage:arguments:";

	private static readonly IntPtr selApplyWithExtent_RoiCallback_InputImage_Arguments_Handle = Selector.GetHandle("applyWithExtent:roiCallback:inputImage:arguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWithString_ = "kernelWithString:";

	private static readonly IntPtr selKernelWithString_Handle = Selector.GetHandle("kernelWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIWarpKernel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIWarpKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIWarpKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("applyWithExtent:roiCallback:inputImage:arguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CIImage ApplyWithExtent(CGRect extent, [BlockProxy(typeof(Trampolines.NIDCIKernelRoiCallback))] CIKernelRoiCallback callback, CIImage image, NSObject[]? args)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCIKernelRoiCallback.Handler, callback);
		NSArray nSArray = ((args == null) ? null : NSArray.FromNSObjects(args));
		CIImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr_IntPtr_IntPtr(base.SuperHandle, selApplyWithExtent_RoiCallback_InputImage_Arguments_Handle, extent, (IntPtr)ptr, image.Handle, nSArray?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr_IntPtr(base.Handle, selApplyWithExtent_RoiCallback_InputImage_Arguments_Handle, extent, (IntPtr)ptr, image.Handle, nSArray?.Handle ?? IntPtr.Zero)));
		ptr->CleanupBlock();
		nSArray?.Dispose();
		return result;
	}

	[Export("kernelWithString:")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static CIWarpKernel FromProgramSingle(string coreImageShaderProgram)
	{
		if (coreImageShaderProgram == null)
		{
			throw new ArgumentNullException("coreImageShaderProgram");
		}
		IntPtr arg = NSString.CreateNative(coreImageShaderProgram);
		CIWarpKernel nSObject = Runtime.GetNSObject<CIWarpKernel>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selKernelWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
