using Foundation;

namespace SceneKit;

public delegate void SCNSceneExportProgressHandler(float totalProgress, NSError error, out bool stop);
