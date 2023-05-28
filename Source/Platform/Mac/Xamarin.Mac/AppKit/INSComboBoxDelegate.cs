using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSComboBoxDelegate", WrapperType = typeof(NSComboBoxDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPopUp", Selector = "comboBoxWillPopUp:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismiss", Selector = "comboBoxWillDismiss:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionChanged", Selector = "comboBoxSelectionDidChange:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionIsChanging", Selector = "comboBoxSelectionIsChanging:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
public interface INSComboBoxDelegate : INativeObject, IDisposable, INSTextFieldDelegate
{
}
