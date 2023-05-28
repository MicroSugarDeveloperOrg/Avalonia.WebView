using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIBlendKernel", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIBlendKernel : CIColorKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyWithForeground_Background_ = "applyWithForeground:background:";

	private static readonly IntPtr selApplyWithForeground_Background_Handle = Selector.GetHandle("applyWithForeground:background:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyWithForeground_Background_ColorSpace_ = "applyWithForeground:background:colorSpace:";

	private static readonly IntPtr selApplyWithForeground_Background_ColorSpace_Handle = Selector.GetHandle("applyWithForeground:background:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClear = "clear";

	private static readonly IntPtr selClearHandle = Selector.GetHandle("clear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColor = "color";

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorBurn = "colorBurn";

	private static readonly IntPtr selColorBurnHandle = Selector.GetHandle("colorBurn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorDodge = "colorDodge";

	private static readonly IntPtr selColorDodgeHandle = Selector.GetHandle("colorDodge");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentAdd = "componentAdd";

	private static readonly IntPtr selComponentAddHandle = Selector.GetHandle("componentAdd");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentMax = "componentMax";

	private static readonly IntPtr selComponentMaxHandle = Selector.GetHandle("componentMax");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentMin = "componentMin";

	private static readonly IntPtr selComponentMinHandle = Selector.GetHandle("componentMin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentMultiply = "componentMultiply";

	private static readonly IntPtr selComponentMultiplyHandle = Selector.GetHandle("componentMultiply");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDarken = "darken";

	private static readonly IntPtr selDarkenHandle = Selector.GetHandle("darken");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDarkerColor = "darkerColor";

	private static readonly IntPtr selDarkerColorHandle = Selector.GetHandle("darkerColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestination = "destination";

	private static readonly IntPtr selDestinationHandle = Selector.GetHandle("destination");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationAtop = "destinationAtop";

	private static readonly IntPtr selDestinationAtopHandle = Selector.GetHandle("destinationAtop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationIn = "destinationIn";

	private static readonly IntPtr selDestinationInHandle = Selector.GetHandle("destinationIn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationOut = "destinationOut";

	private static readonly IntPtr selDestinationOutHandle = Selector.GetHandle("destinationOut");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationOver = "destinationOver";

	private static readonly IntPtr selDestinationOverHandle = Selector.GetHandle("destinationOver");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDifference = "difference";

	private static readonly IntPtr selDifferenceHandle = Selector.GetHandle("difference");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDivide = "divide";

	private static readonly IntPtr selDivideHandle = Selector.GetHandle("divide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExclusion = "exclusion";

	private static readonly IntPtr selExclusionHandle = Selector.GetHandle("exclusion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExclusiveOr = "exclusiveOr";

	private static readonly IntPtr selExclusiveOrHandle = Selector.GetHandle("exclusiveOr");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHardLight = "hardLight";

	private static readonly IntPtr selHardLightHandle = Selector.GetHandle("hardLight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHardMix = "hardMix";

	private static readonly IntPtr selHardMixHandle = Selector.GetHandle("hardMix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHue = "hue";

	private static readonly IntPtr selHueHandle = Selector.GetHandle("hue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelWithString_ = "kernelWithString:";

	private static readonly IntPtr selKernelWithString_Handle = Selector.GetHandle("kernelWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLighten = "lighten";

	private static readonly IntPtr selLightenHandle = Selector.GetHandle("lighten");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLighterColor = "lighterColor";

	private static readonly IntPtr selLighterColorHandle = Selector.GetHandle("lighterColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinearBurn = "linearBurn";

	private static readonly IntPtr selLinearBurnHandle = Selector.GetHandle("linearBurn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinearDodge = "linearDodge";

	private static readonly IntPtr selLinearDodgeHandle = Selector.GetHandle("linearDodge");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinearLight = "linearLight";

	private static readonly IntPtr selLinearLightHandle = Selector.GetHandle("linearLight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLuminosity = "luminosity";

	private static readonly IntPtr selLuminosityHandle = Selector.GetHandle("luminosity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultiply = "multiply";

	private static readonly IntPtr selMultiplyHandle = Selector.GetHandle("multiply");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverlay = "overlay";

	private static readonly IntPtr selOverlayHandle = Selector.GetHandle("overlay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPinLight = "pinLight";

	private static readonly IntPtr selPinLightHandle = Selector.GetHandle("pinLight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaturation = "saturation";

	private static readonly IntPtr selSaturationHandle = Selector.GetHandle("saturation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreen = "screen";

	private static readonly IntPtr selScreenHandle = Selector.GetHandle("screen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSoftLight = "softLight";

	private static readonly IntPtr selSoftLightHandle = Selector.GetHandle("softLight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSource = "source";

	private static readonly IntPtr selSourceHandle = Selector.GetHandle("source");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceAtop = "sourceAtop";

	private static readonly IntPtr selSourceAtopHandle = Selector.GetHandle("sourceAtop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceIn = "sourceIn";

	private static readonly IntPtr selSourceInHandle = Selector.GetHandle("sourceIn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceOut = "sourceOut";

	private static readonly IntPtr selSourceOutHandle = Selector.GetHandle("sourceOut");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceOver = "sourceOver";

	private static readonly IntPtr selSourceOverHandle = Selector.GetHandle("sourceOver");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubtract = "subtract";

	private static readonly IntPtr selSubtractHandle = Selector.GetHandle("subtract");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVividLight = "vividLight";

	private static readonly IntPtr selVividLightHandle = Selector.GetHandle("vividLight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIBlendKernel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Clear
	{
		[Export("clear", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selClearHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Color
	{
		[Export("color", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel ColorBurn
	{
		[Export("colorBurn", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selColorBurnHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel ColorDodge
	{
		[Export("colorDodge", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selColorDodgeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel ComponentAdd
	{
		[Export("componentAdd", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selComponentAddHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel ComponentMax
	{
		[Export("componentMax", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selComponentMaxHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel ComponentMin
	{
		[Export("componentMin", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selComponentMinHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel ComponentMultiply
	{
		[Export("componentMultiply", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selComponentMultiplyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Darken
	{
		[Export("darken", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selDarkenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel DarkerColor
	{
		[Export("darkerColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selDarkerColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Destination
	{
		[Export("destination", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selDestinationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel DestinationAtop
	{
		[Export("destinationAtop", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selDestinationAtopHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel DestinationIn
	{
		[Export("destinationIn", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selDestinationInHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel DestinationOut
	{
		[Export("destinationOut", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selDestinationOutHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel DestinationOver
	{
		[Export("destinationOver", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selDestinationOverHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Difference
	{
		[Export("difference", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selDifferenceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Divide
	{
		[Export("divide", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selDivideHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Exclusion
	{
		[Export("exclusion", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selExclusionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel ExclusiveOr
	{
		[Export("exclusiveOr", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selExclusiveOrHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel HardLight
	{
		[Export("hardLight", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selHardLightHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel HardMix
	{
		[Export("hardMix", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selHardMixHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Hue
	{
		[Export("hue", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selHueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Lighten
	{
		[Export("lighten", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selLightenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel LighterColor
	{
		[Export("lighterColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selLighterColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel LinearBurn
	{
		[Export("linearBurn", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selLinearBurnHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel LinearDodge
	{
		[Export("linearDodge", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selLinearDodgeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel LinearLight
	{
		[Export("linearLight", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selLinearLightHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Luminosity
	{
		[Export("luminosity", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selLuminosityHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Multiply
	{
		[Export("multiply", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selMultiplyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Overlay
	{
		[Export("overlay", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selOverlayHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel PinLight
	{
		[Export("pinLight", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selPinLightHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Saturation
	{
		[Export("saturation", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSaturationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Screen
	{
		[Export("screen", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selScreenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel SoftLight
	{
		[Export("softLight", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSoftLightHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Source
	{
		[Export("source", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSourceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel SourceAtop
	{
		[Export("sourceAtop", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSourceAtopHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel SourceIn
	{
		[Export("sourceIn", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSourceInHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel SourceOut
	{
		[Export("sourceOut", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSourceOutHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel SourceOver
	{
		[Export("sourceOver", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSourceOverHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel Subtract
	{
		[Export("subtract", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSubtractHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel VividLight
	{
		[Export("vividLight", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(class_ptr, selVividLightHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIBlendKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIBlendKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("applyWithForeground:background:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage? Apply(CIImage foreground, CIImage background)
	{
		if (foreground == null)
		{
			throw new ArgumentNullException("foreground");
		}
		if (background == null)
		{
			throw new ArgumentNullException("background");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selApplyWithForeground_Background_Handle, foreground.Handle, background.Handle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selApplyWithForeground_Background_Handle, foreground.Handle, background.Handle));
	}

	[Export("applyWithForeground:background:colorSpace:")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage? Apply(CIImage foreground, CIImage background, CGColorSpace colorSpace)
	{
		if (foreground == null)
		{
			throw new ArgumentNullException("foreground");
		}
		if (background == null)
		{
			throw new ArgumentNullException("background");
		}
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selApplyWithForeground_Background_ColorSpace_Handle, foreground.Handle, background.Handle, colorSpace.Handle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selApplyWithForeground_Background_ColorSpace_Handle, foreground.Handle, background.Handle, colorSpace.Handle));
	}

	[Export("kernelWithString:")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIBlendKernel? CreateKernel(string @string)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		CIBlendKernel nSObject = Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selKernelWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
