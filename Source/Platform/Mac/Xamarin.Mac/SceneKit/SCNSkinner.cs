using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SceneKit;

[Register("SCNSkinner", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNSkinner : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseGeometry = "baseGeometry";

	private static readonly IntPtr selBaseGeometryHandle = Selector.GetHandle("baseGeometry");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseGeometryBindTransform = "baseGeometryBindTransform";

	private static readonly IntPtr selBaseGeometryBindTransformHandle = Selector.GetHandle("baseGeometryBindTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoneIndices = "boneIndices";

	private static readonly IntPtr selBoneIndicesHandle = Selector.GetHandle("boneIndices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoneInverseBindTransforms = "boneInverseBindTransforms";

	private static readonly IntPtr selBoneInverseBindTransformsHandle = Selector.GetHandle("boneInverseBindTransforms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoneWeights = "boneWeights";

	private static readonly IntPtr selBoneWeightsHandle = Selector.GetHandle("boneWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBones = "bones";

	private static readonly IntPtr selBonesHandle = Selector.GetHandle("bones");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBaseGeometry_ = "setBaseGeometry:";

	private static readonly IntPtr selSetBaseGeometry_Handle = Selector.GetHandle("setBaseGeometry:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBaseGeometryBindTransform_ = "setBaseGeometryBindTransform:";

	private static readonly IntPtr selSetBaseGeometryBindTransform_Handle = Selector.GetHandle("setBaseGeometryBindTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSkeleton_ = "setSkeleton:";

	private static readonly IntPtr selSetSkeleton_Handle = Selector.GetHandle("setSkeleton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSkeleton = "skeleton";

	private static readonly IntPtr selSkeletonHandle = Selector.GetHandle("skeleton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSkinnerWithBaseGeometry_Bones_BoneInverseBindTransforms_BoneWeights_BoneIndices_ = "skinnerWithBaseGeometry:bones:boneInverseBindTransforms:boneWeights:boneIndices:";

	private static readonly IntPtr selSkinnerWithBaseGeometry_Bones_BoneInverseBindTransforms_BoneWeights_BoneIndices_Handle = Selector.GetHandle("skinnerWithBaseGeometry:bones:boneInverseBindTransforms:boneWeights:boneIndices:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNSkinner");

	[Mac(10, 10)]
	[iOS(8, 0)]
	public SCNMatrix4[] BoneInverseBindTransforms => FromNSArray(_BoneInverseBindTransforms);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNGeometry BaseGeometry
	{
		[Export("baseGeometry", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNGeometry>(Messaging.IntPtr_objc_msgSend(base.Handle, selBaseGeometryHandle));
			}
			return Runtime.GetNSObject<SCNGeometry>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBaseGeometryHandle));
		}
		[Export("setBaseGeometry:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBaseGeometry_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBaseGeometry_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SCNMatrix4 BaseGeometryBindTransform
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("baseGeometryBindTransform")]
		get
		{
			SCNMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNMatrix4_objc_msgSend_stret(out retval, base.Handle, selBaseGeometryBindTransformHandle);
			}
			else
			{
				Messaging.SCNMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBaseGeometryBindTransformHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setBaseGeometryBindTransform:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNMatrix4(base.Handle, selSetBaseGeometryBindTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNMatrix4(base.SuperHandle, selSetBaseGeometryBindTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SCNGeometrySource BoneIndices
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("boneIndices")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNGeometrySource>(Messaging.IntPtr_objc_msgSend(base.Handle, selBoneIndicesHandle));
			}
			return Runtime.GetNSObject<SCNGeometrySource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBoneIndicesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SCNGeometrySource BoneWeights
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("boneWeights")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNGeometrySource>(Messaging.IntPtr_objc_msgSend(base.Handle, selBoneWeightsHandle));
			}
			return Runtime.GetNSObject<SCNGeometrySource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBoneWeightsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SCNNode[] Bones
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("bones")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selBonesHandle));
			}
			return NSArray.ArrayFromHandle<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBonesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNNode Skeleton
	{
		[Export("skeleton", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selSkeletonHandle));
			}
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSkeletonHandle));
		}
		[Export("setSkeleton:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSkeleton_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSkeleton_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	internal virtual NSArray _BoneInverseBindTransforms
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("boneInverseBindTransforms")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selBoneInverseBindTransformsHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBoneInverseBindTransformsHandle));
		}
	}

	private static SCNMatrix4[] FromNSArray(NSArray nsa)
	{
		if (nsa == null)
		{
			return null;
		}
		nuint count = nsa.Count;
		SCNMatrix4[] array = new SCNMatrix4[(ulong)count];
		for (nuint nuint = (byte)0; nuint < count; ++nuint)
		{
			array[(ulong)nuint] = Runtime.GetNSObject<NSValue>(nsa.ValueAt(nuint)).SCNMatrix4Value;
		}
		return array;
	}

	private static NSArray ToNSArray(SCNMatrix4[] items)
	{
		if (items == null)
		{
			return new NSArray();
		}
		int num = items.Length;
		IntPtr intPtr = Marshal.AllocHGlobal((IntPtr)(num * IntPtr.Size));
		for (nint nint = 0; nint < num; ++nint)
		{
			IntPtr val = NSValue.FromSCNMatrix4(items[(long)nint])?.Handle ?? NSNull.Null.Handle;
			Marshal.WriteIntPtr(intPtr, (int)(nint * IntPtr.Size), val);
		}
		NSArray result = new NSArray(NSArray.FromObjects(intPtr, num));
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Mac(10, 10)]
	[iOS(8, 0)]
	public static SCNSkinner Create(SCNGeometry baseGeometry, SCNNode[] bones, SCNMatrix4[] boneInverseBindTransforms, SCNGeometrySource boneWeights, SCNGeometrySource boneIndices)
	{
		return _Create(baseGeometry, bones, ToNSArray(boneInverseBindTransforms), boneWeights, boneIndices);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNSkinner(NSCoder coder)
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
	protected SCNSkinner(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNSkinner(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("skinnerWithBaseGeometry:bones:boneInverseBindTransforms:boneWeights:boneIndices:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static SCNSkinner _Create(SCNGeometry baseGeometry, SCNNode[] bones, NSArray boneInverseBindTransforms, SCNGeometrySource boneWeights, SCNGeometrySource boneIndices)
	{
		if (baseGeometry == null)
		{
			throw new ArgumentNullException("baseGeometry");
		}
		if (bones == null)
		{
			throw new ArgumentNullException("bones");
		}
		if (boneInverseBindTransforms == null)
		{
			throw new ArgumentNullException("boneInverseBindTransforms");
		}
		if (boneWeights == null)
		{
			throw new ArgumentNullException("boneWeights");
		}
		if (boneIndices == null)
		{
			throw new ArgumentNullException("boneIndices");
		}
		NSArray nSArray = NSArray.FromNSObjects(bones);
		SCNSkinner nSObject = Runtime.GetNSObject<SCNSkinner>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selSkinnerWithBaseGeometry_Bones_BoneInverseBindTransforms_BoneWeights_BoneIndices_Handle, baseGeometry.Handle, nSArray.Handle, boneInverseBindTransforms.Handle, boneWeights.Handle, boneIndices.Handle));
		nSArray.Dispose();
		return nSObject;
	}
}
