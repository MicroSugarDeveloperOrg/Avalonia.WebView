using System;
using ObjCRuntime;

namespace AppKit;

public enum NSOpenGLGlobalOption
{
	FormatCacheSize = 501,
	ClearFormatCache = 502,
	RetainRenderers = 503,
	[Lion]
	UseBuildCache = 506,
	[Obsolete]
	ResetLibrary = 504
}
