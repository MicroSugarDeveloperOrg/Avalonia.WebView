namespace SceneKit;

public delegate SCNVector3 SCNFieldForceEvaluator(SCNVector3 position, SCNVector3 velocity, float mass, float charge, double timeInSeconds);
