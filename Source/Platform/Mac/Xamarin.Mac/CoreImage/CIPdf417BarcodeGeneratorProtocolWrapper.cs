using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIPdf417BarcodeGeneratorProtocolWrapper : BaseWrapper, ICIPdf417BarcodeGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData Message
	{
		[Export("message", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("message")));
		}
		[Export("setMessage:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setMessage:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MinWidth
	{
		[Export("minWidth")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("minWidth"));
		}
		[Export("setMinWidth:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setMinWidth:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MaxWidth
	{
		[Export("maxWidth")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("maxWidth"));
		}
		[Export("setMaxWidth:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setMaxWidth:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MinHeight
	{
		[Export("minHeight")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("minHeight"));
		}
		[Export("setMinHeight:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setMinHeight:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MaxHeight
	{
		[Export("maxHeight")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("maxHeight"));
		}
		[Export("setMaxHeight:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setMaxHeight:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputDataColumns
	{
		[Export("dataColumns")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("dataColumns"));
		}
		[Export("setDataColumns:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setDataColumns:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputRows
	{
		[Export("rows")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("rows"));
		}
		[Export("setRows:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setRows:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float PreferredAspectRatio
	{
		[Export("preferredAspectRatio")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("preferredAspectRatio"));
		}
		[Export("setPreferredAspectRatio:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setPreferredAspectRatio:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputCompactionMode
	{
		[Export("compactionMode")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("compactionMode"));
		}
		[Export("setCompactionMode:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCompactionMode:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputCompactStyle
	{
		[Export("compactStyle")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("compactStyle"));
		}
		[Export("setCompactStyle:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCompactStyle:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputCorrectionLevel
	{
		[Export("correctionLevel")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("correctionLevel"));
		}
		[Export("setCorrectionLevel:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCorrectionLevel:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputAlwaysSpecifyCompaction
	{
		[Export("alwaysSpecifyCompaction")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("alwaysSpecifyCompaction"));
		}
		[Export("setAlwaysSpecifyCompaction:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setAlwaysSpecifyCompaction:"), value);
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
	public CIPdf417BarcodeGeneratorProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
