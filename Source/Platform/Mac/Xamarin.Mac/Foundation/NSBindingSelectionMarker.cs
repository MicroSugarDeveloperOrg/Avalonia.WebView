using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSBindingSelectionMarker", true)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
public class NSBindingSelectionMarker : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultPlaceholderForMarker_OnClass_WithBinding_ = "defaultPlaceholderForMarker:onClass:withBinding:";

	private static readonly IntPtr selDefaultPlaceholderForMarker_OnClass_WithBinding_Handle = Selector.GetHandle("defaultPlaceholderForMarker:onClass:withBinding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultipleValuesSelectionMarker = "multipleValuesSelectionMarker";

	private static readonly IntPtr selMultipleValuesSelectionMarkerHandle = Selector.GetHandle("multipleValuesSelectionMarker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoSelectionMarker = "noSelectionMarker";

	private static readonly IntPtr selNoSelectionMarkerHandle = Selector.GetHandle("noSelectionMarker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotApplicableSelectionMarker = "notApplicableSelectionMarker";

	private static readonly IntPtr selNotApplicableSelectionMarkerHandle = Selector.GetHandle("notApplicableSelectionMarker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultPlaceholder_ForMarker_OnClass_WithBinding_ = "setDefaultPlaceholder:forMarker:onClass:withBinding:";

	private static readonly IntPtr selSetDefaultPlaceholder_ForMarker_OnClass_WithBinding_Handle = Selector.GetHandle("setDefaultPlaceholder:forMarker:onClass:withBinding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSBindingSelectionMarker");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBindingSelectionMarker MultipleValuesSelectionMarker
	{
		[Export("multipleValuesSelectionMarker", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSBindingSelectionMarker>(Messaging.IntPtr_objc_msgSend(class_ptr, selMultipleValuesSelectionMarkerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBindingSelectionMarker NoSelectionMarker
	{
		[Export("noSelectionMarker", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSBindingSelectionMarker>(Messaging.IntPtr_objc_msgSend(class_ptr, selNoSelectionMarkerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSBindingSelectionMarker NotApplicableSelectionMarker
	{
		[Export("notApplicableSelectionMarker", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSBindingSelectionMarker>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotApplicableSelectionMarkerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSBindingSelectionMarker(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSBindingSelectionMarker(IntPtr handle)
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

	[Export("defaultPlaceholderForMarker:onClass:withBinding:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject? GetDefaultPlaceholder(NSBindingSelectionMarker? marker, Class objectClass, string binding)
	{
		if (objectClass == null)
		{
			throw new ArgumentNullException("objectClass");
		}
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		IntPtr arg = NSString.CreateNative(binding);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selDefaultPlaceholderForMarker_OnClass_WithBinding_Handle, marker?.Handle ?? IntPtr.Zero, objectClass.Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("setDefaultPlaceholder:forMarker:onClass:withBinding:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetDefaultPlaceholder(NSObject? placeholder, NSBindingSelectionMarker? marker, Class objectClass, string binding)
	{
		if (objectClass == null)
		{
			throw new ArgumentNullException("objectClass");
		}
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		IntPtr arg = NSString.CreateNative(binding);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selSetDefaultPlaceholder_ForMarker_OnClass_WithBinding_Handle, placeholder?.Handle ?? IntPtr.Zero, marker?.Handle ?? IntPtr.Zero, objectClass.Handle, arg);
		NSString.ReleaseNative(arg);
	}
}
