using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLPackedJointAnimation", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLPackedJointAnimation : MDLObject, IMDLJointAnimation, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_JointPaths_ = "initWithName:jointPaths:";

	private static readonly IntPtr selInitWithName_JointPaths_Handle = Selector.GetHandle("initWithName:jointPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointPaths = "jointPaths";

	private static readonly IntPtr selJointPathsHandle = Selector.GetHandle("jointPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotations = "rotations";

	private static readonly IntPtr selRotationsHandle = Selector.GetHandle("rotations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScales = "scales";

	private static readonly IntPtr selScalesHandle = Selector.GetHandle("scales");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTranslations = "translations";

	private static readonly IntPtr selTranslationsHandle = Selector.GetHandle("translations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLPackedJointAnimation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] JointPaths
	{
		[Export("jointPaths")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selJointPathsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJointPathsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLAnimatedQuaternionArray Rotations
	{
		[Export("rotations")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLAnimatedQuaternionArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selRotationsHandle));
			}
			return Runtime.GetNSObject<MDLAnimatedQuaternionArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRotationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLAnimatedVector3Array Scales
	{
		[Export("scales")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLAnimatedVector3Array>(Messaging.IntPtr_objc_msgSend(base.Handle, selScalesHandle));
			}
			return Runtime.GetNSObject<MDLAnimatedVector3Array>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScalesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLAnimatedVector3Array Translations
	{
		[Export("translations")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLAnimatedVector3Array>(Messaging.IntPtr_objc_msgSend(base.Handle, selTranslationsHandle));
			}
			return Runtime.GetNSObject<MDLAnimatedVector3Array>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTranslationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLPackedJointAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLPackedJointAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:jointPaths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLPackedJointAnimation(string name, string[] jointPaths)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (jointPaths == null)
		{
			throw new ArgumentNullException("jointPaths");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSArray nSArray = NSArray.FromStrings(jointPaths);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithName_JointPaths_Handle, arg, nSArray.Handle), "initWithName:jointPaths:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithName_JointPaths_Handle, arg, nSArray.Handle), "initWithName:jointPaths:");
		}
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
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
