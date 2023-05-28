using System.Runtime.InteropServices;

namespace MediaToolbox;

public static class MTProfessionalVideoWorkflow
{
	[DllImport("/System/Library/Frameworks/MediaToolbox.framework/MediaToolbox", EntryPoint = "MTRegisterProfessionalVideoWorkflowFormatReaders")]
	[Mac(10, 10)]
	public static extern void RegisterFormatReaders();
}
