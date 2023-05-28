using Xamarin.Mac.System.Mac;

namespace SceneKit;

public delegate void SCNParticleEventHandler(IntPtr data, IntPtr dataStride, IntPtr indices, nint count);
