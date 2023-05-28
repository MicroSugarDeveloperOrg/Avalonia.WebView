using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKDecisionTree", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKDecisionTree : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportToURL_Error_ = "exportToURL:error:";

	private static readonly IntPtr selExportToURL_Error_Handle = Selector.GetHandle("exportToURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindActionForAnswers_ = "findActionForAnswers:";

	private static readonly IntPtr selFindActionForAnswers_Handle = Selector.GetHandle("findActionForAnswers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAttribute_ = "initWithAttribute:";

	private static readonly IntPtr selInitWithAttribute_Handle = Selector.GetHandle("initWithAttribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithExamples_Actions_Attributes_ = "initWithExamples:actions:attributes:";

	private static readonly IntPtr selInitWithExamples_Actions_Attributes_Handle = Selector.GetHandle("initWithExamples:actions:attributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Error_ = "initWithURL:error:";

	private static readonly IntPtr selInitWithURL_Error_Handle = Selector.GetHandle("initWithURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRandomSource = "randomSource";

	private static readonly IntPtr selRandomSourceHandle = Selector.GetHandle("randomSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRootNode = "rootNode";

	private static readonly IntPtr selRootNodeHandle = Selector.GetHandle("rootNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRandomSource_ = "setRandomSource:";

	private static readonly IntPtr selSetRandomSource_Handle = Selector.GetHandle("setRandomSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKDecisionTree");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKRandomSource RandomSource
	{
		[Export("randomSource", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GKRandomSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selRandomSourceHandle));
			}
			return Runtime.GetNSObject<GKRandomSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRandomSourceHandle));
		}
		[Export("setRandomSource:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRandomSource_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRandomSource_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKDecisionNode? RootNode
	{
		[Export("rootNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GKDecisionNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selRootNodeHandle));
			}
			return Runtime.GetNSObject<GKDecisionNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRootNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public GKDecisionTree(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKDecisionTree(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKDecisionTree(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAttribute:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKDecisionTree(NSObject attribute)
		: base(NSObjectFlag.Empty)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAttribute_Handle, attribute.Handle), "initWithAttribute:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAttribute_Handle, attribute.Handle), "initWithAttribute:");
		}
	}

	[Export("initWithExamples:actions:attributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKDecisionTree(NSArray<NSObject>[] examples, NSObject[] actions, NSObject[] attributes)
		: base(NSObjectFlag.Empty)
	{
		if (examples == null)
		{
			throw new ArgumentNullException("examples");
		}
		if (actions == null)
		{
			throw new ArgumentNullException("actions");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		NSArray nSArray = NSArray.FromNSObjects(examples);
		NSArray nSArray2 = NSArray.FromNSObjects(actions);
		NSArray nSArray3 = NSArray.FromNSObjects(attributes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithExamples_Actions_Attributes_Handle, nSArray.Handle, nSArray2.Handle, nSArray3.Handle), "initWithExamples:actions:attributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithExamples_Actions_Attributes_Handle, nSArray.Handle, nSArray2.Handle, nSArray3.Handle), "initWithExamples:actions:attributes:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		nSArray3.Dispose();
	}

	[Export("initWithURL:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKDecisionTree(NSUrl url, NSError? error)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithURL_Error_Handle, url.Handle, error?.Handle ?? IntPtr.Zero), "initWithURL:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithURL_Error_Handle, url.Handle, error?.Handle ?? IntPtr.Zero), "initWithURL:error:");
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("exportToURL:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Export(NSUrl url, NSError? error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selExportToURL_Error_Handle, url.Handle, error?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selExportToURL_Error_Handle, url.Handle, error?.Handle ?? IntPtr.Zero);
	}

	[Export("findActionForAnswers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? FindAction(NSDictionary<NSObject, NSObject> answers)
	{
		if (answers == null)
		{
			throw new ArgumentNullException("answers");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFindActionForAnswers_Handle, answers.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFindActionForAnswers_Handle, answers.Handle));
	}
}
