using System;

namespace Darwin;

[Flags]
public enum FilterFlags : uint
{
	ReadPoll = 0x1000u,
	ReadOutOfBand = 0x2000u,
	ReadLowWaterMark = 1u,
	WriteLowWaterMark = 1u,
	NoteTrigger = 0x1000000u,
	NoteFFNop = 0u,
	NoteFFAnd = 0x40000000u,
	NoteFFOr = 0x80000000u,
	NoteFFCopy = 0xC0000000u,
	NoteFFCtrlMask = 0xC0000000u,
	NoteFFlagsMask = 0xFFFFFFu,
	VNodeDelete = 1u,
	VNodeWrite = 2u,
	VNodeExtend = 4u,
	VNodeAttrib = 8u,
	VNodeLink = 0x10u,
	VNodeRename = 0x20u,
	VNodeRevoke = 0x40u,
	VNodeNone = 0x80u,
	ProcExit = 0x80000000u,
	ProcFork = 0x40000000u,
	ProcExec = 0x20000000u,
	ProcReap = 0x10000000u,
	ProcSignal = 0x8000000u,
	ProcExitStatus = 0x4000000u,
	ProcResourceEnd = 0x2000000u,
	ProcAppactive = 0x800000u,
	ProcAppBackground = 0x400000u,
	ProcAppNonUI = 0x200000u,
	ProcAppInactive = 0x100000u,
	ProcAppAllStates = 0xF00000u,
	ProcPDataMask = 0xFFFFFu,
	ProcControlMask = 0xFFF00000u,
	VMPressure = 0x80000000u,
	VMPressureTerminate = 0x40000000u,
	VMPressureSuddenTerminate = 0x20000000u,
	VMError = 0x10000000u,
	TimerSeconds = 1u,
	TimerMicroSeconds = 2u,
	TimerNanoSeconds = 4u,
	TimerAbsolute = 8u
}
