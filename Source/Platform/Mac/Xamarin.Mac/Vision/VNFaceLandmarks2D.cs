using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNFaceLandmarks2D", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNFaceLandmarks2D : VNFaceLandmarks
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllPoints = "allPoints";

	private static readonly IntPtr selAllPointsHandle = Selector.GetHandle("allPoints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFaceContour = "faceContour";

	private static readonly IntPtr selFaceContourHandle = Selector.GetHandle("faceContour");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInnerLips = "innerLips";

	private static readonly IntPtr selInnerLipsHandle = Selector.GetHandle("innerLips");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftEye = "leftEye";

	private static readonly IntPtr selLeftEyeHandle = Selector.GetHandle("leftEye");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftEyebrow = "leftEyebrow";

	private static readonly IntPtr selLeftEyebrowHandle = Selector.GetHandle("leftEyebrow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftPupil = "leftPupil";

	private static readonly IntPtr selLeftPupilHandle = Selector.GetHandle("leftPupil");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMedianLine = "medianLine";

	private static readonly IntPtr selMedianLineHandle = Selector.GetHandle("medianLine");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNose = "nose";

	private static readonly IntPtr selNoseHandle = Selector.GetHandle("nose");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoseCrest = "noseCrest";

	private static readonly IntPtr selNoseCrestHandle = Selector.GetHandle("noseCrest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOuterLips = "outerLips";

	private static readonly IntPtr selOuterLipsHandle = Selector.GetHandle("outerLips");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightEye = "rightEye";

	private static readonly IntPtr selRightEyeHandle = Selector.GetHandle("rightEye");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightEyebrow = "rightEyebrow";

	private static readonly IntPtr selRightEyebrowHandle = Selector.GetHandle("rightEyebrow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightPupil = "rightPupil";

	private static readonly IntPtr selRightPupilHandle = Selector.GetHandle("rightPupil");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNFaceLandmarks2D");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? AllPoints
	{
		[Export("allPoints")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllPointsHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllPointsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? FaceContour
	{
		[Export("faceContour")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selFaceContourHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFaceContourHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? InnerLips
	{
		[Export("innerLips")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selInnerLipsHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInnerLipsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? LeftEye
	{
		[Export("leftEye")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftEyeHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftEyeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? LeftEyebrow
	{
		[Export("leftEyebrow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftEyebrowHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftEyebrowHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? LeftPupil
	{
		[Export("leftPupil")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftPupilHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftPupilHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? MedianLine
	{
		[Export("medianLine")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selMedianLineHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMedianLineHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? Nose
	{
		[Export("nose")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selNoseHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNoseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? NoseCrest
	{
		[Export("noseCrest")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selNoseCrestHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNoseCrestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? OuterLips
	{
		[Export("outerLips")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selOuterLipsHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOuterLipsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? RightEye
	{
		[Export("rightEye")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightEyeHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightEyeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? RightEyebrow
	{
		[Export("rightEyebrow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightEyebrowHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightEyebrowHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarkRegion2D? RightPupil
	{
		[Export("rightPupil")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightPupilHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarkRegion2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightPupilHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public VNFaceLandmarks2D(NSCoder coder)
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
	protected VNFaceLandmarks2D(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNFaceLandmarks2D(IntPtr handle)
		: base(handle)
	{
	}
}
