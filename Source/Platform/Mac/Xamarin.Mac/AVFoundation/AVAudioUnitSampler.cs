using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioUnitSampler", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class AVAudioUnitSampler : AVAudioUnitMidiInstrument
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlobalTuning = "globalTuning";

	private static readonly IntPtr selGlobalTuningHandle = Selector.GetHandle("globalTuning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadAudioFilesAtURLs_Error_ = "loadAudioFilesAtURLs:error:";

	private static readonly IntPtr selLoadAudioFilesAtURLs_Error_Handle = Selector.GetHandle("loadAudioFilesAtURLs:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadInstrumentAtURL_Error_ = "loadInstrumentAtURL:error:";

	private static readonly IntPtr selLoadInstrumentAtURL_Error_Handle = Selector.GetHandle("loadInstrumentAtURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadSoundBankInstrumentAtURL_Program_BankMSB_BankLSB_Error_ = "loadSoundBankInstrumentAtURL:program:bankMSB:bankLSB:error:";

	private static readonly IntPtr selLoadSoundBankInstrumentAtURL_Program_BankMSB_BankLSB_Error_Handle = Selector.GetHandle("loadSoundBankInstrumentAtURL:program:bankMSB:bankLSB:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMasterGain = "masterGain";

	private static readonly IntPtr selMasterGainHandle = Selector.GetHandle("masterGain");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGlobalTuning_ = "setGlobalTuning:";

	private static readonly IntPtr selSetGlobalTuning_Handle = Selector.GetHandle("setGlobalTuning:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMasterGain_ = "setMasterGain:";

	private static readonly IntPtr selSetMasterGain_Handle = Selector.GetHandle("setMasterGain:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStereoPan_ = "setStereoPan:";

	private static readonly IntPtr selSetStereoPan_Handle = Selector.GetHandle("setStereoPan:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStereoPan = "stereoPan";

	private static readonly IntPtr selStereoPanHandle = Selector.GetHandle("stereoPan");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioUnitSampler");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GlobalTuning
	{
		[Export("globalTuning")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGlobalTuningHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGlobalTuningHandle);
		}
		[Export("setGlobalTuning:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetGlobalTuning_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetGlobalTuning_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MasterGain
	{
		[Export("masterGain")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMasterGainHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMasterGainHandle);
		}
		[Export("setMasterGain:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMasterGain_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMasterGain_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float StereoPan
	{
		[Export("stereoPan")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selStereoPanHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selStereoPanHandle);
		}
		[Export("setStereoPan:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetStereoPan_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetStereoPan_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioUnitSampler()
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
	protected AVAudioUnitSampler(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioUnitSampler(IntPtr handle)
		: base(handle)
	{
	}

	[Export("loadAudioFilesAtURLs:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LoadAudioFiles(NSUrl[] audioFiles, out NSError outError)
	{
		if (audioFiles == null)
		{
			throw new ArgumentNullException("audioFiles");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(audioFiles);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selLoadAudioFilesAtURLs_Error_Handle, nSArray.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selLoadAudioFilesAtURLs_Error_Handle, nSArray.Handle, ref arg));
		nSArray.Dispose();
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("loadInstrumentAtURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LoadInstrument(NSUrl instrumentUrl, out NSError outError)
	{
		if (instrumentUrl == null)
		{
			throw new ArgumentNullException("instrumentUrl");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selLoadInstrumentAtURL_Error_Handle, instrumentUrl.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selLoadInstrumentAtURL_Error_Handle, instrumentUrl.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("loadSoundBankInstrumentAtURL:program:bankMSB:bankLSB:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LoadSoundBank(NSUrl bankUrl, byte program, byte bankMSB, byte bankLSB, out NSError outError)
	{
		if (bankUrl == null)
		{
			throw new ArgumentNullException("bankUrl");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_byte_byte_byte_ref_IntPtr(base.SuperHandle, selLoadSoundBankInstrumentAtURL_Program_BankMSB_BankLSB_Error_Handle, bankUrl.Handle, program, bankMSB, bankLSB, ref arg) : Messaging.bool_objc_msgSend_IntPtr_byte_byte_byte_ref_IntPtr(base.Handle, selLoadSoundBankInstrumentAtURL_Program_BankMSB_BankLSB_Error_Handle, bankUrl.Handle, program, bankMSB, bankLSB, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
