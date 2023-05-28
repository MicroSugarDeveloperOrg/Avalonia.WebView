using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "NSCollectionViewDelegateFlowLayout", WrapperType = typeof(NSCollectionViewDelegateFlowLayoutWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SizeForItem", Selector = "collectionView:layout:sizeForItemAtIndexPath:", ReturnType = typeof(CGSize), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSCollectionViewLayout),
	typeof(NSIndexPath)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsetForSection", Selector = "collectionView:layout:insetForSectionAtIndex:", ReturnType = typeof(NSEdgeInsets), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSCollectionViewLayout),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MinimumLineSpacing", Selector = "collectionView:layout:minimumLineSpacingForSectionAtIndex:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSCollectionViewLayout),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MinimumInteritemSpacingForSection", Selector = "collectionView:layout:minimumInteritemSpacingForSectionAtIndex:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSCollectionViewLayout),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReferenceSizeForHeader", Selector = "collectionView:layout:referenceSizeForHeaderInSection:", ReturnType = typeof(CGSize), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSCollectionViewLayout),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReferenceSizeForFooter", Selector = "collectionView:layout:referenceSizeForFooterInSection:", ReturnType = typeof(CGSize), ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSCollectionViewLayout),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSCollectionViewDelegateFlowLayout : INativeObject, IDisposable, INSCollectionViewDelegate
{
}
