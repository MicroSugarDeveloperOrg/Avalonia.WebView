using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSRuleEditorDelegate", WrapperType = typeof(NSRuleEditorDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "NumberOfChildren", Selector = "ruleEditor:numberOfChildrenForCriterion:withRowType:", ReturnType = typeof(nint), ParameterType = new Type[]
{
	typeof(NSRuleEditor),
	typeof(NSObject),
	typeof(NSRuleEditorRowType)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ChildForCriterion", Selector = "ruleEditor:child:forCriterion:withRowType:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSRuleEditor),
	typeof(nint),
	typeof(NSObject),
	typeof(NSRuleEditorRowType)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DisplayValue", Selector = "ruleEditor:displayValueForCriterion:inRow:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSRuleEditor),
	typeof(NSObject),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PredicateParts", Selector = "ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:", ReturnType = typeof(NSDictionary), ParameterType = new Type[]
{
	typeof(NSRuleEditor),
	typeof(NSObject),
	typeof(NSObject),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RowsDidChange", Selector = "ruleEditorRowsDidChange:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingEnded", Selector = "controlTextDidEndEditing:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Changed", Selector = "controlTextDidChange:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EditingBegan", Selector = "controlTextDidBeginEditing:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
public interface INSRuleEditorDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("ruleEditor:numberOfChildrenForCriterion:withRowType:")]
	[Preserve(Conditional = true)]
	nint NumberOfChildren(NSRuleEditor editor, NSObject criterion, NSRuleEditorRowType rowType);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("ruleEditor:child:forCriterion:withRowType:")]
	[Preserve(Conditional = true)]
	NSObject ChildForCriterion(NSRuleEditor editor, nint index, NSObject criterion, NSRuleEditorRowType rowType);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("ruleEditor:displayValueForCriterion:inRow:")]
	[Preserve(Conditional = true)]
	NSObject DisplayValue(NSRuleEditor editor, NSObject criterion, nint row);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("ruleEditor:predicatePartsForCriterion:withDisplayValue:inRow:")]
	[Preserve(Conditional = true)]
	NSDictionary PredicateParts(NSRuleEditor editor, NSObject criterion, NSObject value, nint row);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("ruleEditorRowsDidChange:")]
	[Preserve(Conditional = true)]
	void RowsDidChange(NSNotification notification);
}
