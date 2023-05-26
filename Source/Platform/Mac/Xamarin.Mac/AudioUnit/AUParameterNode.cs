using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AudioUnit;

[Register("AUParameterNode", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AUParameterNode : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayName = "displayName";

	private static readonly IntPtr selDisplayNameHandle = Selector.GetHandle("displayName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayNameWithLength_ = "displayNameWithLength:";

	private static readonly IntPtr selDisplayNameWithLength_Handle = Selector.GetHandle("displayNameWithLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImplementorDisplayNameWithLengthCallback = "implementorDisplayNameWithLengthCallback";

	private static readonly IntPtr selImplementorDisplayNameWithLengthCallbackHandle = Selector.GetHandle("implementorDisplayNameWithLengthCallback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImplementorStringFromValueCallback = "implementorStringFromValueCallback";

	private static readonly IntPtr selImplementorStringFromValueCallbackHandle = Selector.GetHandle("implementorStringFromValueCallback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImplementorValueFromStringCallback = "implementorValueFromStringCallback";

	private static readonly IntPtr selImplementorValueFromStringCallbackHandle = Selector.GetHandle("implementorValueFromStringCallback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImplementorValueObserver = "implementorValueObserver";

	private static readonly IntPtr selImplementorValueObserverHandle = Selector.GetHandle("implementorValueObserver");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImplementorValueProvider = "implementorValueProvider";

	private static readonly IntPtr selImplementorValueProviderHandle = Selector.GetHandle("implementorValueProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyPath = "keyPath";

	private static readonly IntPtr selKeyPathHandle = Selector.GetHandle("keyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveParameterObserver_ = "removeParameterObserver:";

	private static readonly IntPtr selRemoveParameterObserver_Handle = Selector.GetHandle("removeParameterObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImplementorDisplayNameWithLengthCallback_ = "setImplementorDisplayNameWithLengthCallback:";

	private static readonly IntPtr selSetImplementorDisplayNameWithLengthCallback_Handle = Selector.GetHandle("setImplementorDisplayNameWithLengthCallback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImplementorStringFromValueCallback_ = "setImplementorStringFromValueCallback:";

	private static readonly IntPtr selSetImplementorStringFromValueCallback_Handle = Selector.GetHandle("setImplementorStringFromValueCallback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImplementorValueFromStringCallback_ = "setImplementorValueFromStringCallback:";

	private static readonly IntPtr selSetImplementorValueFromStringCallback_Handle = Selector.GetHandle("setImplementorValueFromStringCallback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImplementorValueObserver_ = "setImplementorValueObserver:";

	private static readonly IntPtr selSetImplementorValueObserver_Handle = Selector.GetHandle("setImplementorValueObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImplementorValueProvider_ = "setImplementorValueProvider:";

	private static readonly IntPtr selSetImplementorValueProvider_Handle = Selector.GetHandle("setImplementorValueProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTokenByAddingParameterAutomationObserver_ = "tokenByAddingParameterAutomationObserver:";

	private static readonly IntPtr selTokenByAddingParameterAutomationObserver_Handle = Selector.GetHandle("tokenByAddingParameterAutomationObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTokenByAddingParameterObserver_ = "tokenByAddingParameterObserver:";

	private static readonly IntPtr selTokenByAddingParameterObserver_Handle = Selector.GetHandle("tokenByAddingParameterObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTokenByAddingParameterRecordingObserver_ = "tokenByAddingParameterRecordingObserver:";

	private static readonly IntPtr selTokenByAddingParameterRecordingObserver_Handle = Selector.GetHandle("tokenByAddingParameterRecordingObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AUParameterNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DisplayName
	{
		[Export("displayName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual AUImplementorDisplayNameWithLengthCallback ImplementorDisplayNameWithLengthCallback
	{
		[Export("implementorDisplayNameWithLengthCallback", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAUImplementorDisplayNameWithLengthCallback))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImplementorDisplayNameWithLengthCallbackHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selImplementorDisplayNameWithLengthCallbackHandle));
			return Trampolines.NIDAUImplementorDisplayNameWithLengthCallback.Create(block);
		}
		[Export("setImplementorDisplayNameWithLengthCallback:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAUImplementorDisplayNameWithLengthCallback))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAUImplementorDisplayNameWithLengthCallback.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImplementorDisplayNameWithLengthCallback_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImplementorDisplayNameWithLengthCallback_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual AUImplementorStringFromValueCallback ImplementorStringFromValueCallback
	{
		[Export("implementorStringFromValueCallback", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAUImplementorStringFromValueCallback))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImplementorStringFromValueCallbackHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selImplementorStringFromValueCallbackHandle));
			return Trampolines.NIDAUImplementorStringFromValueCallback.Create(block);
		}
		[Export("setImplementorStringFromValueCallback:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAUImplementorStringFromValueCallback))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAUImplementorStringFromValueCallback.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImplementorStringFromValueCallback_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImplementorStringFromValueCallback_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual AUImplementorValueFromStringCallback ImplementorValueFromStringCallback
	{
		[Export("implementorValueFromStringCallback", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAUImplementorValueFromStringCallback))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImplementorValueFromStringCallbackHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selImplementorValueFromStringCallbackHandle));
			return Trampolines.NIDAUImplementorValueFromStringCallback.Create(block);
		}
		[Export("setImplementorValueFromStringCallback:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAUImplementorValueFromStringCallback))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAUImplementorValueFromStringCallback.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImplementorValueFromStringCallback_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImplementorValueFromStringCallback_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual AUImplementorValueObserver ImplementorValueObserver
	{
		[Export("implementorValueObserver", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAUImplementorValueObserver))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImplementorValueObserverHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selImplementorValueObserverHandle));
			return Trampolines.NIDAUImplementorValueObserver.Create(block);
		}
		[Export("setImplementorValueObserver:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAUImplementorValueObserver))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAUImplementorValueObserver.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImplementorValueObserver_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImplementorValueObserver_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual AUImplementorValueProvider ImplementorValueProvider
	{
		[Export("implementorValueProvider", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAUImplementorValueProvider))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImplementorValueProviderHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selImplementorValueProviderHandle));
			return Trampolines.NIDAUImplementorValueProvider.Create(block);
		}
		[Export("setImplementorValueProvider:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAUImplementorValueProvider))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAUImplementorValueProvider.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImplementorValueProvider_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImplementorValueProvider_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string KeyPath
	{
		[Export("keyPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyPathHandle));
		}
	}

	public AUParameterObserverToken CreateTokenByAddingParameterObserver(AUParameterObserver observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		IntPtr observerToken = TokenByAddingParameterObserver(observer);
		AUParameterObserverToken result = default(AUParameterObserverToken);
		result.ObserverToken = observerToken;
		return result;
	}

	public AUParameterObserverToken CreateTokenByAddingParameterRecordingObserver(AUParameterRecordingObserver observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		IntPtr observerToken = TokenByAddingParameterRecordingObserver(observer);
		AUParameterObserverToken result = default(AUParameterObserverToken);
		result.ObserverToken = observerToken;
		return result;
	}

	public void RemoveParameterObserver(AUParameterObserverToken token)
	{
		RemoveParameterObserver(token.ObserverToken);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AUParameterNode()
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
	protected AUParameterNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AUParameterNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("displayNameWithLength:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetDisplayName(nint maximumLength)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selDisplayNameWithLength_Handle, maximumLength));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selDisplayNameWithLength_Handle, maximumLength));
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AUParameterObserverToken GetToken([BlockProxy(typeof(Trampolines.NIDAUParameterAutomationObserver))] AUParameterAutomationObserver observer)
	{
		return new AUParameterObserverToken(_GetToken(observer));
	}

	[Export("removeParameterObserver:")]
	[Obsolete("Use the 'AUParameterObserverToken' overload.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveParameterObserver(IntPtr token)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveParameterObserver_Handle, token);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveParameterObserver_Handle, token);
		}
	}

	[Export("tokenByAddingParameterObserver:")]
	[Obsolete("Use the 'CreateTokenByAddingParameterObserver' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual IntPtr TokenByAddingParameterObserver([BlockProxy(typeof(Trampolines.NIDAUParameterObserver))] AUParameterObserver observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAUParameterObserver.Handler, observer);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTokenByAddingParameterObserver_Handle, (IntPtr)ptr) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTokenByAddingParameterObserver_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}

	[Export("tokenByAddingParameterRecordingObserver:")]
	[Obsolete("Use the 'CreateTokenByAddingParameterRecordingObserver' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual IntPtr TokenByAddingParameterRecordingObserver([BlockProxy(typeof(Trampolines.NIDAUParameterRecordingObserver))] AUParameterRecordingObserver observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAUParameterRecordingObserver.Handler, observer);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTokenByAddingParameterRecordingObserver_Handle, (IntPtr)ptr) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTokenByAddingParameterRecordingObserver_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}

	[Export("tokenByAddingParameterAutomationObserver:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe virtual IntPtr _GetToken([BlockProxy(typeof(Trampolines.NIDAUParameterAutomationObserver))] AUParameterAutomationObserver observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAUParameterAutomationObserver.Handler, observer);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTokenByAddingParameterAutomationObserver_Handle, (IntPtr)ptr) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTokenByAddingParameterAutomationObserver_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}
}
