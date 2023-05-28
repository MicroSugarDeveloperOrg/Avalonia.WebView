using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSFetchRequestExpression", true)]
public class NSFetchRequestExpression : NSExpression
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContextExpression = "contextExpression";

	private static readonly IntPtr selContextExpressionHandle = Selector.GetHandle("contextExpression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpressionForFetch_Context_CountOnly_ = "expressionForFetch:context:countOnly:";

	private static readonly IntPtr selExpressionForFetch_Context_CountOnly_Handle = Selector.GetHandle("expressionForFetch:context:countOnly:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithExpressionType_ = "initWithExpressionType:";

	private static readonly IntPtr selInitWithExpressionType_Handle = Selector.GetHandle("initWithExpressionType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCountOnlyRequest = "isCountOnlyRequest";

	private static readonly IntPtr selIsCountOnlyRequestHandle = Selector.GetHandle("isCountOnlyRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestExpression = "requestExpression";

	private static readonly IntPtr selRequestExpressionHandle = Selector.GetHandle("requestExpression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFetchRequestExpression");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSExpression Context
	{
		[Export("contextExpression")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selContextExpressionHandle));
			}
			return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContextExpressionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsCountOnly
	{
		[Export("isCountOnlyRequest")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCountOnlyRequestHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCountOnlyRequestHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSExpression Request
	{
		[Export("requestExpression")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestExpressionHandle));
			}
			return Runtime.GetNSObject<NSExpression>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestExpressionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFetchRequestExpression(NSCoder coder)
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
	protected NSFetchRequestExpression(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFetchRequestExpression(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithExpressionType:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSFetchRequestExpression(NSExpressionType type)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithExpressionType_Handle, (ulong)type), "initWithExpressionType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithExpressionType_Handle, (ulong)type), "initWithExpressionType:");
		}
	}

	[Export("expressionForFetch:context:countOnly:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFetchRequestExpression FromFetch(NSExpression fetch, NSExpression context, bool countOnly)
	{
		if (fetch == null)
		{
			throw new ArgumentNullException("fetch");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		return Runtime.GetNSObject<NSFetchRequestExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(class_ptr, selExpressionForFetch_Context_CountOnly_Handle, fetch.Handle, context.Handle, countOnly));
	}
}
