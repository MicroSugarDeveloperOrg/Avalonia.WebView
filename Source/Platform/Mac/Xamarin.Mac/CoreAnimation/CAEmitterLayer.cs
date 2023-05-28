using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAEmitterLayer", true)]
public class CAEmitterLayer : CALayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBirthRate = "birthRate";

	private static readonly IntPtr selBirthRateHandle = Selector.GetHandle("birthRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmitterCells = "emitterCells";

	private static readonly IntPtr selEmitterCellsHandle = Selector.GetHandle("emitterCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmitterDepth = "emitterDepth";

	private static readonly IntPtr selEmitterDepthHandle = Selector.GetHandle("emitterDepth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmitterMode = "emitterMode";

	private static readonly IntPtr selEmitterModeHandle = Selector.GetHandle("emitterMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmitterPosition = "emitterPosition";

	private static readonly IntPtr selEmitterPositionHandle = Selector.GetHandle("emitterPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmitterShape = "emitterShape";

	private static readonly IntPtr selEmitterShapeHandle = Selector.GetHandle("emitterShape");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmitterSize = "emitterSize";

	private static readonly IntPtr selEmitterSizeHandle = Selector.GetHandle("emitterSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmitterZPosition = "emitterZPosition";

	private static readonly IntPtr selEmitterZPositionHandle = Selector.GetHandle("emitterZPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayer = "layer";

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLifetime = "lifetime";

	private static readonly IntPtr selLifetimeHandle = Selector.GetHandle("lifetime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreservesDepth = "preservesDepth";

	private static readonly IntPtr selPreservesDepthHandle = Selector.GetHandle("preservesDepth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderMode = "renderMode";

	private static readonly IntPtr selRenderModeHandle = Selector.GetHandle("renderMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScale = "scale";

	private static readonly IntPtr selScaleHandle = Selector.GetHandle("scale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeed = "seed";

	private static readonly IntPtr selSeedHandle = Selector.GetHandle("seed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBirthRate_ = "setBirthRate:";

	private static readonly IntPtr selSetBirthRate_Handle = Selector.GetHandle("setBirthRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmitterCells_ = "setEmitterCells:";

	private static readonly IntPtr selSetEmitterCells_Handle = Selector.GetHandle("setEmitterCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmitterDepth_ = "setEmitterDepth:";

	private static readonly IntPtr selSetEmitterDepth_Handle = Selector.GetHandle("setEmitterDepth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmitterMode_ = "setEmitterMode:";

	private static readonly IntPtr selSetEmitterMode_Handle = Selector.GetHandle("setEmitterMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmitterPosition_ = "setEmitterPosition:";

	private static readonly IntPtr selSetEmitterPosition_Handle = Selector.GetHandle("setEmitterPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmitterShape_ = "setEmitterShape:";

	private static readonly IntPtr selSetEmitterShape_Handle = Selector.GetHandle("setEmitterShape:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmitterSize_ = "setEmitterSize:";

	private static readonly IntPtr selSetEmitterSize_Handle = Selector.GetHandle("setEmitterSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmitterZPosition_ = "setEmitterZPosition:";

	private static readonly IntPtr selSetEmitterZPosition_Handle = Selector.GetHandle("setEmitterZPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLifetime_ = "setLifetime:";

	private static readonly IntPtr selSetLifetime_Handle = Selector.GetHandle("setLifetime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreservesDepth_ = "setPreservesDepth:";

	private static readonly IntPtr selSetPreservesDepth_Handle = Selector.GetHandle("setPreservesDepth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenderMode_ = "setRenderMode:";

	private static readonly IntPtr selSetRenderMode_Handle = Selector.GetHandle("setRenderMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScale_ = "setScale:";

	private static readonly IntPtr selSetScale_Handle = Selector.GetHandle("setScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSeed_ = "setSeed:";

	private static readonly IntPtr selSetSeed_Handle = Selector.GetHandle("setSeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpin_ = "setSpin:";

	private static readonly IntPtr selSetSpin_Handle = Selector.GetHandle("setSpin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVelocity_ = "setVelocity:";

	private static readonly IntPtr selSetVelocity_Handle = Selector.GetHandle("setVelocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpin = "spin";

	private static readonly IntPtr selSpinHandle = Selector.GetHandle("spin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVelocity = "velocity";

	private static readonly IntPtr selVelocityHandle = Selector.GetHandle("velocity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAEmitterLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModeOutline;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModePoints;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModeSurface;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModeVolume;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RenderAdditive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RenderBackToFront;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RenderOldestFirst;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RenderOldestLast;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RenderUnordered;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShapeCircle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShapeCuboid;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShapeLine;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShapePoint;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShapeRectangle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShapeSphere;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float BirthRate
	{
		[Export("birthRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBirthRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBirthRateHandle);
		}
		[Export("setBirthRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBirthRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBirthRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAEmitterCell[]? Cells
	{
		[Export("emitterCells", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CAEmitterCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selEmitterCellsHandle));
			}
			return NSArray.ArrayFromHandle<CAEmitterCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmitterCellsHandle));
		}
		[Export("setEmitterCells:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEmitterCells_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEmitterCells_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Depth
	{
		[Export("emitterDepth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selEmitterDepthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selEmitterDepthHandle);
		}
		[Export("setEmitterDepth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetEmitterDepth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetEmitterDepth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float LifeTime
	{
		[Export("lifetime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLifetimeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLifetimeHandle);
		}
		[Export("setLifetime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLifetime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLifetime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Mode
	{
		[Export("emitterMode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEmitterModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmitterModeHandle));
		}
		[Export("setEmitterMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEmitterMode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEmitterMode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGPoint Position
	{
		[Export("emitterPosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selEmitterPositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selEmitterPositionHandle);
		}
		[Export("setEmitterPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetEmitterPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetEmitterPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PreservesDepth
	{
		[Export("preservesDepth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesDepthHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesDepthHandle);
		}
		[Export("setPreservesDepth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesDepth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesDepth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string RenderMode
	{
		[Export("renderMode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRenderModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRenderModeHandle));
		}
		[Export("setRenderMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRenderMode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRenderMode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Scale
	{
		[Export("scale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleHandle);
		}
		[Export("setScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Seed
	{
		[Export("seed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSeedHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSeedHandle);
		}
		[Export("setSeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetSeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetSeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Shape
	{
		[Export("emitterShape", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEmitterShapeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmitterShapeHandle));
		}
		[Export("setEmitterShape:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEmitterShape_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEmitterShape_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("emitterSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selEmitterSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selEmitterSizeHandle);
		}
		[Export("setEmitterSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetEmitterSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetEmitterSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Spin
	{
		[Export("spin")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSpinHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSpinHandle);
		}
		[Export("setSpin:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSpin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSpin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Velocity
	{
		[Export("velocity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVelocityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVelocityHandle);
		}
		[Export("setVelocity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVelocity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVelocity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual nfloat ZPosition
	{
		[Export("emitterZPosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selEmitterZPositionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selEmitterZPositionHandle);
		}
		[Export("setEmitterZPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetEmitterZPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetEmitterZPosition_Handle, value);
			}
		}
	}

	[Field("kCAEmitterLayerOutline", "CoreAnimation")]
	public static NSString ModeOutline
	{
		get
		{
			if (_ModeOutline == null)
			{
				_ModeOutline = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerOutline");
			}
			return _ModeOutline;
		}
	}

	[Field("kCAEmitterLayerPoints", "CoreAnimation")]
	public static NSString ModePoints
	{
		get
		{
			if (_ModePoints == null)
			{
				_ModePoints = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerPoints");
			}
			return _ModePoints;
		}
	}

	[Field("kCAEmitterLayerSurface", "CoreAnimation")]
	public static NSString ModeSurface
	{
		get
		{
			if (_ModeSurface == null)
			{
				_ModeSurface = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerSurface");
			}
			return _ModeSurface;
		}
	}

	[Field("kCAEmitterLayerVolume", "CoreAnimation")]
	public static NSString ModeVolume
	{
		get
		{
			if (_ModeVolume == null)
			{
				_ModeVolume = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerVolume");
			}
			return _ModeVolume;
		}
	}

	[Field("kCAEmitterLayerAdditive", "CoreAnimation")]
	public static NSString RenderAdditive
	{
		get
		{
			if (_RenderAdditive == null)
			{
				_RenderAdditive = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerAdditive");
			}
			return _RenderAdditive;
		}
	}

	[Field("kCAEmitterLayerBackToFront", "CoreAnimation")]
	public static NSString RenderBackToFront
	{
		get
		{
			if (_RenderBackToFront == null)
			{
				_RenderBackToFront = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerBackToFront");
			}
			return _RenderBackToFront;
		}
	}

	[Field("kCAEmitterLayerOldestFirst", "CoreAnimation")]
	public static NSString RenderOldestFirst
	{
		get
		{
			if (_RenderOldestFirst == null)
			{
				_RenderOldestFirst = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerOldestFirst");
			}
			return _RenderOldestFirst;
		}
	}

	[Field("kCAEmitterLayerOldestLast", "CoreAnimation")]
	public static NSString RenderOldestLast
	{
		get
		{
			if (_RenderOldestLast == null)
			{
				_RenderOldestLast = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerOldestLast");
			}
			return _RenderOldestLast;
		}
	}

	[Field("kCAEmitterLayerUnordered", "CoreAnimation")]
	public static NSString RenderUnordered
	{
		get
		{
			if (_RenderUnordered == null)
			{
				_RenderUnordered = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerUnordered");
			}
			return _RenderUnordered;
		}
	}

	[Field("kCAEmitterLayerCircle", "CoreAnimation")]
	public static NSString ShapeCircle
	{
		get
		{
			if (_ShapeCircle == null)
			{
				_ShapeCircle = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerCircle");
			}
			return _ShapeCircle;
		}
	}

	[Field("kCAEmitterLayerCuboid", "CoreAnimation")]
	public static NSString ShapeCuboid
	{
		get
		{
			if (_ShapeCuboid == null)
			{
				_ShapeCuboid = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerCuboid");
			}
			return _ShapeCuboid;
		}
	}

	[Field("kCAEmitterLayerLine", "CoreAnimation")]
	public static NSString ShapeLine
	{
		get
		{
			if (_ShapeLine == null)
			{
				_ShapeLine = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerLine");
			}
			return _ShapeLine;
		}
	}

	[Field("kCAEmitterLayerPoint", "CoreAnimation")]
	public static NSString ShapePoint
	{
		get
		{
			if (_ShapePoint == null)
			{
				_ShapePoint = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerPoint");
			}
			return _ShapePoint;
		}
	}

	[Field("kCAEmitterLayerRectangle", "CoreAnimation")]
	public static NSString ShapeRectangle
	{
		get
		{
			if (_ShapeRectangle == null)
			{
				_ShapeRectangle = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerRectangle");
			}
			return _ShapeRectangle;
		}
	}

	[Field("kCAEmitterLayerSphere", "CoreAnimation")]
	public static NSString ShapeSphere
	{
		get
		{
			if (_ShapeSphere == null)
			{
				_ShapeSphere = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAEmitterLayerSphere");
			}
			return _ShapeSphere;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAEmitterLayer()
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
	public CAEmitterLayer(NSCoder coder)
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
	protected CAEmitterLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAEmitterLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static CALayer Create()
	{
		return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}
}
