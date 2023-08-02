using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QuartzComposer;

[Register("QCCompositionRepository", true)]
public class QCCompositionRepository : NSObject
{
	private static readonly IntPtr selSharedCompositionRepositoryHandle = Selector.GetHandle("sharedCompositionRepository");

	private static readonly IntPtr selAllCompositionsHandle = Selector.GetHandle("allCompositions");

	private static readonly IntPtr selCompositionWithIdentifier_Handle = Selector.GetHandle("compositionWithIdentifier:");

	private static readonly IntPtr selCompositionsWithProtocolsAndAttributes_Handle = Selector.GetHandle("compositionsWithProtocols:andAttributes:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QCCompositionRepository");

	private static object __mt_SharedCompositionRepository_var_static;

	private object __mt_AllCompositions_var;

	public override IntPtr ClassHandle => class_ptr;

	public static QCCompositionRepository SharedCompositionRepository
	{
		[Export("sharedCompositionRepository")]
		get
		{
			return (QCCompositionRepository)(__mt_SharedCompositionRepository_var_static = (QCCompositionRepository)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedCompositionRepositoryHandle)));
		}
	}

	public virtual QCComposition[] AllCompositions
	{
		[Export("allCompositions")]
		get
		{
			return (QCComposition[])(__mt_AllCompositions_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<QCComposition>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllCompositionsHandle)) : NSArray.ArrayFromHandle<QCComposition>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllCompositionsHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QCCompositionRepository(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QCCompositionRepository(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QCCompositionRepository(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compositionWithIdentifier:")]
	public virtual QCComposition GetComposition(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		QCComposition result = ((!IsDirectBinding) ? ((QCComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompositionWithIdentifier_Handle, arg))) : ((QCComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCompositionWithIdentifier_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("compositionsWithProtocols:andAttributes:")]
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
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<QCComposition>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCompositionsWithProtocolsAndAttributes_Handle, protocols.Handle, attributes.Handle));
		}
		return NSArray.ArrayFromHandle<QCComposition>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCompositionsWithProtocolsAndAttributes_Handle, protocols.Handle, attributes.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AllCompositions_var = null;
		}
	}
}
