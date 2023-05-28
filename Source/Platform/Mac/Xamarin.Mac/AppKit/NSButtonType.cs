using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSButtonType : ulong
{
	MomentaryLightButton,
	PushOnPushOff,
	Toggle,
	Switch,
	Radio,
	MomentaryChange,
	OnOff,
	MomentaryPushIn,
	Accelerator,
	MultiLevelAccelerator
}
