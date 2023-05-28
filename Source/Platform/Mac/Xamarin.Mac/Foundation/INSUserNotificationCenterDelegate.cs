using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSUserNotificationCenterDelegate", WrapperType = typeof(NSUserNotificationCenterDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDeliverNotification", Selector = "userNotificationCenter:didDeliverNotification:", ParameterType = new Type[]
{
	typeof(NSUserNotificationCenter),
	typeof(NSUserNotification)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidActivateNotification", Selector = "userNotificationCenter:didActivateNotification:", ParameterType = new Type[]
{
	typeof(NSUserNotificationCenter),
	typeof(NSUserNotification)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPresentNotification", Selector = "userNotificationCenter:shouldPresentNotification:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSUserNotificationCenter),
	typeof(NSUserNotification)
}, ParameterByRef = new bool[] { false, false })]
public interface INSUserNotificationCenterDelegate : INativeObject, IDisposable
{
}
