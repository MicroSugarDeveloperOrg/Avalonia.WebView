using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public class CISpotColor : CIFilter, ICISpotColorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
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
	public CIColor CenterColor1
	{
		[Export("centerColor1", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputCenterColor1") as CIColor;
		}
		[Export("setCenterColor1:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputCenterColor1", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor ReplacementColor1
	{
		[Export("replacementColor1", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputReplacementColor1") as CIColor;
		}
		[Export("setReplacementColor1:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputReplacementColor1", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Closeness1
	{
		[Export("closeness1")]
		get
		{
			return GetFloat("inputCloseness1");
		}
		[Export("setCloseness1:")]
		set
		{
			SetFloat("inputCloseness1", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Contrast1
	{
		[Export("contrast1")]
		get
		{
			return GetFloat("inputContrast1");
		}
		[Export("setContrast1:")]
		set
		{
			SetFloat("inputContrast1", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor CenterColor2
	{
		[Export("centerColor2", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputCenterColor2") as CIColor;
		}
		[Export("setCenterColor2:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputCenterColor2", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor ReplacementColor2
	{
		[Export("replacementColor2", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputReplacementColor2") as CIColor;
		}
		[Export("setReplacementColor2:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputReplacementColor2", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Closeness2
	{
		[Export("closeness2")]
		get
		{
			return GetFloat("inputCloseness2");
		}
		[Export("setCloseness2:")]
		set
		{
			SetFloat("inputCloseness2", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Contrast2
	{
		[Export("contrast2")]
		get
		{
			return GetFloat("inputContrast2");
		}
		[Export("setContrast2:")]
		set
		{
			SetFloat("inputContrast2", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor CenterColor3
	{
		[Export("centerColor3", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputCenterColor3") as CIColor;
		}
		[Export("setCenterColor3:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputCenterColor3", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor ReplacementColor3
	{
		[Export("replacementColor3", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputReplacementColor3") as CIColor;
		}
		[Export("setReplacementColor3:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputReplacementColor3", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Closeness3
	{
		[Export("closeness3")]
		get
		{
			return GetFloat("inputCloseness3");
		}
		[Export("setCloseness3:")]
		set
		{
			SetFloat("inputCloseness3", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Contrast3
	{
		[Export("contrast3")]
		get
		{
			return GetFloat("inputContrast3");
		}
		[Export("setContrast3:")]
		set
		{
			SetFloat("inputContrast3", value);
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
	public CISpotColor()
		: base("CISpotColor")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CISpotColor(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CISpotColor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CISpotColor(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
