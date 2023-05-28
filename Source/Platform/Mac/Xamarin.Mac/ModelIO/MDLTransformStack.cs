using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLTransformStack", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLTransformStack : NSObject, IMDLComponent, INativeObject, IDisposable, IMDLTransformComponent, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddMatrixOp_Inverse_ = "addMatrixOp:inverse:";

	private static readonly IntPtr selAddMatrixOp_Inverse_Handle = Selector.GetHandle("addMatrixOp:inverse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOrientOp_Inverse_ = "addOrientOp:inverse:";

	private static readonly IntPtr selAddOrientOp_Inverse_Handle = Selector.GetHandle("addOrientOp:inverse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRotateOp_Order_Inverse_ = "addRotateOp:order:inverse:";

	private static readonly IntPtr selAddRotateOp_Order_Inverse_Handle = Selector.GetHandle("addRotateOp:order:inverse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRotateXOp_Inverse_ = "addRotateXOp:inverse:";

	private static readonly IntPtr selAddRotateXOp_Inverse_Handle = Selector.GetHandle("addRotateXOp:inverse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRotateYOp_Inverse_ = "addRotateYOp:inverse:";

	private static readonly IntPtr selAddRotateYOp_Inverse_Handle = Selector.GetHandle("addRotateYOp:inverse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRotateZOp_Inverse_ = "addRotateZOp:inverse:";

	private static readonly IntPtr selAddRotateZOp_Inverse_Handle = Selector.GetHandle("addRotateZOp:inverse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddScaleOp_Inverse_ = "addScaleOp:inverse:";

	private static readonly IntPtr selAddScaleOp_Inverse_Handle = Selector.GetHandle("addScaleOp:inverse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTranslateOp_Inverse_ = "addTranslateOp:inverse:";

	private static readonly IntPtr selAddTranslateOp_Inverse_Handle = Selector.GetHandle("addTranslateOp:inverse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimatedValueWithName_ = "animatedValueWithName:";

	private static readonly IntPtr selAnimatedValueWithName_Handle = Selector.GetHandle("animatedValueWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDouble4x4AtTime_ = "double4x4AtTime:";

	private static readonly IntPtr selDouble4x4AtTime_Handle = Selector.GetHandle("double4x4AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloat4x4AtTime_ = "float4x4AtTime:";

	private static readonly IntPtr selFloat4x4AtTime_Handle = Selector.GetHandle("float4x4AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlobalTransformWithObject_AtTime_ = "globalTransformWithObject:atTime:";

	private static readonly IntPtr selGlobalTransformWithObject_AtTime_Handle = Selector.GetHandle("globalTransformWithObject:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyTimes = "keyTimes";

	private static readonly IntPtr selKeyTimesHandle = Selector.GetHandle("keyTimes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalTransformAtTime_ = "localTransformAtTime:";

	private static readonly IntPtr selLocalTransformAtTime_Handle = Selector.GetHandle("localTransformAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrix = "matrix";

	private static readonly IntPtr selMatrixHandle = Selector.GetHandle("matrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumTime = "maximumTime";

	private static readonly IntPtr selMaximumTimeHandle = Selector.GetHandle("maximumTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumTime = "minimumTime";

	private static readonly IntPtr selMinimumTimeHandle = Selector.GetHandle("minimumTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetsTransform = "resetsTransform";

	private static readonly IntPtr selResetsTransformHandle = Selector.GetHandle("resetsTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalTransform_ = "setLocalTransform:";

	private static readonly IntPtr selSetLocalTransform_Handle = Selector.GetHandle("setLocalTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalTransform_ForTime_ = "setLocalTransform:forTime:";

	private static readonly IntPtr selSetLocalTransform_ForTime_Handle = Selector.GetHandle("setLocalTransform:forTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatrix_ = "setMatrix:";

	private static readonly IntPtr selSetMatrix_Handle = Selector.GetHandle("setMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResetsTransform_ = "setResetsTransform:";

	private static readonly IntPtr selSetResetsTransform_Handle = Selector.GetHandle("setResetsTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformOps = "transformOps";

	private static readonly IntPtr selTransformOpsHandle = Selector.GetHandle("transformOps");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLTransformStack");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSNumber[] KeyTimes
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("keyTimes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyTimesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyTimesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual Matrix4 Matrix
	{
		[Export("matrix", ArgumentSemantic.Assign)]
		get
		{
			Matrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSend_stret(out retval, base.Handle, selMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMatrixHandle);
			}
			return retval;
		}
		[Export("setMatrix:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Matrix4(base.Handle, selSetMatrix_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Matrix4(base.SuperHandle, selSetMatrix_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual double MaximumTime
	{
		[Export("maximumTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMaximumTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMaximumTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual double MinimumTime
	{
		[Export("minimumTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinimumTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinimumTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual bool ResetsTransform
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("resetsTransform")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selResetsTransformHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selResetsTransformHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setResetsTransform:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetResetsTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetResetsTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLTransformOp[] TransformOps
	{
		[Export("transformOps", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMDLTransformOp>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransformOpsHandle));
			}
			return NSArray.ArrayFromHandle<IMDLTransformOp>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransformOpsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLTransformStack()
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
	protected MDLTransformStack(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLTransformStack(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addMatrixOp:inverse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTransformMatrixOp AddMatrixOp(string animatedValueName, bool inverse)
	{
		if (animatedValueName == null)
		{
			throw new ArgumentNullException("animatedValueName");
		}
		IntPtr arg = NSString.CreateNative(animatedValueName);
		MDLTransformMatrixOp result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLTransformMatrixOp>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selAddMatrixOp_Inverse_Handle, arg, inverse)) : Runtime.GetNSObject<MDLTransformMatrixOp>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selAddMatrixOp_Inverse_Handle, arg, inverse)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addOrientOp:inverse:")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTransformOrientOp AddOrientOp(string animatedValueName, bool inverse)
	{
		if (animatedValueName == null)
		{
			throw new ArgumentNullException("animatedValueName");
		}
		IntPtr arg = NSString.CreateNative(animatedValueName);
		MDLTransformOrientOp result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLTransformOrientOp>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selAddOrientOp_Inverse_Handle, arg, inverse)) : Runtime.GetNSObject<MDLTransformOrientOp>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selAddOrientOp_Inverse_Handle, arg, inverse)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addRotateOp:order:inverse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTransformRotateOp AddRotateOp(string animatedValueName, MDLTransformOpRotationOrder order, bool inverse)
	{
		if (animatedValueName == null)
		{
			throw new ArgumentNullException("animatedValueName");
		}
		IntPtr arg = NSString.CreateNative(animatedValueName);
		MDLTransformRotateOp result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLTransformRotateOp>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_bool(base.SuperHandle, selAddRotateOp_Order_Inverse_Handle, arg, (ulong)order, inverse)) : Runtime.GetNSObject<MDLTransformRotateOp>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_bool(base.Handle, selAddRotateOp_Order_Inverse_Handle, arg, (ulong)order, inverse)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addRotateXOp:inverse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTransformRotateXOp AddRotateXOp(string animatedValueName, bool inverse)
	{
		if (animatedValueName == null)
		{
			throw new ArgumentNullException("animatedValueName");
		}
		IntPtr arg = NSString.CreateNative(animatedValueName);
		MDLTransformRotateXOp result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLTransformRotateXOp>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selAddRotateXOp_Inverse_Handle, arg, inverse)) : Runtime.GetNSObject<MDLTransformRotateXOp>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selAddRotateXOp_Inverse_Handle, arg, inverse)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addRotateYOp:inverse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTransformRotateYOp AddRotateYOp(string animatedValueName, bool inverse)
	{
		if (animatedValueName == null)
		{
			throw new ArgumentNullException("animatedValueName");
		}
		IntPtr arg = NSString.CreateNative(animatedValueName);
		MDLTransformRotateYOp result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLTransformRotateYOp>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selAddRotateYOp_Inverse_Handle, arg, inverse)) : Runtime.GetNSObject<MDLTransformRotateYOp>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selAddRotateYOp_Inverse_Handle, arg, inverse)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addRotateZOp:inverse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTransformRotateZOp AddRotateZOp(string animatedValueName, bool inverse)
	{
		if (animatedValueName == null)
		{
			throw new ArgumentNullException("animatedValueName");
		}
		IntPtr arg = NSString.CreateNative(animatedValueName);
		MDLTransformRotateZOp result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLTransformRotateZOp>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selAddRotateZOp_Inverse_Handle, arg, inverse)) : Runtime.GetNSObject<MDLTransformRotateZOp>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selAddRotateZOp_Inverse_Handle, arg, inverse)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addScaleOp:inverse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTransformScaleOp AddScaleOp(string animatedValueName, bool inverse)
	{
		if (animatedValueName == null)
		{
			throw new ArgumentNullException("animatedValueName");
		}
		IntPtr arg = NSString.CreateNative(animatedValueName);
		MDLTransformScaleOp result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLTransformScaleOp>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selAddScaleOp_Inverse_Handle, arg, inverse)) : Runtime.GetNSObject<MDLTransformScaleOp>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selAddScaleOp_Inverse_Handle, arg, inverse)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addTranslateOp:inverse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTransformTranslateOp AddTranslateOp(string animatedValueName, bool inverse)
	{
		if (animatedValueName == null)
		{
			throw new ArgumentNullException("animatedValueName");
		}
		IntPtr arg = NSString.CreateNative(animatedValueName);
		MDLTransformTranslateOp result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLTransformTranslateOp>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selAddTranslateOp_Inverse_Handle, arg, inverse)) : Runtime.GetNSObject<MDLTransformTranslateOp>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selAddTranslateOp_Inverse_Handle, arg, inverse)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("globalTransformWithObject:atTime:")]
	[Obsolete("Use 'CreateGlobalTransform4x4' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Matrix4 CreateGlobalTransform(MDLObject obj, double atTime)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Messaging.xamarin_simd__Matrix4_objc_msgSend_stret_IntPtr_Double(out var retval, class_ptr, selGlobalTransformWithObject_AtTime_Handle, obj.Handle, atTime);
		return retval;
	}

	[Export("animatedValueWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLAnimatedValue GetAnimatedValue(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		MDLAnimatedValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLAnimatedValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimatedValueWithName_Handle, arg)) : Runtime.GetNSObject<MDLAnimatedValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimatedValueWithName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localTransformAtTime:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Matrix4 GetLocalTransform(double atTime)
	{
		Matrix4 retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__Matrix4_objc_msgSend_stret_Double(out retval, base.Handle, selLocalTransformAtTime_Handle, atTime);
		}
		else
		{
			Messaging.xamarin_simd__Matrix4_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selLocalTransformAtTime_Handle, atTime);
		}
		return retval;
	}

	[Export("float4x4AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NMatrix4 GetNMatrix4(double atTime)
	{
		NMatrix4 retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double(out retval, base.Handle, selFloat4x4AtTime_Handle, atTime);
		}
		else
		{
			Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selFloat4x4AtTime_Handle, atTime);
		}
		return retval;
	}

	[Export("double4x4AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NMatrix4d GetNMatrix4d(double atTime)
	{
		NMatrix4d retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__NMatrix4d_objc_msgSend_stret_Double(out retval, base.Handle, selDouble4x4AtTime_Handle, atTime);
		}
		else
		{
			Messaging.xamarin_simd__NMatrix4d_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selDouble4x4AtTime_Handle, atTime);
		}
		return retval;
	}

	[Export("setLocalTransform:forTime:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLocalTransform(Matrix4 transform, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Matrix4_Double(base.Handle, selSetLocalTransform_ForTime_Handle, transform, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Matrix4_Double(base.SuperHandle, selSetLocalTransform_ForTime_Handle, transform, time);
		}
	}

	[Export("setLocalTransform:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLocalTransform(Matrix4 transform)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Matrix4(base.Handle, selSetLocalTransform_Handle, transform);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Matrix4(base.SuperHandle, selSetLocalTransform_Handle, transform);
		}
	}
}
