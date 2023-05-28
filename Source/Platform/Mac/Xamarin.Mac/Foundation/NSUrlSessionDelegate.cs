using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSURLSessionDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class NSUrlSessionDelegate : NSObject, INSUrlSessionDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlSessionDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlSessionDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlSessionDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("URLSession:didBecomeInvalidWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBecomeInvalid(NSUrlSession session, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSessionDidFinishEventsForBackgroundURLSession:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishEventsForBackgroundSession(NSUrlSession session)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:didReceiveChallenge:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveChallenge(NSUrlSession session, NSUrlAuthenticationChallenge challenge, [BlockProxy(typeof(Trampolines.NIDActionArity2V44))] Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
