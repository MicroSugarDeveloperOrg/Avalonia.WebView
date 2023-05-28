using System;

namespace CoreServices;

[Flags]
public enum FSEventStreamEventFlags : uint
{
	None = 0u,
	MustScanSubDirs = 1u,
	UserDropped = 2u,
	KernelDropped = 4u,
	EventIdsWrapped = 8u,
	HistoryDone = 0x10u,
	RootChanged = 0x20u,
	Mount = 0x40u,
	Unmount = 0x80u,
	ItemCreated = 0x100u,
	ItemRemoved = 0x200u,
	ItemInodeMetaMod = 0x400u,
	ItemRenamed = 0x800u,
	ItemModified = 0x1000u,
	ItemFinderInfoMod = 0x2000u,
	ItemChangeOwner = 0x4000u,
	ItemXattrMod = 0x8000u,
	ItemIsFile = 0x10000u,
	ItemIsDir = 0x20000u,
	ItemIsSymlink = 0x40000u,
	OwnEvent = 0x80000u,
	ItemIsHardlink = 0x100000u,
	ItemIsLastHardlink = 0x200000u,
	[Mac(10, 14)]
	ItemCloned = 0x400000u
}
