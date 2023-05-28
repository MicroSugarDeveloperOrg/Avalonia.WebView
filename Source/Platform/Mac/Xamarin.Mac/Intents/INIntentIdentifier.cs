using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public enum INIntentIdentifier
{
	None = -1,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	StartAudioCall,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	StartVideoCall,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	SearchCallHistory,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	SetAudioSourceInCar,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	SetClimateSettingsInCar,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	SetDefrosterSettingsInCar,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	SetSeatSettingsInCar,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	SetProfileInCar,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	SaveProfileInCar,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	StartWorkout,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	PauseWorkout,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	EndWorkout,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	CancelWorkout,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	ResumeWorkout,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	SetRadioStation,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	SendMessage,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	SearchForMessages,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	SetMessageAttribute,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	SendPayment,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	RequestPayment,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	SearchForPhotos,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	StartPhotoPlayback,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	ListRideOptions,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	RequestRide,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	GetRideStatus
}
