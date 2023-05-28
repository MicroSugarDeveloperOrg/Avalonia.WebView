using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSScrubberDataSource", WrapperType = typeof(NSScrubberDataSourceWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNumberOfItems", Selector = "numberOfItemsForScrubber:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(NSScrubber) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewForItem", Selector = "scrubber:viewForItemAtIndex:", ReturnType = typeof(NSScrubberItemView), ParameterType = new Type[]
{
	typeof(NSScrubber),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
public interface INSScrubberDataSource : INativeObject, IDisposable
{
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("numberOfItemsForScrubber:")]
	[Preserve(Conditional = true)]
	nint GetNumberOfItems(NSScrubber scrubber);

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("scrubber:viewForItemAtIndex:")]
	[Preserve(Conditional = true)]
	NSScrubberItemView GetViewForItem(NSScrubber scrubber, nint index);
}
