using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Protocol(Name = "SCNAnimation", WrapperType = typeof(SCNAnimationProtocolWrapper))]
public interface ISCNAnimationProtocol : INativeObject, IDisposable
{
}
