using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSFileManagerDelegate", WrapperType = typeof(NSFileManagerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldCopyItemAtPath", Selector = "fileManager:shouldCopyItemAtPath:toPath:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSFileManager),
	typeof(NSString),
	typeof(NSString)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorCopyingItem", Selector = "fileManager:shouldProceedAfterError:copyingItemAtPath:toPath:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSFileManager),
	typeof(NSError),
	typeof(string),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldMoveItemAtPath", Selector = "fileManager:shouldMoveItemAtPath:toPath:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSFileManager),
	typeof(string),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorMovingItem", Selector = "fileManager:shouldProceedAfterError:movingItemAtPath:toPath:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSFileManager),
	typeof(NSError),
	typeof(string),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldLinkItemAtPath", Selector = "fileManager:shouldLinkItemAtPath:toPath:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSFileManager),
	typeof(string),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorLinkingItem", Selector = "fileManager:shouldProceedAfterError:linkingItemAtPath:toPath:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSFileManager),
	typeof(NSError),
	typeof(string),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRemoveItemAtPath", Selector = "fileManager:shouldRemoveItemAtPath:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSFileManager),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorRemovingItem", Selector = "fileManager:shouldProceedAfterError:removingItemAtPath:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSFileManager),
	typeof(NSError),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSFileManagerDelegate : INativeObject, IDisposable
{
}
