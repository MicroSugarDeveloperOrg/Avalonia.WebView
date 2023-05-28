using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSFilePresenter", WrapperType = typeof(NSFilePresenterWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RelinquishPresentedItemToReader", Selector = "relinquishPresentedItemToReader:", ParameterType = new Type[] { typeof(NSFilePresenterReacquirer) }, ParameterByRef = new bool[] { false }, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDNSFilePresenterReacquirer) })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RelinquishPresentedItemToWriter", Selector = "relinquishPresentedItemToWriter:", ParameterType = new Type[] { typeof(NSFilePresenterReacquirer) }, ParameterByRef = new bool[] { false }, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDNSFilePresenterReacquirer) })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SavePresentedItemChanges", Selector = "savePresentedItemChangesWithCompletionHandler:", ParameterType = new Type[] { typeof(Action<NSError>) }, ParameterByRef = new bool[] { false }, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDActionArity1V11) })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AccommodatePresentedItemDeletion", Selector = "accommodatePresentedItemDeletionWithCompletionHandler:", ParameterType = new Type[] { typeof(Action<NSError>) }, ParameterByRef = new bool[] { false }, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDActionArity1V11) })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemMoved", Selector = "presentedItemDidMoveToURL:", ParameterType = new Type[] { typeof(NSUrl) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemChanged", Selector = "presentedItemDidChange")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemGainedVersion", Selector = "presentedItemDidGainVersion:", ParameterType = new Type[] { typeof(NSFileVersion) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemLostVersion", Selector = "presentedItemDidLoseVersion:", ParameterType = new Type[] { typeof(NSFileVersion) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemResolveConflictVersion", Selector = "presentedItemDidResolveConflictVersion:", ParameterType = new Type[] { typeof(NSFileVersion) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AccommodatePresentedSubitemDeletion", Selector = "accommodatePresentedSubitemDeletionAtURL:completionHandler:", ParameterType = new Type[]
{
	typeof(NSUrl),
	typeof(Action<NSError>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V11)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemAppeared", Selector = "presentedSubitemDidAppearAtURL:", ParameterType = new Type[] { typeof(NSUrl) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemMoved", Selector = "presentedSubitemAtURL:didMoveToURL:", ParameterType = new Type[]
{
	typeof(NSUrl),
	typeof(NSUrl)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemChanged", Selector = "presentedSubitemDidChangeAtURL:", ParameterType = new Type[] { typeof(NSUrl) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemGainedVersion", Selector = "presentedSubitemAtURL:didGainVersion:", ParameterType = new Type[]
{
	typeof(NSUrl),
	typeof(NSFileVersion)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemLostVersion", Selector = "presentedSubitemAtURL:didLoseVersion:", ParameterType = new Type[]
{
	typeof(NSUrl),
	typeof(NSFileVersion)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedSubitemResolvedConflictVersion", Selector = "presentedSubitemAtURL:didResolveConflictVersion:", ParameterType = new Type[]
{
	typeof(NSUrl),
	typeof(NSFileVersion)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentedItemChangedUbiquityAttributes", Selector = "presentedItemDidChangeUbiquityAttributes:", ParameterType = new Type[] { typeof(NSSet<NSString>) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PresentedItemURL", Selector = "presentedItemURL", PropertyType = typeof(NSUrl), GetterSelector = "presentedItemURL", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PesentedItemOperationQueue", Selector = "presentedItemOperationQueue", PropertyType = typeof(NSOperationQueue), GetterSelector = "presentedItemOperationQueue", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PresentedItemObservedUbiquityAttributes", Selector = "observedPresentedItemUbiquityAttributes", PropertyType = typeof(NSSet<NSString>), GetterSelector = "observedPresentedItemUbiquityAttributes", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PrimaryPresentedItemUrl", Selector = "primaryPresentedItemURL", PropertyType = typeof(NSUrl), GetterSelector = "primaryPresentedItemURL", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSFilePresenter : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	NSUrl PresentedItemURL
	{
		[Export("presentedItemURL", ArgumentSemantic.Retain)]
		get;
	}

	[Preserve(Conditional = true)]
	NSOperationQueue PesentedItemOperationQueue
	{
		[Export("presentedItemOperationQueue", ArgumentSemantic.Retain)]
		get;
	}
}
