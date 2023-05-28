using System;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "CNChangeHistoryEventVisitor", WrapperType = typeof(CNChangeHistoryEventVisitorWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DropEverything", Selector = "visitDropEverythingEvent:", ParameterType = new Type[] { typeof(CNChangeHistoryDropEverythingEvent) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddContact", Selector = "visitAddContactEvent:", ParameterType = new Type[] { typeof(CNChangeHistoryAddContactEvent) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateContact", Selector = "visitUpdateContactEvent:", ParameterType = new Type[] { typeof(CNChangeHistoryUpdateContactEvent) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DeleteContact", Selector = "visitDeleteContactEvent:", ParameterType = new Type[] { typeof(CNChangeHistoryDeleteContactEvent) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddGroup", Selector = "visitAddGroupEvent:", ParameterType = new Type[] { typeof(CNChangeHistoryAddGroupEvent) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGroup", Selector = "visitUpdateGroupEvent:", ParameterType = new Type[] { typeof(CNChangeHistoryUpdateGroupEvent) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteGroup", Selector = "visitDeleteGroupEvent:", ParameterType = new Type[] { typeof(CNChangeHistoryDeleteGroupEvent) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddMemberToGroup", Selector = "visitAddMemberToGroupEvent:", ParameterType = new Type[] { typeof(CNChangeHistoryAddMemberToGroupEvent) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveMemberFromGroup", Selector = "visitRemoveMemberFromGroupEvent:", ParameterType = new Type[] { typeof(CNChangeHistoryRemoveMemberFromGroupEvent) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddSubgroupToGroup", Selector = "visitAddSubgroupToGroupEvent:", ParameterType = new Type[] { typeof(CNChangeHistoryAddSubgroupToGroupEvent) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveSubgroupFromGroup", Selector = "visitRemoveSubgroupFromGroupEvent:", ParameterType = new Type[] { typeof(CNChangeHistoryRemoveSubgroupFromGroupEvent) }, ParameterByRef = new bool[] { false })]
public interface ICNChangeHistoryEventVisitor : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("visitDropEverythingEvent:")]
	[Preserve(Conditional = true)]
	void DropEverything(CNChangeHistoryDropEverythingEvent @event);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("visitAddContactEvent:")]
	[Preserve(Conditional = true)]
	void AddContact(CNChangeHistoryAddContactEvent @event);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("visitUpdateContactEvent:")]
	[Preserve(Conditional = true)]
	void UpdateContact(CNChangeHistoryUpdateContactEvent @event);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("visitDeleteContactEvent:")]
	[Preserve(Conditional = true)]
	void DeleteContact(CNChangeHistoryDeleteContactEvent @event);
}
