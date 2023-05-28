using ObjCRuntime;

namespace AppKit;

[Mac(10, 14)]
[Native]
public enum NSWorkspaceAuthorizationType : long
{
	CreateSymbolicLink,
	SetAttributes,
	ReplaceFile
}
