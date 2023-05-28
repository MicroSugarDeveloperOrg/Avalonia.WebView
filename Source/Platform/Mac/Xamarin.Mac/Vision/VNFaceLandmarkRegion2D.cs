using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNFaceLandmarkRegion2D", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNFaceLandmarkRegion2D : VNFaceLandmarkRegion
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNormalizedPoints = "normalizedPoints";

	private static readonly IntPtr selNormalizedPointsHandle = Selector.GetHandle("normalizedPoints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointsInImageOfSize_ = "pointsInImageOfSize:";

	private static readonly IntPtr selPointsInImageOfSize_Handle = Selector.GetHandle("pointsInImageOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrecisionEstimatesPerPoint = "precisionEstimatesPerPoint";

	private static readonly IntPtr selPrecisionEstimatesPerPointHandle = Selector.GetHandle("precisionEstimatesPerPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNFaceLandmarkRegion2D");

	public unsafe virtual CGPoint[] NormalizedPoints
	{
		get
		{
			IntPtr intPtr = _GetNormalizedPoints();
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			int num = (int)PointCount;
			CGPoint[] array = new CGPoint[num];
			CGPoint* ptr = (CGPoint*)(void*)intPtr;
			for (int i = 0; i < num; i++)
			{
				array[i] = *(ptr++);
			}
			return array;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindAs(typeof(nfloat[]), OriginalType = typeof(NSNumber[]))]
	public virtual nfloat[]? PrecisionEstimatesPerPoint
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("precisionEstimatesPerPoint")]
		get
		{
			IntPtr intPtr;
			if (base.IsDirectBinding)
			{
				return ((intPtr = Messaging.IntPtr_objc_msgSend(base.Handle, selPrecisionEstimatesPerPointHandle)) == IntPtr.Zero) ? null : NSArray.ArrayFromHandleFunc(intPtr, delegate(IntPtr ptr)
				{
					using NSNumber nSNumber2 = Runtime.GetNSObject<NSNumber>(ptr);
					return nSNumber2.NFloatValue;
				});
			}
			IntPtr intPtr2;
			return ((intPtr2 = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrecisionEstimatesPerPointHandle)) == IntPtr.Zero) ? null : NSArray.ArrayFromHandleFunc(intPtr2, delegate(IntPtr ptr)
			{
				using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(ptr);
				return nSNumber.NFloatValue;
			});
		}
	}

	public unsafe virtual CGPoint[] GetPointsInImage(CGSize imageSize)
	{
		IntPtr intPtr = _GetPointsInImage(imageSize);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		int num = (int)PointCount;
		CGPoint[] array = new CGPoint[num];
		CGPoint* ptr = (CGPoint*)(void*)intPtr;
		for (int i = 0; i < num; i++)
		{
			array[i] = *(ptr++);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public VNFaceLandmarkRegion2D(NSCoder coder)
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
	protected VNFaceLandmarkRegion2D(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNFaceLandmarkRegion2D(IntPtr handle)
		: base(handle)
	{
	}

	[Export("normalizedPoints")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _GetNormalizedPoints()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selNormalizedPointsHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNormalizedPointsHandle);
	}

	[Export("pointsInImageOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _GetPointsInImage(CGSize imageSize)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_CGSize(base.Handle, selPointsInImageOfSize_Handle, imageSize);
		}
		return Messaging.IntPtr_objc_msgSendSuper_CGSize(base.SuperHandle, selPointsInImageOfSize_Handle, imageSize);
	}
}
