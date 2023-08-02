using System;

namespace CoreFoundation;

[Flags]
public enum CFSocketFlags
{
	AutomaticallyReenableReadCallBack = 1,
	AutomaticallyReenableAcceptCallBack = 2,
	AutomaticallyReenableDataCallBack = 3,
	AutomaticallyReenableWriteCallBack = 8,
	LeaveErrors = 0x40,
	CloseOnInvalidate = 0x80
}
