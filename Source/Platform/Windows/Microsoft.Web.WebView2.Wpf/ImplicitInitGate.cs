#define TRACE
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace Microsoft.Web.WebView2.Wpf;

internal class ImplicitInitGate : ISupportInitialize
{
	private bool ISupportInitializeOpen => ISupportInitializeCount == 0;

	private int ISupportInitializeCount { get; set; }

	private bool SyncContextOpen => SynchronizationContext.Current != null;

	private Action PendingInitAction { get; set; }

	public void BeginInit()
	{
		ISupportInitializeCount++;
		OnDataChanged();
	}

	public void EndInit()
	{
		Trace.Assert(ISupportInitializeCount > 0, "Called EndInit more times than BeginInit was called.");
		ISupportInitializeCount--;
		OnDataChanged();
	}

	public void OnSynchronizationContextExists(object sender, RoutedEventArgs e)
	{
		Trace.Assert(SyncContextOpen, "Expected UI thread to have a SynchronizationContext by the time this event fires.");
		OnDataChanged();
	}

	public void RunWhenOpen(Action initAction)
	{
		PendingInitAction = initAction;
		OnDataChanged();
	}

	private void OnDataChanged()
	{
		if (PendingInitAction != null && ISupportInitializeOpen && SyncContextOpen)
		{
			PendingInitAction();
			PendingInitAction = null;
		}
	}
}
