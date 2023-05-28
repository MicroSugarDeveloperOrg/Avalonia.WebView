using System;

namespace ObjCRuntime;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class LinkWithAttribute : Attribute
{
	public bool ForceLoad { get; set; }

	public string Frameworks { get; set; }

	public string WeakFrameworks { get; set; }

	public string LibraryName { get; private set; }

	public string LinkerFlags { get; set; }

	public LinkTarget LinkTarget { get; set; }

	public bool NeedsGccExceptionHandling { get; set; }

	public bool IsCxx { get; set; }

	public bool SmartLink { get; set; }

	public DlsymOption Dlsym { get; set; }

	public LinkWithAttribute(string libraryName, LinkTarget target, string linkerFlags)
	{
		LibraryName = libraryName;
		LinkerFlags = linkerFlags;
		LinkTarget = target;
	}

	public LinkWithAttribute(string libraryName, LinkTarget target)
	{
		LibraryName = libraryName;
		LinkTarget = target;
	}

	public LinkWithAttribute(string libraryName)
	{
		LibraryName = libraryName;
	}

	public LinkWithAttribute()
	{
	}
}
