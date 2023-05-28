using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using OpenTK;
using SceneKit;

namespace ModelIO;

[Register("MDLLight", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLLight : MDLObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpace = "colorSpace";

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIrradianceAtPoint_ = "irradianceAtPoint:";

	private static readonly IntPtr selIrradianceAtPoint_Handle = Selector.GetHandle("irradianceAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIrradianceAtPoint_ColorSpace_ = "irradianceAtPoint:colorSpace:";

	private static readonly IntPtr selIrradianceAtPoint_ColorSpace_Handle = Selector.GetHandle("irradianceAtPoint:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightType = "lightType";

	private static readonly IntPtr selLightTypeHandle = Selector.GetHandle("lightType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightWithSCNLight_ = "lightWithSCNLight:";

	private static readonly IntPtr selLightWithSCNLight_Handle = Selector.GetHandle("lightWithSCNLight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorSpace_ = "setColorSpace:";

	private static readonly IntPtr selSetColorSpace_Handle = Selector.GetHandle("setColorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLightType_ = "setLightType:";

	private static readonly IntPtr selSetLightType_Handle = Selector.GetHandle("setLightType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLLight");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual NSString ColorSpace
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("colorSpace")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle));
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setColorSpace:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColorSpace_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColorSpace_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLLightType LightType
	{
		[Export("lightType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLLightType)Messaging.UInt64_objc_msgSend(base.Handle, selLightTypeHandle);
			}
			return (MDLLightType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLightTypeHandle);
		}
		[Export("setLightType:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLightType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLightType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLLight()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLLight(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLLight(IntPtr handle)
		: base(handle)
	{
	}

	[Export("lightWithSCNLight:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLLight FromSceneLight(SCNLight sceneLight)
	{
		if (sceneLight == null)
		{
			throw new ArgumentNullException("sceneLight");
		}
		return Runtime.GetNSObject<MDLLight>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLightWithSCNLight_Handle, sceneLight.Handle));
	}

	[Export("irradianceAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor GetIrradiance(Vector3 point)
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3(base.SuperHandle, selIrradianceAtPoint_Handle, point) : Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3(base.Handle, selIrradianceAtPoint_Handle, point));
		return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
	}

	[Export("irradianceAtPoint:colorSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor GetIrradiance(Vector3 point, CGColorSpace colorSpace)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_IntPtr(base.SuperHandle, selIrradianceAtPoint_ColorSpace_Handle, point, colorSpace.Handle) : Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_IntPtr(base.Handle, selIrradianceAtPoint_ColorSpace_Handle, point, colorSpace.Handle));
		return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
	}
}
