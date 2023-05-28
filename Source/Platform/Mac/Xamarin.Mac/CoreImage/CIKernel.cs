using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIKernel", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CIKernel : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyWithExtent_RoiCallback_Arguments_ = "applyWithExtent:roiCallback:arguments:";

	private static readonly IntPtr selApplyWithExtent_RoiCallback_Arguments_Handle = Selector.GetHandle("applyWithExtent:roiCallback:arguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWithFunctionName_FromMetalLibraryData_Error_ = "kernelWithFunctionName:fromMetalLibraryData:error:";

	private static readonly IntPtr selKernelWithFunctionName_FromMetalLibraryData_Error_Handle = Selector.GetHandle("kernelWithFunctionName:fromMetalLibraryData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWithFunctionName_FromMetalLibraryData_OutputPixelFormat_Error_ = "kernelWithFunctionName:fromMetalLibraryData:outputPixelFormat:error:";

	private static readonly IntPtr selKernelWithFunctionName_FromMetalLibraryData_OutputPixelFormat_Error_Handle = Selector.GetHandle("kernelWithFunctionName:fromMetalLibraryData:outputPixelFormat:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWithString_ = "kernelWithString:";

	private static readonly IntPtr selKernelWithString_Handle = Selector.GetHandle("kernelWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelsWithString_ = "kernelsWithString:";

	private static readonly IntPtr selKernelsWithString_Handle = Selector.GetHandle("kernelsWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetROISelector_ = "setROISelector:";

	private static readonly IntPtr selSetROISelector_Handle = Selector.GetHandle("setROISelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIKernel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("applyWithExtent:roiCallback:arguments:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CIImage ApplyWithExtent(CGRect extent, [BlockProxy(typeof(Trampolines.NIDCIKernelRoiCallback))] CIKernelRoiCallback callback, NSObject[]? args)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCIKernelRoiCallback.Handler, callback);
		NSArray nSArray = ((args == null) ? null : NSArray.FromNSObjects(args));
		CIImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr_IntPtr(base.SuperHandle, selApplyWithExtent_RoiCallback_Arguments_Handle, extent, (IntPtr)ptr, nSArray?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr(base.Handle, selApplyWithExtent_RoiCallback_Arguments_Handle, extent, (IntPtr)ptr, nSArray?.Handle ?? IntPtr.Zero)));
		ptr->CleanupBlock();
		nSArray?.Dispose();
		return result;
	}

	[Export("kernelWithFunctionName:fromMetalLibraryData:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIKernel? FromFunction(string name, NSData data, out NSError? error)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(name);
		CIKernel nSObject = Runtime.GetNSObject<CIKernel>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selKernelWithFunctionName_FromMetalLibraryData_Error_Handle, arg2, data.Handle, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("kernelWithFunctionName:fromMetalLibraryData:outputPixelFormat:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIKernel? FromFunction(string name, NSData data, CIFormat format, out NSError? error)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(name);
		CIKernel nSObject = Runtime.GetNSObject<CIKernel>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int_ref_IntPtr(class_ptr, selKernelWithFunctionName_FromMetalLibraryData_OutputPixelFormat_Error_Handle, arg2, data.Handle, (int)format, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("kernelsWithString:")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIKernel[] FromProgramMultiple(string coreImageShaderProgram)
	{
		if (coreImageShaderProgram == null)
		{
			throw new ArgumentNullException("coreImageShaderProgram");
		}
		IntPtr arg = NSString.CreateNative(coreImageShaderProgram);
		CIKernel[] result = NSArray.ArrayFromHandle<CIKernel>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selKernelsWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("kernelWithString:")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIKernel FromProgramSingle(string coreImageShaderProgram)
	{
		if (coreImageShaderProgram == null)
		{
			throw new ArgumentNullException("coreImageShaderProgram");
		}
		IntPtr arg = NSString.CreateNative(coreImageShaderProgram);
		CIKernel nSObject = Runtime.GetNSObject<CIKernel>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selKernelWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("setROISelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetRegionOfInterestSelector(Selector aMethod)
	{
		if (aMethod == null)
		{
			throw new ArgumentNullException("aMethod");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetROISelector_Handle, aMethod.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetROISelector_Handle, aMethod.Handle);
		}
	}
}
