using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAEmitterCell", true)]
public class CAEmitterCell : NSObject
{
	private CGImage contents;

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	private static readonly IntPtr selBirthRateHandle = Selector.GetHandle("birthRate");

	private static readonly IntPtr selSetBirthRate_Handle = Selector.GetHandle("setBirthRate:");

	private static readonly IntPtr selLifetimeHandle = Selector.GetHandle("lifetime");

	private static readonly IntPtr selSetLifetime_Handle = Selector.GetHandle("setLifetime:");

	private static readonly IntPtr selLifetimeRangeHandle = Selector.GetHandle("lifetimeRange");

	private static readonly IntPtr selSetLifetimeRange_Handle = Selector.GetHandle("setLifetimeRange:");

	private static readonly IntPtr selEmissionLatitudeHandle = Selector.GetHandle("emissionLatitude");

	private static readonly IntPtr selSetEmissionLatitude_Handle = Selector.GetHandle("setEmissionLatitude:");

	private static readonly IntPtr selEmissionLongitudeHandle = Selector.GetHandle("emissionLongitude");

	private static readonly IntPtr selSetEmissionLongitude_Handle = Selector.GetHandle("setEmissionLongitude:");

	private static readonly IntPtr selEmissionRangeHandle = Selector.GetHandle("emissionRange");

	private static readonly IntPtr selSetEmissionRange_Handle = Selector.GetHandle("setEmissionRange:");

	private static readonly IntPtr selVelocityHandle = Selector.GetHandle("velocity");

	private static readonly IntPtr selSetVelocity_Handle = Selector.GetHandle("setVelocity:");

	private static readonly IntPtr selVelocityRangeHandle = Selector.GetHandle("velocityRange");

	private static readonly IntPtr selSetVelocityRange_Handle = Selector.GetHandle("setVelocityRange:");

	private static readonly IntPtr selXAccelerationHandle = Selector.GetHandle("xAcceleration");

	private static readonly IntPtr selSetXAcceleration_Handle = Selector.GetHandle("setXAcceleration:");

	private static readonly IntPtr selYAccelerationHandle = Selector.GetHandle("yAcceleration");

	private static readonly IntPtr selSetYAcceleration_Handle = Selector.GetHandle("setYAcceleration:");

	private static readonly IntPtr selZAccelerationHandle = Selector.GetHandle("zAcceleration");

	private static readonly IntPtr selSetZAcceleration_Handle = Selector.GetHandle("setZAcceleration:");

	private static readonly IntPtr selScaleHandle = Selector.GetHandle("scale");

	private static readonly IntPtr selSetScale_Handle = Selector.GetHandle("setScale:");

	private static readonly IntPtr selScaleRangeHandle = Selector.GetHandle("scaleRange");

	private static readonly IntPtr selSetScaleRange_Handle = Selector.GetHandle("setScaleRange:");

	private static readonly IntPtr selScaleSpeedHandle = Selector.GetHandle("scaleSpeed");

	private static readonly IntPtr selSetScaleSpeed_Handle = Selector.GetHandle("setScaleSpeed:");

	private static readonly IntPtr selSpinHandle = Selector.GetHandle("spin");

	private static readonly IntPtr selSetSpin_Handle = Selector.GetHandle("setSpin:");

	private static readonly IntPtr selSpinRangeHandle = Selector.GetHandle("spinRange");

	private static readonly IntPtr selSetSpinRange_Handle = Selector.GetHandle("setSpinRange:");

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	private static readonly IntPtr selRedSpeedHandle = Selector.GetHandle("redSpeed");

	private static readonly IntPtr selSetRedSpeed_Handle = Selector.GetHandle("setRedSpeed:");

	private static readonly IntPtr selGreenSpeedHandle = Selector.GetHandle("greenSpeed");

	private static readonly IntPtr selSetGreenSpeed_Handle = Selector.GetHandle("setGreenSpeed:");

	private static readonly IntPtr selBlueSpeedHandle = Selector.GetHandle("blueSpeed");

	private static readonly IntPtr selSetBlueSpeed_Handle = Selector.GetHandle("setBlueSpeed:");

	private static readonly IntPtr selAlphaSpeedHandle = Selector.GetHandle("alphaSpeed");

	private static readonly IntPtr selSetAlphaSpeed_Handle = Selector.GetHandle("setAlphaSpeed:");

	private static readonly IntPtr selContentsHandle = Selector.GetHandle("contents");

	private static readonly IntPtr selSetContents_Handle = Selector.GetHandle("setContents:");

	private static readonly IntPtr selContentsRectHandle = Selector.GetHandle("contentsRect");

	private static readonly IntPtr selSetContentsRect_Handle = Selector.GetHandle("setContentsRect:");

	private static readonly IntPtr selMinificationFilterHandle = Selector.GetHandle("minificationFilter");

	private static readonly IntPtr selSetMinificationFilter_Handle = Selector.GetHandle("setMinificationFilter:");

	private static readonly IntPtr selMagnificationFilterHandle = Selector.GetHandle("magnificationFilter");

	private static readonly IntPtr selSetMagnificationFilter_Handle = Selector.GetHandle("setMagnificationFilter:");

	private static readonly IntPtr selMinificationFilterBiasHandle = Selector.GetHandle("minificationFilterBias");

	private static readonly IntPtr selSetMinificationFilterBias_Handle = Selector.GetHandle("setMinificationFilterBias:");

	private static readonly IntPtr selEmitterCellsHandle = Selector.GetHandle("emitterCells");

	private static readonly IntPtr selSetEmitterCells_Handle = Selector.GetHandle("setEmitterCells:");

	private static readonly IntPtr selStyleHandle = Selector.GetHandle("style");

	private static readonly IntPtr selSetStyle_Handle = Selector.GetHandle("setStyle:");

	private static readonly IntPtr selEmitterCellHandle = Selector.GetHandle("emitterCell");

	private static readonly IntPtr selDefaultValueForKey_Handle = Selector.GetHandle("defaultValueForKey:");

	private static readonly IntPtr selShouldArchiveValueForKey_Handle = Selector.GetHandle("shouldArchiveValueForKey:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAEmitterCell");

	private object __mt_WeakContents_var;

	private object __mt_Cells_var;

	private object __mt_Style_var;

	public CGImage Contents
	{
		get
		{
			if (contents != null)
			{
				return contents;
			}
			IntPtr intPtr = _Contents;
			if (!(intPtr != IntPtr.Zero))
			{
				return null;
			}
			return contents = new CGImage(intPtr);
		}
		set
		{
			_Contents = value?.Handle ?? IntPtr.Zero;
			contents = value;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
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

	public virtual float LifetimeRange
	{
		[Export("lifetimeRange")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLifetimeRangeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLifetimeRangeHandle);
		}
		[Export("setLifetimeRange:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLifetimeRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLifetimeRange_Handle, value);
			}
		}
	}

	public virtual float EmissionLatitude
	{
		[Export("emissionLatitude")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selEmissionLatitudeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selEmissionLatitudeHandle);
		}
		[Export("setEmissionLatitude:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetEmissionLatitude_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetEmissionLatitude_Handle, value);
			}
		}
	}

	public virtual float EmissionLongitude
	{
		[Export("emissionLongitude")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selEmissionLongitudeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selEmissionLongitudeHandle);
		}
		[Export("setEmissionLongitude:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetEmissionLongitude_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetEmissionLongitude_Handle, value);
			}
		}
	}

	public virtual float EmissionRange
	{
		[Export("emissionRange")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selEmissionRangeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selEmissionRangeHandle);
		}
		[Export("setEmissionRange:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetEmissionRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetEmissionRange_Handle, value);
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

	public virtual float VelocityRange
	{
		[Export("velocityRange")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVelocityRangeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVelocityRangeHandle);
		}
		[Export("setVelocityRange:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVelocityRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVelocityRange_Handle, value);
			}
		}
	}

	public virtual float AccelerationX
	{
		[Export("xAcceleration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selXAccelerationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selXAccelerationHandle);
		}
		[Export("setXAcceleration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetXAcceleration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetXAcceleration_Handle, value);
			}
		}
	}

	public virtual float AccelerationY
	{
		[Export("yAcceleration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selYAccelerationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selYAccelerationHandle);
		}
		[Export("setYAcceleration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetYAcceleration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetYAcceleration_Handle, value);
			}
		}
	}

	public virtual float AccelerationZ
	{
		[Export("zAcceleration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selZAccelerationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selZAccelerationHandle);
		}
		[Export("setZAcceleration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetZAcceleration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetZAcceleration_Handle, value);
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

	public virtual float ScaleRange
	{
		[Export("scaleRange")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleRangeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleRangeHandle);
		}
		[Export("setScaleRange:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetScaleRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetScaleRange_Handle, value);
			}
		}
	}

	public virtual float ScaleSpeed
	{
		[Export("scaleSpeed")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleSpeedHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleSpeedHandle);
		}
		[Export("setScaleSpeed:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetScaleSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetScaleSpeed_Handle, value);
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

	public virtual float SpinRange
	{
		[Export("spinRange")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSpinRangeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSpinRangeHandle);
		}
		[Export("setSpinRange:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSpinRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSpinRange_Handle, value);
			}
		}
	}

	public virtual CGColor Color
	{
		[Export("color")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGColor(Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle));
			}
			return new CGColor(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle));
		}
		[Export("setColor:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, value.Handle);
			}
		}
	}

	public virtual float RedSpeed
	{
		[Export("redSpeed")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRedSpeedHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRedSpeedHandle);
		}
		[Export("setRedSpeed:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRedSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRedSpeed_Handle, value);
			}
		}
	}

	public virtual float GreenSpeed
	{
		[Export("greenSpeed")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGreenSpeedHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGreenSpeedHandle);
		}
		[Export("setGreenSpeed:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetGreenSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetGreenSpeed_Handle, value);
			}
		}
	}

	public virtual float BlueSpeed
	{
		[Export("blueSpeed")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBlueSpeedHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBlueSpeedHandle);
		}
		[Export("setBlueSpeed:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBlueSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBlueSpeed_Handle, value);
			}
		}
	}

	public virtual float AlphaSpeed
	{
		[Export("alphaSpeed")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAlphaSpeedHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAlphaSpeedHandle);
		}
		[Export("setAlphaSpeed:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetAlphaSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetAlphaSpeed_Handle, value);
			}
		}
	}

	public virtual NSObject WeakContents
	{
		[Export("contents")]
		get
		{
			return (NSObject)(__mt_WeakContents_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentsHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContentsHandle))));
		}
		[Export("setContents:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContents_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContents_Handle, value.Handle);
			}
			__mt_WeakContents_var = value;
		}
	}

	internal IntPtr _Contents
	{
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selContentsHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentsHandle);
		}
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContents_Handle, value);
			}
		}
	}

	public virtual CGRect ContentsRect
	{
		[Export("contentsRect")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selContentsRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selContentsRectHandle);
			}
			return retval;
		}
		[Export("setContentsRect:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetContentsRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetContentsRect_Handle, value);
			}
		}
	}

	public virtual string MinificationFilter
	{
		[Export("minificationFilter")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMinificationFilterHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMinificationFilterHandle));
		}
		[Export("setMinificationFilter:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMinificationFilter_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMinificationFilter_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string MagnificationFilter
	{
		[Export("magnificationFilter")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMagnificationFilterHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMagnificationFilterHandle));
		}
		[Export("setMagnificationFilter:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMagnificationFilter_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMagnificationFilter_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual float MinificationFilterBias
	{
		[Export("minificationFilterBias")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinificationFilterBiasHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinificationFilterBiasHandle);
		}
		[Export("setMinificationFilterBias:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMinificationFilterBias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMinificationFilterBias_Handle, value);
			}
		}
	}

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

	public virtual NSDictionary Style
	{
		[Export("style", ArgumentSemantic.Copy)]
		get
		{
			return (NSDictionary)(__mt_Style_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStyleHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStyleHandle)))));
		}
		[Export("setStyle:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStyle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStyle_Handle, value.Handle);
			}
			__mt_Style_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAEmitterCell()
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
	public CAEmitterCell(NSCoder coder)
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
	public CAEmitterCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAEmitterCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("emitterCell")]
	public static CAEmitterCell EmitterCell()
	{
		return (CAEmitterCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selEmitterCellHandle));
	}

	[Export("defaultValueForKey:")]
	public static NSObject DefaultValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("shouldArchiveValueForKey:")]
	public virtual bool ShouldArchiveValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldArchiveValueForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldArchiveValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakContents_var = null;
			__mt_Cells_var = null;
			__mt_Style_var = null;
		}
	}
}
