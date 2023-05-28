using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLSkeleton", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLSkeleton : MDLObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_JointPaths_ = "initWithName:jointPaths:";

	private static readonly IntPtr selInitWithName_JointPaths_Handle = Selector.GetHandle("initWithName:jointPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointBindTransforms = "jointBindTransforms";

	private static readonly IntPtr selJointBindTransformsHandle = Selector.GetHandle("jointBindTransforms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointPaths = "jointPaths";

	private static readonly IntPtr selJointPathsHandle = Selector.GetHandle("jointPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointRestTransforms = "jointRestTransforms";

	private static readonly IntPtr selJointRestTransformsHandle = Selector.GetHandle("jointRestTransforms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLSkeleton");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMatrix4x4Array JointBindTransforms
	{
		[Export("jointBindTransforms")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMatrix4x4Array>(Messaging.IntPtr_objc_msgSend(base.Handle, selJointBindTransformsHandle));
			}
			return Runtime.GetNSObject<MDLMatrix4x4Array>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJointBindTransformsHandle));
		}
	}

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
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual MDLMatrix4x4Array JointRestTransforms
	{
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("jointRestTransforms")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMatrix4x4Array>(Messaging.IntPtr_objc_msgSend(base.Handle, selJointRestTransformsHandle));
			}
			return Runtime.GetNSObject<MDLMatrix4x4Array>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJointRestTransformsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLSkeleton(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLSkeleton(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:jointPaths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLSkeleton(string name, string[] jointPaths)
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
