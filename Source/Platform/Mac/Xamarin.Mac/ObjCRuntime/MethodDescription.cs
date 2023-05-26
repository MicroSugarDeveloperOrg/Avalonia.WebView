using System.Reflection;

namespace ObjCRuntime;

public struct MethodDescription
{
	public MethodBase method;

	public ArgumentSemantic semantic;

	public MethodDescription(MethodBase method, ArgumentSemantic semantic)
	{
		this.method = method;
		this.semantic = semantic;
	}
}
