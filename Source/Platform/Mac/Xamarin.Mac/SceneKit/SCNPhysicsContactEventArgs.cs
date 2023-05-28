using System;

namespace SceneKit;

public class SCNPhysicsContactEventArgs : EventArgs
{
	public SCNPhysicsContact Contact { get; set; }

	public SCNPhysicsContactEventArgs(SCNPhysicsContact contact)
	{
		Contact = contact;
	}
}
