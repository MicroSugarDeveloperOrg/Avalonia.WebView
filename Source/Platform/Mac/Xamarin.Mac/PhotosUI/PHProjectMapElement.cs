using System;
using System.ComponentModel;
using AppKit;
using CoreLocation;
using Foundation;
using MapKit;
using ObjCRuntime;

namespace PhotosUI;

[Register("PHProjectMapElement", true)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class PHProjectMapElement : PHProjectElement, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAltitude = "altitude";

	private static readonly IntPtr selAltitudeHandle = Selector.GetHandle("altitude");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnnotations = "annotations";

	private static readonly IntPtr selAnnotationsHandle = Selector.GetHandle("annotations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterCoordinate = "centerCoordinate";

	private static readonly IntPtr selCenterCoordinateHandle = Selector.GetHandle("centerCoordinate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeading = "heading";

	private static readonly IntPtr selHeadingHandle = Selector.GetHandle("heading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapType = "mapType";

	private static readonly IntPtr selMapTypeHandle = Selector.GetHandle("mapType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPitch = "pitch";

	private static readonly IntPtr selPitchHandle = Selector.GetHandle("pitch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHProjectMapElement");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Altitude
	{
		[Export("altitude")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAltitudeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAltitudeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMKAnnotation[] Annotations
	{
		[Export("annotations", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMKAnnotation>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnnotationsHandle));
			}
			return NSArray.ArrayFromHandle<IMKAnnotation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnnotationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CLLocationCoordinate2D CenterCoordinate
	{
		[Export("centerCoordinate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CLLocationCoordinate2D_objc_msgSend(base.Handle, selCenterCoordinateHandle);
			}
			return Messaging.CLLocationCoordinate2D_objc_msgSendSuper(base.SuperHandle, selCenterCoordinateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Heading
	{
		[Export("heading")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selHeadingHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selHeadingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapType MapType
	{
		[Export("mapType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (MKMapType)Messaging.UInt64_objc_msgSend(base.Handle, selMapTypeHandle);
			}
			return (MKMapType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMapTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Pitch
	{
		[Export("pitch")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selPitchHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selPitchHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public PHProjectMapElement(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected PHProjectMapElement(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHProjectMapElement(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
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
}
