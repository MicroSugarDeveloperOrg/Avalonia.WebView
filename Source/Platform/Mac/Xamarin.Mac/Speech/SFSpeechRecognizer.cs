using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Speech;

[Register("SFSpeechRecognizer", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class SFSpeechRecognizer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationStatus = "authorizationStatus";

	private static readonly IntPtr selAuthorizationStatusHandle = Selector.GetHandle("authorizationStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultTaskHint = "defaultTaskHint";

	private static readonly IntPtr selDefaultTaskHintHandle = Selector.GetHandle("defaultTaskHint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLocale_ = "initWithLocale:";

	private static readonly IntPtr selInitWithLocale_Handle = Selector.GetHandle("initWithLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAvailable = "isAvailable";

	private static readonly IntPtr selIsAvailableHandle = Selector.GetHandle("isAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocale = "locale";

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueue = "queue";

	private static readonly IntPtr selQueueHandle = Selector.GetHandle("queue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecognitionTaskWithRequest_Delegate_ = "recognitionTaskWithRequest:delegate:";

	private static readonly IntPtr selRecognitionTaskWithRequest_Delegate_Handle = Selector.GetHandle("recognitionTaskWithRequest:delegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecognitionTaskWithRequest_ResultHandler_ = "recognitionTaskWithRequest:resultHandler:";

	private static readonly IntPtr selRecognitionTaskWithRequest_ResultHandler_Handle = Selector.GetHandle("recognitionTaskWithRequest:resultHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAuthorization_ = "requestAuthorization:";

	private static readonly IntPtr selRequestAuthorization_Handle = Selector.GetHandle("requestAuthorization:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultTaskHint_ = "setDefaultTaskHint:";

	private static readonly IntPtr selSetDefaultTaskHint_Handle = Selector.GetHandle("setDefaultTaskHint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQueue_ = "setQueue:";

	private static readonly IntPtr selSetQueue_Handle = Selector.GetHandle("setQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSupportsOnDeviceRecognition_ = "setSupportsOnDeviceRecognition:";

	private static readonly IntPtr selSetSupportsOnDeviceRecognition_Handle = Selector.GetHandle("setSupportsOnDeviceRecognition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedLocales = "supportedLocales";

	private static readonly IntPtr selSupportedLocalesHandle = Selector.GetHandle("supportedLocales");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsOnDeviceRecognition = "supportsOnDeviceRecognition";

	private static readonly IntPtr selSupportsOnDeviceRecognitionHandle = Selector.GetHandle("supportsOnDeviceRecognition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SFSpeechRecognizer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SFSpeechRecognizerAuthorizationStatus AuthorizationStatus
	{
		[Export("authorizationStatus")]
		get
		{
			return (SFSpeechRecognizerAuthorizationStatus)Messaging.Int64_objc_msgSend(class_ptr, selAuthorizationStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Available
	{
		[Export("isAvailable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAvailableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SFSpeechRecognitionTaskHint DefaultTaskHint
	{
		[Export("defaultTaskHint", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SFSpeechRecognitionTaskHint)Messaging.Int64_objc_msgSend(base.Handle, selDefaultTaskHintHandle);
			}
			return (SFSpeechRecognitionTaskHint)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDefaultTaskHintHandle);
		}
		[Export("setDefaultTaskHint:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDefaultTaskHint_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDefaultTaskHint_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ISFSpeechRecognizerDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			ISFSpeechRecognizerDelegate iSFSpeechRecognizerDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<ISFSpeechRecognizerDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<ISFSpeechRecognizerDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iSFSpeechRecognizerDelegate;
			return iSFSpeechRecognizerDelegate;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLocale Locale
	{
		[Export("locale", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleHandle));
			}
			return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOperationQueue Queue
	{
		[Export("queue", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSend(base.Handle, selQueueHandle));
			}
			return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQueueHandle));
		}
		[Export("setQueue:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetQueue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetQueue_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSet<NSLocale> SupportedLocales
	{
		[Export("supportedLocales")]
		get
		{
			return Runtime.GetNSObject<NSSet<NSLocale>>(Messaging.IntPtr_objc_msgSend(class_ptr, selSupportedLocalesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool SupportsOnDeviceRecognition
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("supportsOnDeviceRecognition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsOnDeviceRecognitionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsOnDeviceRecognitionHandle);
		}
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setSupportsOnDeviceRecognition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSupportsOnDeviceRecognition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSupportsOnDeviceRecognition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SFSpeechRecognizer()
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
	protected SFSpeechRecognizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SFSpeechRecognizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLocale:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SFSpeechRecognizer(NSLocale locale)
		: base(NSObjectFlag.Empty)
	{
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithLocale_Handle, locale.Handle), "initWithLocale:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithLocale_Handle, locale.Handle), "initWithLocale:");
		}
	}

	[Export("recognitionTaskWithRequest:resultHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual SFSpeechRecognitionTask GetRecognitionTask(SFSpeechRecognitionRequest request, [BlockProxy(typeof(Trampolines.NIDActionArity2V83))] Action<SFSpeechRecognitionResult, NSError> resultHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (resultHandler == null)
		{
			throw new ArgumentNullException("resultHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V83.Handler, resultHandler);
		SFSpeechRecognitionTask result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SFSpeechRecognitionTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRecognitionTaskWithRequest_ResultHandler_Handle, request.Handle, (IntPtr)ptr)) : Runtime.GetNSObject<SFSpeechRecognitionTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selRecognitionTaskWithRequest_ResultHandler_Handle, request.Handle, (IntPtr)ptr)));
		ptr->CleanupBlock();
		return result;
	}

	[Export("recognitionTaskWithRequest:delegate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SFSpeechRecognitionTask GetRecognitionTask(SFSpeechRecognitionRequest request, ISFSpeechRecognitionTaskDelegate @delegate)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (@delegate == null)
		{
			throw new ArgumentNullException("@delegate");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SFSpeechRecognitionTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selRecognitionTaskWithRequest_Delegate_Handle, request.Handle, @delegate.Handle));
		}
		return Runtime.GetNSObject<SFSpeechRecognitionTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRecognitionTaskWithRequest_Delegate_Handle, request.Handle, @delegate.Handle));
	}

	[Export("requestAuthorization:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RequestAuthorization([BlockProxy(typeof(Trampolines.NIDActionArity1V86))] Action<SFSpeechRecognizerAuthorizationStatus> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V86.Handler, handler);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRequestAuthorization_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
		}
	}
}
