using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QuartzComposer;

[Register("QCCompositionRepository", true)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
public class QCCompositionRepository : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllCompositions = "allCompositions";

	private static readonly IntPtr selAllCompositionsHandle = Selector.GetHandle("allCompositions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositionWithIdentifier_ = "compositionWithIdentifier:";

	private static readonly IntPtr selCompositionWithIdentifier_Handle = Selector.GetHandle("compositionWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositionsWithProtocols_AndAttributes_ = "compositionsWithProtocols:andAttributes:";

	private static readonly IntPtr selCompositionsWithProtocols_AndAttributes_Handle = Selector.GetHandle("compositionsWithProtocols:andAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedCompositionRepository = "sharedCompositionRepository";

	private static readonly IntPtr selSharedCompositionRepositoryHandle = Selector.GetHandle("sharedCompositionRepository");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QCCompositionRepository");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QCComposition[] AllCompositions
	{
		[Export("allCompositions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<QCComposition>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllCompositionsHandle));
			}
			return NSArray.ArrayFromHandle<QCComposition>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllCompositionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QCCompositionRepository SharedCompositionRepository
	{
		[Export("sharedCompositionRepository")]
		get
		{
			return Runtime.GetNSObject<QCCompositionRepository>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedCompositionRepositoryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QCCompositionRepository(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QCCompositionRepository(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compositionWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QCComposition GetComposition(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		QCComposition result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<QCComposition>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompositionWithIdentifier_Handle, arg)) : Runtime.GetNSObject<QCComposition>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCompositionWithIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("compositionsWithProtocols:andAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QCComposition[] GetCompositions(NSArray protocols, NSDictionary attributes)
	{
		if (protocols == null)
		{
			throw new ArgumentNullException("protocols");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<QCComposition>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCompositionsWithProtocols_AndAttributes_Handle, protocols.Handle, attributes.Handle));
		}
		return NSArray.ArrayFromHandle<QCComposition>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCompositionsWithProtocols_AndAttributes_Handle, protocols.Handle, attributes.Handle));
	}
}
