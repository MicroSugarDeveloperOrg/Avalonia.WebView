using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class CIColorClamp : CIFilter, ICIColorClampProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[Obsolete("Use 'MinComponents' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? InputMinComponents
	{
		get
		{
			return ValueForKey("inputMinComponents") as CIVector;
		}
		set
		{
			SetValue("inputMinComponents", value);
		}
	}

	[Obsolete("Use 'MaxComponents' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? InputMaxComponents
	{
		get
		{
			return ValueForKey("inputMaxComponents") as CIVector;
		}
		set
		{
			SetValue("inputMaxComponents", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? InputImage
	{
		[Export("inputImage", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputImage") as CIImage;
		}
		[Export("setInputImage:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputImage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector MinComponents
	{
		[Export("minComponents", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputMinComponents") as CIVector;
		}
		[Export("setMinComponents:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputMinComponents", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector MaxComponents
	{
		[Export("maxComponents", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputMaxComponents") as CIVector;
		}
		[Export("setMaxComponents:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputMaxComponents", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CIImage? OutputImage
	{
		[Export("outputImage")]
		get
		{
			return ValueForKey("outputImage") as CIImage;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColorClamp()
		: base("CIColorClamp")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColorClamp(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIColorClamp(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIColorClamp(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
