using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSComboBoxCellDataSource", WrapperType = typeof(NSComboBoxCellDataSourceWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ObjectValueForItem", Selector = "comboBoxCell:objectValueForItemAtIndex:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSComboBoxCell),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ItemCount", Selector = "numberOfItemsInComboBoxCell:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(NSComboBoxCell) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CompletedString", Selector = "comboBoxCell:completedString:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSComboBoxCell),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IndexOfItem", Selector = "comboBoxCell:indexOfItemWithStringValue:", ReturnType = typeof(nuint), ParameterType = new Type[]
{
	typeof(NSComboBoxCell),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface INSComboBoxCellDataSource : INativeObject, IDisposable
{
}
