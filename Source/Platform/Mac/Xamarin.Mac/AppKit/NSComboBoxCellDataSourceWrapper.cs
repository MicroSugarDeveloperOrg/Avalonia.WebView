using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSComboBoxCellDataSourceWrapper : BaseWrapper, INSComboBoxCellDataSource, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSComboBoxCellDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
