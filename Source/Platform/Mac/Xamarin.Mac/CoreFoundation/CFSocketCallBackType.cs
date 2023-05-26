using System;

namespace CoreFoundation;

[Flags]
public enum CFSocketCallBackType
{
	NoCallBack = 0,
	ReadCallBack = 1,
	AcceptCallBack = 2,
	DataCallBack = 3,
	ConnectCallBack = 4,
	WriteCallBack = 8
}
