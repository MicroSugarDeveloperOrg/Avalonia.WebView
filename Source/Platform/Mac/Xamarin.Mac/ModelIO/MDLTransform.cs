using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLTransform", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLTransform : NSObject, IMDLComponent, INativeObject, IDisposable, IMDLTransformComponent, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlobalTransformWithObject_AtTime_ = "globalTransformWithObject:atTime:";

	private static readonly IntPtr selGlobalTransformWithObject_AtTime_Handle = Selector.GetHandle("globalTransformWithObject:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMatrix_ = "initWithMatrix:";

	private static readonly IntPtr selInitWithMatrix_Handle = Selector.GetHandle("initWithMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMatrix_ResetsTransform_ = "initWithMatrix:resetsTransform:";

	private static readonly IntPtr selInitWithMatrix_ResetsTransform_Handle = Selector.GetHandle("initWithMatrix:resetsTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTransformComponent_ = "initWithTransformComponent:";

	private static readonly IntPtr selInitWithTransformComponent_Handle = Selector.GetHandle("initWithTransformComponent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTransformComponent_ResetsTransform_ = "initWithTransformComponent:resetsTransform:";

	private static readonly IntPtr selInitWithTransformComponent_ResetsTransform_Handle = Selector.GetHandle("initWithTransformComponent:resetsTransform:");

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
	private const string selRotation = "rotation";

	private static readonly IntPtr selRotationHandle = Selector.GetHandle("rotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotationAtTime_ = "rotationAtTime:";

	private static readonly IntPtr selRotationAtTime_Handle = Selector.GetHandle("rotationAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotationMatrixAtTime_ = "rotationMatrixAtTime:";

	private static readonly IntPtr selRotationMatrixAtTime_Handle = Selector.GetHandle("rotationMatrixAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScale = "scale";

	private static readonly IntPtr selScaleHandle = Selector.GetHandle("scale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleAtTime_ = "scaleAtTime:";

	private static readonly IntPtr selScaleAtTime_Handle = Selector.GetHandle("scaleAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdentity = "setIdentity";

	private static readonly IntPtr selSetIdentityHandle = Selector.GetHandle("setIdentity");

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
	private const string selSetMatrix_ForTime_ = "setMatrix:forTime:";

	private static readonly IntPtr selSetMatrix_ForTime_Handle = Selector.GetHandle("setMatrix:forTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResetsTransform_ = "setResetsTransform:";

	private static readonly IntPtr selSetResetsTransform_Handle = Selector.GetHandle("setResetsTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotation_ = "setRotation:";

	private static readonly IntPtr selSetRotation_Handle = Selector.GetHandle("setRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotation_ForTime_ = "setRotation:forTime:";

	private static readonly IntPtr selSetRotation_ForTime_Handle = Selector.GetHandle("setRotation:forTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScale_ = "setScale:";

	private static readonly IntPtr selSetScale_Handle = Selector.GetHandle("setScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScale_ForTime_ = "setScale:forTime:";

	private static readonly IntPtr selSetScale_ForTime_Handle = Selector.GetHandle("setScale:forTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShear_ = "setShear:";

	private static readonly IntPtr selSetShear_Handle = Selector.GetHandle("setShear:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShear_ForTime_ = "setShear:forTime:";

	private static readonly IntPtr selSetShear_ForTime_Handle = Selector.GetHandle("setShear:forTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTranslation_ = "setTranslation:";

	private static readonly IntPtr selSetTranslation_Handle = Selector.GetHandle("setTranslation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTranslation_ForTime_ = "setTranslation:forTime:";

	private static readonly IntPtr selSetTranslation_ForTime_Handle = Selector.GetHandle("setTranslation:forTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShear = "shear";

	private static readonly IntPtr selShearHandle = Selector.GetHandle("shear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShearAtTime_ = "shearAtTime:";

	private static readonly IntPtr selShearAtTime_Handle = Selector.GetHandle("shearAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTranslation = "translation";

	private static readonly IntPtr selTranslationHandle = Selector.GetHandle("translation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTranslationAtTime_ = "translationAtTime:";

	private static readonly IntPtr selTranslationAtTime_Handle = Selector.GetHandle("translationAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLTransform");

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual Vector3 Rotation
	{
		[Export("rotation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector3_objc_msgSend(base.Handle, selRotationHandle);
			}
			return Messaging.xamarin_simd__Vector3_objc_msgSendSuper(base.SuperHandle, selRotationHandle);
		}
		[Export("setRotation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector3(base.Handle, selSetRotation_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 Scale
	{
		[Export("scale", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector3_objc_msgSend(base.Handle, selScaleHandle);
			}
			return Messaging.xamarin_simd__Vector3_objc_msgSendSuper(base.SuperHandle, selScaleHandle);
		}
		[Export("setScale:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector3(base.Handle, selSetScale_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 Shear
	{
		[Export("shear", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector3_objc_msgSend(base.Handle, selShearHandle);
			}
			return Messaging.xamarin_simd__Vector3_objc_msgSendSuper(base.SuperHandle, selShearHandle);
		}
		[Export("setShear:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector3(base.Handle, selSetShear_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetShear_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 Translation
	{
		[Export("translation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector3_objc_msgSend(base.Handle, selTranslationHandle);
			}
			return Messaging.xamarin_simd__Vector3_objc_msgSendSuper(base.SuperHandle, selTranslationHandle);
		}
		[Export("setTranslation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector3(base.Handle, selSetTranslation_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetTranslation_Handle, value);
			}
		}
	}

	public static NMatrix4 CreateGlobalTransform4x4(MDLObject obj, double atTime)
	{
		return NMatrix4.Transpose((NMatrix4)CreateGlobalTransform(obj, atTime));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLTransform()
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
	protected MDLTransform(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLTransform(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTransformComponent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLTransform(IMDLTransformComponent component)
		: base(NSObjectFlag.Empty)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTransformComponent_Handle, component.Handle), "initWithTransformComponent:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTransformComponent_Handle, component.Handle), "initWithTransformComponent:");
		}
	}

	[Export("initWithTransformComponent:resetsTransform:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLTransform(IMDLTransformComponent component, bool resetsTransform)
		: base(NSObjectFlag.Empty)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitWithTransformComponent_ResetsTransform_Handle, component.Handle, resetsTransform), "initWithTransformComponent:resetsTransform:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitWithTransformComponent_ResetsTransform_Handle, component.Handle, resetsTransform), "initWithTransformComponent:resetsTransform:");
		}
	}

	[Export("initWithMatrix:")]
	[Obsolete("Use the '(MatrixFloat4x4)' overload instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLTransform(Matrix4 matrix)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_Matrix4(base.Handle, selInitWithMatrix_Handle, matrix), "initWithMatrix:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Matrix4(base.SuperHandle, selInitWithMatrix_Handle, matrix), "initWithMatrix:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLTransform(NMatrix4 matrix)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_NMatrix4(base.Handle, selInitWithMatrix_Handle, matrix), "initWithMatrix:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_NMatrix4(base.SuperHandle, selInitWithMatrix_Handle, matrix), "initWithMatrix:");
		}
	}

	[Export("initWithMatrix:resetsTransform:")]
	[Obsolete("Use the '(MatrixFloat4x4, bool)' overload instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLTransform(Matrix4 matrix, bool resetsTransform)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_Matrix4_bool(base.Handle, selInitWithMatrix_ResetsTransform_Handle, matrix, resetsTransform), "initWithMatrix:resetsTransform:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Matrix4_bool(base.SuperHandle, selInitWithMatrix_ResetsTransform_Handle, matrix, resetsTransform), "initWithMatrix:resetsTransform:");
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLTransform(NMatrix4 matrix, bool resetsTransform)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_NMatrix4_bool(base.Handle, selInitWithMatrix_ResetsTransform_Handle, matrix, resetsTransform), "initWithMatrix:resetsTransform:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_NMatrix4_bool(base.SuperHandle, selInitWithMatrix_ResetsTransform_Handle, matrix, resetsTransform), "initWithMatrix:resetsTransform:");
		}
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

	[Export("rotationAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 GetRotation(double atTime)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector3_objc_msgSend_Double(base.Handle, selRotationAtTime_Handle, atTime);
		}
		return Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Double(base.SuperHandle, selRotationAtTime_Handle, atTime);
	}

	[Export("rotationMatrixAtTime:")]
	[Obsolete("Use 'GetRotationMatrix4x4' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Matrix4 GetRotationMatrix(double atTime)
	{
		Matrix4 retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__Matrix4_objc_msgSend_stret_Double(out retval, base.Handle, selRotationMatrixAtTime_Handle, atTime);
		}
		else
		{
			Messaging.xamarin_simd__Matrix4_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selRotationMatrixAtTime_Handle, atTime);
		}
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NMatrix4 GetRotationMatrix4x4(double atTime)
	{
		Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double(out var retval, base.Handle, selRotationMatrixAtTime_Handle, atTime);
		return retval;
	}

	[Export("scaleAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 GetScale(double atTime)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector3_objc_msgSend_Double(base.Handle, selScaleAtTime_Handle, atTime);
		}
		return Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Double(base.SuperHandle, selScaleAtTime_Handle, atTime);
	}

	[Export("shearAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 GetShear(double atTime)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector3_objc_msgSend_Double(base.Handle, selShearAtTime_Handle, atTime);
		}
		return Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Double(base.SuperHandle, selShearAtTime_Handle, atTime);
	}

	[Export("translationAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 GetTranslation(double atTime)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector3_objc_msgSend_Double(base.Handle, selTranslationAtTime_Handle, atTime);
		}
		return Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Double(base.SuperHandle, selTranslationAtTime_Handle, atTime);
	}

	[Export("setIdentity")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetIdentity()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetIdentityHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetIdentityHandle);
		}
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

	[Export("setMatrix:forTime:")]
	[Obsolete("Use 'SetMatrix4x4' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMatrix(Matrix4 matrix, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Matrix4_Double(base.Handle, selSetMatrix_ForTime_Handle, matrix, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Matrix4_Double(base.SuperHandle, selSetMatrix_ForTime_Handle, matrix, time);
		}
	}

	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetMatrix4x4(NMatrix4 matrix, double time)
	{
		Messaging.xamarin_simd__void_objc_msgSend_NMatrix4_Double(base.Handle, selSetMatrix_ForTime_Handle, matrix, time);
	}

	[Export("setRotation:forTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetRotation(Vector3 rotation, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector3_Double(base.Handle, selSetRotation_ForTime_Handle, rotation, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3_Double(base.SuperHandle, selSetRotation_ForTime_Handle, rotation, time);
		}
	}

	[Export("setScale:forTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetScale(Vector3 scale, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector3_Double(base.Handle, selSetScale_ForTime_Handle, scale, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3_Double(base.SuperHandle, selSetScale_ForTime_Handle, scale, time);
		}
	}

	[Export("setShear:forTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetShear(Vector3 scale, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector3_Double(base.Handle, selSetShear_ForTime_Handle, scale, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3_Double(base.SuperHandle, selSetShear_ForTime_Handle, scale, time);
		}
	}

	[Export("setTranslation:forTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTranslation(Vector3 translation, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector3_Double(base.Handle, selSetTranslation_ForTime_Handle, translation, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3_Double(base.SuperHandle, selSetTranslation_ForTime_Handle, translation, time);
		}
	}
}
