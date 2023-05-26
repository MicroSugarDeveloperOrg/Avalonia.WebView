using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreMidi;

[Register("MIDICIProfileState", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MidiCIProfileState : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisabledProfiles = "disabledProfiles";

	private static readonly IntPtr selDisabledProfilesHandle = Selector.GetHandle("disabledProfiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnabledProfiles = "enabledProfiles";

	private static readonly IntPtr selEnabledProfilesHandle = Selector.GetHandle("enabledProfiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithEnabledProfiles_DisabledProfiles_ = "initWithEnabledProfiles:disabledProfiles:";

	private static readonly IntPtr selInitWithEnabledProfiles_DisabledProfiles_Handle = Selector.GetHandle("initWithEnabledProfiles:disabledProfiles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MIDICIProfileState");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MidiCIProfile[] DisabledProfiles
	{
		[Export("disabledProfiles")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MidiCIProfile>(Messaging.IntPtr_objc_msgSend(base.Handle, selDisabledProfilesHandle));
			}
			return NSArray.ArrayFromHandle<MidiCIProfile>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisabledProfilesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MidiCIProfile[] EnabledProfiles
	{
		[Export("enabledProfiles")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MidiCIProfile>(Messaging.IntPtr_objc_msgSend(base.Handle, selEnabledProfilesHandle));
			}
			return NSArray.ArrayFromHandle<MidiCIProfile>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEnabledProfilesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MidiCIProfileState(NSCoder coder)
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
	protected MidiCIProfileState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MidiCIProfileState(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithEnabledProfiles:disabledProfiles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MidiCIProfileState(MidiCIProfile[] enabled, MidiCIProfile[] disabled)
		: base(NSObjectFlag.Empty)
	{
		if (enabled == null)
		{
			throw new ArgumentNullException("enabled");
		}
		if (disabled == null)
		{
			throw new ArgumentNullException("disabled");
		}
		NSArray nSArray = NSArray.FromNSObjects(enabled);
		NSArray nSArray2 = NSArray.FromNSObjects(disabled);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithEnabledProfiles_DisabledProfiles_Handle, nSArray.Handle, nSArray2.Handle), "initWithEnabledProfiles:disabledProfiles:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithEnabledProfiles_DisabledProfiles_Handle, nSArray.Handle, nSArray2.Handle), "initWithEnabledProfiles:disabledProfiles:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
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
}
