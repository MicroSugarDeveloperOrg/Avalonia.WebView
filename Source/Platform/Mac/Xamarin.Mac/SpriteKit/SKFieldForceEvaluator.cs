using OpenTK;

namespace SpriteKit;

public delegate Vector3 SKFieldForceEvaluator(Vector4 position, Vector4 velocity, float mass, float charge, double time);
