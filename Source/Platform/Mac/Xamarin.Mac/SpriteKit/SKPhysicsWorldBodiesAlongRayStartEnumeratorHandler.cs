using CoreGraphics;

namespace SpriteKit;

public delegate void SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler(SKPhysicsBody body, CGPoint point, CGVector normal, out bool stop);
