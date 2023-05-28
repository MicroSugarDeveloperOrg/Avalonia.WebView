using System;
using System.Runtime.InteropServices;
using JavaScriptCore;

namespace SceneKit;

[Mac(10, 10)]
[iOS(8, 0)]
public static class SCNJavaScript
{
	[DllImport("/System/Library/Frameworks/SceneKit.framework/SceneKit")]
	private static extern void SCNExportJavaScriptModule(IntPtr context);

	public static void ExportModule(JSContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		SCNExportJavaScriptModule(context.Handle);
	}
}
