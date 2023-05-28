using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using CoreGraphics;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[StructLayout(LayoutKind.Sequential)]
[Register("NSObject", true)]
public class NSObject : IEquatable<NSObject>, INativeObject, IDisposable, INSObjectProtocol
{
    private struct objc_super
    {
        public IntPtr receiver;
        public IntPtr super;
    }

    private delegate IntPtr RetainTrampolineDelegate(IntPtr @this, IntPtr sel);
    private delegate void ReleaseTrampolineDelegate(IntPtr @this, IntPtr sel);

    [Flags]
	private enum Flags : byte
	{
		Disposed = 1,
		NativeRef = 2,
		IsDirectBinding = 4,
		RegisteredToggleRef = 8,
		InFinalizerQueue = 0x10,
		HasManagedRef = 0x20,
		IsCustomType = 0x80
	}

	[Register("__NSObject_Disposer")]
	[Preserve(AllMembers = true)]
	internal class NSObject_Disposer : NSObject
	{
		private static readonly List<NSObject> drainList1 = new List<NSObject>();

		private static readonly List<NSObject> drainList2 = new List<NSObject>();

		private static List<NSObject> handles = drainList1;

		private new static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("__NSObject_Disposer");

		private static readonly IntPtr drainHandle = Selector.GetHandle("drain:");

		private static readonly object lock_obj = new object();

		private NSObject_Disposer()
		{
		}

		internal static void Add(NSObject handle)
		{
			bool flag;
			lock (lock_obj)
			{
				handles.Add(handle);
				flag = handles.Count == 1;
			}
			if (flag)
			{
				Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(class_ptr, Selector.PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle, drainHandle, IntPtr.Zero, arg3: false);
			}
		}

		[Export("drain:")]
		private static void Drain(NSObject ctx)
		{
			List<NSObject> list;
			lock (lock_obj)
			{
				list = handles;
				if (handles == drainList1)
				{
					handles = drainList2;
				}
				else
				{
					handles = drainList1;
				}
			}
			foreach (NSObject item in list)
			{
                if (_is_autoloaded)
                    item.ReleaseManagedRef();
                else
                    item.ReleaseManagedRefEx();
                //
			}
			list.Clear();
		}
	}

	[Register("__XamarinObjectObserver")]
	private class Observer : NSObject
	{
		private WeakReference obj;

		private Action<NSObservedChange> cback;

		private NSString key;

		public Observer(NSObject obj, NSString key, Action<NSObservedChange> observer)
		{
			if (observer == null)
			{
				throw new ArgumentNullException("observer");
			}
			this.obj = new WeakReference(obj);
			this.key = key;
			cback = observer;
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		public override void ObserveValue(NSString keyPath, NSObject ofObject, NSDictionary change, IntPtr context)
		{
			if (keyPath == key && context == base.Handle)
			{
				cback(new NSObservedChange(change));
			}
			else
			{
				base.ObserveValue(keyPath, ofObject, change, context);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (obj != null)
				{
					((NSObject)obj.Target)?.RemoveObserver(this, key, base.Handle);
				}
				obj = null;
				cback = null;
			}
			else
			{
				Console.Error.WriteLine("Warning: observer object was not disposed manually with Dispose()");
			}
			base.Dispose(disposing);
		}
	}

	private const string selConformsToProtocol = "conformsToProtocol:";

	private const string selEncodeWithCoder = "encodeWithCoder:";

	private static IntPtr selConformsToProtocolHandle = Selector.GetHandle("conformsToProtocol:");

	private static IntPtr selEncodeWithCoderHandle = Selector.GetHandle("encodeWithCoder:");

	public static readonly Assembly PlatformAssembly = typeof(NSObject).Assembly;

    private static IntPtr RetainTrampolineFunctionPointer;
    private static IntPtr ReleaseTrampolineFunctionPointer;

    private static RetainTrampolineDelegate retainTrampoline;
    private static ReleaseTrampolineDelegate releaseTrampoline;

    private static object lock_obj = new object();

    private static bool _is_autoloaded = true;

    #region
    //private IntPtr super;
    //private IntPtr gchandle;
    //private bool has_managed_ref;
    #endregion

    private IntPtr handle;

	private IntPtr class_handle;

	private Flags flags;

	private static IntPtr fl = Dlfcn.dlopen("/System/Library/Frameworks/Foundation.framework/Foundation", 1);

	private static IntPtr al = Dlfcn.dlopen("/System/Library/Frameworks/AppKit.framework/AppKit", 1);

	private static IntPtr ab = Dlfcn.dlopen("/System/Library/Frameworks/AddressBook.framework/AddressBook", 1);

	private static IntPtr ct = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 1);

	private static IntPtr wl = Dlfcn.dlopen("/System/Library/Frameworks/WebKit.framework/WebKit", 1);

	private static IntPtr zl = Dlfcn.dlopen("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", 1);

	private static IntPtr ql = Dlfcn.dlopen("/System/Library/Frameworks/QTKit.framework/QTKit", 1);

	private static IntPtr cl = Dlfcn.dlopen("/System/Library/Frameworks/CoreLocation.framework/CoreLocation", 1);

	private static IntPtr ll = Dlfcn.dlopen("/System/Library/Frameworks/Security.framework/Security", 1);

	private static IntPtr zc = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/QuartzComposer.framework/QuartzComposer", 1);

	private static IntPtr cw = Dlfcn.dlopen("/System/Library/Frameworks/CoreWLAN.framework/CoreWLAN", 1);

	private static IntPtr pk = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/PDFKit.framework/PDFKit", 1);

	private static IntPtr ik = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/ImageKit.framework/ImageKit", 1);

	private static IntPtr sb = Dlfcn.dlopen("/System/Library/Frameworks/ScriptingBridge.framework/ScriptingBridge", 1);

	private static IntPtr av = Dlfcn.dlopen("/System/Library/Frameworks/AVFoundation.framework/AVFoundation", 1);

	private static IntPtr js = Dlfcn.dlopen("/System/Library/Frameworks/JavaScriptCore.framework/JavaScriptCore", 1);

	private static IntPtr sk = Dlfcn.dlopen("/System/Library/Frameworks/SceneKit.framework/SceneKit", 1);

	private static IntPtr bl = Dlfcn.dlopen("/System/Library/Frameworks/IOBluetooth.framework/Versions/A/Frameworks/CoreBluetooth.framework/CoreBluetooth", 1);

	private static IntPtr st = Dlfcn.dlopen("/System/Library/Frameworks/StoreKit.framework/StoreKit", 1);

	private static IntPtr gk = Dlfcn.dlopen("/System/Library/Frameworks/GameKit.framework/GameKit", 1);

	private static IntPtr ib = Dlfcn.dlopen("/System/Library/Frameworks/IOBluetooth.framework/IOBluetooth", 1);

	private static IntPtr bu = Dlfcn.dlopen("/System/Library/Frameworks/IOBluetoothUI.framework/IOBluetoothUI", 1);

	private static IntPtr ca = Dlfcn.dlopen("/System/Library/Frameworks/CoreAudioKit.framework/CoreAudioKit", 1);

	private static IntPtr im = Dlfcn.dlopen("/System/Library/Frameworks/InputMethodKit.framework/InputMethodKit", 1);

	private static IntPtr ol = Dlfcn.dlopen("/System/Library/Frameworks/OpenAL.framework/OpenAL", 1);

	private static IntPtr ma = Dlfcn.dlopen("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility", 1);

	private static IntPtr mi = Dlfcn.dlopen("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI", 1);

	private static IntPtr ic = Dlfcn.dlopen("/System/Library/Frameworks/ImageCaptureCore.framework/ImageCaptureCore", 1);

	private static IntPtr it = Dlfcn.dlopen("/System/Library/Frameworks/Intents.framework/Intents", 1);

	private static IntPtr me = Dlfcn.dlopen("/System/Library/Frameworks/MediaLibrary.framework/MediaLibrary", 1);

	private static IntPtr gl = Dlfcn.dlopen("/System/Library/Frameworks/GLKit.framework/GLKit", 1);

	private static IntPtr sp = Dlfcn.dlopen("/System/Library/Frameworks/SpriteKit.framework/SpriteKit", 1);

	private static IntPtr ck = Dlfcn.dlopen("/System/Library/Frameworks/CloudKit.framework/CloudKit", 1);

	private static IntPtr la = Dlfcn.dlopen("/System/Library/Frameworks/LocalAuthentication.framework/LocalAuthentication", 1);

	private static IntPtr ac = Dlfcn.dlopen("/System/Library/Frameworks/Accounts.framework/Accounts", 1);

	private static IntPtr cn = Dlfcn.dlopen("/System/Library/Frameworks/Contacts.framework/Contacts", 1);

	private static IntPtr cu = Dlfcn.dlopen("/System/Library/Frameworks/ContactsUI.framework/ContactsUI", 1);

	private static IntPtr mk = Dlfcn.dlopen("/System/Library/Frameworks/MapKit.framework/MapKit", 1);

	private static IntPtr ek = Dlfcn.dlopen("/System/Library/Frameworks/EventKit.framework/EventKit", 1);

	private static IntPtr so = Dlfcn.dlopen("/System/Library/Frameworks/Social.framework/Social", 1);

	private static IntPtr gc = Dlfcn.dlopen("/System/Library/Frameworks/GameController.framework/GameController", 1);

	private static IntPtr ak = Dlfcn.dlopen("/System/Library/Frameworks/AVKit.framework/AVKit", 1);

	private static IntPtr vt = Dlfcn.dlopen("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox", 1);

	private static IntPtr gp = Dlfcn.dlopen("/System/Library/Frameworks/GameplayKit.framework/GameplayKit", 1);

	private static IntPtr ne = Dlfcn.dlopen("/System/Library/Frameworks/NetworkExtension.framework/NetworkExtension", 1);

	private static IntPtr mc = Dlfcn.dlopen("/System/Library/Frameworks/MultipeerConnectivity.framework/MultipeerConnectivity", 1);

	private static IntPtr fs = Dlfcn.dlopen("/System/Library/Frameworks/FinderSync.framework/FinderSync", 1);

	private static IntPtr ml = Dlfcn.dlopen("/System/Library/Frameworks/MetalKit.framework/MetalKit", 1);

	private static IntPtr io = Dlfcn.dlopen("/System/Library/Frameworks/ModelIO.framework/ModelIO", 1);

	private static IntPtr nc = Dlfcn.dlopen("/System/Library/Frameworks/NotificationCenter.framework/NotificationCenter", 1);

	private static IntPtr pl = Dlfcn.dlopen("/System/Library/Frameworks/Photos.framework/Photos", 1);

	private static IntPtr pu = Dlfcn.dlopen("/System/Library/Frameworks/PhotosUI.framework/PhotosUI", 1);

	private static IntPtr mp = Dlfcn.dlopen("/System/Library/Frameworks/MediaPlayer.framework/MediaPlayer", 1);

	private static IntPtr pc = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore", 1);

	private static IntPtr cml = Dlfcn.dlopen("/System/Library/Frameworks/CoreML.framework/CoreML", 1);

	private static IntPtr vn = Dlfcn.dlopen("/System/Library/Frameworks/Vision.framework/Vision", 1);

	private static IntPtr ios = Dlfcn.dlopen("/System/Library/Frameworks/IOSurface.framework/IOSurface", 1);

	private static IntPtr ex = Dlfcn.dlopen("/System/Library/Frameworks/ExternalAccessory.framework/ExternalAccessory", 1);

	private static IntPtr ms = Dlfcn.dlopen("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders", 1);

	private static IntPtr bc = Dlfcn.dlopen("/System/Library/Frameworks/BusinessChat.framework/BusinessChat", 1);

	private static IntPtr ad = Dlfcn.dlopen("/System/Library/Frameworks/AdSupport.framework/AdSupport", 1);

	private static IntPtr nl = Dlfcn.dlopen("/System/Library/Frameworks/NaturalLanguage.framework/NaturalLanguage", 1);

	private static IntPtr vs = Dlfcn.dlopen("/System/Library/Frameworks/VideoSubscriberAccount.framework/VideoSubscriberAccount", 1);

	private static IntPtr un = Dlfcn.dlopen("/System/Library/Frameworks/UserNotifications.framework/UserNotifications", 1);

	private static IntPtr il = Dlfcn.dlopen("/System/Library/Frameworks/iTunesLibrary.framework/iTunesLibrary", 1);

    internal static bool Initialize(bool is_autoloaded)
    {
        _is_autoloaded = is_autoloaded;
        return true;
    }

	//[Obsolete("Use PlatformAssembly for easier code sharing across platforms.")]
	public static readonly Assembly MonoMacAssembly = typeof(NSObject).Assembly;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObserver_ForKeyPath_Options_Context_ = "addObserver:forKeyPath:options:context:";

	private static readonly IntPtr selAddObserver_ForKeyPath_Options_Context_Handle = Selector.GetHandle("addObserver:forKeyPath:options:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticallyNotifiesObserversForKey_ = "automaticallyNotifiesObserversForKey:";

	private static readonly IntPtr selAutomaticallyNotifiesObserversForKey_Handle = Selector.GetHandle("automaticallyNotifiesObserversForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutorelease = "autorelease";

	private static readonly IntPtr selAutoreleaseHandle = Selector.GetHandle("autorelease");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAwakeFromNib = "awakeFromNib";

	private static readonly IntPtr selAwakeFromNibHandle = Selector.GetHandle("awakeFromNib");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBind_ToObject_WithKeyPath_Options_ = "bind:toObject:withKeyPath:options:";

	private static readonly IntPtr selBind_ToObject_WithKeyPath_Options_Handle = Selector.GetHandle("bind:toObject:withKeyPath:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelPreviousPerformRequestsWithTarget_ = "cancelPreviousPerformRequestsWithTarget:";

	private static readonly IntPtr selCancelPreviousPerformRequestsWithTarget_Handle = Selector.GetHandle("cancelPreviousPerformRequestsWithTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelPreviousPerformRequestsWithTarget_Selector_Object_ = "cancelPreviousPerformRequestsWithTarget:selector:object:";

	private static readonly IntPtr selCancelPreviousPerformRequestsWithTarget_Selector_Object_Handle = Selector.GetHandle("cancelPreviousPerformRequestsWithTarget:selector:object:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClass = "class";

	private static readonly IntPtr selClassHandle = Selector.GetHandle("class");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitEditing = "commitEditing";

	private static readonly IntPtr selCommitEditingHandle = Selector.GetHandle("commitEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_ = "commitEditingWithDelegate:didCommitSelector:contextInfo:";

	private static readonly IntPtr selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle = Selector.GetHandle("commitEditingWithDelegate:didCommitSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConformsToProtocol_ = "conformsToProtocol:";

	private static readonly IntPtr selConformsToProtocol_Handle = Selector.GetHandle("conformsToProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopy = "copy";

	private static readonly IntPtr selCopyHandle = Selector.GetHandle("copy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDebugDescription = "debugDescription";

	private static readonly IntPtr selDebugDescriptionHandle = Selector.GetHandle("debugDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultPlaceholderForMarker_WithBinding_ = "defaultPlaceholderForMarker:withBinding:";

	private static readonly IntPtr selDefaultPlaceholderForMarker_WithBinding_Handle = Selector.GetHandle("defaultPlaceholderForMarker:withBinding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescription = "description";

	private static readonly IntPtr selDescriptionHandle = Selector.GetHandle("description");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionaryWithValuesForKeys_ = "dictionaryWithValuesForKeys:";

	private static readonly IntPtr selDictionaryWithValuesForKeys_Handle = Selector.GetHandle("dictionaryWithValuesForKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidChange_ValuesAtIndexes_ForKey_ = "didChange:valuesAtIndexes:forKey:";

	private static readonly IntPtr selDidChange_ValuesAtIndexes_ForKey_Handle = Selector.GetHandle("didChange:valuesAtIndexes:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidChangeValueForKey_ = "didChangeValueForKey:";

	private static readonly IntPtr selDidChangeValueForKey_Handle = Selector.GetHandle("didChangeValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidChangeValueForKey_WithSetMutation_UsingObjects_ = "didChangeValueForKey:withSetMutation:usingObjects:";

	private static readonly IntPtr selDidChangeValueForKey_WithSetMutation_UsingObjects_Handle = Selector.GetHandle("didChangeValueForKey:withSetMutation:usingObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoesNotRecognizeSelector_ = "doesNotRecognizeSelector:";

	private static readonly IntPtr selDoesNotRecognizeSelector_Handle = Selector.GetHandle("doesNotRecognizeSelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExposedBindings = "exposedBindings";

	private static readonly IntPtr selExposedBindingsHandle = Selector.GetHandle("exposedBindings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHash = "hash";

	private static readonly IntPtr selHashHandle = Selector.GetHandle("hash");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInfoForBinding_ = "infoForBinding:";

	private static readonly IntPtr selInfoForBinding_Handle = Selector.GetHandle("infoForBinding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqual_ = "isEqual:";

	private static readonly IntPtr selIsEqual_Handle = Selector.GetHandle("isEqual:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsKindOfClass_ = "isKindOfClass:";

	private static readonly IntPtr selIsKindOfClass_Handle = Selector.GetHandle("isKindOfClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMemberOfClass_ = "isMemberOfClass:";

	private static readonly IntPtr selIsMemberOfClass_Handle = Selector.GetHandle("isMemberOfClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsProxy = "isProxy";

	private static readonly IntPtr selIsProxyHandle = Selector.GetHandle("isProxy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyPathsForValuesAffectingValueForKey_ = "keyPathsForValuesAffectingValueForKey:";

	private static readonly IntPtr selKeyPathsForValuesAffectingValueForKey_Handle = Selector.GetHandle("keyPathsForValuesAffectingValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMethodForSelector_ = "methodForSelector:";

	private static readonly IntPtr selMethodForSelector_Handle = Selector.GetHandle("methodForSelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopy = "mutableCopy";

	private static readonly IntPtr selMutableCopyHandle = Selector.GetHandle("mutableCopy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectDidEndEditing_ = "objectDidEndEditing:";

	private static readonly IntPtr selObjectDidEndEditing_Handle = Selector.GetHandle("objectDidEndEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObserveValueForKeyPath_OfObject_Change_Context_ = "observeValueForKeyPath:ofObject:change:context:";

	private static readonly IntPtr selObserveValueForKeyPath_OfObject_Change_Context_Handle = Selector.GetHandle("observeValueForKeyPath:ofObject:change:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptionDescriptionsForBinding_ = "optionDescriptionsForBinding:";

	private static readonly IntPtr selOptionDescriptionsForBinding_Handle = Selector.GetHandle("optionDescriptionsForBinding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSelector_ = "performSelector:";

	private static readonly IntPtr selPerformSelector_Handle = Selector.GetHandle("performSelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSelector_OnThread_WithObject_WaitUntilDone_ = "performSelector:onThread:withObject:waitUntilDone:";

	private static readonly IntPtr selPerformSelector_OnThread_WithObject_WaitUntilDone_Handle = Selector.GetHandle("performSelector:onThread:withObject:waitUntilDone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSelector_OnThread_WithObject_WaitUntilDone_Modes_ = "performSelector:onThread:withObject:waitUntilDone:modes:";

	private static readonly IntPtr selPerformSelector_OnThread_WithObject_WaitUntilDone_Modes_Handle = Selector.GetHandle("performSelector:onThread:withObject:waitUntilDone:modes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSelector_WithObject_ = "performSelector:withObject:";

	private static readonly IntPtr selPerformSelector_WithObject_Handle = Selector.GetHandle("performSelector:withObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSelector_WithObject_AfterDelay_ = "performSelector:withObject:afterDelay:";

	private static readonly IntPtr selPerformSelector_WithObject_AfterDelay_Handle = Selector.GetHandle("performSelector:withObject:afterDelay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSelector_WithObject_AfterDelay_InModes_ = "performSelector:withObject:afterDelay:inModes:";

	private static readonly IntPtr selPerformSelector_WithObject_AfterDelay_InModes_Handle = Selector.GetHandle("performSelector:withObject:afterDelay:inModes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSelector_WithObject_WithObject_ = "performSelector:withObject:withObject:";

	private static readonly IntPtr selPerformSelector_WithObject_WithObject_Handle = Selector.GetHandle("performSelector:withObject:withObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForInterfaceBuilder = "prepareForInterfaceBuilder";

	private static readonly IntPtr selPrepareForInterfaceBuilderHandle = Selector.GetHandle("prepareForInterfaceBuilder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelease = "release";

	private static readonly IntPtr selReleaseHandle = Selector.GetHandle("release");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObserver_ForKeyPath_ = "removeObserver:forKeyPath:";

	private static readonly IntPtr selRemoveObserver_ForKeyPath_Handle = Selector.GetHandle("removeObserver:forKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObserver_ForKeyPath_Context_ = "removeObserver:forKeyPath:context:";

	private static readonly IntPtr selRemoveObserver_ForKeyPath_Context_Handle = Selector.GetHandle("removeObserver:forKeyPath:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRespondsToSelector_ = "respondsToSelector:";

	private static readonly IntPtr selRespondsToSelector_Handle = Selector.GetHandle("respondsToSelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRetain = "retain";

	private static readonly IntPtr selRetainHandle = Selector.GetHandle("retain");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRetainCount = "retainCount";

	private static readonly IntPtr selRetainCountHandle = Selector.GetHandle("retainCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelf = "self";

	private static readonly IntPtr selSelfHandle = Selector.GetHandle("self");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultPlaceholder_ForMarker_WithBinding_ = "setDefaultPlaceholder:forMarker:withBinding:";

	private static readonly IntPtr selSetDefaultPlaceholder_ForMarker_WithBinding_Handle = Selector.GetHandle("setDefaultPlaceholder:forMarker:withBinding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNilValueForKey_ = "setNilValueForKey:";

	private static readonly IntPtr selSetNilValueForKey_Handle = Selector.GetHandle("setNilValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForKey_ = "setValue:forKey:";

	private static readonly IntPtr selSetValue_ForKey_Handle = Selector.GetHandle("setValue:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForKeyPath_ = "setValue:forKeyPath:";

	private static readonly IntPtr selSetValue_ForKeyPath_Handle = Selector.GetHandle("setValue:forKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForUndefinedKey_ = "setValue:forUndefinedKey:";

	private static readonly IntPtr selSetValue_ForUndefinedKey_Handle = Selector.GetHandle("setValue:forUndefinedKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValuesForKeysWithDictionary_ = "setValuesForKeysWithDictionary:";

	private static readonly IntPtr selSetValuesForKeysWithDictionary_Handle = Selector.GetHandle("setValuesForKeysWithDictionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuperclass = "superclass";

	private static readonly IntPtr selSuperclassHandle = Selector.GetHandle("superclass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnbind_ = "unbind:";

	private static readonly IntPtr selUnbind_Handle = Selector.GetHandle("unbind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueClassForBinding_ = "valueClassForBinding:";

	private static readonly IntPtr selValueClassForBinding_Handle = Selector.GetHandle("valueClassForBinding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForKey_ = "valueForKey:";

	private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForKeyPath_ = "valueForKeyPath:";

	private static readonly IntPtr selValueForKeyPath_Handle = Selector.GetHandle("valueForKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForUndefinedKey_ = "valueForUndefinedKey:";

	private static readonly IntPtr selValueForUndefinedKey_Handle = Selector.GetHandle("valueForUndefinedKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillChange_ValuesAtIndexes_ForKey_ = "willChange:valuesAtIndexes:forKey:";

	private static readonly IntPtr selWillChange_ValuesAtIndexes_ForKey_Handle = Selector.GetHandle("willChange:valuesAtIndexes:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillChangeValueForKey_ = "willChangeValueForKey:";

	private static readonly IntPtr selWillChangeValueForKey_Handle = Selector.GetHandle("willChangeValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillChangeValueForKey_WithSetMutation_UsingObjects_ = "willChangeValueForKey:withSetMutation:usingObjects:";

	private static readonly IntPtr selWillChangeValueForKey_WithSetMutation_UsingObjects_Handle = Selector.GetHandle("willChangeValueForKey:withSetMutation:usingObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZone = "zone";

	private static readonly IntPtr selZoneHandle = Selector.GetHandle("zone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangeIndexesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangeKindKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangeNewKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangeNotificationIsPriorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangeOldKey;

	private bool disposed
	{
		get
		{
			return (flags & Flags.Disposed) == Flags.Disposed;
		}
		set
		{
			flags = (value ? (flags | Flags.Disposed) : (flags & ~Flags.Disposed));
		}
	}

	internal bool IsRegisteredToggleRef
	{
		get
		{
			return (flags & Flags.RegisteredToggleRef) == Flags.RegisteredToggleRef;
		}
		set
		{
			flags = (value ? (flags | Flags.RegisteredToggleRef) : (flags & ~Flags.RegisteredToggleRef));
		}
	}

	protected internal bool IsDirectBinding
	{
		get
		{
			return (flags & Flags.IsDirectBinding) == Flags.IsDirectBinding;
		}
		set
		{
			flags = (value ? (flags | Flags.IsDirectBinding) : (flags & ~Flags.IsDirectBinding));
		}
	}

	internal bool InFinalizerQueue => (flags & Flags.InFinalizerQueue) == Flags.InFinalizerQueue;

	private bool IsCustomType
	{
		get
		{
			bool flag = (flags & Flags.IsCustomType) == Flags.IsCustomType;
			if (!flag)
			{
				flag = ObjCRuntime.Class.IsCustomType(GetType());
				if (flag)
				{
					flags |= Flags.IsCustomType;
				}
			}
			return flag;
		}
	}

	public unsafe IntPtr SuperHandle
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException(GetType().Name);
			}
			if (class_handle == IntPtr.Zero)
			{
				class_handle = ClassHandle;
			}
			fixed (IntPtr* ptr = &handle)
			{
				return (IntPtr)ptr;
			}
		}
	}

	public IntPtr Handle
	{
		get
		{
			return handle;
		}
		set
		{
			if (!(handle == value))
			{
				if (handle != IntPtr.Zero)
				{
					Runtime.UnregisterNSObject(handle);
				}
				handle = value;
				if (handle != IntPtr.Zero)
				{
					Runtime.RegisterNSObject(this, handle);
				}
			}
		}
	}

	public virtual IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class Class
	{
		[Export("class")]
		get
		{
			IntPtr intPtr = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selClassHandle) : Messaging.IntPtr_objc_msgSend(Handle, selClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DebugDescription
	{
		[Export("debugDescription")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selDebugDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selDebugDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Description
	{
		[Export("description")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsProxy
	{
		[Export("isProxy")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(Handle, selIsProxyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(SuperHandle, selIsProxyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint RetainCount
	{
		[Export("retainCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(Handle, selRetainCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(SuperHandle, selRetainCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Self
	{
		[Export("self")]
		get
		{
			if (IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selSelfHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selSelfHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class Superclass
	{
		[Export("superclass")]
		get
		{
			IntPtr intPtr = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selSuperclassHandle) : Messaging.IntPtr_objc_msgSend(Handle, selSuperclassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSZone Zone
	{
		[Export("zone")]
		get
		{
			IntPtr intPtr = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selZoneHandle) : Messaging.IntPtr_objc_msgSend(Handle, selZoneHandle));
			return (intPtr == IntPtr.Zero) ? null : new NSZone(intPtr);
		}
	}

	[Field("NSKeyValueChangeIndexesKey", "Foundation")]
	public static NSString ChangeIndexesKey
	{
		get
		{
			if (_ChangeIndexesKey == null)
			{
				_ChangeIndexesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyValueChangeIndexesKey");
			}
			return _ChangeIndexesKey;
		}
	}

	[Field("NSKeyValueChangeKindKey", "Foundation")]
	public static NSString ChangeKindKey
	{
		get
		{
			if (_ChangeKindKey == null)
			{
				_ChangeKindKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyValueChangeKindKey");
			}
			return _ChangeKindKey;
		}
	}

	[Field("NSKeyValueChangeNewKey", "Foundation")]
	public static NSString ChangeNewKey
	{
		get
		{
			if (_ChangeNewKey == null)
			{
				_ChangeNewKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyValueChangeNewKey");
			}
			return _ChangeNewKey;
		}
	}

	[Field("NSKeyValueChangeNotificationIsPriorKey", "Foundation")]
	public static NSString ChangeNotificationIsPriorKey
	{
		get
		{
			if (_ChangeNotificationIsPriorKey == null)
			{
				_ChangeNotificationIsPriorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyValueChangeNotificationIsPriorKey");
			}
			return _ChangeNotificationIsPriorKey;
		}
	}

	[Field("NSKeyValueChangeOldKey", "Foundation")]
	public static NSString ChangeOldKey
	{
		get
		{
			if (_ChangeOldKey == null)
			{
				_ChangeOldKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyValueChangeOldKey");
			}
			return _ChangeOldKey;
		}
	}

	[Export("init")]
	public NSObject()
	{
		bool alloced = AllocIfNeeded();
		InitializeObject(alloced);
	}

	public NSObject(NSObjectFlag x)
	{
		bool alloced = AllocIfNeeded();
		InitializeObject(alloced);
	}

	public NSObject(IntPtr handle)
		: this(handle, alloced: false)
	{
	}

	public NSObject(IntPtr handle, bool alloced)
	{
		this.handle = handle;
		InitializeObject(alloced);
	}

	~NSObject()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	internal static IntPtr Initialize()
	{
		return class_ptr;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern void RegisterToggleRef(NSObject obj, IntPtr handle, bool isCustomType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern void xamarin_release_managed_ref(IntPtr handle, NSObject managed_obj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern void xamarin_create_managed_ref(IntPtr handle, NSObject obj, bool retain);

	public static bool IsNewRefcountEnabled()
	{
		return true;
	}

	protected void MarkDirty()
	{
		MarkDirty(allowCustomTypes: false);
	}

	internal void MarkDirty(bool allowCustomTypes)
	{
		if (!IsRegisteredToggleRef && (allowCustomTypes || !IsCustomType))
		{
			IsRegisteredToggleRef = true;
			RegisterToggleRef(this, Handle, allowCustomTypes);
		}
	}

	private void InitializeObject(bool alloced)
	{
		if (alloced && handle == IntPtr.Zero && ObjCRuntime.Class.ThrowOnInitFailure)
		{
			if (ClassHandle == IntPtr.Zero)
			{
				throw new Exception($"Could not create an native instance of the type '{GetType().FullName}': the native class hasn't been loaded.\nIt is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.");
			}
			throw new Exception($"Failed to create a instance of the native type '{new Class(ClassHandle).Name}'.\nIt is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.");
		}
		IsDirectBinding = GetType().Assembly == PlatformAssembly;
		Runtime.RegisterNSObject(this, handle);
		if ((flags & Flags.NativeRef) != Flags.NativeRef)
		{
            if (_is_autoloaded)
                CreateManagedRef(!alloced);
            else
                CreateManagedRefEx(!alloced);

        }
	}

	private void CreateManagedRef(bool retain)
	{
		xamarin_create_managed_ref(handle, this, retain);
	}

	private void ReleaseManagedRef()
	{
		xamarin_release_managed_ref(handle, this);
	}

	private static bool IsProtocol(Type type, IntPtr protocol)
	{
		while (type != typeof(NSObject) && type != null)
		{
			object[] customAttributes = type.GetCustomAttributes(typeof(ProtocolAttribute), inherit: false);
			ProtocolAttribute protocolAttribute = (ProtocolAttribute)((customAttributes.Length != 0) ? customAttributes[0] : null);
			if (protocolAttribute != null && !protocolAttribute.IsInformal)
			{
				string protocol2;
				if (!string.IsNullOrEmpty(protocolAttribute.Name))
				{
					protocol2 = protocolAttribute.Name;
				}
				else
				{
					customAttributes = type.GetCustomAttributes(typeof(RegisterAttribute), inherit: false);
					RegisterAttribute registerAttribute = (RegisterAttribute)((customAttributes.Length != 0) ? customAttributes[0] : null);
					protocol2 = ((registerAttribute == null || string.IsNullOrEmpty(registerAttribute.Name)) ? type.Name : registerAttribute.Name);
				}
				IntPtr protocol3 = Runtime.GetProtocol(protocol2);
				if (protocol3 != IntPtr.Zero && protocol3 == protocol)
				{
					return true;
				}
			}
			type = type.BaseType;
		}
		return false;
	}

	[Preserve]
	private bool InvokeConformsToProtocol(IntPtr protocol)
	{
		return ConformsToProtocol(protocol);
	}

	[Export("conformsToProtocol:")]
	[Preserve]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public virtual bool ConformsToProtocol(IntPtr protocol)
	{
		bool flag = IsDirectBinding;
		if (flag && GetType().Assembly != PlatformAssembly)
		{
			object[] customAttributes = GetType().GetCustomAttributes(typeof(RegisterAttribute), inherit: false);
			if (customAttributes != null && customAttributes.Length == 1)
			{
				flag = ((RegisterAttribute)customAttributes[0]).IsWrapper;
			}
		}
		if ((!flag) ? Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selConformsToProtocolHandle, protocol) : Messaging.bool_objc_msgSend_IntPtr(Handle, selConformsToProtocolHandle, protocol))
		{
			return true;
		}
		if (!Runtime.DynamicRegistrationSupported)
		{
			return false;
		}
		object[] customAttributes2 = GetType().GetCustomAttributes(typeof(AdoptsAttribute), inherit: true);
		object[] array = customAttributes2;
		for (int i = 0; i < array.Length; i++)
		{
			AdoptsAttribute adoptsAttribute = (AdoptsAttribute)array[i];
			if (adoptsAttribute.ProtocolHandle == protocol)
			{
				return true;
			}
		}
		if (IsProtocol(GetType(), protocol))
		{
			return true;
		}
		Type[] interfaces = GetType().GetInterfaces();
		Type[] array2 = interfaces;
		foreach (Type type in array2)
		{
			if (IsProtocol(type, protocol))
			{
				return true;
			}
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void DangerousRelease()
	{
		DangerousRelease(handle);
	}

	internal static void DangerousRelease(IntPtr handle)
	{
		if (!(handle == IntPtr.Zero))
		{
			Messaging.void_objc_msgSend(handle, Selector.ReleaseHandle);
		}
	}

	internal static void DangerousRetain(IntPtr handle)
	{
		if (!(handle == IntPtr.Zero))
		{
			Messaging.void_objc_msgSend(handle, Selector.RetainHandle);
		}
	}

	internal static void DangerousAutorelease(IntPtr handle)
	{
		Messaging.void_objc_msgSend(handle, Selector.AutoreleaseHandle);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSObject DangerousRetain()
	{
		Messaging.void_objc_msgSend(handle, Selector.RetainHandle);
		return this;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSObject DangerousAutorelease()
	{
		Messaging.void_objc_msgSend(handle, Selector.AutoreleaseHandle);
		return this;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected void InitializeHandle(IntPtr handle)
	{
		InitializeHandle(handle, "init*");
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected void InitializeHandle(IntPtr handle, string initSelector)
	{
		if (this.handle == IntPtr.Zero && ObjCRuntime.Class.ThrowOnInitFailure)
		{
			if (ClassHandle == IntPtr.Zero)
			{
				throw new Exception($"Could not create an native instance of the type '{GetType().FullName}': the native class hasn't been loaded.\nIt is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.");
			}
			throw new Exception($"Failed to create a instance of the native type '{new Class(ClassHandle).Name}'.\nIt is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.");
		}
		if (handle == IntPtr.Zero && ObjCRuntime.Class.ThrowOnInitFailure)
		{
			Handle = IntPtr.Zero;
			throw new Exception($"Could not initialize an instance of the type '{GetType().FullName}': the native '{initSelector}' method returned nil.\nIt is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.");
		}
		Handle = handle;
	}

	private bool AllocIfNeeded()
	{
		if (handle == IntPtr.Zero)
		{
			handle = Messaging.IntPtr_objc_msgSend(ObjCRuntime.Class.GetHandle(GetType()), Selector.AllocHandle);
			return true;
		}
		return false;
	}

	private IntPtr GetObjCIvar(string name)
	{
		object_getInstanceVariable(handle, name, out var val);
		return val;
	}

	[Obsolete("Do not use; this API does not properly retain/release existing/new values, so leaks and/or crashes may occur.")]
	public NSObject GetNativeField(string name)
	{
		IntPtr objCIvar = GetObjCIvar(name);
		if (objCIvar == IntPtr.Zero)
		{
			return null;
		}
		return Runtime.GetNSObject(objCIvar);
	}

	private void SetObjCIvar(string name, IntPtr value)
	{
		object_setInstanceVariable(handle, name, value);
	}

	[Obsolete("Do not use; this API does not properly retain/release existing/new values, so leaks and/or crashes may occur.")]
	public void SetNativeField(string name, NSObject value)
	{
		if (value == null)
		{
			SetObjCIvar(name, IntPtr.Zero);
		}
		else
		{
			SetObjCIvar(name, value.Handle);
		}
	}

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern void object_getInstanceVariable(IntPtr obj, string name, out IntPtr val);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern void object_setInstanceVariable(IntPtr obj, string name, IntPtr val);

	private void InvokeOnMainThread(Selector sel, NSObject obj, bool wait)
	{
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(Handle, Selector.PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle, sel.Handle, obj?.Handle ?? IntPtr.Zero, wait);
	}

	public void BeginInvokeOnMainThread(Selector sel, NSObject obj)
	{
		InvokeOnMainThread(sel, obj, wait: false);
	}

	public void InvokeOnMainThread(Selector sel, NSObject obj)
	{
		InvokeOnMainThread(sel, obj, wait: true);
	}

	public void BeginInvokeOnMainThread(Action action)
	{
		NSAsyncActionDispatcher nSAsyncActionDispatcher = new NSAsyncActionDispatcher(action);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(nSAsyncActionDispatcher.Handle, Selector.PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle, NSDispatcher.Selector.Handle, nSAsyncActionDispatcher.Handle, arg3: false);
	}

	internal void BeginInvokeOnMainThread(SendOrPostCallback cb, object state)
	{
		NSAsyncSynchronizationContextDispatcher nSAsyncSynchronizationContextDispatcher = new NSAsyncSynchronizationContextDispatcher(cb, state);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(nSAsyncSynchronizationContextDispatcher.Handle, Selector.PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle, NSDispatcher.Selector.Handle, nSAsyncSynchronizationContextDispatcher.Handle, arg3: false);
	}

	public void InvokeOnMainThread(Action action)
	{
		using NSActionDispatcher nSActionDispatcher = new NSActionDispatcher(action);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(nSActionDispatcher.Handle, Selector.PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle, NSDispatcher.Selector.Handle, nSActionDispatcher.Handle, arg3: true);
	}

	internal void InvokeOnMainThread(SendOrPostCallback cb, object state)
	{
		using NSSynchronizationContextDispatcher nSSynchronizationContextDispatcher = new NSSynchronizationContextDispatcher(cb, state);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(nSSynchronizationContextDispatcher.Handle, Selector.PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle, NSDispatcher.Selector.Handle, nSSynchronizationContextDispatcher.Handle, arg3: true);
	}

	public static NSObject FromObject(object obj)
	{
		if (obj == null)
		{
			return NSNull.Null;
		}
		Type type = obj.GetType();
		if (type == typeof(NSObject) || type.IsSubclassOf(typeof(NSObject)))
		{
			return (NSObject)obj;
		}
		switch (Type.GetTypeCode(type))
		{
		case TypeCode.Boolean:
			return new NSNumber((bool)obj);
		case TypeCode.Char:
			return new NSNumber((char)obj);
		case TypeCode.SByte:
			return new NSNumber((sbyte)obj);
		case TypeCode.Byte:
			return new NSNumber((byte)obj);
		case TypeCode.Int16:
			return new NSNumber((short)obj);
		case TypeCode.UInt16:
			return new NSNumber((ushort)obj);
		case TypeCode.Int32:
			return new NSNumber((int)obj);
		case TypeCode.UInt32:
			return new NSNumber((uint)obj);
		case TypeCode.Int64:
			return new NSNumber((long)obj);
		case TypeCode.UInt64:
			return new NSNumber((ulong)obj);
		case TypeCode.Single:
			return new NSNumber((float)obj);
		case TypeCode.Double:
			return new NSNumber((double)obj);
		case TypeCode.String:
			return new NSString((string)obj);
		default:
			if (type == typeof(IntPtr))
			{
				return NSValue.ValueFromPointer((IntPtr)obj);
			}
			if (type == typeof(nint))
			{
				return NSNumber.FromNInt((nint)obj);
			}
			if (type == typeof(nuint))
			{
				return NSNumber.FromNUInt((nuint)obj);
			}
			if (type == typeof(nfloat))
			{
				return NSNumber.FromNFloat((nfloat)obj);
			}
			if (type == typeof(CGSize))
			{
				return NSValue.FromCGSize((CGSize)obj);
			}
			if (type == typeof(CGRect))
			{
				return NSValue.FromCGRect((CGRect)obj);
			}
			if (type == typeof(CGPoint))
			{
				return NSValue.FromCGPoint((CGPoint)obj);
			}
			if (obj is INativeObject nativeObject)
			{
				return Runtime.GetNSObject(nativeObject.Handle);
			}
			return null;
		}
	}

	public void SetValueForKeyPath(IntPtr handle, NSString keyPath)
	{
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetValue_ForKeyPath_Handle, handle, keyPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetValue_ForKeyPath_Handle, handle, keyPath.Handle);
		}
	}

	public override int GetHashCode()
	{
		if (!IsDirectBinding)
		{
			return base.GetHashCode();
		}
		return GetNativeHash().GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (!(obj is NSObject nSObject))
		{
			return false;
		}
		bool isDirectBinding = IsDirectBinding;
		if (isDirectBinding != nSObject.IsDirectBinding)
		{
			return false;
		}
		return isDirectBinding ? IsEqual(nSObject) : (this == nSObject);
	}

	public bool Equals(NSObject obj)
	{
		return Equals((object)obj);
	}

	public override string ToString()
	{
		return Description ?? base.ToString();
	}

	public virtual void Invoke(Action action, double delay)
	{
		NSAsyncActionDispatcher nSAsyncActionDispatcher = new NSAsyncActionDispatcher(action);
		nSAsyncActionDispatcher.PerformSelector(NSDispatcher.Selector, null, delay);
	}

	public virtual void Invoke(Action action, TimeSpan delay)
	{
		NSAsyncActionDispatcher nSAsyncActionDispatcher = new NSAsyncActionDispatcher(action);
		nSAsyncActionDispatcher.PerformSelector(NSDispatcher.Selector, null, delay.TotalSeconds);
	}

	internal void ClearHandle()
	{
		handle = IntPtr.Zero;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposed)
		{
			return;
		}
		disposed = true;
		if (handle != IntPtr.Zero)
		{
			if (disposing)
			{
                if (_is_autoloaded)
                    ReleaseManagedRef();
                else
                    ReleaseManagedRefEx();
			}
			else
			{
				NSObject_Disposer.Add(this);
			}
		}

        //DisposeInner();

    }

	public IDisposable AddObserver(string key, NSKeyValueObservingOptions options, Action<NSObservedChange> observer)
	{
		return AddObserver(new NSString(key), options, observer);
	}

	public IDisposable AddObserver(NSString key, NSKeyValueObservingOptions options, Action<NSObservedChange> observer)
	{
		Observer observer2 = new Observer(this, key, observer);
		AddObserver(observer2, key, options, observer2.Handle);
		return observer2;
	}

	internal void SetAsProxy()
	{
		IsDirectBinding = true;
	}

	[Export("addObserver:forKeyPath:options:context:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObserver(NSObject observer, NSString keyPath, NSKeyValueObservingOptions options, IntPtr context)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(Handle, selAddObserver_ForKeyPath_Options_Context_Handle, observer.Handle, keyPath.Handle, (ulong)options, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(SuperHandle, selAddObserver_ForKeyPath_Options_Context_Handle, observer.Handle, keyPath.Handle, (ulong)options, context);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AddObserver(NSObject observer, string keyPath, NSKeyValueObservingOptions options, IntPtr context)
	{
		AddObserver(observer, (NSString)keyPath, options, context);
	}

	[Export("automaticallyNotifiesObserversForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AutomaticallyNotifiesObserversForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selAutomaticallyNotifiesObserversForKey_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("awakeFromNib")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AwakeFromNib()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(Handle, selAwakeFromNibHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(SuperHandle, selAwakeFromNibHandle);
		}
	}

	[Export("bind:toObject:withKeyPath:options:")]
	[Obsolete("Use 'Bind (NSString binding, NSObject observable, string keyPath, [NullAllowed] NSDictionary options)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Bind(string binding, NSObject observable, string keyPath, NSDictionary? options)
	{
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		if (observable == null)
		{
			throw new ArgumentNullException("observable");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		IntPtr arg = NSString.CreateNative(binding);
		IntPtr arg2 = NSString.CreateNative(keyPath);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(Handle, selBind_ToObject_WithKeyPath_Options_Handle, arg, observable.Handle, arg2, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(SuperHandle, selBind_ToObject_WithKeyPath_Options_Handle, arg, observable.Handle, arg2, options?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Bind(NSString binding, NSObject observable, string keyPath, NSDictionary? options)
	{
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		if (observable == null)
		{
			throw new ArgumentNullException("observable");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		IntPtr arg = NSString.CreateNative(keyPath);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(Handle, selBind_ToObject_WithKeyPath_Options_Handle, binding.Handle, observable.Handle, arg, options?.Handle ?? IntPtr.Zero);
		NSString.ReleaseNative(arg);
	}

	[Export("infoForBinding:")]
	[Obsolete("Use 'GetBindingInfo (NSString binding)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary BindingInfo(string binding)
	{
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		IntPtr arg = NSString.CreateNative(binding);
		NSDictionary result = ((!IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selInfoForBinding_Handle, arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selInfoForBinding_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("optionDescriptionsForBinding:")]
	[Obsolete("Use 'GetBindingOptionDescriptions (NSString aBinding)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] BindingOptionDescriptions(string aBinding)
	{
		if (aBinding == null)
		{
			throw new ArgumentNullException("aBinding");
		}
		IntPtr arg = NSString.CreateNative(aBinding);
		NSObject[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selOptionDescriptionsForBinding_Handle, arg)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selOptionDescriptionsForBinding_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("valueClassForBinding:")]
	[Obsolete("Use 'GetBindingValueClass (NSString binding)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class BindingValueClass(string binding)
	{
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		IntPtr arg = NSString.CreateNative(binding);
		IntPtr intPtr = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selValueClassForBinding_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selValueClassForBinding_Handle, arg));
		NSString.ReleaseNative(arg);
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Export("cancelPreviousPerformRequestsWithTarget:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CancelPreviousPerformRequest(NSObject aTarget)
	{
		if (aTarget == null)
		{
			throw new ArgumentNullException("aTarget");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selCancelPreviousPerformRequestsWithTarget_Handle, aTarget.Handle);
	}

	[Export("cancelPreviousPerformRequestsWithTarget:selector:object:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CancelPreviousPerformRequest(NSObject aTarget, Selector selector, NSObject? argument)
	{
		if (aTarget == null)
		{
			throw new ArgumentNullException("aTarget");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selCancelPreviousPerformRequestsWithTarget_Selector_Object_Handle, aTarget.Handle, selector.Handle, argument?.Handle ?? IntPtr.Zero);
	}

	[Export("commitEditing")]
	[Deprecated(PlatformName.MacOSX, PlatformArchitecture.None, "Now on 'NSEditor' protocol.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CommitEditing()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(Handle, selCommitEditingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(SuperHandle, selCommitEditingHandle);
	}

	[Export("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
	[Deprecated(PlatformName.MacOSX, PlatformArchitecture.None, "Now on 'NSEditor' protocol.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CommitEditing(NSObject objDelegate, Selector didCommitSelector, IntPtr contextInfo)
	{
		if (objDelegate == null)
		{
			throw new ArgumentNullException("objDelegate");
		}
		if (didCommitSelector == null)
		{
			throw new ArgumentNullException("didCommitSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(Handle, selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle, objDelegate.Handle, didCommitSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(SuperHandle, selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle, objDelegate.Handle, didCommitSelector.Handle, contextInfo);
		}
	}

	[Export("copy")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy()
	{
		if (!(this is INSCopying))
		{
			throw new InvalidOperationException("Type does not conform to NSCopying");
		}
		NSObject nSObject = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selCopyHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selCopyHandle)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("didChange:valuesAtIndexes:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChange(NSKeyValueChange changeKind, NSIndexSet indexes, NSString forKey)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (forKey == null)
		{
			throw new ArgumentNullException("forKey");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr(Handle, selDidChange_ValuesAtIndexes_ForKey_Handle, (ulong)changeKind, indexes.Handle, forKey.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr_IntPtr(SuperHandle, selDidChange_ValuesAtIndexes_ForKey_Handle, (ulong)changeKind, indexes.Handle, forKey.Handle);
		}
	}

	[Export("didChangeValueForKey:withSetMutation:usingObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChange(NSString forKey, NSKeyValueSetMutationKind mutationKind, NSSet objects)
	{
		if (forKey == null)
		{
			throw new ArgumentNullException("forKey");
		}
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(Handle, selDidChangeValueForKey_WithSetMutation_UsingObjects_Handle, forKey.Handle, (ulong)mutationKind, objects.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr(SuperHandle, selDidChangeValueForKey_WithSetMutation_UsingObjects_Handle, forKey.Handle, (ulong)mutationKind, objects.Handle);
		}
	}

	[Export("didChangeValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeValue(string forKey)
	{
		if (forKey == null)
		{
			throw new ArgumentNullException("forKey");
		}
		IntPtr arg = NSString.CreateNative(forKey);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(Handle, selDidChangeValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selDidChangeValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("doesNotRecognizeSelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DoesNotRecognizeSelector(Selector sel)
	{
		if (sel == null)
		{
			throw new ArgumentNullException("sel");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(Handle, selDoesNotRecognizeSelector_Handle, sel.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selDoesNotRecognizeSelector_Handle, sel.Handle);
		}
	}

	[Export("exposedBindings")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] ExposedBindings()
	{
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(Handle, selExposedBindingsHandle));
		}
		return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selExposedBindingsHandle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDictionary GetBindingInfo(NSString binding)
	{
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selInfoForBinding_Handle, binding.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject[] GetBindingOptionDescriptions(NSString aBinding)
	{
		if (aBinding == null)
		{
			throw new ArgumentNullException("aBinding");
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selOptionDescriptionsForBinding_Handle, aBinding.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Class GetBindingValueClass(NSString binding)
	{
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		IntPtr intPtr = Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selValueClassForBinding_Handle, binding.Handle);
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject GetDefaultPlaceholder(NSObject marker, string binding)
	{
		return GetDefaultPlaceholder(marker, (NSString)binding);
	}

	[Export("defaultPlaceholderForMarker:withBinding:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject GetDefaultPlaceholder(NSObject marker, NSString binding)
	{
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDefaultPlaceholderForMarker_WithBinding_Handle, marker.Handle, binding.Handle));
	}

	[Export("dictionaryWithValuesForKeys:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary GetDictionaryOfValuesFromKeys(NSString[] keys)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		NSArray nSArray = NSArray.FromNSObjects(keys);
		NSDictionary result = ((!IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selDictionaryWithValuesForKeys_Handle, nSArray.Handle)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selDictionaryWithValuesForKeys_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("keyPathsForValuesAffectingValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSet GetKeyPathsForValuesAffecting(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selKeyPathsForValuesAffectingValueForKey_Handle, key.Handle));
	}

	[Export("methodForSelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr GetMethodForSelector(Selector sel)
	{
		if (sel == null)
		{
			throw new ArgumentNullException("sel");
		}
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selMethodForSelector_Handle, sel.Handle);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selMethodForSelector_Handle, sel.Handle);
	}

	[Export("hash")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetNativeHash()
	{
		if (IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend(Handle, selHashHandle);
		}
		return Messaging.nuint_objc_msgSendSuper(SuperHandle, selHashHandle);
	}

	[Export("isEqual:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqual(NSObject? anObject)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(Handle, selIsEqual_Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selIsEqual_Handle, anObject?.Handle ?? IntPtr.Zero);
	}

	[Export("isKindOfClass:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsKindOfClass(Class? aClass)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(Handle, selIsKindOfClass_Handle, aClass?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selIsKindOfClass_Handle, aClass?.Handle ?? IntPtr.Zero);
	}

	[Export("isMemberOfClass:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsMemberOfClass(Class? aClass)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(Handle, selIsMemberOfClass_Handle, aClass?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selIsMemberOfClass_Handle, aClass?.Handle ?? IntPtr.Zero);
	}

	[Export("mutableCopy")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy()
	{
		if (!(this is INSMutableCopying))
		{
			throw new InvalidOperationException("Type does not conform to NSMutableCopying");
		}
		NSObject nSObject = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selMutableCopyHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selMutableCopyHandle)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("objectDidEndEditing:")]
	[Deprecated(PlatformName.MacOSX, PlatformArchitecture.None, "Now on 'NSEditor' protocol.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ObjectDidEndEditing(NSObject editor)
	{
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(Handle, selObjectDidEndEditing_Handle, editor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selObjectDidEndEditing_Handle, editor.Handle);
		}
	}

	[Export("observeValueForKeyPath:ofObject:change:context:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ObserveValue(NSString keyPath, NSObject ofObject, NSDictionary change, IntPtr context)
	{
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		if (ofObject == null)
		{
			throw new ArgumentNullException("ofObject");
		}
		if (change == null)
		{
			throw new ArgumentNullException("change");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(Handle, selObserveValueForKeyPath_OfObject_Change_Context_Handle, keyPath.Handle, ofObject.Handle, change.Handle, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(SuperHandle, selObserveValueForKeyPath_OfObject_Change_Context_Handle, keyPath.Handle, ofObject.Handle, change.Handle, context);
		}
	}

	[Export("performSelector:withObject:afterDelay:inModes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformSelector(Selector selector, NSObject? withObject, double afterDelay, NSString[] nsRunLoopModes)
	{
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (nsRunLoopModes == null)
		{
			throw new ArgumentNullException("nsRunLoopModes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nsRunLoopModes);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Double_IntPtr(Handle, selPerformSelector_WithObject_AfterDelay_InModes_Handle, selector.Handle, withObject?.Handle ?? IntPtr.Zero, afterDelay, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Double_IntPtr(SuperHandle, selPerformSelector_WithObject_AfterDelay_InModes_Handle, selector.Handle, withObject?.Handle ?? IntPtr.Zero, afterDelay, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("performSelector:withObject:afterDelay:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformSelector(Selector selector, NSObject? withObject, double delay)
	{
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Double(Handle, selPerformSelector_WithObject_AfterDelay_Handle, selector.Handle, withObject?.Handle ?? IntPtr.Zero, delay);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Double(SuperHandle, selPerformSelector_WithObject_AfterDelay_Handle, selector.Handle, withObject?.Handle ?? IntPtr.Zero, delay);
		}
	}

	[Export("performSelector:onThread:withObject:waitUntilDone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformSelector(Selector selector, NSThread onThread, NSObject? withObject, bool waitUntilDone)
	{
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (onThread == null)
		{
			throw new ArgumentNullException("onThread");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(Handle, selPerformSelector_OnThread_WithObject_WaitUntilDone_Handle, selector.Handle, onThread.Handle, withObject?.Handle ?? IntPtr.Zero, waitUntilDone);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool(SuperHandle, selPerformSelector_OnThread_WithObject_WaitUntilDone_Handle, selector.Handle, onThread.Handle, withObject?.Handle ?? IntPtr.Zero, waitUntilDone);
		}
	}

	[Export("performSelector:onThread:withObject:waitUntilDone:modes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformSelector(Selector selector, NSThread onThread, NSObject? withObject, bool waitUntilDone, NSString[] nsRunLoopModes)
	{
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (onThread == null)
		{
			throw new ArgumentNullException("onThread");
		}
		if (nsRunLoopModes == null)
		{
			throw new ArgumentNullException("nsRunLoopModes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nsRunLoopModes);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr(Handle, selPerformSelector_OnThread_WithObject_WaitUntilDone_Modes_Handle, selector.Handle, onThread.Handle, withObject?.Handle ?? IntPtr.Zero, waitUntilDone, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr(SuperHandle, selPerformSelector_OnThread_WithObject_WaitUntilDone_Modes_Handle, selector.Handle, onThread.Handle, withObject?.Handle ?? IntPtr.Zero, waitUntilDone, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("performSelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject PerformSelector(Selector aSelector)
	{
		if (aSelector == null)
		{
			throw new ArgumentNullException("aSelector");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selPerformSelector_Handle, aSelector.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selPerformSelector_Handle, aSelector.Handle));
	}

	[Export("performSelector:withObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject PerformSelector(Selector aSelector, NSObject? anObject)
	{
		if (aSelector == null)
		{
			throw new ArgumentNullException("aSelector");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(Handle, selPerformSelector_WithObject_Handle, aSelector.Handle, anObject?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selPerformSelector_WithObject_Handle, aSelector.Handle, anObject?.Handle ?? IntPtr.Zero));
	}

	[Export("performSelector:withObject:withObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject PerformSelector(Selector aSelector, NSObject? object1, NSObject? object2)
	{
		if (aSelector == null)
		{
			throw new ArgumentNullException("aSelector");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(Handle, selPerformSelector_WithObject_WithObject_Handle, aSelector.Handle, object1?.Handle ?? IntPtr.Zero, object2?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(SuperHandle, selPerformSelector_WithObject_WithObject_Handle, aSelector.Handle, object1?.Handle ?? IntPtr.Zero, object2?.Handle ?? IntPtr.Zero));
	}

	[Export("prepareForInterfaceBuilder")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareForInterfaceBuilder()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(Handle, selPrepareForInterfaceBuilderHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(SuperHandle, selPrepareForInterfaceBuilderHandle);
		}
	}

	[Export("removeObserver:forKeyPath:context:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObserver(NSObject observer, NSString keyPath, IntPtr context)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(Handle, selRemoveObserver_ForKeyPath_Context_Handle, observer.Handle, keyPath.Handle, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(SuperHandle, selRemoveObserver_ForKeyPath_Context_Handle, observer.Handle, keyPath.Handle, context);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RemoveObserver(NSObject observer, string keyPath, IntPtr context)
	{
		RemoveObserver(observer, (NSString)keyPath, context);
	}

	[Export("removeObserver:forKeyPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObserver(NSObject observer, NSString keyPath)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selRemoveObserver_ForKeyPath_Handle, observer.Handle, keyPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selRemoveObserver_ForKeyPath_Handle, observer.Handle, keyPath.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RemoveObserver(NSObject observer, string keyPath)
	{
		RemoveObserver(observer, (NSString)keyPath);
	}

	[Export("respondsToSelector:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RespondsToSelector(Selector? sel)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(Handle, selRespondsToSelector_Handle, (sel == null) ? IntPtr.Zero : sel.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selRespondsToSelector_Handle, (sel == null) ? IntPtr.Zero : sel.Handle);
	}

	[Obsolete("Use 'SetDefaultPlaceholder (NSObject placeholder, NSObject marker, NSString binding)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetDefaultPlaceholder(NSObject placeholder, NSObject marker, string binding)
	{
		SetDefaultPlaceholder(placeholder, marker, (NSString)binding);
	}

	[Export("setDefaultPlaceholder:forMarker:withBinding:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetDefaultPlaceholder(NSObject placeholder, NSObject marker, NSString binding)
	{
		if (placeholder == null)
		{
			throw new ArgumentNullException("placeholder");
		}
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selSetDefaultPlaceholder_ForMarker_WithBinding_Handle, placeholder.Handle, marker.Handle, binding.Handle);
	}

	[Export("setNilValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNilValueForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(Handle, selSetNilValueForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetNilValueForKey_Handle, key.Handle);
		}
	}

	[Export("setValue:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValueForKey(NSObject value, NSString key)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetValue_ForKey_Handle, value.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetValue_ForKey_Handle, value.Handle, key.Handle);
		}
	}

	[Export("setValue:forKeyPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValueForKeyPath(NSObject value, NSString keyPath)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetValue_ForKeyPath_Handle, value.Handle, keyPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetValue_ForKeyPath_Handle, value.Handle, keyPath.Handle);
		}
	}

	[Export("setValue:forUndefinedKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValueForUndefinedKey(NSObject value, NSString undefinedKey)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (undefinedKey == null)
		{
			throw new ArgumentNullException("undefinedKey");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetValue_ForUndefinedKey_Handle, value.Handle, undefinedKey.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetValue_ForUndefinedKey_Handle, value.Handle, undefinedKey.Handle);
		}
	}

	[Export("setValuesForKeysWithDictionary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValuesForKeysWithDictionary(NSDictionary keyedValues)
	{
		if (keyedValues == null)
		{
			throw new ArgumentNullException("keyedValues");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(Handle, selSetValuesForKeysWithDictionary_Handle, keyedValues.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetValuesForKeysWithDictionary_Handle, keyedValues.Handle);
		}
	}

	[Export("unbind:")]
	[Obsolete("Use 'Unbind (NSString binding)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Unbind(string binding)
	{
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		IntPtr arg = NSString.CreateNative(binding);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(Handle, selUnbind_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selUnbind_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Unbind(NSString binding)
	{
		if (binding == null)
		{
			throw new ArgumentNullException("binding");
		}
		Messaging.void_objc_msgSend_IntPtr(Handle, selUnbind_Handle, binding.Handle);
	}

	[Export("valueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ValueForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.xamarin_IntPtr_objc_msgSend_IntPtr(Handle, selValueForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.xamarin_IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selValueForKey_Handle, key.Handle));
	}

	[Export("valueForKeyPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ValueForKeyPath(NSString keyPath)
	{
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selValueForKeyPath_Handle, keyPath.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selValueForKeyPath_Handle, keyPath.Handle));
	}

	[Export("valueForUndefinedKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ValueForUndefinedKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selValueForUndefinedKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selValueForUndefinedKey_Handle, key.Handle));
	}

	[Export("willChange:valuesAtIndexes:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillChange(NSKeyValueChange changeKind, NSIndexSet indexes, NSString forKey)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (forKey == null)
		{
			throw new ArgumentNullException("forKey");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr(Handle, selWillChange_ValuesAtIndexes_ForKey_Handle, (ulong)changeKind, indexes.Handle, forKey.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr_IntPtr(SuperHandle, selWillChange_ValuesAtIndexes_ForKey_Handle, (ulong)changeKind, indexes.Handle, forKey.Handle);
		}
	}

	[Export("willChangeValueForKey:withSetMutation:usingObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillChange(NSString forKey, NSKeyValueSetMutationKind mutationKind, NSSet objects)
	{
		if (forKey == null)
		{
			throw new ArgumentNullException("forKey");
		}
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(Handle, selWillChangeValueForKey_WithSetMutation_UsingObjects_Handle, forKey.Handle, (ulong)mutationKind, objects.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr(SuperHandle, selWillChangeValueForKey_WithSetMutation_UsingObjects_Handle, forKey.Handle, (ulong)mutationKind, objects.Handle);
		}
	}

	[Export("willChangeValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillChangeValue(string forKey)
	{
		if (forKey == null)
		{
			throw new ArgumentNullException("forKey");
		}
		IntPtr arg = NSString.CreateNative(forKey);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(Handle, selWillChangeValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selWillChangeValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

    #region

    [Export("encodeWithCoder:")]
    public virtual void EncodeTo(NSCoder coder)
    {
        if (coder == null)
            throw new ArgumentNullException(nameof(coder));
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_intptr(Handle, selEncodeWithCoderHandle, coder.Handle);
        else
            Messaging.void_objc_msgSendSuper_intptr(SuperHandle, selEncodeWithCoderHandle, coder.Handle);
    }

    public void Release() => Messaging.void_objc_msgSend(handle, Selector.ReleaseHandle);

    public NSObject Retain()
    {
        Messaging.void_objc_msgSend(handle, Selector.RetainHandle);
        return this;
    }

    public NSObject Autorelease()
    {
        Messaging.void_objc_msgSend(handle, Selector.AutoreleaseHandle);
        return this;
    }

    //public unsafe IntPtr SuperHandleEx
    //{
    //    get
    //    {
    //        if (super == IntPtr.Zero)
    //        {
    //            super = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(NSObject.objc_super)));
    //            NSObject.objc_super* innerSuper = (NSObject.objc_super*)(void*)super;
    //            innerSuper->receiver = handle;
    //            innerSuper->super = ClassHandle;
    //        }
    //        return super;
    //    }
    //}


    //protected void DisposeInner()
    //{
    //    if (!(super != IntPtr.Zero))
    //        return;
    //    Marshal.FreeHGlobal(super);
    //    super = IntPtr.Zero;
    //}

    private static int GetRetainCount(IntPtr @this) => Messaging.int_objc_msgSend(@this, Selector.RetainCount);

    private void UnregisterObject() => Runtime.NativeObjectHasDied(handle);

    //private void FreeGCHandle()
    //{
    //    if (!(gchandle != IntPtr.Zero))
    //        return;
    //    GCHandle.FromIntPtr(gchandle).Free();
    //    gchandle = IntPtr.Zero;
    //}

    //private void SwitchGCHandle(bool to_weak)
    //{
    //    if (gchandle != IntPtr.Zero)
    //        GCHandle.FromIntPtr(gchandle).Free();
    //    if (to_weak)
    //        gchandle = GCHandle.ToIntPtr(GCHandle.Alloc((object)this, GCHandleType.WeakTrackResurrection));
    //    else
    //        gchandle = GCHandle.ToIntPtr(GCHandle.Alloc((object)this, GCHandleType.Normal));
    //}

    internal static void OverrideRetainAndRelease(IntPtr @class)
    {
        lock (lock_obj)
        {
            if (NSObject.ReleaseTrampolineFunctionPointer == IntPtr.Zero)
            {
                //NSObject.retainTrampoline = new NSObject.RetainTrampolineDelegate(NSObject.RetainTrampoline);
                //NSObject.releaseTrampoline = new NSObject.ReleaseTrampolineDelegate(NSObject.ReleaseTrampoline);
                NSObject.RetainTrampolineFunctionPointer = Marshal.GetFunctionPointerForDelegate<NSObject.RetainTrampolineDelegate>(NSObject.retainTrampoline);
                NSObject.ReleaseTrampolineFunctionPointer = Marshal.GetFunctionPointerForDelegate<NSObject.ReleaseTrampolineDelegate>(NSObject.releaseTrampoline);
            }
        }
        Class.class_addMethod(@class, Selector.RetainHandle, NSObject.RetainTrampolineFunctionPointer, "@@:");
        Class.class_addMethod(@class, Selector.ReleaseHandle, NSObject.ReleaseTrampolineFunctionPointer, "v@:");
    }

    private static bool IsUserType(IntPtr @this)
    {
        IntPtr num = NSObject.object_getClass(@this);
        if (Class.class_getMethodImplementation(num, Selector.RetainHandle) == NSObject.RetainTrampolineFunctionPointer)
            return true;
        Type type = Class.Lookup(num, false);
        return type != (Type)null && Class.IsCustomType(type);
    }

    //private void CreateGCHandle(bool force_weak)
    //{
    //    int num = force_weak ? 1 : (NSObject.GetRetainCount(handle) == 1 ? 1 : 0);
    //    has_managed_ref = true;
    //    if (num != 0)
    //        gchandle = GCHandle.ToIntPtr(GCHandle.Alloc((object)this, GCHandleType.WeakTrackResurrection));
    //    else
    //        gchandle = GCHandle.ToIntPtr(GCHandle.Alloc((object)this, GCHandleType.Normal));
    //}

    private void CreateManagedRefEx(bool retain)
    {
        //if (NSObject.IsUserType(handle) && gchandle == IntPtr.Zero)
            //CreateGCHandle(!retain);
        if (!retain)
            return;
        Messaging.void_objc_msgSend(handle, Selector.RetainHandle);
    }

    private void ReleaseManagedRefEx()
    {

        if (disposed)
            return;

        //IntPtr innerhandle = handle;
        //if (NSObject.IsUserType(innerhandle))
            //has_managed_ref = false;
        //else
            UnregisterObject();
        Messaging.void_objc_msgSend(handle, Selector.ReleaseHandle);
    }

    [DllImport("/usr/lib/libobjc.dylib")]
    private static extern IntPtr object_getClass(IntPtr @this);

    [DllImport("/usr/lib/libobjc.dylib")]
    private static extern IntPtr objc_msgSendSuper(ref NSObject.objc_super super, IntPtr selector);

    private static IntPtr InvokeObjCMethodImplementation(IntPtr @this, IntPtr sel)
    {
        IntPtr cls = NSObject.object_getClass(@this);
        IntPtr superclass = Class.class_getSuperclass(cls);
        IntPtr methodImplementation1 = Class.class_getMethodImplementation(cls, sel);
        for (IntPtr methodImplementation2 = Class.class_getMethodImplementation(superclass, sel); methodImplementation1 == methodImplementation2; methodImplementation2 = Class.class_getMethodImplementation(superclass, sel))
            superclass = Class.class_getSuperclass(superclass);
        NSObject.objc_super super;
        super.receiver = @this;
        super.super = superclass;
        return NSObject.objc_msgSendSuper(ref super, sel);
    }

    //private static void ReleaseTrampoline(IntPtr @this, IntPtr sel)
    //{
    //    int num = Messaging.int_objc_msgSend(@this, Selector.RetainCount);
    //    if (num == 1)
    //    {
    //        NSObject nsObject = ObjCRuntime.Runtime.TryGetNSObject(@this);
    //        if (nsObject != null)
    //        {
    //            nsObject.UnregisterObject();
    //            nsObject.FreeGCHandle();
    //        }
    //    }
    //    if (num == 2)
    //    {
    //        NSObject nsObject = ObjCRuntime.Runtime.TryGetNSObject(@this);
    //        if (nsObject != null && nsObject.has_managed_ref)
    //            nsObject.SwitchGCHandle(true);
    //    }
    //    NSObject.InvokeObjCMethodImplementation(@this, sel);
    //}

    //private static IntPtr RetainTrampoline(IntPtr @this, IntPtr sel)
    //{
    //    if (Messaging.int_objc_msgSend(@this, Selector.RetainCount) == 1)
    //    {
    //        NSObject nsObject = ObjCRuntime.Runtime.TryGetNSObject(@this);
    //        if (nsObject != null && nsObject.has_managed_ref)
    //            nsObject.SwitchGCHandle(false);
    //    }
    //    @this = NSObject.InvokeObjCMethodImplementation(@this, sel);
    //    return @this;
    //}

    #endregion

}
