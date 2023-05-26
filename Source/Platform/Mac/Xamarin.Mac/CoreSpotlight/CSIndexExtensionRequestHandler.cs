using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreSpotlight;

[Register("CSIndexExtensionRequestHandler", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class CSIndexExtensionRequestHandler : NSObject, ICSSearchableIndexDelegate, INativeObject, IDisposable, INSExtensionRequestHandling
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginRequestWithExtensionContext_ = "beginRequestWithExtensionContext:";

	private static readonly IntPtr selBeginRequestWithExtensionContext_Handle = Selector.GetHandle("beginRequestWithExtensionContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataForSearchableIndex_ItemIdentifier_TypeIdentifier_Error_ = "dataForSearchableIndex:itemIdentifier:typeIdentifier:error:";

	private static readonly IntPtr selDataForSearchableIndex_ItemIdentifier_TypeIdentifier_Error_Handle = Selector.GetHandle("dataForSearchableIndex:itemIdentifier:typeIdentifier:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileURLForSearchableIndex_ItemIdentifier_TypeIdentifier_InPlace_Error_ = "fileURLForSearchableIndex:itemIdentifier:typeIdentifier:inPlace:error:";

	private static readonly IntPtr selFileURLForSearchableIndex_ItemIdentifier_TypeIdentifier_InPlace_Error_Handle = Selector.GetHandle("fileURLForSearchableIndex:itemIdentifier:typeIdentifier:inPlace:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchableIndex_ReindexAllSearchableItemsWithAcknowledgementHandler_ = "searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:";

	private static readonly IntPtr selSearchableIndex_ReindexAllSearchableItemsWithAcknowledgementHandler_Handle = Selector.GetHandle("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchableIndex_ReindexSearchableItemsWithIdentifiers_AcknowledgementHandler_ = "searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:";

	private static readonly IntPtr selSearchableIndex_ReindexSearchableItemsWithIdentifiers_AcknowledgementHandler_Handle = Selector.GetHandle("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchableIndexDidFinishThrottle_ = "searchableIndexDidFinishThrottle:";

	private static readonly IntPtr selSearchableIndexDidFinishThrottle_Handle = Selector.GetHandle("searchableIndexDidFinishThrottle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchableIndexDidThrottle_ = "searchableIndexDidThrottle:";

	private static readonly IntPtr selSearchableIndexDidThrottle_Handle = Selector.GetHandle("searchableIndexDidThrottle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CSIndexExtensionRequestHandler");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CSIndexExtensionRequestHandler()
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
	protected CSIndexExtensionRequestHandler(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CSIndexExtensionRequestHandler(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginRequestWithExtensionContext:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginRequestWithExtensionContext(NSExtensionContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBeginRequestWithExtensionContext_Handle, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBeginRequestWithExtensionContext_Handle, context.Handle);
		}
	}

	[Export("searchableIndexDidFinishThrottle:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishThrottle(CSSearchableIndex searchableIndex)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSearchableIndexDidFinishThrottle_Handle, searchableIndex.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSearchableIndexDidFinishThrottle_Handle, searchableIndex.Handle);
		}
	}

	[Export("searchableIndexDidThrottle:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidThrottle(CSSearchableIndex searchableIndex)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSearchableIndexDidThrottle_Handle, searchableIndex.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSearchableIndexDidThrottle_Handle, searchableIndex.Handle);
		}
	}

	[Export("dataForSearchableIndex:itemIdentifier:typeIdentifier:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetData(CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, out NSError outError)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(itemIdentifier);
		IntPtr arg3 = NSString.CreateNative(typeIdentifier);
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selDataForSearchableIndex_ItemIdentifier_TypeIdentifier_Error_Handle, searchableIndex.Handle, arg2, arg3, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selDataForSearchableIndex_ItemIdentifier_TypeIdentifier_Error_Handle, searchableIndex.Handle, arg2, arg3, ref arg)));
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("fileURLForSearchableIndex:itemIdentifier:typeIdentifier:inPlace:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? GetFileUrl(CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, bool inPlace, out NSError outError)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(itemIdentifier);
		IntPtr arg3 = NSString.CreateNative(typeIdentifier);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_ref_IntPtr(base.SuperHandle, selFileURLForSearchableIndex_ItemIdentifier_TypeIdentifier_InPlace_Error_Handle, searchableIndex.Handle, arg2, arg3, inPlace, ref arg)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_ref_IntPtr(base.Handle, selFileURLForSearchableIndex_ItemIdentifier_TypeIdentifier_InPlace_Error_Handle, searchableIndex.Handle, arg2, arg3, inPlace, ref arg)));
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReindexAllSearchableItems(CSSearchableIndex searchableIndex, [BlockProxy(typeof(Trampolines.NIDAction))] Action acknowledgementHandler)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		if (acknowledgementHandler == null)
		{
			throw new ArgumentNullException("acknowledgementHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, acknowledgementHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSearchableIndex_ReindexAllSearchableItemsWithAcknowledgementHandler_Handle, searchableIndex.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSearchableIndex_ReindexAllSearchableItemsWithAcknowledgementHandler_Handle, searchableIndex.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReindexSearchableItems(CSSearchableIndex searchableIndex, string[] identifiers, [BlockProxy(typeof(Trampolines.NIDAction))] Action acknowledgementHandler)
	{
		if (searchableIndex == null)
		{
			throw new ArgumentNullException("searchableIndex");
		}
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		if (acknowledgementHandler == null)
		{
			throw new ArgumentNullException("acknowledgementHandler");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, acknowledgementHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSearchableIndex_ReindexSearchableItemsWithIdentifiers_AcknowledgementHandler_Handle, searchableIndex.Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSearchableIndex_ReindexSearchableItemsWithIdentifiers_AcknowledgementHandler_Handle, searchableIndex.Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}
}
