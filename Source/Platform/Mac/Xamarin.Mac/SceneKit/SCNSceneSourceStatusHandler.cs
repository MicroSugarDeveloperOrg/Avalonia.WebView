using Foundation;

namespace SceneKit;

public delegate void SCNSceneSourceStatusHandler(float totalProgress, SCNSceneSourceStatus status, NSError error, ref bool stopLoading);
