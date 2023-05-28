using System.ComponentModel;
using System.Threading.Tasks;
using AudioUnit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVAudioUnit", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class AVAudioUnit : AVAudioNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAUAudioUnit = "AUAudioUnit";

	private static readonly IntPtr selAUAudioUnitHandle = Selector.GetHandle("AUAudioUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioComponentDescription = "audioComponentDescription";

	private static readonly IntPtr selAudioComponentDescriptionHandle = Selector.GetHandle("audioComponentDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioUnit = "audioUnit";

	private static readonly IntPtr selAudioUnitHandle = Selector.GetHandle("audioUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstantiateWithComponentDescription_Options_CompletionHandler_ = "instantiateWithComponentDescription:options:completionHandler:";

	private static readonly IntPtr selInstantiateWithComponentDescription_Options_CompletionHandler_Handle = Selector.GetHandle("instantiateWithComponentDescription:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadAudioUnitPresetAtURL_Error_ = "loadAudioUnitPresetAtURL:error:";

	private static readonly IntPtr selLoadAudioUnitPresetAtURL_Error_Handle = Selector.GetHandle("loadAudioUnitPresetAtURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManufacturerName = "manufacturerName";

	private static readonly IntPtr selManufacturerNameHandle = Selector.GetHandle("manufacturerName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVersion = "version";

	private static readonly IntPtr selVersionHandle = Selector.GetHandle("version");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioUnit");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public new virtual AUAudioUnit AUAudioUnit
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("AUAudioUnit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AUAudioUnit>(Messaging.IntPtr_objc_msgSend(base.Handle, selAUAudioUnitHandle));
			}
			return Runtime.GetNSObject<AUAudioUnit>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAUAudioUnitHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual AudioComponentDescription AudioComponentDescription
	{
		[Export("audioComponentDescription")]
		get
		{
			AudioComponentDescription retval;
			if (base.IsDirectBinding)
			{
				Messaging.AudioComponentDescription_objc_msgSend_stret(out retval, base.Handle, selAudioComponentDescriptionHandle);
			}
			else
			{
				Messaging.AudioComponentDescription_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAudioComponentDescriptionHandle);
			}
			return retval;
		}
	}

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
	public virtual string ManufacturerName
	{
		[Export("manufacturerName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selManufacturerNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManufacturerNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Version
	{
		[Export("version")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVersionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVersionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioUnit(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioUnit(IntPtr handle)
		: base(handle)
	{
	}

	[Export("instantiateWithComponentDescription:options:completionHandler:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void FromComponentDescription(AudioComponentDescription audioComponentDescription, AudioComponentInstantiationOptions options, [BlockProxy(typeof(Trampolines.NIDActionArity2V2))] Action<AVAudioUnit, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V2.Handler, completionHandler);
		Messaging.void_objc_msgSend_AudioComponentDescription_UInt32_IntPtr(class_ptr, selInstantiateWithComponentDescription_Options_CompletionHandler_Handle, audioComponentDescription, (uint)options, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<AVAudioUnit> FromComponentDescriptionAsync(AudioComponentDescription audioComponentDescription, AudioComponentInstantiationOptions options)
	{
		TaskCompletionSource<AVAudioUnit> tcs = new TaskCompletionSource<AVAudioUnit>();
		FromComponentDescription(audioComponentDescription, options, delegate(AVAudioUnit arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("loadAudioUnitPresetAtURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LoadAudioUnitPreset(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selLoadAudioUnitPresetAtURL_Error_Handle, url.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selLoadAudioUnitPresetAtURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
