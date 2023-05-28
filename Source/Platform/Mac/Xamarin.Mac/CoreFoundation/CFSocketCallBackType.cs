using System;
using ObjCRuntime;

namespace CoreFoundation;

[Flags]
[Native]
public enum CFSocketCallBackType : ulong
{
	NoCallBack = 0uL,
	ReadCallBack = 1uL,
	AcceptCallBack = 2uL,
	DataCallBack = 3uL,
	ConnectCallBack = 4uL,
	WriteCallBack = 8uL
}
