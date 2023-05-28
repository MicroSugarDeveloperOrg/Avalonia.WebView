using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSComboBoxDataSource", WrapperType = typeof(NSComboBoxDataSourceWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ObjectValueForItem", Selector = "comboBox:objectValueForItemAtIndex:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSComboBox),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemCount", Selector = "numberOfItemsInComboBox:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(NSComboBox) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CompletedString", Selector = "comboBox:completedString:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSComboBox),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IndexOfItem", Selector = "comboBox:indexOfItemWithStringValue:", ReturnType = typeof(nint), ParameterType = new Type[]
{
	typeof(NSComboBox),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface INSComboBoxDataSource : INativeObject, IDisposable
{
}
