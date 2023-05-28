using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIColorKernel", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CIColorKernel : CIKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyWithExtent_Arguments_ = "applyWithExtent:arguments:";

	private static readonly IntPtr selApplyWithExtent_Arguments_Handle = Selector.GetHandle("applyWithExtent:arguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWithString_ = "kernelWithString:";

	private static readonly IntPtr selKernelWithString_Handle = Selector.GetHandle("kernelWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIColorKernel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIColorKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIColorKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("applyWithExtent:arguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage ApplyWithExtent(CGRect extent, NSObject[]? args)
	{
		NSArray nSArray = ((args == null) ? null : NSArray.FromNSObjects(args));
		CIImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selApplyWithExtent_Arguments_Handle, extent, nSArray?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(base.Handle, selApplyWithExtent_Arguments_Handle, extent, nSArray?.Handle ?? IntPtr.Zero)));
		nSArray?.Dispose();
		return result;
	}

	[Export("kernelWithString:")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static CIColorKernel FromProgramSingle(string coreImageShaderProgram)
	{
		if (coreImageShaderProgram == null)
		{
			throw new ArgumentNullException("coreImageShaderProgram");
		}
		IntPtr arg = NSString.CreateNative(coreImageShaderProgram);
		CIColorKernel nSObject = Runtime.GetNSObject<CIColorKernel>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selKernelWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
