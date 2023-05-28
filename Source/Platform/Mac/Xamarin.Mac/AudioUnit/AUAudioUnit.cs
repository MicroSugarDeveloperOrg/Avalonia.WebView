using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using AVFoundation;
using CoreMidi;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AudioUnit;

[Register("AUAudioUnit", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AUAudioUnit : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveAudioComponentInstanceInvalidation(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AudioComponentInstanceInvalidationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAudioComponentInstanceInvalidation(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AudioComponentInstanceInvalidationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveAudioComponentRegistrationsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AudioComponentRegistrationsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAudioComponentRegistrationsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AudioComponentRegistrationsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMIDIOutputBufferSizeHint = "MIDIOutputBufferSizeHint";

	private static readonly IntPtr selMIDIOutputBufferSizeHintHandle = Selector.GetHandle("MIDIOutputBufferSizeHint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMIDIOutputEventBlock = "MIDIOutputEventBlock";

	private static readonly IntPtr selMIDIOutputEventBlockHandle = Selector.GetHandle("MIDIOutputEventBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMIDIOutputNames = "MIDIOutputNames";

	private static readonly IntPtr selMIDIOutputNamesHandle = Selector.GetHandle("MIDIOutputNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllParameterValues = "allParameterValues";

	private static readonly IntPtr selAllParameterValuesHandle = Selector.GetHandle("allParameterValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllocateRenderResourcesAndReturnError_ = "allocateRenderResourcesAndReturnError:";

	private static readonly IntPtr selAllocateRenderResourcesAndReturnError_Handle = Selector.GetHandle("allocateRenderResourcesAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioUnitName = "audioUnitName";

	private static readonly IntPtr selAudioUnitNameHandle = Selector.GetHandle("audioUnitName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioUnitShortName = "audioUnitShortName";

	private static readonly IntPtr selAudioUnitShortNameHandle = Selector.GetHandle("audioUnitShortName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanProcessInPlace = "canProcessInPlace";

	private static readonly IntPtr selCanProcessInPlaceHandle = Selector.GetHandle("canProcessInPlace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelCapabilities = "channelCapabilities";

	private static readonly IntPtr selChannelCapabilitiesHandle = Selector.GetHandle("channelCapabilities");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelMap = "channelMap";

	private static readonly IntPtr selChannelMapHandle = Selector.GetHandle("channelMap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponent = "component";

	private static readonly IntPtr selComponentHandle = Selector.GetHandle("component");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentDescription = "componentDescription";

	private static readonly IntPtr selComponentDescriptionHandle = Selector.GetHandle("componentDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentName = "componentName";

	private static readonly IntPtr selComponentNameHandle = Selector.GetHandle("componentName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentVersion = "componentVersion";

	private static readonly IntPtr selComponentVersionHandle = Selector.GetHandle("componentVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextName = "contextName";

	private static readonly IntPtr selContextNameHandle = Selector.GetHandle("contextName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPreset = "currentPreset";

	private static readonly IntPtr selCurrentPresetHandle = Selector.GetHandle("currentPreset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeallocateRenderResources = "deallocateRenderResources";

	private static readonly IntPtr selDeallocateRenderResourcesHandle = Selector.GetHandle("deallocateRenderResources");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteUserPreset_Error_ = "deleteUserPreset:error:";

	private static readonly IntPtr selDeleteUserPreset_Error_Handle = Selector.GetHandle("deleteUserPreset:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableProfile_Cable_OnChannel_Error_ = "disableProfile:cable:onChannel:error:";

	private static readonly IntPtr selDisableProfile_Cable_OnChannel_Error_Handle = Selector.GetHandle("disableProfile:cable:onChannel:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableProfile_Cable_OnChannel_Error_ = "enableProfile:cable:onChannel:error:";

	private static readonly IntPtr selEnableProfile_Cable_OnChannel_Error_Handle = Selector.GetHandle("enableProfile:cable:onChannel:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFactoryPresets = "factoryPresets";

	private static readonly IntPtr selFactoryPresetsHandle = Selector.GetHandle("factoryPresets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFullState = "fullState";

	private static readonly IntPtr selFullStateHandle = Selector.GetHandle("fullState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFullStateForDocument = "fullStateForDocument";

	private static readonly IntPtr selFullStateForDocumentHandle = Selector.GetHandle("fullStateForDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithComponentDescription_Error_ = "initWithComponentDescription:error:";

	private static readonly IntPtr selInitWithComponentDescription_Error_Handle = Selector.GetHandle("initWithComponentDescription:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithComponentDescription_Options_Error_ = "initWithComponentDescription:options:error:";

	private static readonly IntPtr selInitWithComponentDescription_Options_Error_Handle = Selector.GetHandle("initWithComponentDescription:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputBusses = "inputBusses";

	private static readonly IntPtr selInputBussesHandle = Selector.GetHandle("inputBusses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstantiateWithComponentDescription_Options_CompletionHandler_ = "instantiateWithComponentDescription:options:completionHandler:";

	private static readonly IntPtr selInstantiateWithComponentDescription_Options_CompletionHandler_Handle = Selector.GetHandle("instantiateWithComponentDescription:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInternalRenderBlock = "internalRenderBlock";

	private static readonly IntPtr selInternalRenderBlockHandle = Selector.GetHandle("internalRenderBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLoadedInProcess = "isLoadedInProcess";

	private static readonly IntPtr selIsLoadedInProcessHandle = Selector.GetHandle("isLoadedInProcess");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMusicDeviceOrEffect = "isMusicDeviceOrEffect";

	private static readonly IntPtr selIsMusicDeviceOrEffectHandle = Selector.GetHandle("isMusicDeviceOrEffect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRenderingOffline = "isRenderingOffline";

	private static readonly IntPtr selIsRenderingOfflineHandle = Selector.GetHandle("isRenderingOffline");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLatency = "latency";

	private static readonly IntPtr selLatencyHandle = Selector.GetHandle("latency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManufacturerName = "manufacturerName";

	private static readonly IntPtr selManufacturerNameHandle = Selector.GetHandle("manufacturerName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumFramesToRender = "maximumFramesToRender";

	private static readonly IntPtr selMaximumFramesToRenderHandle = Selector.GetHandle("maximumFramesToRender");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputBusses = "outputBusses";

	private static readonly IntPtr selOutputBussesHandle = Selector.GetHandle("outputBusses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParameterTree = "parameterTree";

	private static readonly IntPtr selParameterTreeHandle = Selector.GetHandle("parameterTree");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParametersForOverviewWithCount_ = "parametersForOverviewWithCount:";

	private static readonly IntPtr selParametersForOverviewWithCount_Handle = Selector.GetHandle("parametersForOverviewWithCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresetStateFor_Error_ = "presetStateFor:error:";

	private static readonly IntPtr selPresetStateFor_Error_Handle = Selector.GetHandle("presetStateFor:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProfileChangedBlock = "profileChangedBlock";

	private static readonly IntPtr selProfileChangedBlockHandle = Selector.GetHandle("profileChangedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProfileStateForCable_Channel_ = "profileStateForCable:channel:";

	private static readonly IntPtr selProfileStateForCable_Channel_Handle = Selector.GetHandle("profileStateForCable:channel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProvidesUserInterface = "providesUserInterface";

	private static readonly IntPtr selProvidesUserInterfaceHandle = Selector.GetHandle("providesUserInterface");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterSubclass_AsComponentDescription_Name_Version_ = "registerSubclass:asComponentDescription:name:version:";

	private static readonly IntPtr selRegisterSubclass_AsComponentDescription_Name_Version_Handle = Selector.GetHandle("registerSubclass:asComponentDescription:name:version:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRenderObserver_ = "removeRenderObserver:";

	private static readonly IntPtr selRemoveRenderObserver_Handle = Selector.GetHandle("removeRenderObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderBlock = "renderBlock";

	private static readonly IntPtr selRenderBlockHandle = Selector.GetHandle("renderBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderQuality = "renderQuality";

	private static readonly IntPtr selRenderQualityHandle = Selector.GetHandle("renderQuality");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderResourcesAllocated = "renderResourcesAllocated";

	private static readonly IntPtr selRenderResourcesAllocatedHandle = Selector.GetHandle("renderResourcesAllocated");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestViewControllerWithCompletionHandler_ = "requestViewControllerWithCompletionHandler:";

	private static readonly IntPtr selRequestViewControllerWithCompletionHandler_Handle = Selector.GetHandle("requestViewControllerWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveUserPreset_Error_ = "saveUserPreset:error:";

	private static readonly IntPtr selSaveUserPreset_Error_Handle = Selector.GetHandle("saveUserPreset:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleParameterBlock = "scheduleParameterBlock";

	private static readonly IntPtr selScheduleParameterBlockHandle = Selector.GetHandle("scheduleParameterBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChannelMap_ = "setChannelMap:";

	private static readonly IntPtr selSetChannelMap_Handle = Selector.GetHandle("setChannelMap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContextName_ = "setContextName:";

	private static readonly IntPtr selSetContextName_Handle = Selector.GetHandle("setContextName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentPreset_ = "setCurrentPreset:";

	private static readonly IntPtr selSetCurrentPreset_Handle = Selector.GetHandle("setCurrentPreset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFullState_ = "setFullState:";

	private static readonly IntPtr selSetFullState_Handle = Selector.GetHandle("setFullState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFullStateForDocument_ = "setFullStateForDocument:";

	private static readonly IntPtr selSetFullStateForDocument_Handle = Selector.GetHandle("setFullStateForDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMIDIOutputBufferSizeHint_ = "setMIDIOutputBufferSizeHint:";

	private static readonly IntPtr selSetMIDIOutputBufferSizeHint_Handle = Selector.GetHandle("setMIDIOutputBufferSizeHint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMIDIOutputEventBlock_ = "setMIDIOutputEventBlock:";

	private static readonly IntPtr selSetMIDIOutputEventBlock_Handle = Selector.GetHandle("setMIDIOutputEventBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumFramesToRender_ = "setMaximumFramesToRender:";

	private static readonly IntPtr selSetMaximumFramesToRender_Handle = Selector.GetHandle("setMaximumFramesToRender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParameterTree_ = "setParameterTree:";

	private static readonly IntPtr selSetParameterTree_Handle = Selector.GetHandle("setParameterTree:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProfileChangedBlock_ = "setProfileChangedBlock:";

	private static readonly IntPtr selSetProfileChangedBlock_Handle = Selector.GetHandle("setProfileChangedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenderQuality_ = "setRenderQuality:";

	private static readonly IntPtr selSetRenderQuality_Handle = Selector.GetHandle("setRenderQuality:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenderResourcesAllocated_ = "setRenderResourcesAllocated:";

	private static readonly IntPtr selSetRenderResourcesAllocated_Handle = Selector.GetHandle("setRenderResourcesAllocated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenderingOffline_ = "setRenderingOffline:";

	private static readonly IntPtr selSetRenderingOffline_Handle = Selector.GetHandle("setRenderingOffline:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldBypassEffect_ = "setShouldBypassEffect:";

	private static readonly IntPtr selSetShouldBypassEffect_Handle = Selector.GetHandle("setShouldBypassEffect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransportStateBlock_ = "setTransportStateBlock:";

	private static readonly IntPtr selSetTransportStateBlock_Handle = Selector.GetHandle("setTransportStateBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldBypassEffect = "shouldBypassEffect";

	private static readonly IntPtr selShouldBypassEffectHandle = Selector.GetHandle("shouldBypassEffect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldChangeToFormat_ForBus_ = "shouldChangeToFormat:forBus:";

	private static readonly IntPtr selShouldChangeToFormat_ForBus_Handle = Selector.GetHandle("shouldChangeToFormat:forBus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsMPE = "supportsMPE";

	private static readonly IntPtr selSupportsMPEHandle = Selector.GetHandle("supportsMPE");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsUserPresets = "supportsUserPresets";

	private static readonly IntPtr selSupportsUserPresetsHandle = Selector.GetHandle("supportsUserPresets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTailTime = "tailTime";

	private static readonly IntPtr selTailTimeHandle = Selector.GetHandle("tailTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransportStateBlock = "transportStateBlock";

	private static readonly IntPtr selTransportStateBlockHandle = Selector.GetHandle("transportStateBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserPresets = "userPresets";

	private static readonly IntPtr selUserPresetsHandle = Selector.GetHandle("userPresets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVirtualMIDICableCount = "virtualMIDICableCount";

	private static readonly IntPtr selVirtualMIDICableCountHandle = Selector.GetHandle("virtualMIDICableCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AUAudioUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioComponentInstanceInvalidationNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioComponentRegistrationsChangedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllParameterValues
	{
		[Export("allParameterValues")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllParameterValuesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllParameterValuesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? AudioUnitName
	{
		[Export("audioUnitName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioUnitNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioUnitNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanProcessInPlace
	{
		[Export("canProcessInPlace")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanProcessInPlaceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanProcessInPlaceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? ChannelCapabilities
	{
		[Export("channelCapabilities", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selChannelCapabilitiesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChannelCapabilitiesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual NSNumber[]? ChannelMap
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("channelMap")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selChannelMapHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChannelMapHandle));
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setChannelMap:")]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetChannelMap_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetChannelMap_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AudioComponent Component
	{
		[Export("component")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComponentHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selComponentHandle));
			return (intPtr == IntPtr.Zero) ? null : new AudioComponent(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AudioComponentDescription ComponentDescription
	{
		[Export("componentDescription")]
		get
		{
			AudioComponentDescription retval;
			if (base.IsDirectBinding)
			{
				Messaging.AudioComponentDescription_objc_msgSend_stret(out retval, base.Handle, selComponentDescriptionHandle);
			}
			else
			{
				Messaging.AudioComponentDescription_objc_msgSendSuper_stret(out retval, base.SuperHandle, selComponentDescriptionHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ComponentName
	{
		[Export("componentName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selComponentNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComponentNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint ComponentVersion
	{
		[Export("componentVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selComponentVersionHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selComponentVersionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ContextName
	{
		[Export("contextName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContextNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContextNameHandle));
		}
		[Export("setContextName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContextName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContextName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUAudioUnitPreset? CurrentPreset
	{
		[Export("currentPreset", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AUAudioUnitPreset>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentPresetHandle));
			}
			return Runtime.GetNSObject<AUAudioUnitPreset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentPresetHandle));
		}
		[Export("setCurrentPreset:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrentPreset_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrentPreset_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUAudioUnitPreset[]? FactoryPresets
	{
		[Export("factoryPresets", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AUAudioUnitPreset>(Messaging.IntPtr_objc_msgSend(base.Handle, selFactoryPresetsHandle));
			}
			return NSArray.ArrayFromHandle<AUAudioUnitPreset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFactoryPresetsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? FullState
	{
		[Export("fullState", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selFullStateHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFullStateHandle));
		}
		[Export("setFullState:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFullState_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFullState_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? FullStateForDocument
	{
		[Export("fullStateForDocument", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selFullStateForDocumentHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFullStateForDocumentHandle));
		}
		[Export("setFullStateForDocument:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFullStateForDocument_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFullStateForDocument_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUAudioUnitBusArray InputBusses
	{
		[Export("inputBusses")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AUAudioUnitBusArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputBussesHandle));
			}
			return Runtime.GetNSObject<AUAudioUnitBusArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputBussesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUInternalRenderBlock InternalRenderBlock
	{
		[Export("internalRenderBlock")]
		[return: DelegateProxy(typeof(Trampolines.SDAUInternalRenderBlock))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInternalRenderBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selInternalRenderBlockHandle));
			return Trampolines.NIDAUInternalRenderBlock.Create(block);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual bool IsLoadedInProcess
	{
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("isLoadedInProcess")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadedInProcessHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadedInProcessHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Latency
	{
		[Export("latency")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLatencyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLatencyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ManufacturerName
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
	public virtual uint MaximumFramesToRender
	{
		[Export("maximumFramesToRender")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selMaximumFramesToRenderHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selMaximumFramesToRenderHandle);
		}
		[Export("setMaximumFramesToRender:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetMaximumFramesToRender_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetMaximumFramesToRender_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nint MidiOutputBufferSizeHint
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("MIDIOutputBufferSizeHint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMIDIOutputBufferSizeHintHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMIDIOutputBufferSizeHintHandle);
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setMIDIOutputBufferSizeHint:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMIDIOutputBufferSizeHint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMIDIOutputBufferSizeHint_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public unsafe virtual AUMidiOutputEventBlock? MidiOutputEventBlock
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("MIDIOutputEventBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAUMidiOutputEventBlock))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMIDIOutputEventBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selMIDIOutputEventBlockHandle));
			return Trampolines.NIDAUMidiOutputEventBlock.Create(block);
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setMIDIOutputEventBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAUMidiOutputEventBlock))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAUMidiOutputEventBlock.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMIDIOutputEventBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMIDIOutputEventBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string[] MidiOutputNames
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("MIDIOutputNames", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMIDIOutputNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMIDIOutputNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MusicDeviceOrEffect
	{
		[Export("isMusicDeviceOrEffect")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMusicDeviceOrEffectHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMusicDeviceOrEffectHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUAudioUnitBusArray OutputBusses
	{
		[Export("outputBusses")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AUAudioUnitBusArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputBussesHandle));
			}
			return Runtime.GetNSObject<AUAudioUnitBusArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputBussesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUParameterTree? ParameterTree
	{
		[Export("parameterTree")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AUParameterTree>(Messaging.IntPtr_objc_msgSend(base.Handle, selParameterTreeHandle));
			}
			return Runtime.GetNSObject<AUParameterTree>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParameterTreeHandle));
		}
		[Export("setParameterTree:")]
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParameterTree_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParameterTree_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public unsafe virtual AUMidiCIProfileChangedCallback? ProfileChangedCallback
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("profileChangedBlock", ArgumentSemantic.Assign)]
		[return: DelegateProxy(typeof(Trampolines.SDAUMidiCIProfileChangedCallback))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProfileChangedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selProfileChangedBlockHandle));
			return Trampolines.NIDAUMidiCIProfileChangedCallback.Create(block);
		}
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("setProfileChangedBlock:", ArgumentSemantic.Assign)]
		[param: BlockProxy(typeof(Trampolines.NIDAUMidiCIProfileChangedCallback))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAUMidiCIProfileChangedCallback.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProfileChangedBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProfileChangedBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool ProvidesUserInterface
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("providesUserInterface")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selProvidesUserInterfaceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selProvidesUserInterfaceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AURenderBlock RenderBlock
	{
		[Export("renderBlock")]
		[return: DelegateProxy(typeof(Trampolines.SDAURenderBlock))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRenderBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selRenderBlockHandle));
			return Trampolines.NIDAURenderBlock.Create(block);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RenderQuality
	{
		[Export("renderQuality", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selRenderQualityHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRenderQualityHandle);
		}
		[Export("setRenderQuality:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetRenderQuality_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetRenderQuality_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RenderResourcesAllocated
	{
		[Export("renderResourcesAllocated")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRenderResourcesAllocatedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRenderResourcesAllocatedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RenderingOffline
	{
		[Export("isRenderingOffline")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRenderingOfflineHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRenderingOfflineHandle);
		}
		[Export("setRenderingOffline:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRenderingOffline_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRenderingOffline_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUScheduleParameterBlock ScheduleParameterBlock
	{
		[Export("scheduleParameterBlock")]
		[return: DelegateProxy(typeof(Trampolines.SDAUScheduleParameterBlock))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScheduleParameterBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selScheduleParameterBlockHandle));
			return Trampolines.NIDAUScheduleParameterBlock.Create(block);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual string? ShortName
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("audioUnitShortName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioUnitShortNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioUnitShortNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBypassEffect
	{
		[Export("shouldBypassEffect")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldBypassEffectHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldBypassEffectHandle);
		}
		[Export("setShouldBypassEffect:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldBypassEffect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldBypassEffect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public virtual bool SupportsMpe
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Export("supportsMPE")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsMPEHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsMPEHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool SupportsUserPresets
	{
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("supportsUserPresets")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsUserPresetsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsUserPresetsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TailTime
	{
		[Export("tailTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTailTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTailTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual AUHostTransportStateBlock? TransportStateBlock
	{
		[Export("transportStateBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAUHostTransportStateBlock))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransportStateBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selTransportStateBlockHandle));
			return Trampolines.NIDAUHostTransportStateBlock.Create(block);
		}
		[Export("setTransportStateBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAUHostTransportStateBlock))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAUHostTransportStateBlock.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTransportStateBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTransportStateBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual AUAudioUnitPreset[] UserPresets
	{
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("userPresets", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AUAudioUnitPreset>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserPresetsHandle));
			}
			return NSArray.ArrayFromHandle<AUAudioUnitPreset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserPresetsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint VirtualMidiCableCount
	{
		[Export("virtualMIDICableCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selVirtualMIDICableCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selVirtualMIDICableCountHandle);
		}
	}

	[Field("kAudioComponentInstanceInvalidationNotification", "AudioUnit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Advice("Use AUAudioUnit.Notifications.ObserveAudioComponentInstanceInvalidation helper method instead.")]
	public static NSString AudioComponentInstanceInvalidationNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AudioComponentInstanceInvalidationNotification == null)
			{
				_AudioComponentInstanceInvalidationNotification = Dlfcn.GetStringConstant(Libraries.AudioUnit.Handle, "kAudioComponentInstanceInvalidationNotification");
			}
			return _AudioComponentInstanceInvalidationNotification;
		}
	}

	[Field("kAudioComponentRegistrationsChangedNotification", "AudioUnit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Advice("Use AUAudioUnit.Notifications.ObserveAudioComponentRegistrationsChanged helper method instead.")]
	public static NSString AudioComponentRegistrationsChangedNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AudioComponentRegistrationsChangedNotification == null)
			{
				_AudioComponentRegistrationsChangedNotification = Dlfcn.GetStringConstant(Libraries.AudioUnit.Handle, "kAudioComponentRegistrationsChangedNotification");
			}
			return _AudioComponentRegistrationsChangedNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AUAudioUnit(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AUAudioUnit(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithComponentDescription:options:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AUAudioUnit(AudioComponentDescription componentDescription, AudioComponentInstantiationOptions options, out NSError? outError)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_AudioComponentDescription_UInt32_ref_IntPtr(base.Handle, selInitWithComponentDescription_Options_Error_Handle, componentDescription, (uint)options, ref arg), "initWithComponentDescription:options:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_AudioComponentDescription_UInt32_ref_IntPtr(base.SuperHandle, selInitWithComponentDescription_Options_Error_Handle, componentDescription, (uint)options, ref arg), "initWithComponentDescription:options:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithComponentDescription:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AUAudioUnit(AudioComponentDescription componentDescription, out NSError? outError)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_AudioComponentDescription_ref_IntPtr(base.Handle, selInitWithComponentDescription_Error_Handle, componentDescription, ref arg), "initWithComponentDescription:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_AudioComponentDescription_ref_IntPtr(base.SuperHandle, selInitWithComponentDescription_Error_Handle, componentDescription, ref arg), "initWithComponentDescription:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("allocateRenderResourcesAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllocateRenderResources(out NSError? outError)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selAllocateRenderResourcesAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selAllocateRenderResourcesAndReturnError_Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("deallocateRenderResources")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeallocateRenderResources()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeallocateRenderResourcesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeallocateRenderResourcesHandle);
		}
	}

	[Export("deleteUserPreset:error:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DeleteUserPreset(AUAudioUnitPreset userPreset, out NSError? outError)
	{
		if (userPreset == null)
		{
			throw new ArgumentNullException("userPreset");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selDeleteUserPreset_Error_Handle, userPreset.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selDeleteUserPreset_Error_Handle, userPreset.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("disableProfile:cable:onChannel:error:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Disable(MidiCIProfile profile, byte cable, byte channel, out NSError? outError)
	{
		if (profile == null)
		{
			throw new ArgumentNullException("profile");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_byte_byte_ref_IntPtr(base.SuperHandle, selDisableProfile_Cable_OnChannel_Error_Handle, profile.Handle, cable, channel, ref arg) : Messaging.bool_objc_msgSend_IntPtr_byte_byte_ref_IntPtr(base.Handle, selDisableProfile_Cable_OnChannel_Error_Handle, profile.Handle, cable, channel, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("enableProfile:cable:onChannel:error:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enable(MidiCIProfile profile, byte cable, byte channel, out NSError? outError)
	{
		if (profile == null)
		{
			throw new ArgumentNullException("profile");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_byte_byte_ref_IntPtr(base.SuperHandle, selEnableProfile_Cable_OnChannel_Error_Handle, profile.Handle, cable, channel, ref arg) : Messaging.bool_objc_msgSend_IntPtr_byte_byte_ref_IntPtr(base.Handle, selEnableProfile_Cable_OnChannel_Error_Handle, profile.Handle, cable, channel, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("instantiateWithComponentDescription:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void FromComponentDescription(AudioComponentDescription componentDescription, AudioComponentInstantiationOptions options, [BlockProxy(typeof(Trampolines.NIDActionArity2V12))] Action<AUAudioUnit, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V12.Handler, completionHandler);
		Messaging.void_objc_msgSend_AudioComponentDescription_UInt32_IntPtr(class_ptr, selInstantiateWithComponentDescription_Options_CompletionHandler_Handle, componentDescription, (uint)options, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<AUAudioUnit> FromComponentDescriptionAsync(AudioComponentDescription componentDescription, AudioComponentInstantiationOptions options)
	{
		TaskCompletionSource<AUAudioUnit> tcs = new TaskCompletionSource<AUAudioUnit>();
		FromComponentDescription(componentDescription, options, delegate(AUAudioUnit arg1_, NSError arg2_)
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

	[Export("parametersForOverviewWithCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] GetParametersForOverview(nint count)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selParametersForOverviewWithCount_Handle, count));
		}
		return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selParametersForOverviewWithCount_Handle, count));
	}

	[Export("presetStateFor:error:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSObject>? GetPresetState(AUAudioUnitPreset userPreset, out NSError? outError)
	{
		if (userPreset == null)
		{
			throw new ArgumentNullException("userPreset");
		}
		IntPtr arg = IntPtr.Zero;
		NSDictionary<NSString, NSObject> result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selPresetStateFor_Error_Handle, userPreset.Handle, ref arg)) : Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selPresetStateFor_Error_Handle, userPreset.Handle, ref arg)));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("profileStateForCable:channel:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MidiCIProfileState GetProfileState(byte cable, byte channel)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MidiCIProfileState>(Messaging.IntPtr_objc_msgSend_byte_byte(base.Handle, selProfileStateForCable_Channel_Handle, cable, channel));
		}
		return Runtime.GetNSObject<MidiCIProfileState>(Messaging.IntPtr_objc_msgSendSuper_byte_byte(base.SuperHandle, selProfileStateForCable_Channel_Handle, cable, channel));
	}

	[Export("registerSubclass:asComponentDescription:name:version:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegisterSubclass(Class cls, AudioComponentDescription componentDescription, string name, uint version)
	{
		if (cls == null)
		{
			throw new ArgumentNullException("cls");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		Messaging.void_objc_msgSend_IntPtr_AudioComponentDescription_IntPtr_UInt32(class_ptr, selRegisterSubclass_AsComponentDescription_Name_Version_Handle, cls.Handle, componentDescription, arg, version);
		NSString.ReleaseNative(arg);
	}

	[Export("removeRenderObserver:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveRenderObserver(nint token)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveRenderObserver_Handle, token);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveRenderObserver_Handle, token);
		}
	}

	[Export("requestViewControllerWithCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RequestViewController([BlockProxy(typeof(Trampolines.NIDActionArity1V14))] Action<NSViewController> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V14.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRequestViewControllerWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRequestViewControllerWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSViewController> RequestViewControllerAsync()
	{
		TaskCompletionSource<NSViewController> tcs = new TaskCompletionSource<NSViewController>();
		RequestViewController(delegate(NSViewController obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("saveUserPreset:error:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SaveUserPreset(AUAudioUnitPreset userPreset, out NSError? outError)
	{
		if (userPreset == null)
		{
			throw new ArgumentNullException("userPreset");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selSaveUserPreset_Error_Handle, userPreset.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selSaveUserPreset_Error_Handle, userPreset.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setRenderResourcesAllocated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetRenderResourcesAllocated(bool flag)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetRenderResourcesAllocated_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRenderResourcesAllocated_Handle, flag);
		}
	}

	[Export("shouldChangeToFormat:forBus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldChangeToFormat(AVAudioFormat format, AUAudioUnitBus bus)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (bus == null)
		{
			throw new ArgumentNullException("bus");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selShouldChangeToFormat_ForBus_Handle, format.Handle, bus.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selShouldChangeToFormat_ForBus_Handle, format.Handle, bus.Handle);
	}
}
