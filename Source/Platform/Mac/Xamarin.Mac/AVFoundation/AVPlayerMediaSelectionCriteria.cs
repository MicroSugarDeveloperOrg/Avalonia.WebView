using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerMediaSelectionCriteria", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVPlayerMediaSelectionCriteria : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPreferredLanguages_PreferredMediaCharacteristics_ = "initWithPreferredLanguages:preferredMediaCharacteristics:";

	private static readonly IntPtr selInitWithPreferredLanguages_PreferredMediaCharacteristics_Handle = Selector.GetHandle("initWithPreferredLanguages:preferredMediaCharacteristics:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPrincipalMediaCharacteristics_PreferredLanguages_PreferredMediaCharacteristics_ = "initWithPrincipalMediaCharacteristics:preferredLanguages:preferredMediaCharacteristics:";

	private static readonly IntPtr selInitWithPrincipalMediaCharacteristics_PreferredLanguages_PreferredMediaCharacteristics_Handle = Selector.GetHandle("initWithPrincipalMediaCharacteristics:preferredLanguages:preferredMediaCharacteristics:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredLanguages = "preferredLanguages";

	private static readonly IntPtr selPreferredLanguagesHandle = Selector.GetHandle("preferredLanguages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMediaCharacteristics = "preferredMediaCharacteristics";

	private static readonly IntPtr selPreferredMediaCharacteristicsHandle = Selector.GetHandle("preferredMediaCharacteristics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrincipalMediaCharacteristics = "principalMediaCharacteristics";

	private static readonly IntPtr selPrincipalMediaCharacteristicsHandle = Selector.GetHandle("principalMediaCharacteristics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPlayerMediaSelectionCriteria");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? PreferredLanguages
	{
		[Export("preferredLanguages")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredLanguagesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredLanguagesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[]? PreferredMediaCharacteristics
	{
		[Export("preferredMediaCharacteristics")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredMediaCharacteristicsHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredMediaCharacteristicsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindAs(typeof(AVMediaCharacteristics[]), OriginalType = typeof(NSString[]))]
	public virtual AVMediaCharacteristics[]? PrincipalMediaCharacteristics
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("principalMediaCharacteristics")]
		get
		{
			IntPtr intPtr;
			if (base.IsDirectBinding)
			{
				return ((intPtr = Messaging.IntPtr_objc_msgSend(base.Handle, selPrincipalMediaCharacteristicsHandle)) == IntPtr.Zero) ? null : NSArray.ArrayFromHandleFunc(intPtr, delegate(IntPtr ptr)
				{
					using NSString constant2 = Runtime.GetNSObject<NSString>(ptr);
					return AVMediaCharacteristicsExtensions.GetValue(constant2);
				});
			}
			IntPtr intPtr2;
			return ((intPtr2 = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrincipalMediaCharacteristicsHandle)) == IntPtr.Zero) ? null : NSArray.ArrayFromHandleFunc(intPtr2, delegate(IntPtr ptr)
			{
				using NSString constant = Runtime.GetNSObject<NSString>(ptr);
				return AVMediaCharacteristicsExtensions.GetValue(constant);
			});
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerMediaSelectionCriteria()
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
	protected AVPlayerMediaSelectionCriteria(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerMediaSelectionCriteria(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPreferredLanguages:preferredMediaCharacteristics:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerMediaSelectionCriteria(string[]? preferredLanguages, NSString[]? preferredMediaCharacteristics)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((preferredLanguages == null) ? null : NSArray.FromStrings(preferredLanguages));
		NSArray nSArray2 = ((preferredMediaCharacteristics == null) ? null : NSArray.FromNSObjects(preferredMediaCharacteristics));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithPreferredLanguages_PreferredMediaCharacteristics_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithPreferredLanguages:preferredMediaCharacteristics:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithPreferredLanguages_PreferredMediaCharacteristics_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithPreferredLanguages:preferredMediaCharacteristics:");
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
	}

	[Export("initWithPrincipalMediaCharacteristics:preferredLanguages:preferredMediaCharacteristics:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerMediaSelectionCriteria([BindAs(typeof(AVMediaCharacteristics[]), OriginalType = typeof(NSString[]))] AVMediaCharacteristics[] principalMediaCharacteristics, [BindAs(typeof(AVMediaCharacteristics[]), OriginalType = typeof(NSString[]))] AVMediaCharacteristics[] preferredLanguages, string[]? preferredMediaCharacteristics)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = NSArray.FromNSObjects((AVMediaCharacteristics o) => o.GetConstant(), principalMediaCharacteristics);
		NSArray nSArray2 = NSArray.FromNSObjects((AVMediaCharacteristics o) => o.GetConstant(), preferredLanguages);
		NSArray nSArray3 = ((preferredMediaCharacteristics == null) ? null : NSArray.FromStrings(preferredMediaCharacteristics));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithPrincipalMediaCharacteristics_PreferredLanguages_PreferredMediaCharacteristics_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero), "initWithPrincipalMediaCharacteristics:preferredLanguages:preferredMediaCharacteristics:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithPrincipalMediaCharacteristics_PreferredLanguages_PreferredMediaCharacteristics_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero), "initWithPrincipalMediaCharacteristics:preferredLanguages:preferredMediaCharacteristics:");
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
		nSArray3?.Dispose();
	}
}
