using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[iOS(11, 0)]
[TV(11, 0)]
[Mac(10, 13, 0, PlatformArchitecture.Arch64)]
public static class SCNAnimatableExtensions
{
	public static void AddAnimation(this ISCNAnimatable self, SCNAnimation animation, string key)
	{
		using CAAnimation animation2 = CAAnimation.FromSCNAnimation(animation);
		using NSString key2 = ((key != null) ? new NSString(key) : null);
		self.AddAnimation(animation2, key2);
	}
}
