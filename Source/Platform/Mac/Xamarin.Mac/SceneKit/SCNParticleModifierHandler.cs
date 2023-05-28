using Xamarin.Mac.System.Mac;

namespace SceneKit;

public delegate void SCNParticleModifierHandler(IntPtr data, IntPtr dataStride, nint start, nint end, float deltaTime);
