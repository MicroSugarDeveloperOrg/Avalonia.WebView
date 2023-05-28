using System;
using System.Reflection;

namespace ObjCRuntime;

public class AssemblyRegistrationEventArgs : EventArgs
{
	public bool Register { get; set; }

	public AssemblyName AssemblyName { get; internal set; }
}
