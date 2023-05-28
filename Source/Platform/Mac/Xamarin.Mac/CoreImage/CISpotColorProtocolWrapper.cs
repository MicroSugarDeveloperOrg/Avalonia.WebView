using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CISpotColorProtocolWrapper : BaseWrapper, ICISpotColorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? InputImage
	{
		[Export("inputImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("inputImage")));
		}
		[Export("setInputImage:", ArgumentSemantic.Retain)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setInputImage:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor CenterColor1
	{
		[Export("centerColor1", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("centerColor1")));
		}
		[Export("setCenterColor1:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setCenterColor1:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor ReplacementColor1
	{
		[Export("replacementColor1", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("replacementColor1")));
		}
		[Export("setReplacementColor1:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setReplacementColor1:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Closeness1
	{
		[Export("closeness1")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("closeness1"));
		}
		[Export("setCloseness1:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCloseness1:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Contrast1
	{
		[Export("contrast1")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("contrast1"));
		}
		[Export("setContrast1:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setContrast1:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor CenterColor2
	{
		[Export("centerColor2", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("centerColor2")));
		}
		[Export("setCenterColor2:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setCenterColor2:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor ReplacementColor2
	{
		[Export("replacementColor2", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("replacementColor2")));
		}
		[Export("setReplacementColor2:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setReplacementColor2:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Closeness2
	{
		[Export("closeness2")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("closeness2"));
		}
		[Export("setCloseness2:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCloseness2:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Contrast2
	{
		[Export("contrast2")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("contrast2"));
		}
		[Export("setContrast2:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setContrast2:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor CenterColor3
	{
		[Export("centerColor3", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("centerColor3")));
		}
		[Export("setCenterColor3:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setCenterColor3:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor ReplacementColor3
	{
		[Export("replacementColor3", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("replacementColor3")));
		}
		[Export("setReplacementColor3:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setReplacementColor3:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Closeness3
	{
		[Export("closeness3")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("closeness3"));
		}
		[Export("setCloseness3:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCloseness3:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Contrast3
	{
		[Export("contrast3")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("contrast3"));
		}
		[Export("setContrast3:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setContrast3:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public CIImage? OutputImage
	{
		[Export("outputImage")]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("outputImage")));
		}
	}

	[Preserve(Conditional = true)]
	public CISpotColorProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
