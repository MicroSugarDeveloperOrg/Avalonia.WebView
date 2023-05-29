using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIKernel", true)]
public class CIKernel : NSObject
{
	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selKernelsWithString_Handle = Selector.GetHandle("kernelsWithString:");

	private static readonly IntPtr selSetROISelector_Handle = Selector.GetHandle("setROISelector:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIKernel");

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIKernel(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("kernelsWithString:")]
	public static CIKernel[] FromProgram(string coreImageShaderProgram)
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

	[Export("setROISelector:")]
	public virtual void SetRegionOfInterestSelector(Selector aMethod)
	{
		if (aMethod == null)
		{
			throw new ArgumentNullException("aMethod");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetROISelector_Handle, aMethod.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetROISelector_Handle, aMethod.Handle);
		}
	}
}
