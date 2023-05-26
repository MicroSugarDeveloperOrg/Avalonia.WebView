namespace Darwin;

public enum EventFilter : short
{
	Read = -1,
	Write = -2,
	Aio = -3,
	Vnode = -4,
	Proc = -5,
	Signal = -6,
	Timer = -7,
	MachPort = -8,
	FS = -9,
	User = -10,
	VM = -11
}
