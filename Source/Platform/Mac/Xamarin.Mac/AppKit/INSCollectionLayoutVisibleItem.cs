using AddressBook;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "NSCollectionLayoutVisibleItem", WrapperType = typeof(NSCollectionLayoutVisibleItemWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Alpha", Selector = "alpha", PropertyType = typeof(nfloat), GetterSelector = "alpha", SetterSelector = "setAlpha:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ZIndex", Selector = "zIndex", PropertyType = typeof(nint), GetterSelector = "zIndex", SetterSelector = "setZIndex:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Hidden", Selector = "hidden", PropertyType = typeof(bool), GetterSelector = "isHidden", SetterSelector = "setHidden:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Center", Selector = "center", PropertyType = typeof(CGPoint), GetterSelector = "center", SetterSelector = "setCenter:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof(string), GetterSelector = "name", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "IndexPath", Selector = "indexPath", PropertyType = typeof(NSIndexPath), GetterSelector = "indexPath", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Frame", Selector = "frame", PropertyType = typeof(CGRect), GetterSelector = "frame", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Bounds", Selector = "bounds", PropertyType = typeof(CGRect), GetterSelector = "bounds", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RepresentedElementCategory", Selector = "representedElementCategory", PropertyType = typeof(NSCollectionElementCategory), GetterSelector = "representedElementCategory", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RepresentedElementKind", Selector = "representedElementKind", PropertyType = typeof(string), GetterSelector = "representedElementKind", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSCollectionLayoutVisibleItem : INativeObject, IDisposable
{
    [Preserve(Conditional = true)]
    nfloat Alpha
    {
        [Export("alpha")]
        get;
        [Export("setAlpha:")]
        set;
    }

    [Preserve(Conditional = true)]
    nint ZIndex
    {
        [Export("zIndex")]
        get;
        [Export("setZIndex:")]
        set;
    }

    [Preserve(Conditional = true)]
    bool Hidden
    {
        [Export("isHidden")]
        get;
        [Export("setHidden:")]
        set;
    }

    [Preserve(Conditional = true)]
    CGPoint Center
    {
        [Export("center", ArgumentSemantic.Assign)]
        get;
        [Export("setCenter:", ArgumentSemantic.Assign)]
        set;
    }

    [Preserve(Conditional = true)]
    string Name
    {
        [Export("name")]
        get;
    }

    [Preserve(Conditional = true)]
    NSIndexPath IndexPath
    {
        [Export("indexPath")]
        get;
    }

    [Preserve(Conditional = true)]
    CGRect Frame
    {
        [Export("frame")]
        get;
    }

    [Preserve(Conditional = true)]
    CGRect Bounds
    {
        [Export("bounds")]
        get;
    }

    [Preserve(Conditional = true)]
    NSCollectionElementCategory RepresentedElementCategory
    {
        [Export("representedElementCategory")]
        get;
    }

    [Preserve(Conditional = true)]
    string? RepresentedElementKind
    {
        [Export("representedElementKind")]
        get;
    }
}