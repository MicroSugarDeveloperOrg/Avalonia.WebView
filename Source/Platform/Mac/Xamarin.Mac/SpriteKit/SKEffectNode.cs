using System;
using System.ComponentModel;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKEffectNode", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKEffectNode : SKNode, ISKWarpable, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeValues = "attributeValues";

	private static readonly IntPtr selAttributeValuesHandle = Selector.GetHandle("attributeValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendMode = "blendMode";

	private static readonly IntPtr selBlendModeHandle = Selector.GetHandle("blendMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilter = "filter";

	private static readonly IntPtr selFilterHandle = Selector.GetHandle("filter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeValues_ = "setAttributeValues:";

	private static readonly IntPtr selSetAttributeValues_Handle = Selector.GetHandle("setAttributeValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendMode_ = "setBlendMode:";

	private static readonly IntPtr selSetBlendMode_Handle = Selector.GetHandle("setBlendMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFilter_ = "setFilter:";

	private static readonly IntPtr selSetFilter_Handle = Selector.GetHandle("setFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShader_ = "setShader:";

	private static readonly IntPtr selSetShader_Handle = Selector.GetHandle("setShader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldCenterFilter_ = "setShouldCenterFilter:";

	private static readonly IntPtr selSetShouldCenterFilter_Handle = Selector.GetHandle("setShouldCenterFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldEnableEffects_ = "setShouldEnableEffects:";

	private static readonly IntPtr selSetShouldEnableEffects_Handle = Selector.GetHandle("setShouldEnableEffects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldRasterize_ = "setShouldRasterize:";

	private static readonly IntPtr selSetShouldRasterize_Handle = Selector.GetHandle("setShouldRasterize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubdivisionLevels_ = "setSubdivisionLevels:";

	private static readonly IntPtr selSetSubdivisionLevels_Handle = Selector.GetHandle("setSubdivisionLevels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForAttributeNamed_ = "setValue:forAttributeNamed:";

	private static readonly IntPtr selSetValue_ForAttributeNamed_Handle = Selector.GetHandle("setValue:forAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWarpGeometry_ = "setWarpGeometry:";

	private static readonly IntPtr selSetWarpGeometry_Handle = Selector.GetHandle("setWarpGeometry:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShader = "shader";

	private static readonly IntPtr selShaderHandle = Selector.GetHandle("shader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldCenterFilter = "shouldCenterFilter";

	private static readonly IntPtr selShouldCenterFilterHandle = Selector.GetHandle("shouldCenterFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldEnableEffects = "shouldEnableEffects";

	private static readonly IntPtr selShouldEnableEffectsHandle = Selector.GetHandle("shouldEnableEffects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldRasterize = "shouldRasterize";

	private static readonly IntPtr selShouldRasterizeHandle = Selector.GetHandle("shouldRasterize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubdivisionLevels = "subdivisionLevels";

	private static readonly IntPtr selSubdivisionLevelsHandle = Selector.GetHandle("subdivisionLevels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForAttributeNamed_ = "valueForAttributeNamed:";

	private static readonly IntPtr selValueForAttributeNamed_Handle = Selector.GetHandle("valueForAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWarpGeometry = "warpGeometry";

	private static readonly IntPtr selWarpGeometryHandle = Selector.GetHandle("warpGeometry");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKEffectNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WarpGeometry_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public new virtual NSDictionary<NSString, SKAttributeValue> AttributeValues
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("attributeValues", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeValuesHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeValuesHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAttributeValues:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributeValues_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeValues_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKBlendMode BlendMode
	{
		[Export("blendMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKBlendMode)Messaging.Int64_objc_msgSend(base.Handle, selBlendModeHandle);
			}
			return (SKBlendMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBlendModeHandle);
		}
		[Export("setBlendMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBlendMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBlendMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual CIFilter? Filter
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("filter", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterHandle));
			}
			return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setFilter:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SKShader? Shader
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("shader", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSend(base.Handle, selShaderHandle));
			}
			return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShaderHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setShader:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldCenterFilter
	{
		[Export("shouldCenterFilter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldCenterFilterHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldCenterFilterHandle);
		}
		[Export("setShouldCenterFilter:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldCenterFilter_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldCenterFilter_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldEnableEffects
	{
		[Export("shouldEnableEffects")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldEnableEffectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldEnableEffectsHandle);
		}
		[Export("setShouldEnableEffects:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldEnableEffects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldEnableEffects_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldRasterize
	{
		[Export("shouldRasterize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldRasterizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldRasterizeHandle);
		}
		[Export("setShouldRasterize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldRasterize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldRasterize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual nint SubdivisionLevels
	{
		[Export("subdivisionLevels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSubdivisionLevelsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSubdivisionLevelsHandle);
		}
		[Export("setSubdivisionLevels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSubdivisionLevels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSubdivisionLevels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual SKWarpGeometry? WarpGeometry
	{
		[Export("warpGeometry", ArgumentSemantic.Assign)]
		get
		{
			SKWarpGeometry sKWarpGeometry = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKWarpGeometry>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWarpGeometryHandle)) : Runtime.GetNSObject<SKWarpGeometry>(Messaging.IntPtr_objc_msgSend(base.Handle, selWarpGeometryHandle)));
			MarkDirty();
			__mt_WarpGeometry_var = sKWarpGeometry;
			return sKWarpGeometry;
		}
		[Export("setWarpGeometry:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWarpGeometry_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWarpGeometry_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WarpGeometry_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKEffectNode()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKEffectNode(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKEffectNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKEffectNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("valueForAttributeNamed:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual SKAttributeValue? GetValue(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		SKAttributeValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKAttributeValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForAttributeNamed_Handle, arg)) : Runtime.GetNSObject<SKAttributeValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForAttributeNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setValue:forAttributeNamed:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void SetValue(SKAttributeValue value, string key)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValue_ForAttributeNamed_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValue_ForAttributeNamed_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WarpGeometry_var = null;
		}
	}
}
