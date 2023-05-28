using System;
using System.ComponentModel;
using AppKit;
using AudioUnit;
using Foundation;
using ObjCRuntime;

namespace CoreAudioKit;

[Register("AUGenericView", true)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class AUGenericView : NSView, IAUCustomViewPersistentData, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioUnit = "audioUnit";

	private static readonly IntPtr selAudioUnitHandle = Selector.GetHandle("audioUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomViewPersistentData = "customViewPersistentData";

	private static readonly IntPtr selCustomViewPersistentDataHandle = Selector.GetHandle("customViewPersistentData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAudioUnit_ = "initWithAudioUnit:";

	private static readonly IntPtr selInitWithAudioUnit_Handle = Selector.GetHandle("initWithAudioUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAudioUnit_DisplayFlags_ = "initWithAudioUnit:displayFlags:";

	private static readonly IntPtr selInitWithAudioUnit_DisplayFlags_Handle = Selector.GetHandle("initWithAudioUnit:displayFlags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomViewPersistentData_ = "setCustomViewPersistentData:";

	private static readonly IntPtr selSetCustomViewPersistentData_Handle = Selector.GetHandle("setCustomViewPersistentData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsExpertParameters_ = "setShowsExpertParameters:";

	private static readonly IntPtr selSetShowsExpertParameters_Handle = Selector.GetHandle("setShowsExpertParameters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsExpertParameters = "showsExpertParameters";

	private static readonly IntPtr selShowsExpertParametersHandle = Selector.GetHandle("showsExpertParameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AUGenericView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_CustomViewPersistentData_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual global::AudioUnit.AudioUnit AudioUnit
	{
		[Export("audioUnit")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioUnitHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selAudioUnitHandle));
			return (intPtr == IntPtr.Zero) ? null : new global::AudioUnit.AudioUnit(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSDictionary<NSString, NSObject>? CustomViewPersistentData
	{
		[Export("customViewPersistentData", ArgumentSemantic.Assign)]
		get
		{
			NSDictionary<NSString, NSObject> nSDictionary = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomViewPersistentDataHandle)) : Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomViewPersistentDataHandle)));
			MarkDirty();
			__mt_CustomViewPersistentData_var = nSDictionary;
			return nSDictionary;
		}
		[Export("setCustomViewPersistentData:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomViewPersistentData_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomViewPersistentData_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_CustomViewPersistentData_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsExpertParameters
	{
		[Export("showsExpertParameters")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsExpertParametersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsExpertParametersHandle);
		}
		[Export("setShowsExpertParameters:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsExpertParameters_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsExpertParameters_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AUGenericView(NSCoder coder)
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
	protected AUGenericView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AUGenericView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAudioUnit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AUGenericView(global::AudioUnit.AudioUnit au)
		: base(NSObjectFlag.Empty)
	{
		if (au == null)
		{
			throw new ArgumentNullException("au");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAudioUnit_Handle, au.Handle), "initWithAudioUnit:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAudioUnit_Handle, au.Handle), "initWithAudioUnit:");
		}
	}

	[Export("initWithAudioUnit:displayFlags:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AUGenericView(global::AudioUnit.AudioUnit au, AUGenericViewDisplayFlags inFlags)
		: base(NSObjectFlag.Empty)
	{
		if (au == null)
		{
			throw new ArgumentNullException("au");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt32(base.Handle, selInitWithAudioUnit_DisplayFlags_Handle, au.Handle, (uint)inFlags), "initWithAudioUnit:displayFlags:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selInitWithAudioUnit_DisplayFlags_Handle, au.Handle, (uint)inFlags), "initWithAudioUnit:displayFlags:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_CustomViewPersistentData_var = null;
		}
	}
}
