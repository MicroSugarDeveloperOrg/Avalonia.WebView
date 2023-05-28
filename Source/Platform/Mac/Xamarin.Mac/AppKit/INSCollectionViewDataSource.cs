using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSCollectionViewDataSource", WrapperType = typeof(NSCollectionViewDataSourceWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNumberofItems", Selector = "collectionView:numberOfItemsInSection:", ReturnType = typeof(nint), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItem", Selector = "collectionView:itemForRepresentedObjectAtIndexPath:", ReturnType = typeof(NSCollectionViewItem), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSIndexPath)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNumberOfSections", Selector = "numberOfSectionsInCollectionView:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(NSCollectionView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetView", Selector = "collectionView:viewForSupplementaryElementOfKind:atIndexPath:", ReturnType = typeof(NSView), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSString),
	typeof(NSIndexPath)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSCollectionViewDataSource : INativeObject, IDisposable
{
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("collectionView:numberOfItemsInSection:")]
	[Preserve(Conditional = true)]
	nint GetNumberofItems(NSCollectionView collectionView, nint section);

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("collectionView:itemForRepresentedObjectAtIndexPath:")]
	[Preserve(Conditional = true)]
	NSCollectionViewItem GetItem(NSCollectionView collectionView, NSIndexPath indexPath);
}
