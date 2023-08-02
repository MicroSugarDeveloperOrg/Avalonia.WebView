using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAEmitterLayer", true)]
public class CAEmitterLayer : CALayer
{
	private static readonly IntPtr selEmitterCellsHandle = Selector.GetHandle("emitterCells");

	private static readonly IntPtr selSetEmitterCells_Handle = Selector.GetHandle("setEmitterCells:");

	private static readonly IntPtr selBirthRateHandle = Selector.GetHandle("birthRate");

	private static readonly IntPtr selSetBirthRate_Handle = Selector.GetHandle("setBirthRate:");

	private static readonly IntPtr selLifetimeHandle = Selector.GetHandle("lifetime");

	private static readonly IntPtr selSetLifetime_Handle = Selector.GetHandle("setLifetime:");

	private static readonly IntPtr selEmitterPositionHandle = Selector.GetHandle("emitterPosition");

	private static readonly IntPtr selSetEmitterPosition_Handle = Selector.GetHandle("setEmitterPosition:");

	private static readonly IntPtr selEmitterZPositionHandle = Selector.GetHandle("emitterZPosition");

	private static readonly IntPtr selSetEmitterZPosition_Handle = Selector.GetHandle("setEmitterZPosition:");

	private static readonly IntPtr selEmitterSizeHandle = Selector.GetHandle("emitterSize");

	private static readonly IntPtr selSetEmitterSize_Handle = Selector.GetHandle("setEmitterSize:");

	private static readonly IntPtr selEmitterDepthHandle = Selector.GetHandle("emitterDepth");

	private static readonly IntPtr selSetEmitterDepth_Handle = Selector.GetHandle("setEmitterDepth:");

	private static readonly IntPtr selEmitterShapeHandle = Selector.GetHandle("emitterShape");

	private static readonly IntPtr selSetEmitterShape_Handle = Selector.GetHandle("setEmitterShape:");

	private static readonly IntPtr selEmitterModeHandle = Selector.GetHandle("emitterMode");

	private static readonly IntPtr selSetEmitterMode_Handle = Selector.GetHandle("setEmitterMode:");

	private static readonly IntPtr selRenderModeHandle = Selector.GetHandle("renderMode");

	private static readonly IntPtr selSetRenderMode_Handle = Selector.GetHandle("setRenderMode:");

	private static readonly IntPtr selPreservesDepthHandle = Selector.GetHandle("preservesDepth");

	private static readonly IntPtr selSetPreservesDepth_Handle = Selector.GetHandle("setPreservesDepth:");

	private static readonly IntPtr selVelocityHandle = Selector.GetHandle("velocity");

	private static readonly IntPtr selSetVelocity_Handle = Selector.GetHandle("setVelocity:");

	private static readonly IntPtr selScaleHandle = Selector.GetHandle("scale");

	private static readonly IntPtr selSetScale_Handle = Selector.GetHandle("setScale:");

	private static readonly IntPtr selSpinHandle = Selector.GetHandle("spin");

	private static readonly IntPtr selSetSpin_Handle = Selector.GetHandle("setSpin:");

	private static readonly IntPtr selSeedHandle = Selector.GetHandle("seed");

	private static readonly IntPtr selSetSeed_Handle = Selector.GetHandle("setSeed:");

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAEmitterLayer");

	private object __mt_Cells_var;

	private static NSString _ShapePoint;

	private static NSString _ShapeLine;

	private static NSString _ShapeRectangle;

	private static NSString _ShapeCuboid;

	private static NSString _ShapeCircle;

	private static NSString _ShapeSphere;

	private static NSString _ModePoints;

	private static NSString _ModeOutline;

	private static NSString _ModeSurface;

	private static NSString _ModeVolume;

	private static NSString _RenderUnordered;

	private static NSString _RenderOldestFirst;

	private static NSString _RenderOldestLast;

	private static NSString _RenderBackToFront;

	private static NSString _RenderAdditive;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CAEmitterCell[] Cells
	{
		[Export("emitterCells")]
		get
		{
			return (CAEmitterCell[])(__mt_Cells_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<CAEmitterCell>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmitterCellsHandle)) : NSArray.ArrayFromHandle<CAEmitterCell>(Messaging.IntPtr_objc_msgSend(base.Handle, selEmitterCellsHandle))));
		}
		[Export("setEmitterCells:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEmitterCells_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEmitterCells_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Cells_var = value;
		}
	}

	public virtual float BirthRate
	{
		[Export("birthRate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBirthRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBirthRateHandle);
		}
		[Export("setBirthRate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBirthRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBirthRate_Handle, value);
			}
		}
	}

	public virtual float LifeTime
	{
		[Export("lifetime")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLifetimeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLifetimeHandle);
		}
		[Export("setLifetime:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLifetime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLifetime_Handle, value);
			}
		}
	}

	public new virtual CGPoint Position
	{
		[Export("emitterPosition")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selEmitterPositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selEmitterPositionHandle);
		}
		[Export("setEmitterPosition:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetEmitterPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetEmitterPosition_Handle, value);
			}
		}
	}

	public new virtual double ZPosition
	{
		[Export("emitterZPosition")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selEmitterZPositionHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selEmitterZPositionHandle);
		}
		[Export("setEmitterZPosition:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetEmitterZPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetEmitterZPosition_Handle, value);
			}
		}
	}

	public virtual CGSize Size
	{
		[Export("emitterSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selEmitterSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selEmitterSizeHandle);
		}
		[Export("setEmitterSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetEmitterSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetEmitterSize_Handle, value);
			}
		}
	}

	public virtual double Depth
	{
		[Export("emitterDepth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selEmitterDepthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selEmitterDepthHandle);
		}
		[Export("setEmitterDepth:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetEmitterDepth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetEmitterDepth_Handle, value);
			}
		}
	}

	public virtual string Shape
	{
		[Export("emitterShape")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEmitterShapeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmitterShapeHandle));
		}
		[Export("setEmitterShape:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	public virtual string Mode
	{
		[Export("emitterMode")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEmitterModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmitterModeHandle));
		}
		[Export("setEmitterMode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	public virtual string RenderMode
	{
		[Export("renderMode")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRenderModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRenderModeHandle));
		}
		[Export("setRenderMode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	public virtual bool PreservesDepth
	{
		[Export("preservesDepth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesDepthHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesDepthHandle);
		}
		[Export("setPreservesDepth:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesDepth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesDepth_Handle, value);
			}
		}
	}

	public virtual float Velocity
	{
		[Export("velocity")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVelocityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVelocityHandle);
		}
		[Export("setVelocity:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVelocity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVelocity_Handle, value);
			}
		}
	}

	public virtual float Scale
	{
		[Export("scale")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleHandle);
		}
		[Export("setScale:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetScale_Handle, value);
			}
		}
	}

	public virtual float Spin
	{
		[Export("spin")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSpinHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSpinHandle);
		}
		[Export("setSpin:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSpin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSpin_Handle, value);
			}
		}
	}

	public virtual int Seed
	{
		[Export("seed")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSeedHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSeedHandle);
		}
		[Export("setSeed:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetSeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetSeed_Handle, value);
			}
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAEmitterLayer()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CAEmitterLayer(NSCoder coder)
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
	public CAEmitterLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAEmitterLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	public new static CALayer Create()
	{
		return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Cells_var = null;
		}
	}
}
