using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Register("ASAuthorizationController", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class ASAuthorizationController : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationRequests = "authorizationRequests";

	private static readonly IntPtr selAuthorizationRequestsHandle = Selector.GetHandle("authorizationRequests");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAuthorizationRequests_ = "initWithAuthorizationRequests:";

	private static readonly IntPtr selInitWithAuthorizationRequests_Handle = Selector.GetHandle("initWithAuthorizationRequests:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequests = "performRequests";

	private static readonly IntPtr selPerformRequestsHandle = Selector.GetHandle("performRequests");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentationContextProvider = "presentationContextProvider";

	private static readonly IntPtr selPresentationContextProviderHandle = Selector.GetHandle("presentationContextProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPresentationContextProvider_ = "setPresentationContextProvider:";

	private static readonly IntPtr selSetPresentationContextProvider_Handle = Selector.GetHandle("setPresentationContextProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASAuthorizationController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_PresentationContextProvider_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ASAuthorizationRequest[] AuthorizationRequests
	{
		[Export("authorizationRequests", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<ASAuthorizationRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selAuthorizationRequestsHandle));
			}
			return NSArray.ArrayFromHandle<ASAuthorizationRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAuthorizationRequestsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IASAuthorizationControllerDelegate? Delegate
	{
		get
		{
			return WeakDelegate as IASAuthorizationControllerDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual IASAuthorizationControllerPresentationContextProviding? PresentationContextProvider
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("presentationContextProvider", ArgumentSemantic.Weak)]
		get
		{
			IASAuthorizationControllerPresentationContextProviding iASAuthorizationControllerPresentationContextProviding = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IASAuthorizationControllerPresentationContextProviding>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPresentationContextProviderHandle), owns: false) : Runtime.GetINativeObject<IASAuthorizationControllerPresentationContextProviding>(Messaging.IntPtr_objc_msgSend(base.Handle, selPresentationContextProviderHandle), owns: false));
			MarkDirty();
			__mt_PresentationContextProvider_var = iASAuthorizationControllerPresentationContextProviding;
			return iASAuthorizationControllerPresentationContextProviding;
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setPresentationContextProvider:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPresentationContextProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPresentationContextProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_PresentationContextProvider_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
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
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ASAuthorizationController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASAuthorizationController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAuthorizationRequests:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ASAuthorizationController(ASAuthorizationRequest[] authorizationRequests)
		: base(NSObjectFlag.Empty)
	{
		if (authorizationRequests == null)
		{
			throw new ArgumentNullException("authorizationRequests");
		}
		NSArray nSArray = NSArray.FromNSObjects(authorizationRequests);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAuthorizationRequests_Handle, nSArray.Handle), "initWithAuthorizationRequests:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAuthorizationRequests_Handle, nSArray.Handle), "initWithAuthorizationRequests:");
		}
		nSArray.Dispose();
	}

	[Export("performRequests")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformRequests()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPerformRequestsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPerformRequestsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PresentationContextProvider_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
