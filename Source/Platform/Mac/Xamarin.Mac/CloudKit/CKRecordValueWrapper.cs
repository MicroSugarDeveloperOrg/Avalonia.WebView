using System;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

internal sealed class CKRecordValueWrapper : BaseWrapper, ICKRecordValue, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CKRecordValueWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
