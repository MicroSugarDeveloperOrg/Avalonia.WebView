using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSComboBoxDataSourceWrapper : BaseWrapper, INSComboBoxDataSource, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSComboBoxDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
