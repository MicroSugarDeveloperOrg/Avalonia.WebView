using Foundation;
using ObjCRuntime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AVFoundation;

[Register("AVAudioUnitComponent", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioUnitComponent : NSObject
{
    public static class Notifications
    {
        public static NSObject ObserveTagsDidChange(EventHandler<NSNotificationEventArgs> handler)
        {
            EventHandler<NSNotificationEventArgs> handler2 = handler;
            return NSNotificationCenter.DefaultCenter.AddObserver(TagsDidChangeNotification, delegate (NSNotification notification)
            {
                handler2(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveTagsDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
        {
            EventHandler<NSNotificationEventArgs> handler2 = handler;
            return NSNotificationCenter.DefaultCenter.AddObserver(TagsDidChangeNotification, delegate (NSNotification notification)
            {
                handler2(null, new NSNotificationEventArgs(notification));
            }, objectToObserve);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAllTagNames = "allTagNames";

    private static readonly IntPtr selAllTagNamesHandle = Selector.GetHandle("allTagNames");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAudioComponent = "audioComponent";

    private static readonly IntPtr selAudioComponentHandle = Selector.GetHandle("audioComponent");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAudioComponentDescription = "audioComponentDescription";

    private static readonly IntPtr selAudioComponentDescriptionHandle = Selector.GetHandle("audioComponentDescription");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAvailableArchitectures = "availableArchitectures";

    private static readonly IntPtr selAvailableArchitecturesHandle = Selector.GetHandle("availableArchitectures");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selConfigurationDictionary = "configurationDictionary";

    private static readonly IntPtr selConfigurationDictionaryHandle = Selector.GetHandle("configurationDictionary");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selHasCustomView = "hasCustomView";

    private static readonly IntPtr selHasCustomViewHandle = Selector.GetHandle("hasCustomView");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selHasMIDIInput = "hasMIDIInput";

    private static readonly IntPtr selHasMIDIInputHandle = Selector.GetHandle("hasMIDIInput");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selHasMIDIOutput = "hasMIDIOutput";

    private static readonly IntPtr selHasMIDIOutputHandle = Selector.GetHandle("hasMIDIOutput");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIcon = "icon";

    private static readonly IntPtr selIconHandle = Selector.GetHandle("icon");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIconURL = "iconURL";

    private static readonly IntPtr selIconURLHandle = Selector.GetHandle("iconURL");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsSandboxSafe = "isSandboxSafe";

    private static readonly IntPtr selIsSandboxSafeHandle = Selector.GetHandle("isSandboxSafe");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedTypeName = "localizedTypeName";

    private static readonly IntPtr selLocalizedTypeNameHandle = Selector.GetHandle("localizedTypeName");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selManufacturerName = "manufacturerName";

    private static readonly IntPtr selManufacturerNameHandle = Selector.GetHandle("manufacturerName");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selName = "name";

    private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPassesAUVal = "passesAUVal";

    private static readonly IntPtr selPassesAUValHandle = Selector.GetHandle("passesAUVal");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetUserTagNames_ = "setUserTagNames:";

    private static readonly IntPtr selSetUserTagNames_Handle = Selector.GetHandle("setUserTagNames:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSupportsNumberInputChannels_OutputChannels_ = "supportsNumberInputChannels:outputChannels:";

    private static readonly IntPtr selSupportsNumberInputChannels_OutputChannels_Handle = Selector.GetHandle("supportsNumberInputChannels:outputChannels:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTypeName = "typeName";

    private static readonly IntPtr selTypeNameHandle = Selector.GetHandle("typeName");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selUserTagNames = "userTagNames";

    private static readonly IntPtr selUserTagNamesHandle = Selector.GetHandle("userTagNames");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selVersion = "version";

    private static readonly IntPtr selVersionHandle = Selector.GetHandle("version");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selVersionString = "versionString";

    private static readonly IntPtr selVersionStringHandle = Selector.GetHandle("versionString");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioUnitComponent");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _TagsDidChangeNotification;

    public override IntPtr ClassHandle => class_ptr;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string[] AllTagNames
    {
        [Export("allTagNames")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAllTagNamesHandle));
            }
            return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllTagNamesHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual AudioComponent AudioComponent
    {
        [Export("audioComponent")]
        get
        {
            IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioComponentHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selAudioComponentHandle));
            return (intPtr == IntPtr.Zero) ? null : new AudioComponent(intPtr);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual AudioComponentDescription AudioComponentDescription
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
    public virtual NSNumber[] AvailableArchitectures
    {
        [Export("availableArchitectures")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableArchitecturesHandle));
            }
            return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableArchitecturesHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool HasCustomView
    {
        [Export("hasCustomView")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selHasCustomViewHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasCustomViewHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool HasMidiInput
    {
        [Export("hasMIDIInput")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selHasMIDIInputHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasMIDIInputHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool HasMidiOutput
    {
        [Export("hasMIDIOutput")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selHasMIDIOutputHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasMIDIOutputHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    public virtual NSImage? Icon
    {
        [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
        [Export("icon")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selIconHandle));
            }
            return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIconHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSUrl? IconUrl
    {
        [Export("iconURL")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selIconURLHandle));
            }
            return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIconURLHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string LocalizedTypeName
    {
        [Export("localizedTypeName")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedTypeNameHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedTypeNameHandle));
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
    public virtual bool PassesAUVal
    {
        [Export("passesAUVal")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selPassesAUValHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPassesAUValHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool SandboxSafe
    {
        [Export("isSandboxSafe")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selIsSandboxSafeHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSandboxSafeHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string TypeName
    {
        [Export("typeName")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeNameHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeNameHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string[] UserTagNames
    {
        [Export("userTagNames", ArgumentSemantic.Copy)]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserTagNamesHandle));
            }
            return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserTagNamesHandle));
        }
        [Export("setUserTagNames:", ArgumentSemantic.Copy)]
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            NSArray nSArray = NSArray.FromStrings(value);
            if (base.IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserTagNames_Handle, nSArray.Handle);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserTagNames_Handle, nSArray.Handle);
            }
            nSArray.Dispose();
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
    public virtual string VersionString
    {
        [Export("versionString")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVersionStringHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVersionStringHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSDictionary WeakConfigurationDictionary
    {
        [Export("configurationDictionary")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationDictionaryHandle));
            }
            return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationDictionaryHandle));
        }
    }

    [Field("AVAudioUnitComponentTagsDidChangeNotification", "AVFoundation")]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
    [Advice("Use AVAudioUnitComponent.Notifications.ObserveTagsDidChange helper method instead.")]
    public static NSString TagsDidChangeNotification
    {
        [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
        get
        {
            if (_TagsDidChangeNotification == null)
            {
                _TagsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitComponentTagsDidChangeNotification");
            }
            return _TagsDidChangeNotification;
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public AVAudioUnitComponent()
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
    protected AVAudioUnitComponent(NSObjectFlag t)
        : base(t)
    {
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal AVAudioUnitComponent(IntPtr handle)
        : base(handle)
    {
    }

    [Export("supportsNumberInputChannels:outputChannels:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool SupportsNumberInputChannels(nint numInputChannels, nint numOutputChannels)
    {
        if (base.IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_nint_nint(base.Handle, selSupportsNumberInputChannels_OutputChannels_Handle, numInputChannels, numOutputChannels);
        }
        return Messaging.bool_objc_msgSendSuper_nint_nint(base.SuperHandle, selSupportsNumberInputChannels_OutputChannels_Handle, numInputChannels, numOutputChannels);
    }
}