using Foundation;

namespace Metal;

[Advice("The 'NSString' argument will match a property of 'MTLDeviceNotificationHandler'.")]
public delegate void MTLDeviceNotificationHandler(IMTLDevice device, NSString notifyName);
