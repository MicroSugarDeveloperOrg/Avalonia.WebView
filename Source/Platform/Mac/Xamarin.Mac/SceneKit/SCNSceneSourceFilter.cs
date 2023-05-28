using Foundation;

namespace SceneKit;

public delegate bool SCNSceneSourceFilter(NSObject entry, NSString identifier, ref bool stop);
