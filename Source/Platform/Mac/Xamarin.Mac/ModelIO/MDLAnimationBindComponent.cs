using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLAnimationBindComponent", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLAnimationBindComponent : NSObject, IMDLComponent, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeometryBindTransform = "geometryBindTransform";

	private static readonly IntPtr selGeometryBindTransformHandle = Selector.GetHandle("geometryBindTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointAnimation = "jointAnimation";

	private static readonly IntPtr selJointAnimationHandle = Selector.GetHandle("jointAnimation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointPaths = "jointPaths";

	private static readonly IntPtr selJointPathsHandle = Selector.GetHandle("jointPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGeometryBindTransform_ = "setGeometryBindTransform:";

	private static readonly IntPtr selSetGeometryBindTransform_Handle = Selector.GetHandle("setGeometryBindTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJointAnimation_ = "setJointAnimation:";

	private static readonly IntPtr selSetJointAnimation_Handle = Selector.GetHandle("setJointAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJointPaths_ = "setJointPaths:";

	private static readonly IntPtr selSetJointPaths_Handle = Selector.GetHandle("setJointPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSkeleton_ = "setSkeleton:";

	private static readonly IntPtr selSetSkeleton_Handle = Selector.GetHandle("setSkeleton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSkeleton = "skeleton";

	private static readonly IntPtr selSkeletonHandle = Selector.GetHandle("skeleton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAnimationBindComponent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NMatrix4d GeometryBindTransform
	{
		[Export("geometryBindTransform", ArgumentSemantic.Assign)]
		get
		{
			NMatrix4d retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix4d_objc_msgSend_stret(out retval, base.Handle, selGeometryBindTransformHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix4d_objc_msgSendSuper_stret(out retval, base.SuperHandle, selGeometryBindTransformHandle);
			}
			return retval;
		}
		[Export("setGeometryBindTransform:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_NMatrix4d(base.Handle, selSetGeometryBindTransform_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4d(base.SuperHandle, selSetGeometryBindTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLJointAnimation? JointAnimation
	{
		[Export("jointAnimation", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLJointAnimation>(Messaging.IntPtr_objc_msgSend(base.Handle, selJointAnimationHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLJointAnimation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJointAnimationHandle), owns: false);
		}
		[Export("setJointAnimation:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetJointAnimation_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetJointAnimation_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? JointPaths
	{
		[Export("jointPaths", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selJointPathsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJointPathsHandle));
		}
		[Export("setJointPaths:", ArgumentSemantic.Retain)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetJointPaths_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetJointPaths_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLSkeleton? Skeleton
	{
		[Export("skeleton", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLSkeleton>(Messaging.IntPtr_objc_msgSend(base.Handle, selSkeletonHandle));
			}
			return Runtime.GetNSObject<MDLSkeleton>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSkeletonHandle));
		}
		[Export("setSkeleton:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSkeleton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSkeleton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAnimationBindComponent()
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
	protected MDLAnimationBindComponent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAnimationBindComponent(IntPtr handle)
		: base(handle)
	{
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
}
