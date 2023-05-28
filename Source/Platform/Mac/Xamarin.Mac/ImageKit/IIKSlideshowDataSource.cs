using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Protocol(Name = "IKSlideshowDataSource", WrapperType = typeof(IKSlideshowDataSourceWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItemAt", Selector = "slideshowItemAtIndex:", ReturnType = typeof(NSObject), ParameterType = new Type[] { typeof(nint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNameOfItemAt", Selector = "nameOfSlideshowItemAtIndex:", ReturnType = typeof(string), ParameterType = new Type[] { typeof(nint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanExportItemToApplication", Selector = "canExportSlideshowItemAtIndex:toApplication:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(nint),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStart", Selector = "slideshowWillStart")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStop", Selector = "slideshowDidStop")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChange", Selector = "slideshowDidChangeCurrentIndex:", ParameterType = new Type[] { typeof(nint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ItemCount", Selector = "numberOfSlideshowItems", PropertyType = typeof(nint), GetterSelector = "numberOfSlideshowItems", ArgumentSemantic = ArgumentSemantic.None)]
public interface IIKSlideshowDataSource : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	nint ItemCount
	{
		[Export("numberOfSlideshowItems")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("slideshowItemAtIndex:")]
	[Preserve(Conditional = true)]
	NSObject GetItemAt(nint index);
}
