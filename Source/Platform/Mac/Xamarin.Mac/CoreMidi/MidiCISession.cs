using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreMidi;

[Register("MIDICISession", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MidiCISession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceIdentification = "deviceIdentification";

	private static readonly IntPtr selDeviceIdentificationHandle = Selector.GetHandle("deviceIdentification");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableProfile_OnChannel_Error_ = "disableProfile:onChannel:error:";

	private static readonly IntPtr selDisableProfile_OnChannel_Error_Handle = Selector.GetHandle("disableProfile:onChannel:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableProfile_OnChannel_Error_ = "enableProfile:onChannel:error:";

	private static readonly IntPtr selEnableProfile_OnChannel_Error_Handle = Selector.GetHandle("enableProfile:onChannel:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntity = "entity";

	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetProperty_OnChannel_ResponseHandler_ = "getProperty:onChannel:responseHandler:";

	private static readonly IntPtr selGetProperty_OnChannel_ResponseHandler_Handle = Selector.GetHandle("getProperty:onChannel:responseHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasProperty_OnChannel_ResponseHandler_ = "hasProperty:onChannel:responseHandler:";

	private static readonly IntPtr selHasProperty_OnChannel_ResponseHandler_Handle = Selector.GetHandle("hasProperty:onChannel:responseHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMIDIEntity_DataReadyHandler_ = "initWithMIDIEntity:dataReadyHandler:";

	private static readonly IntPtr selInitWithMIDIEntity_DataReadyHandler_Handle = Selector.GetHandle("initWithMIDIEntity:dataReadyHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProfileChangedCallback = "profileChangedCallback";

	private static readonly IntPtr selProfileChangedCallbackHandle = Selector.GetHandle("profileChangedCallback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProfileStateForChannel_ = "profileStateForChannel:";

	private static readonly IntPtr selProfileStateForChannel_Handle = Selector.GetHandle("profileStateForChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyChangedCallback = "propertyChangedCallback";

	private static readonly IntPtr selPropertyChangedCallbackHandle = Selector.GetHandle("propertyChangedCallback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProfileChangedCallback_ = "setProfileChangedCallback:";

	private static readonly IntPtr selSetProfileChangedCallback_Handle = Selector.GetHandle("setProfileChangedCallback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProperty_OnChannel_ResponseHandler_ = "setProperty:onChannel:responseHandler:";

	private static readonly IntPtr selSetProperty_OnChannel_ResponseHandler_Handle = Selector.GetHandle("setProperty:onChannel:responseHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPropertyChangedCallback_ = "setPropertyChangedCallback:";

	private static readonly IntPtr selSetPropertyChangedCallback_Handle = Selector.GetHandle("setPropertyChangedCallback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsProfileCapability = "supportsProfileCapability";

	private static readonly IntPtr selSupportsProfileCapabilityHandle = Selector.GetHandle("supportsProfileCapability");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsPropertyCapability = "supportsPropertyCapability";

	private static readonly IntPtr selSupportsPropertyCapabilityHandle = Selector.GetHandle("supportsPropertyCapability");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MIDICISession");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MidiCIDeviceIdentification DeviceIdentification
	{
		[Export("deviceIdentification")]
		get
		{
			MidiCIDeviceIdentification retval;
			if (base.IsDirectBinding)
			{
				Messaging.MidiCIDeviceIdentification_objc_msgSend_stret(out retval, base.Handle, selDeviceIdentificationHandle);
			}
			else
			{
				Messaging.MidiCIDeviceIdentification_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDeviceIdentificationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint Entity
	{
		[Export("entity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selEntityHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selEntityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual MidiCIProfileChangedHandler? ProfileChangedCallback
	{
		[Export("profileChangedCallback", ArgumentSemantic.Assign)]
		[return: DelegateProxy(typeof(Trampolines.SDMidiCIProfileChangedHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProfileChangedCallbackHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selProfileChangedCallbackHandle));
			return Trampolines.NIDMidiCIProfileChangedHandler.Create(block);
		}
		[Export("setProfileChangedCallback:", ArgumentSemantic.Assign)]
		[param: BlockProxy(typeof(Trampolines.NIDMidiCIProfileChangedHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDMidiCIProfileChangedHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProfileChangedCallback_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProfileChangedCallback_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual MidiCIPropertyChangedHandler? PropertyChangedCallback
	{
		[Export("propertyChangedCallback", ArgumentSemantic.Assign)]
		[return: DelegateProxy(typeof(Trampolines.SDMidiCIPropertyChangedHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertyChangedCallbackHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPropertyChangedCallbackHandle));
			return Trampolines.NIDMidiCIPropertyChangedHandler.Create(block);
		}
		[Export("setPropertyChangedCallback:", ArgumentSemantic.Assign)]
		[param: BlockProxy(typeof(Trampolines.NIDMidiCIPropertyChangedHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDMidiCIPropertyChangedHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPropertyChangedCallback_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPropertyChangedCallback_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsProfileCapability
	{
		[Export("supportsProfileCapability")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsProfileCapabilityHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsProfileCapabilityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsPropertyCapability
	{
		[Export("supportsPropertyCapability")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsPropertyCapabilityHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsPropertyCapabilityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MidiCISession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MidiCISession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMIDIEntity:dataReadyHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe MidiCISession(uint entity, [BlockProxy(typeof(Trampolines.NIDAction))] Action handler)
		: base(NSObjectFlag.Empty)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt32_IntPtr(base.Handle, selInitWithMIDIEntity_DataReadyHandler_Handle, entity, (IntPtr)ptr), "initWithMIDIEntity:dataReadyHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr(base.SuperHandle, selInitWithMIDIEntity_DataReadyHandler_Handle, entity, (IntPtr)ptr), "initWithMIDIEntity:dataReadyHandler:");
		}
		ptr->CleanupBlock();
	}

	[Export("disableProfile:onChannel:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DisableProfile(MidiCIProfile profile, byte channel, out NSError? outError)
	{
		if (profile == null)
		{
			throw new ArgumentNullException("profile");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_byte_ref_IntPtr(base.SuperHandle, selDisableProfile_OnChannel_Error_Handle, profile.Handle, channel, ref arg) : Messaging.bool_objc_msgSend_IntPtr_byte_ref_IntPtr(base.Handle, selDisableProfile_OnChannel_Error_Handle, profile.Handle, channel, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("enableProfile:onChannel:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EnableProfile(MidiCIProfile profile, byte channel, out NSError? outError)
	{
		if (profile == null)
		{
			throw new ArgumentNullException("profile");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_byte_ref_IntPtr(base.SuperHandle, selEnableProfile_OnChannel_Error_Handle, profile.Handle, channel, ref arg) : Messaging.bool_objc_msgSend_IntPtr_byte_ref_IntPtr(base.Handle, selEnableProfile_OnChannel_Error_Handle, profile.Handle, channel, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("profileStateForChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MidiCIProfileState GetProfileState(byte channel)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MidiCIProfileState>(Messaging.IntPtr_objc_msgSend_byte(base.Handle, selProfileStateForChannel_Handle, channel));
		}
		return Runtime.GetNSObject<MidiCIProfileState>(Messaging.IntPtr_objc_msgSendSuper_byte(base.SuperHandle, selProfileStateForChannel_Handle, channel));
	}

	[Export("getProperty:onChannel:responseHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetProperty(NSData inquiry, byte channel, [BlockProxy(typeof(Trampolines.NIDMidiCIPropertyResponseHandler))] MidiCIPropertyResponseHandler handler)
	{
		if (inquiry == null)
		{
			throw new ArgumentNullException("inquiry");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMidiCIPropertyResponseHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_byte_IntPtr(base.Handle, selGetProperty_OnChannel_ResponseHandler_Handle, inquiry.Handle, channel, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_byte_IntPtr(base.SuperHandle, selGetProperty_OnChannel_ResponseHandler_Handle, inquiry.Handle, channel, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("hasProperty:onChannel:responseHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void HasProperty(NSData inquiry, byte channel, [BlockProxy(typeof(Trampolines.NIDMidiCIPropertyResponseHandler))] MidiCIPropertyResponseHandler handler)
	{
		if (inquiry == null)
		{
			throw new ArgumentNullException("inquiry");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMidiCIPropertyResponseHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_byte_IntPtr(base.Handle, selHasProperty_OnChannel_ResponseHandler_Handle, inquiry.Handle, channel, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_byte_IntPtr(base.SuperHandle, selHasProperty_OnChannel_ResponseHandler_Handle, inquiry.Handle, channel, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("setProperty:onChannel:responseHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetProperty(NSData inquiry, byte channel, [BlockProxy(typeof(Trampolines.NIDMidiCIPropertyResponseHandler))] MidiCIPropertyResponseHandler handler)
	{
		if (inquiry == null)
		{
			throw new ArgumentNullException("inquiry");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMidiCIPropertyResponseHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_byte_IntPtr(base.Handle, selSetProperty_OnChannel_ResponseHandler_Handle, inquiry.Handle, channel, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_byte_IntPtr(base.SuperHandle, selSetProperty_OnChannel_ResponseHandler_Handle, inquiry.Handle, channel, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}
