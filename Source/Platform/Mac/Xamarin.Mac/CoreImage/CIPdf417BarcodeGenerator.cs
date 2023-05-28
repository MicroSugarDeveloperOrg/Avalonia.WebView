using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CIPdf417BarcodeGenerator : CICodeGenerator, ICIPdf417BarcodeGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[Obsolete("Use 'InputCorrectionLevel' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public int CorrectionLevel
	{
		get
		{
			return GetInt("inputCorrectionLevel");
		}
		set
		{
			SetInt("inputCorrectionLevel", value);
		}
	}

	[Obsolete("Use 'InputAlwaysSpecifyCompaction' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AlwaysSpecifyCompaction
	{
		get
		{
			return GetBool("inputAlwaysSpecifyCompaction");
		}
		set
		{
			SetBool("inputAlwaysSpecifyCompaction", value);
		}
	}

	[Obsolete("Use 'InputCompactStyle' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool CompactStyle
	{
		get
		{
			return GetBool("inputCompactStyle");
		}
		set
		{
			SetBool("inputCompactStyle", value);
		}
	}

	[Obsolete("Use 'InputCompactStyle' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public int DataColumns
	{
		get
		{
			return GetInt("inputDataColumns");
		}
		set
		{
			SetInt("inputDataColumns", value);
		}
	}

	[Obsolete("Use 'InputCompactionMode' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public int CompactionMode
	{
		get
		{
			return GetInt("inputCompactionMode");
		}
		set
		{
			SetInt("inputCompactionMode", value);
		}
	}

	[Obsolete("Use 'InputRows' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public int Rows
	{
		get
		{
			return GetInt("inputRows");
		}
		set
		{
			SetInt("inputRows", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGImage OutputCGImage => Runtime.GetINativeObject<CGImage>(GetHandle("outputCGImage"), owns: false);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new NSData Message
	{
		[Export("message", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetINativeObject<NSData>(GetHandle("inputMessage"), owns: false);
		}
		[Export("setMessage:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputMessage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MinWidth
	{
		[Export("minWidth")]
		get
		{
			return GetFloat("inputMinWidth");
		}
		[Export("setMinWidth:")]
		set
		{
			SetFloat("inputMinWidth", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MaxWidth
	{
		[Export("maxWidth")]
		get
		{
			return GetFloat("inputMaxWidth");
		}
		[Export("setMaxWidth:")]
		set
		{
			SetFloat("inputMaxWidth", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MinHeight
	{
		[Export("minHeight")]
		get
		{
			return GetFloat("inputMinHeight");
		}
		[Export("setMinHeight:")]
		set
		{
			SetFloat("inputMinHeight", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MaxHeight
	{
		[Export("maxHeight")]
		get
		{
			return GetFloat("inputMaxHeight");
		}
		[Export("setMaxHeight:")]
		set
		{
			SetFloat("inputMaxHeight", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputDataColumns
	{
		[Export("dataColumns")]
		get
		{
			return GetFloat("inputDataColumns");
		}
		[Export("setDataColumns:")]
		set
		{
			SetFloat("inputDataColumns", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputRows
	{
		[Export("rows")]
		get
		{
			return GetFloat("inputRows");
		}
		[Export("setRows:")]
		set
		{
			SetFloat("inputRows", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float PreferredAspectRatio
	{
		[Export("preferredAspectRatio")]
		get
		{
			return GetFloat("inputPreferredAspectRatio");
		}
		[Export("setPreferredAspectRatio:")]
		set
		{
			SetFloat("inputPreferredAspectRatio", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputCompactionMode
	{
		[Export("compactionMode")]
		get
		{
			return GetFloat("inputCompactionMode");
		}
		[Export("setCompactionMode:")]
		set
		{
			SetFloat("inputCompactionMode", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputCompactStyle
	{
		[Export("compactStyle")]
		get
		{
			return GetFloat("inputCompactStyle");
		}
		[Export("setCompactStyle:")]
		set
		{
			SetFloat("inputCompactStyle", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputCorrectionLevel
	{
		[Export("correctionLevel")]
		get
		{
			return GetFloat("inputCorrectionLevel");
		}
		[Export("setCorrectionLevel:")]
		set
		{
			SetFloat("inputCorrectionLevel", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputAlwaysSpecifyCompaction
	{
		[Export("alwaysSpecifyCompaction")]
		get
		{
			return GetFloat("inputAlwaysSpecifyCompaction");
		}
		[Export("setAlwaysSpecifyCompaction:")]
		set
		{
			SetFloat("inputAlwaysSpecifyCompaction", value);
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
	public CIPdf417BarcodeGenerator()
		: base("CIPDF417BarcodeGenerator")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIPdf417BarcodeGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIPdf417BarcodeGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIPdf417BarcodeGenerator(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
