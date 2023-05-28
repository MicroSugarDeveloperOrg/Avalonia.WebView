using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AutomaticAssessmentConfiguration;

[Protocol]
[Register("Xamarin_Mac__AutomaticAssessmentConfiguration_AEAssessmentSessionDelegate", false)]
[Model]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
public class AEAssessmentSessionDelegate : NSObject, IAEAssessmentSessionDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AEAssessmentSessionDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AEAssessmentSessionDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AEAssessmentSessionDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("assessmentSessionDidBegin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBegin(AEAssessmentSession session)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("assessmentSessionDidEnd:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEnd(AEAssessmentSession session)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("assessmentSession:failedToBeginWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FailedToBegin(AEAssessmentSession session, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("assessmentSession:wasInterruptedWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WasInterrupted(AEAssessmentSession session, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
