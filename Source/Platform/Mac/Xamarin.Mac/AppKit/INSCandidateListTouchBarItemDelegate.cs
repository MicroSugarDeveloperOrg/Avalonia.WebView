using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSCandidateListTouchBarItemDelegate", WrapperType = typeof(NSCandidateListTouchBarItemDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeginSelectingCandidate", Selector = "candidateListTouchBarItem:beginSelectingCandidateAtIndex:", ParameterType = new Type[]
{
	typeof(NSCandidateListTouchBarItem),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangeSelectionFromCandidate", Selector = "candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:", ParameterType = new Type[]
{
	typeof(NSCandidateListTouchBarItem),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndSelectingCandidate", Selector = "candidateListTouchBarItem:endSelectingCandidateAtIndex:", ParameterType = new Type[]
{
	typeof(NSCandidateListTouchBarItem),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangedCandidateListVisibility", Selector = "candidateListTouchBarItem:changedCandidateListVisibility:", ParameterType = new Type[]
{
	typeof(NSCandidateListTouchBarItem),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
public interface INSCandidateListTouchBarItemDelegate : INativeObject, IDisposable
{
}
