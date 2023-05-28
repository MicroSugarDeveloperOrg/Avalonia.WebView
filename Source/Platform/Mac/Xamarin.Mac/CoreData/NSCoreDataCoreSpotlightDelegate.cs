using System;
using System.ComponentModel;
using CoreSpotlight;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSCoreDataCoreSpotlightDelegate", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class NSCoreDataCoreSpotlightDelegate : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeSetForObject_ = "attributeSetForObject:";

	private static readonly IntPtr selAttributeSetForObject_Handle = Selector.GetHandle("attributeSetForObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDomainIdentifier = "domainIdentifier";

	private static readonly IntPtr selDomainIdentifierHandle = Selector.GetHandle("domainIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexName = "indexName";

	private static readonly IntPtr selIndexNameHandle = Selector.GetHandle("indexName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitForStoreWithDescription_Model_ = "initForStoreWithDescription:model:";

	private static readonly IntPtr selInitForStoreWithDescription_Model_Handle = Selector.GetHandle("initForStoreWithDescription:model:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchableIndex_ReindexAllSearchableItemsWithAcknowledgementHandler_ = "searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:";

	private static readonly IntPtr selSearchableIndex_ReindexAllSearchableItemsWithAcknowledgementHandler_Handle = Selector.GetHandle("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchableIndex_ReindexSearchableItemsWithIdentifiers_AcknowledgementHandler_ = "searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:";

	private static readonly IntPtr selSearchableIndex_ReindexSearchableItemsWithIdentifiers_AcknowledgementHandler_Handle = Selector.GetHandle("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCoreDataCoreSpotlightDelegate");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DomainIdentifier
	{
		[Export("domainIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDomainIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDomainIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? IndexName
	{
		[Export("indexName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCoreDataCoreSpotlightDelegate()
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
	protected NSCoreDataCoreSpotlightDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCoreDataCoreSpotlightDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initForStoreWithDescription:model:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCoreDataCoreSpotlightDelegate(NSPersistentStoreDescription description, NSManagedObjectModel model)
		: base(NSObjectFlag.Empty)
	{
		if (description == null)
		{
			throw new ArgumentNullException("description");
		}
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitForStoreWithDescription_Model_Handle, description.Handle, model.Handle), "initForStoreWithDescription:model:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitForStoreWithDescription_Model_Handle, description.Handle, model.Handle), "initForStoreWithDescription:model:");
		}
	}

	[Export("attributeSetForObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CSSearchableItemAttributeSet? GetAttributeSet(NSManagedObject @object)
	{
		if (@object == null)
		{
			throw new ArgumentNullException("@object");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CSSearchableItemAttributeSet>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeSetForObject_Handle, @object.Handle));
		}
		return Runtime.GetNSObject<CSSearchableItemAttributeSet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeSetForObject_Handle, @object.Handle));
	}

	[Export("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:")]
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
