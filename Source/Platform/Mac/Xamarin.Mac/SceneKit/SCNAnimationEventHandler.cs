using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Mac(10, 9)]
[iOS(8, 0)]
[Watch(4, 0)]
public delegate void SCNAnimationEventHandler(CAAnimation animation, NSObject animatedObject, bool playingBackward);
