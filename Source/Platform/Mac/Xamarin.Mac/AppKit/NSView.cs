using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CoreAnimation;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSView", true)]
public class NSView : NSResponder, INSAccessibility, INativeObject, IDisposable, INSAccessibilityElementProtocol, INSAppearanceCustomization, INSDraggingDestination, INSUserInterfaceItemIdentification
{
	private delegate nint view_compare_func(IntPtr view1, IntPtr view2, IntPtr context);

	private sealed class SortData
	{
		public Exception Exception;

		public Func<NSView, NSView, NSComparisonResult> Comparer;
	}

	public static class Notifications
	{
		public static NSObject ObserveAnnouncementRequested(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AnnouncementRequestedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAnnouncementRequested(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AnnouncementRequestedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveApplicationActivated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationActivatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveApplicationActivated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationActivatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveApplicationDeactivated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationDeactivatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveApplicationDeactivated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationDeactivatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveApplicationHidden(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationHiddenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveApplicationHidden(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationHiddenNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveApplicationShown(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationShownNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveApplicationShown(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ApplicationShownNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveBoundsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(BoundsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveBoundsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(BoundsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveCreated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveCreated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDrawerCreated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DrawerCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDrawerCreated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DrawerCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveFocusChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FocusChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFocusChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FocusChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveFocusedWindowChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FocusedWindowChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFocusedWindowChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FocusedWindowChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveFrameChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FrameChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFrameChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FrameChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveGlobalFrameChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(GlobalFrameChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveGlobalFrameChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(GlobalFrameChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveHelpTagCreated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(HelpTagCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveHelpTagCreated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(HelpTagCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveLayoutChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(LayoutChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveLayoutChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(LayoutChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveMainWindowChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MainWindowChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveMainWindowChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MainWindowChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveMoved(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveMoved(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveResized(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ResizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveResized(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ResizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveRowCollapsed(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowCollapsedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRowCollapsed(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowCollapsedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveRowCountChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowCountChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRowCountChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowCountChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveRowExpanded(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowExpandedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRowExpanded(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RowExpandedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedCellsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedCellsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedCellsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedCellsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedChildrenChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedChildrenChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedChildrenChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedChildrenChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedChildrenMoved(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedChildrenMovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedChildrenMoved(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedChildrenMovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedColumnsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedColumnsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedColumnsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedColumnsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedRowsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedRowsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedRowsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedRowsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectedTextChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedTextChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedTextChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedTextChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSheetCreated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SheetCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSheetCreated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SheetCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveTitleChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TitleChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveTitleChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TitleChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveUIElementDestroyed(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UIElementDestroyedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveUIElementDestroyed(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UIElementDestroyedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveUIElementFocusedChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UIElementFocusedChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveUIElementFocusedChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UIElementFocusedChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveUnitsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UnitsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveUnitsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UnitsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveUpdatedTrackingAreas(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UpdatedTrackingAreasNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveUpdatedTrackingAreas(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UpdatedTrackingAreasNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveValueChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ValueChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveValueChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ValueChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWindowCreated(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWindowCreated(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowCreatedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWindowDeminiaturized(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowDeminiaturizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWindowDeminiaturized(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowDeminiaturizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWindowMiniaturized(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowMiniaturizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWindowMiniaturized(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowMiniaturizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWindowMoved(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowMovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWindowMoved(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowMovedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWindowResized(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowResizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWindowResized(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WindowResizedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	private static view_compare_func view_comparer = view_compare;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsFirstMouse_ = "acceptsFirstMouse:";

	private static readonly IntPtr selAcceptsFirstMouse_Handle = Selector.GetHandle("acceptsFirstMouse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsTouchEvents = "acceptsTouchEvents";

	private static readonly IntPtr selAcceptsTouchEventsHandle = Selector.GetHandle("acceptsTouchEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityActionDescription_ = "accessibilityActionDescription:";

	private static readonly IntPtr selAccessibilityActionDescription_Handle = Selector.GetHandle("accessibilityActionDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityActionNames = "accessibilityActionNames";

	private static readonly IntPtr selAccessibilityActionNamesHandle = Selector.GetHandle("accessibilityActionNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityActivationPoint = "accessibilityActivationPoint";

	private static readonly IntPtr selAccessibilityActivationPointHandle = Selector.GetHandle("accessibilityActivationPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityAllowedValues = "accessibilityAllowedValues";

	private static readonly IntPtr selAccessibilityAllowedValuesHandle = Selector.GetHandle("accessibilityAllowedValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityApplicationFocusedUIElement = "accessibilityApplicationFocusedUIElement";

	private static readonly IntPtr selAccessibilityApplicationFocusedUIElementHandle = Selector.GetHandle("accessibilityApplicationFocusedUIElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityArrayAttributeCount_ = "accessibilityArrayAttributeCount:";

	private static readonly IntPtr selAccessibilityArrayAttributeCount_Handle = Selector.GetHandle("accessibilityArrayAttributeCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityArrayAttributeValues_Index_MaxCount_ = "accessibilityArrayAttributeValues:index:maxCount:";

	private static readonly IntPtr selAccessibilityArrayAttributeValues_Index_MaxCount_Handle = Selector.GetHandle("accessibilityArrayAttributeValues:index:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityAttributeNames = "accessibilityAttributeNames";

	private static readonly IntPtr selAccessibilityAttributeNamesHandle = Selector.GetHandle("accessibilityAttributeNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityAttributeValue_ = "accessibilityAttributeValue:";

	private static readonly IntPtr selAccessibilityAttributeValue_Handle = Selector.GetHandle("accessibilityAttributeValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityAttributeValue_ForParameter_ = "accessibilityAttributeValue:forParameter:";

	private static readonly IntPtr selAccessibilityAttributeValue_ForParameter_Handle = Selector.GetHandle("accessibilityAttributeValue:forParameter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityAttributedStringForRange_ = "accessibilityAttributedStringForRange:";

	private static readonly IntPtr selAccessibilityAttributedStringForRange_Handle = Selector.GetHandle("accessibilityAttributedStringForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCancelButton = "accessibilityCancelButton";

	private static readonly IntPtr selAccessibilityCancelButtonHandle = Selector.GetHandle("accessibilityCancelButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCellForColumn_Row_ = "accessibilityCellForColumn:row:";

	private static readonly IntPtr selAccessibilityCellForColumn_Row_Handle = Selector.GetHandle("accessibilityCellForColumn:row:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityChildren = "accessibilityChildren";

	private static readonly IntPtr selAccessibilityChildrenHandle = Selector.GetHandle("accessibilityChildren");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityChildrenInNavigationOrder = "accessibilityChildrenInNavigationOrder";

	private static readonly IntPtr selAccessibilityChildrenInNavigationOrderHandle = Selector.GetHandle("accessibilityChildrenInNavigationOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityClearButton = "accessibilityClearButton";

	private static readonly IntPtr selAccessibilityClearButtonHandle = Selector.GetHandle("accessibilityClearButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCloseButton = "accessibilityCloseButton";

	private static readonly IntPtr selAccessibilityCloseButtonHandle = Selector.GetHandle("accessibilityCloseButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumnCount = "accessibilityColumnCount";

	private static readonly IntPtr selAccessibilityColumnCountHandle = Selector.GetHandle("accessibilityColumnCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumnHeaderUIElements = "accessibilityColumnHeaderUIElements";

	private static readonly IntPtr selAccessibilityColumnHeaderUIElementsHandle = Selector.GetHandle("accessibilityColumnHeaderUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumnIndexRange = "accessibilityColumnIndexRange";

	private static readonly IntPtr selAccessibilityColumnIndexRangeHandle = Selector.GetHandle("accessibilityColumnIndexRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumnTitles = "accessibilityColumnTitles";

	private static readonly IntPtr selAccessibilityColumnTitlesHandle = Selector.GetHandle("accessibilityColumnTitles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumns = "accessibilityColumns";

	private static readonly IntPtr selAccessibilityColumnsHandle = Selector.GetHandle("accessibilityColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityContents = "accessibilityContents";

	private static readonly IntPtr selAccessibilityContentsHandle = Selector.GetHandle("accessibilityContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCriticalValue = "accessibilityCriticalValue";

	private static readonly IntPtr selAccessibilityCriticalValueHandle = Selector.GetHandle("accessibilityCriticalValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCustomActions = "accessibilityCustomActions";

	private static readonly IntPtr selAccessibilityCustomActionsHandle = Selector.GetHandle("accessibilityCustomActions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityCustomRotors = "accessibilityCustomRotors";

	private static readonly IntPtr selAccessibilityCustomRotorsHandle = Selector.GetHandle("accessibilityCustomRotors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDecrementButton = "accessibilityDecrementButton";

	private static readonly IntPtr selAccessibilityDecrementButtonHandle = Selector.GetHandle("accessibilityDecrementButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDefaultButton = "accessibilityDefaultButton";

	private static readonly IntPtr selAccessibilityDefaultButtonHandle = Selector.GetHandle("accessibilityDefaultButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisclosedByRow = "accessibilityDisclosedByRow";

	private static readonly IntPtr selAccessibilityDisclosedByRowHandle = Selector.GetHandle("accessibilityDisclosedByRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisclosedRows = "accessibilityDisclosedRows";

	private static readonly IntPtr selAccessibilityDisclosedRowsHandle = Selector.GetHandle("accessibilityDisclosedRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisclosureLevel = "accessibilityDisclosureLevel";

	private static readonly IntPtr selAccessibilityDisclosureLevelHandle = Selector.GetHandle("accessibilityDisclosureLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDocument = "accessibilityDocument";

	private static readonly IntPtr selAccessibilityDocumentHandle = Selector.GetHandle("accessibilityDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityExtrasMenuBar = "accessibilityExtrasMenuBar";

	private static readonly IntPtr selAccessibilityExtrasMenuBarHandle = Selector.GetHandle("accessibilityExtrasMenuBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFilename = "accessibilityFilename";

	private static readonly IntPtr selAccessibilityFilenameHandle = Selector.GetHandle("accessibilityFilename");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFocusedUIElement = "accessibilityFocusedUIElement";

	private static readonly IntPtr selAccessibilityFocusedUIElementHandle = Selector.GetHandle("accessibilityFocusedUIElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFocusedWindow = "accessibilityFocusedWindow";

	private static readonly IntPtr selAccessibilityFocusedWindowHandle = Selector.GetHandle("accessibilityFocusedWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrame = "accessibilityFrame";

	private static readonly IntPtr selAccessibilityFrameHandle = Selector.GetHandle("accessibilityFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrameForRange_ = "accessibilityFrameForRange:";

	private static readonly IntPtr selAccessibilityFrameForRange_Handle = Selector.GetHandle("accessibilityFrameForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFullScreenButton = "accessibilityFullScreenButton";

	private static readonly IntPtr selAccessibilityFullScreenButtonHandle = Selector.GetHandle("accessibilityFullScreenButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityGrowArea = "accessibilityGrowArea";

	private static readonly IntPtr selAccessibilityGrowAreaHandle = Selector.GetHandle("accessibilityGrowArea");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHandles = "accessibilityHandles";

	private static readonly IntPtr selAccessibilityHandlesHandle = Selector.GetHandle("accessibilityHandles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHeader = "accessibilityHeader";

	private static readonly IntPtr selAccessibilityHeaderHandle = Selector.GetHandle("accessibilityHeader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHelp = "accessibilityHelp";

	private static readonly IntPtr selAccessibilityHelpHandle = Selector.GetHandle("accessibilityHelp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHitTest_ = "accessibilityHitTest:";

	private static readonly IntPtr selAccessibilityHitTest_Handle = Selector.GetHandle("accessibilityHitTest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHorizontalScrollBar = "accessibilityHorizontalScrollBar";

	private static readonly IntPtr selAccessibilityHorizontalScrollBarHandle = Selector.GetHandle("accessibilityHorizontalScrollBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHorizontalUnitDescription = "accessibilityHorizontalUnitDescription";

	private static readonly IntPtr selAccessibilityHorizontalUnitDescriptionHandle = Selector.GetHandle("accessibilityHorizontalUnitDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHorizontalUnits = "accessibilityHorizontalUnits";

	private static readonly IntPtr selAccessibilityHorizontalUnitsHandle = Selector.GetHandle("accessibilityHorizontalUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIdentifier = "accessibilityIdentifier";

	private static readonly IntPtr selAccessibilityIdentifierHandle = Selector.GetHandle("accessibilityIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIncrementButton = "accessibilityIncrementButton";

	private static readonly IntPtr selAccessibilityIncrementButtonHandle = Selector.GetHandle("accessibilityIncrementButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIndex = "accessibilityIndex";

	private static readonly IntPtr selAccessibilityIndexHandle = Selector.GetHandle("accessibilityIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIndexOfChild_ = "accessibilityIndexOfChild:";

	private static readonly IntPtr selAccessibilityIndexOfChild_Handle = Selector.GetHandle("accessibilityIndexOfChild:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityInsertionPointLineNumber = "accessibilityInsertionPointLineNumber";

	private static readonly IntPtr selAccessibilityInsertionPointLineNumberHandle = Selector.GetHandle("accessibilityInsertionPointLineNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIsAttributeSettable_ = "accessibilityIsAttributeSettable:";

	private static readonly IntPtr selAccessibilityIsAttributeSettable_Handle = Selector.GetHandle("accessibilityIsAttributeSettable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIsIgnored = "accessibilityIsIgnored";

	private static readonly IntPtr selAccessibilityIsIgnoredHandle = Selector.GetHandle("accessibilityIsIgnored");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLabel = "accessibilityLabel";

	private static readonly IntPtr selAccessibilityLabelHandle = Selector.GetHandle("accessibilityLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLabelUIElements = "accessibilityLabelUIElements";

	private static readonly IntPtr selAccessibilityLabelUIElementsHandle = Selector.GetHandle("accessibilityLabelUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLabelValue = "accessibilityLabelValue";

	private static readonly IntPtr selAccessibilityLabelValueHandle = Selector.GetHandle("accessibilityLabelValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLayoutPointForScreenPoint_ = "accessibilityLayoutPointForScreenPoint:";

	private static readonly IntPtr selAccessibilityLayoutPointForScreenPoint_Handle = Selector.GetHandle("accessibilityLayoutPointForScreenPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLayoutSizeForScreenSize_ = "accessibilityLayoutSizeForScreenSize:";

	private static readonly IntPtr selAccessibilityLayoutSizeForScreenSize_Handle = Selector.GetHandle("accessibilityLayoutSizeForScreenSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLineForIndex_ = "accessibilityLineForIndex:";

	private static readonly IntPtr selAccessibilityLineForIndex_Handle = Selector.GetHandle("accessibilityLineForIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLinkedUIElements = "accessibilityLinkedUIElements";

	private static readonly IntPtr selAccessibilityLinkedUIElementsHandle = Selector.GetHandle("accessibilityLinkedUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMainWindow = "accessibilityMainWindow";

	private static readonly IntPtr selAccessibilityMainWindowHandle = Selector.GetHandle("accessibilityMainWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMarkerGroupUIElement = "accessibilityMarkerGroupUIElement";

	private static readonly IntPtr selAccessibilityMarkerGroupUIElementHandle = Selector.GetHandle("accessibilityMarkerGroupUIElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMarkerTypeDescription = "accessibilityMarkerTypeDescription";

	private static readonly IntPtr selAccessibilityMarkerTypeDescriptionHandle = Selector.GetHandle("accessibilityMarkerTypeDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMarkerUIElements = "accessibilityMarkerUIElements";

	private static readonly IntPtr selAccessibilityMarkerUIElementsHandle = Selector.GetHandle("accessibilityMarkerUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMarkerValues = "accessibilityMarkerValues";

	private static readonly IntPtr selAccessibilityMarkerValuesHandle = Selector.GetHandle("accessibilityMarkerValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMaxValue = "accessibilityMaxValue";

	private static readonly IntPtr selAccessibilityMaxValueHandle = Selector.GetHandle("accessibilityMaxValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMenuBar = "accessibilityMenuBar";

	private static readonly IntPtr selAccessibilityMenuBarHandle = Selector.GetHandle("accessibilityMenuBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMinValue = "accessibilityMinValue";

	private static readonly IntPtr selAccessibilityMinValueHandle = Selector.GetHandle("accessibilityMinValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityMinimizeButton = "accessibilityMinimizeButton";

	private static readonly IntPtr selAccessibilityMinimizeButtonHandle = Selector.GetHandle("accessibilityMinimizeButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityNextContents = "accessibilityNextContents";

	private static readonly IntPtr selAccessibilityNextContentsHandle = Selector.GetHandle("accessibilityNextContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityNotifiesWhenDestroyed = "accessibilityNotifiesWhenDestroyed";

	private static readonly IntPtr selAccessibilityNotifiesWhenDestroyedHandle = Selector.GetHandle("accessibilityNotifiesWhenDestroyed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityNumberOfCharacters = "accessibilityNumberOfCharacters";

	private static readonly IntPtr selAccessibilityNumberOfCharactersHandle = Selector.GetHandle("accessibilityNumberOfCharacters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityOrientation = "accessibilityOrientation";

	private static readonly IntPtr selAccessibilityOrientationHandle = Selector.GetHandle("accessibilityOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityOverflowButton = "accessibilityOverflowButton";

	private static readonly IntPtr selAccessibilityOverflowButtonHandle = Selector.GetHandle("accessibilityOverflowButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParameterizedAttributeNames = "accessibilityParameterizedAttributeNames";

	private static readonly IntPtr selAccessibilityParameterizedAttributeNamesHandle = Selector.GetHandle("accessibilityParameterizedAttributeNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParent = "accessibilityParent";

	private static readonly IntPtr selAccessibilityParentHandle = Selector.GetHandle("accessibilityParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformAction_ = "accessibilityPerformAction:";

	private static readonly IntPtr selAccessibilityPerformAction_Handle = Selector.GetHandle("accessibilityPerformAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformCancel = "accessibilityPerformCancel";

	private static readonly IntPtr selAccessibilityPerformCancelHandle = Selector.GetHandle("accessibilityPerformCancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformConfirm = "accessibilityPerformConfirm";

	private static readonly IntPtr selAccessibilityPerformConfirmHandle = Selector.GetHandle("accessibilityPerformConfirm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformDecrement = "accessibilityPerformDecrement";

	private static readonly IntPtr selAccessibilityPerformDecrementHandle = Selector.GetHandle("accessibilityPerformDecrement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformDelete = "accessibilityPerformDelete";

	private static readonly IntPtr selAccessibilityPerformDeleteHandle = Selector.GetHandle("accessibilityPerformDelete");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformIncrement = "accessibilityPerformIncrement";

	private static readonly IntPtr selAccessibilityPerformIncrementHandle = Selector.GetHandle("accessibilityPerformIncrement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformPick = "accessibilityPerformPick";

	private static readonly IntPtr selAccessibilityPerformPickHandle = Selector.GetHandle("accessibilityPerformPick");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformPress = "accessibilityPerformPress";

	private static readonly IntPtr selAccessibilityPerformPressHandle = Selector.GetHandle("accessibilityPerformPress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformRaise = "accessibilityPerformRaise";

	private static readonly IntPtr selAccessibilityPerformRaiseHandle = Selector.GetHandle("accessibilityPerformRaise");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformShowAlternateUI = "accessibilityPerformShowAlternateUI";

	private static readonly IntPtr selAccessibilityPerformShowAlternateUIHandle = Selector.GetHandle("accessibilityPerformShowAlternateUI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformShowDefaultUI = "accessibilityPerformShowDefaultUI";

	private static readonly IntPtr selAccessibilityPerformShowDefaultUIHandle = Selector.GetHandle("accessibilityPerformShowDefaultUI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformShowMenu = "accessibilityPerformShowMenu";

	private static readonly IntPtr selAccessibilityPerformShowMenuHandle = Selector.GetHandle("accessibilityPerformShowMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPlaceholderValue = "accessibilityPlaceholderValue";

	private static readonly IntPtr selAccessibilityPlaceholderValueHandle = Selector.GetHandle("accessibilityPlaceholderValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPreviousContents = "accessibilityPreviousContents";

	private static readonly IntPtr selAccessibilityPreviousContentsHandle = Selector.GetHandle("accessibilityPreviousContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityProxy = "accessibilityProxy";

	private static readonly IntPtr selAccessibilityProxyHandle = Selector.GetHandle("accessibilityProxy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRTFForRange_ = "accessibilityRTFForRange:";

	private static readonly IntPtr selAccessibilityRTFForRange_Handle = Selector.GetHandle("accessibilityRTFForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRangeForIndex_ = "accessibilityRangeForIndex:";

	private static readonly IntPtr selAccessibilityRangeForIndex_Handle = Selector.GetHandle("accessibilityRangeForIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRangeForLine_ = "accessibilityRangeForLine:";

	private static readonly IntPtr selAccessibilityRangeForLine_Handle = Selector.GetHandle("accessibilityRangeForLine:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRangeForPosition_ = "accessibilityRangeForPosition:";

	private static readonly IntPtr selAccessibilityRangeForPosition_Handle = Selector.GetHandle("accessibilityRangeForPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRole = "accessibilityRole";

	private static readonly IntPtr selAccessibilityRoleHandle = Selector.GetHandle("accessibilityRole");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRoleDescription = "accessibilityRoleDescription";

	private static readonly IntPtr selAccessibilityRoleDescriptionHandle = Selector.GetHandle("accessibilityRoleDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRowCount = "accessibilityRowCount";

	private static readonly IntPtr selAccessibilityRowCountHandle = Selector.GetHandle("accessibilityRowCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRowHeaderUIElements = "accessibilityRowHeaderUIElements";

	private static readonly IntPtr selAccessibilityRowHeaderUIElementsHandle = Selector.GetHandle("accessibilityRowHeaderUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRowIndexRange = "accessibilityRowIndexRange";

	private static readonly IntPtr selAccessibilityRowIndexRangeHandle = Selector.GetHandle("accessibilityRowIndexRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRows = "accessibilityRows";

	private static readonly IntPtr selAccessibilityRowsHandle = Selector.GetHandle("accessibilityRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRulerMarkerType = "accessibilityRulerMarkerType";

	private static readonly IntPtr selAccessibilityRulerMarkerTypeHandle = Selector.GetHandle("accessibilityRulerMarkerType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityScreenPointForLayoutPoint_ = "accessibilityScreenPointForLayoutPoint:";

	private static readonly IntPtr selAccessibilityScreenPointForLayoutPoint_Handle = Selector.GetHandle("accessibilityScreenPointForLayoutPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityScreenSizeForLayoutSize_ = "accessibilityScreenSizeForLayoutSize:";

	private static readonly IntPtr selAccessibilityScreenSizeForLayoutSize_Handle = Selector.GetHandle("accessibilityScreenSizeForLayoutSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySearchButton = "accessibilitySearchButton";

	private static readonly IntPtr selAccessibilitySearchButtonHandle = Selector.GetHandle("accessibilitySearchButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySearchMenu = "accessibilitySearchMenu";

	private static readonly IntPtr selAccessibilitySearchMenuHandle = Selector.GetHandle("accessibilitySearchMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedCells = "accessibilitySelectedCells";

	private static readonly IntPtr selAccessibilitySelectedCellsHandle = Selector.GetHandle("accessibilitySelectedCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedChildren = "accessibilitySelectedChildren";

	private static readonly IntPtr selAccessibilitySelectedChildrenHandle = Selector.GetHandle("accessibilitySelectedChildren");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedColumns = "accessibilitySelectedColumns";

	private static readonly IntPtr selAccessibilitySelectedColumnsHandle = Selector.GetHandle("accessibilitySelectedColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedRows = "accessibilitySelectedRows";

	private static readonly IntPtr selAccessibilitySelectedRowsHandle = Selector.GetHandle("accessibilitySelectedRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedText = "accessibilitySelectedText";

	private static readonly IntPtr selAccessibilitySelectedTextHandle = Selector.GetHandle("accessibilitySelectedText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedTextRange = "accessibilitySelectedTextRange";

	private static readonly IntPtr selAccessibilitySelectedTextRangeHandle = Selector.GetHandle("accessibilitySelectedTextRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedTextRanges = "accessibilitySelectedTextRanges";

	private static readonly IntPtr selAccessibilitySelectedTextRangesHandle = Selector.GetHandle("accessibilitySelectedTextRanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityServesAsTitleForUIElements = "accessibilityServesAsTitleForUIElements";

	private static readonly IntPtr selAccessibilityServesAsTitleForUIElementsHandle = Selector.GetHandle("accessibilityServesAsTitleForUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySetValue_ForAttribute_ = "accessibilitySetValue:forAttribute:";

	private static readonly IntPtr selAccessibilitySetValue_ForAttribute_Handle = Selector.GetHandle("accessibilitySetValue:forAttribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySharedCharacterRange = "accessibilitySharedCharacterRange";

	private static readonly IntPtr selAccessibilitySharedCharacterRangeHandle = Selector.GetHandle("accessibilitySharedCharacterRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySharedFocusElements = "accessibilitySharedFocusElements";

	private static readonly IntPtr selAccessibilitySharedFocusElementsHandle = Selector.GetHandle("accessibilitySharedFocusElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySharedTextUIElements = "accessibilitySharedTextUIElements";

	private static readonly IntPtr selAccessibilitySharedTextUIElementsHandle = Selector.GetHandle("accessibilitySharedTextUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityShownMenu = "accessibilityShownMenu";

	private static readonly IntPtr selAccessibilityShownMenuHandle = Selector.GetHandle("accessibilityShownMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySortDirection = "accessibilitySortDirection";

	private static readonly IntPtr selAccessibilitySortDirectionHandle = Selector.GetHandle("accessibilitySortDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySplitters = "accessibilitySplitters";

	private static readonly IntPtr selAccessibilitySplittersHandle = Selector.GetHandle("accessibilitySplitters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityStringForRange_ = "accessibilityStringForRange:";

	private static readonly IntPtr selAccessibilityStringForRange_Handle = Selector.GetHandle("accessibilityStringForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityStyleRangeForIndex_ = "accessibilityStyleRangeForIndex:";

	private static readonly IntPtr selAccessibilityStyleRangeForIndex_Handle = Selector.GetHandle("accessibilityStyleRangeForIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySubrole = "accessibilitySubrole";

	private static readonly IntPtr selAccessibilitySubroleHandle = Selector.GetHandle("accessibilitySubrole");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityTabs = "accessibilityTabs";

	private static readonly IntPtr selAccessibilityTabsHandle = Selector.GetHandle("accessibilityTabs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityTitle = "accessibilityTitle";

	private static readonly IntPtr selAccessibilityTitleHandle = Selector.GetHandle("accessibilityTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityTitleUIElement = "accessibilityTitleUIElement";

	private static readonly IntPtr selAccessibilityTitleUIElementHandle = Selector.GetHandle("accessibilityTitleUIElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityToolbarButton = "accessibilityToolbarButton";

	private static readonly IntPtr selAccessibilityToolbarButtonHandle = Selector.GetHandle("accessibilityToolbarButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityTopLevelUIElement = "accessibilityTopLevelUIElement";

	private static readonly IntPtr selAccessibilityTopLevelUIElementHandle = Selector.GetHandle("accessibilityTopLevelUIElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityURL = "accessibilityURL";

	private static readonly IntPtr selAccessibilityURLHandle = Selector.GetHandle("accessibilityURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityUnitDescription = "accessibilityUnitDescription";

	private static readonly IntPtr selAccessibilityUnitDescriptionHandle = Selector.GetHandle("accessibilityUnitDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityUnits = "accessibilityUnits";

	private static readonly IntPtr selAccessibilityUnitsHandle = Selector.GetHandle("accessibilityUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityValue = "accessibilityValue";

	private static readonly IntPtr selAccessibilityValueHandle = Selector.GetHandle("accessibilityValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityValueDescription = "accessibilityValueDescription";

	private static readonly IntPtr selAccessibilityValueDescriptionHandle = Selector.GetHandle("accessibilityValueDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVerticalScrollBar = "accessibilityVerticalScrollBar";

	private static readonly IntPtr selAccessibilityVerticalScrollBarHandle = Selector.GetHandle("accessibilityVerticalScrollBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVerticalUnitDescription = "accessibilityVerticalUnitDescription";

	private static readonly IntPtr selAccessibilityVerticalUnitDescriptionHandle = Selector.GetHandle("accessibilityVerticalUnitDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVerticalUnits = "accessibilityVerticalUnits";

	private static readonly IntPtr selAccessibilityVerticalUnitsHandle = Selector.GetHandle("accessibilityVerticalUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleCells = "accessibilityVisibleCells";

	private static readonly IntPtr selAccessibilityVisibleCellsHandle = Selector.GetHandle("accessibilityVisibleCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleCharacterRange = "accessibilityVisibleCharacterRange";

	private static readonly IntPtr selAccessibilityVisibleCharacterRangeHandle = Selector.GetHandle("accessibilityVisibleCharacterRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleChildren = "accessibilityVisibleChildren";

	private static readonly IntPtr selAccessibilityVisibleChildrenHandle = Selector.GetHandle("accessibilityVisibleChildren");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleColumns = "accessibilityVisibleColumns";

	private static readonly IntPtr selAccessibilityVisibleColumnsHandle = Selector.GetHandle("accessibilityVisibleColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleRows = "accessibilityVisibleRows";

	private static readonly IntPtr selAccessibilityVisibleRowsHandle = Selector.GetHandle("accessibilityVisibleRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityWarningValue = "accessibilityWarningValue";

	private static readonly IntPtr selAccessibilityWarningValueHandle = Selector.GetHandle("accessibilityWarningValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityWindow = "accessibilityWindow";

	private static readonly IntPtr selAccessibilityWindowHandle = Selector.GetHandle("accessibilityWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityWindows = "accessibilityWindows";

	private static readonly IntPtr selAccessibilityWindowsHandle = Selector.GetHandle("accessibilityWindows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityZoomButton = "accessibilityZoomButton";

	private static readonly IntPtr selAccessibilityZoomButtonHandle = Selector.GetHandle("accessibilityZoomButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddConstraint_ = "addConstraint:";

	private static readonly IntPtr selAddConstraint_Handle = Selector.GetHandle("addConstraint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddConstraints_ = "addConstraints:";

	private static readonly IntPtr selAddConstraints_Handle = Selector.GetHandle("addConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddCursorRect_Cursor_ = "addCursorRect:cursor:";

	private static readonly IntPtr selAddCursorRect_Cursor_Handle = Selector.GetHandle("addCursorRect:cursor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddGestureRecognizer_ = "addGestureRecognizer:";

	private static readonly IntPtr selAddGestureRecognizer_Handle = Selector.GetHandle("addGestureRecognizer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddLayoutGuide_ = "addLayoutGuide:";

	private static readonly IntPtr selAddLayoutGuide_Handle = Selector.GetHandle("addLayoutGuide:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSubview_ = "addSubview:";

	private static readonly IntPtr selAddSubview_Handle = Selector.GetHandle("addSubview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSubview_Positioned_RelativeTo_ = "addSubview:positioned:relativeTo:";

	private static readonly IntPtr selAddSubview_Positioned_RelativeTo_Handle = Selector.GetHandle("addSubview:positioned:relativeTo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddToolTipRect_Owner_UserData_ = "addToolTipRect:owner:userData:";

	private static readonly IntPtr selAddToolTipRect_Owner_UserData_Handle = Selector.GetHandle("addToolTipRect:owner:userData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTrackingArea_ = "addTrackingArea:";

	private static readonly IntPtr selAddTrackingArea_Handle = Selector.GetHandle("addTrackingArea:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTrackingRect_Owner_UserData_AssumeInside_ = "addTrackingRect:owner:userData:assumeInside:";

	private static readonly IntPtr selAddTrackingRect_Owner_UserData_AssumeInside_Handle = Selector.GetHandle("addTrackingRect:owner:userData:assumeInside:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdjustPageHeightNew_Top_Bottom_Limit_ = "adjustPageHeightNew:top:bottom:limit:";

	private static readonly IntPtr selAdjustPageHeightNew_Top_Bottom_Limit_Handle = Selector.GetHandle("adjustPageHeightNew:top:bottom:limit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdjustPageWidthNew_Left_Right_Limit_ = "adjustPageWidthNew:left:right:limit:";

	private static readonly IntPtr selAdjustPageWidthNew_Left_Right_Limit_Handle = Selector.GetHandle("adjustPageWidthNew:left:right:limit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdjustScroll_ = "adjustScroll:";

	private static readonly IntPtr selAdjustScroll_Handle = Selector.GetHandle("adjustScroll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignmentRectForFrame_ = "alignmentRectForFrame:";

	private static readonly IntPtr selAlignmentRectForFrame_Handle = Selector.GetHandle("alignmentRectForFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignmentRectInsets = "alignmentRectInsets";

	private static readonly IntPtr selAlignmentRectInsetsHandle = Selector.GetHandle("alignmentRectInsets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllocateGState = "allocateGState";

	private static readonly IntPtr selAllocateGStateHandle = Selector.GetHandle("allocateGState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsVibrancy = "allowsVibrancy";

	private static readonly IntPtr selAllowsVibrancyHandle = Selector.GetHandle("allowsVibrancy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlphaValue = "alphaValue";

	private static readonly IntPtr selAlphaValueHandle = Selector.GetHandle("alphaValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAncestorSharedWithView_ = "ancestorSharedWithView:";

	private static readonly IntPtr selAncestorSharedWithView_Handle = Selector.GetHandle("ancestorSharedWithView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationForKey_ = "animationForKey:";

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimations = "animations";

	private static readonly IntPtr selAnimationsHandle = Selector.GetHandle("animations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimator = "animator";

	private static readonly IntPtr selAnimatorHandle = Selector.GetHandle("animator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppearance = "appearance";

	private static readonly IntPtr selAppearanceHandle = Selector.GetHandle("appearance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoresizesSubviews = "autoresizesSubviews";

	private static readonly IntPtr selAutoresizesSubviewsHandle = Selector.GetHandle("autoresizesSubviews");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoresizingMask = "autoresizingMask";

	private static readonly IntPtr selAutoresizingMaskHandle = Selector.GetHandle("autoresizingMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoscroll_ = "autoscroll:";

	private static readonly IntPtr selAutoscroll_Handle = Selector.GetHandle("autoscroll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundFilters = "backgroundFilters";

	private static readonly IntPtr selBackgroundFiltersHandle = Selector.GetHandle("backgroundFilters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackingAlignedRect_Options_ = "backingAlignedRect:options:";

	private static readonly IntPtr selBackingAlignedRect_Options_Handle = Selector.GetHandle("backingAlignedRect:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaselineOffsetFromBottom = "baselineOffsetFromBottom";

	private static readonly IntPtr selBaselineOffsetFromBottomHandle = Selector.GetHandle("baselineOffsetFromBottom");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginDocument = "beginDocument";

	private static readonly IntPtr selBeginDocumentHandle = Selector.GetHandle("beginDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginDraggingSessionWithItems_Event_Source_ = "beginDraggingSessionWithItems:event:source:";

	private static readonly IntPtr selBeginDraggingSessionWithItems_Event_Source_Handle = Selector.GetHandle("beginDraggingSessionWithItems:event:source:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginPageInRect_AtPlacement_ = "beginPageInRect:atPlacement:";

	private static readonly IntPtr selBeginPageInRect_AtPlacement_Handle = Selector.GetHandle("beginPageInRect:atPlacement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitmapImageRepForCachingDisplayInRect_ = "bitmapImageRepForCachingDisplayInRect:";

	private static readonly IntPtr selBitmapImageRepForCachingDisplayInRect_Handle = Selector.GetHandle("bitmapImageRepForCachingDisplayInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBottomAnchor = "bottomAnchor";

	private static readonly IntPtr selBottomAnchorHandle = Selector.GetHandle("bottomAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBounds = "bounds";

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundsRotation = "boundsRotation";

	private static readonly IntPtr selBoundsRotationHandle = Selector.GetHandle("boundsRotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCacheDisplayInRect_ToBitmapImageRep_ = "cacheDisplayInRect:toBitmapImageRep:";

	private static readonly IntPtr selCacheDisplayInRect_ToBitmapImageRep_Handle = Selector.GetHandle("cacheDisplayInRect:toBitmapImageRep:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanBecomeKeyView = "canBecomeKeyView";

	private static readonly IntPtr selCanBecomeKeyViewHandle = Selector.GetHandle("canBecomeKeyView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanDraw = "canDraw";

	private static readonly IntPtr selCanDrawHandle = Selector.GetHandle("canDraw");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanDrawConcurrently = "canDrawConcurrently";

	private static readonly IntPtr selCanDrawConcurrentlyHandle = Selector.GetHandle("canDrawConcurrently");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanDrawSubviewsIntoLayer = "canDrawSubviewsIntoLayer";

	private static readonly IntPtr selCanDrawSubviewsIntoLayerHandle = Selector.GetHandle("canDrawSubviewsIntoLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterScanRect_ = "centerScanRect:";

	private static readonly IntPtr selCenterScanRect_Handle = Selector.GetHandle("centerScanRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterXAnchor = "centerXAnchor";

	private static readonly IntPtr selCenterXAnchorHandle = Selector.GetHandle("centerXAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterYAnchor = "centerYAnchor";

	private static readonly IntPtr selCenterYAnchorHandle = Selector.GetHandle("centerYAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositingFilter = "compositingFilter";

	private static readonly IntPtr selCompositingFilterHandle = Selector.GetHandle("compositingFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConcludeDragOperation_ = "concludeDragOperation:";

	private static readonly IntPtr selConcludeDragOperation_Handle = Selector.GetHandle("concludeDragOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraints = "constraints";

	private static readonly IntPtr selConstraintsHandle = Selector.GetHandle("constraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintsAffectingLayoutForOrientation_ = "constraintsAffectingLayoutForOrientation:";

	private static readonly IntPtr selConstraintsAffectingLayoutForOrientation_Handle = Selector.GetHandle("constraintsAffectingLayoutForOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentCompressionResistancePriorityForOrientation_ = "contentCompressionResistancePriorityForOrientation:";

	private static readonly IntPtr selContentCompressionResistancePriorityForOrientation_Handle = Selector.GetHandle("contentCompressionResistancePriorityForOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentFilters = "contentFilters";

	private static readonly IntPtr selContentFiltersHandle = Selector.GetHandle("contentFilters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentHuggingPriorityForOrientation_ = "contentHuggingPriorityForOrientation:";

	private static readonly IntPtr selContentHuggingPriorityForOrientation_Handle = Selector.GetHandle("contentHuggingPriorityForOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPoint_FromView_ = "convertPoint:fromView:";

	private static readonly IntPtr selConvertPoint_FromView_Handle = Selector.GetHandle("convertPoint:fromView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPoint_ToView_ = "convertPoint:toView:";

	private static readonly IntPtr selConvertPoint_ToView_Handle = Selector.GetHandle("convertPoint:toView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointFromBacking_ = "convertPointFromBacking:";

	private static readonly IntPtr selConvertPointFromBacking_Handle = Selector.GetHandle("convertPointFromBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointFromBase_ = "convertPointFromBase:";

	private static readonly IntPtr selConvertPointFromBase_Handle = Selector.GetHandle("convertPointFromBase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointFromLayer_ = "convertPointFromLayer:";

	private static readonly IntPtr selConvertPointFromLayer_Handle = Selector.GetHandle("convertPointFromLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointToBacking_ = "convertPointToBacking:";

	private static readonly IntPtr selConvertPointToBacking_Handle = Selector.GetHandle("convertPointToBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointToBase_ = "convertPointToBase:";

	private static readonly IntPtr selConvertPointToBase_Handle = Selector.GetHandle("convertPointToBase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointToLayer_ = "convertPointToLayer:";

	private static readonly IntPtr selConvertPointToLayer_Handle = Selector.GetHandle("convertPointToLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRect_FromView_ = "convertRect:fromView:";

	private static readonly IntPtr selConvertRect_FromView_Handle = Selector.GetHandle("convertRect:fromView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRect_ToView_ = "convertRect:toView:";

	private static readonly IntPtr selConvertRect_ToView_Handle = Selector.GetHandle("convertRect:toView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectFromBacking_ = "convertRectFromBacking:";

	private static readonly IntPtr selConvertRectFromBacking_Handle = Selector.GetHandle("convertRectFromBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectFromBase_ = "convertRectFromBase:";

	private static readonly IntPtr selConvertRectFromBase_Handle = Selector.GetHandle("convertRectFromBase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectFromLayer_ = "convertRectFromLayer:";

	private static readonly IntPtr selConvertRectFromLayer_Handle = Selector.GetHandle("convertRectFromLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectToBacking_ = "convertRectToBacking:";

	private static readonly IntPtr selConvertRectToBacking_Handle = Selector.GetHandle("convertRectToBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectToBase_ = "convertRectToBase:";

	private static readonly IntPtr selConvertRectToBase_Handle = Selector.GetHandle("convertRectToBase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectToLayer_ = "convertRectToLayer:";

	private static readonly IntPtr selConvertRectToLayer_Handle = Selector.GetHandle("convertRectToLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertSize_FromView_ = "convertSize:fromView:";

	private static readonly IntPtr selConvertSize_FromView_Handle = Selector.GetHandle("convertSize:fromView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertSize_ToView_ = "convertSize:toView:";

	private static readonly IntPtr selConvertSize_ToView_Handle = Selector.GetHandle("convertSize:toView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertSizeFromBacking_ = "convertSizeFromBacking:";

	private static readonly IntPtr selConvertSizeFromBacking_Handle = Selector.GetHandle("convertSizeFromBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertSizeFromBase_ = "convertSizeFromBase:";

	private static readonly IntPtr selConvertSizeFromBase_Handle = Selector.GetHandle("convertSizeFromBase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertSizeFromLayer_ = "convertSizeFromLayer:";

	private static readonly IntPtr selConvertSizeFromLayer_Handle = Selector.GetHandle("convertSizeFromLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertSizeToBacking_ = "convertSizeToBacking:";

	private static readonly IntPtr selConvertSizeToBacking_Handle = Selector.GetHandle("convertSizeToBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertSizeToBase_ = "convertSizeToBase:";

	private static readonly IntPtr selConvertSizeToBase_Handle = Selector.GetHandle("convertSizeToBase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertSizeToLayer_ = "convertSizeToLayer:";

	private static readonly IntPtr selConvertSizeToLayer_Handle = Selector.GetHandle("convertSizeToLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithEPSInsideRect_ = "dataWithEPSInsideRect:";

	private static readonly IntPtr selDataWithEPSInsideRect_Handle = Selector.GetHandle("dataWithEPSInsideRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithPDFInsideRect_ = "dataWithPDFInsideRect:";

	private static readonly IntPtr selDataWithPDFInsideRect_Handle = Selector.GetHandle("dataWithPDFInsideRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultAnimationForKey_ = "defaultAnimationForKey:";

	private static readonly IntPtr selDefaultAnimationForKey_Handle = Selector.GetHandle("defaultAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultFocusRingType = "defaultFocusRingType";

	private static readonly IntPtr selDefaultFocusRingTypeHandle = Selector.GetHandle("defaultFocusRingType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultMenu = "defaultMenu";

	private static readonly IntPtr selDefaultMenuHandle = Selector.GetHandle("defaultMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidAddSubview_ = "didAddSubview:";

	private static readonly IntPtr selDidAddSubview_Handle = Selector.GetHandle("didAddSubview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidCloseMenu_WithEvent_ = "didCloseMenu:withEvent:";

	private static readonly IntPtr selDidCloseMenu_WithEvent_Handle = Selector.GetHandle("didCloseMenu:withEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscardCursorRects = "discardCursorRects";

	private static readonly IntPtr selDiscardCursorRectsHandle = Selector.GetHandle("discardCursorRects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplay = "display";

	private static readonly IntPtr selDisplayHandle = Selector.GetHandle("display");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayIfNeeded = "displayIfNeeded";

	private static readonly IntPtr selDisplayIfNeededHandle = Selector.GetHandle("displayIfNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayIfNeededIgnoringOpacity = "displayIfNeededIgnoringOpacity";

	private static readonly IntPtr selDisplayIfNeededIgnoringOpacityHandle = Selector.GetHandle("displayIfNeededIgnoringOpacity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayIfNeededInRect_ = "displayIfNeededInRect:";

	private static readonly IntPtr selDisplayIfNeededInRect_Handle = Selector.GetHandle("displayIfNeededInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayIfNeededInRectIgnoringOpacity_ = "displayIfNeededInRectIgnoringOpacity:";

	private static readonly IntPtr selDisplayIfNeededInRectIgnoringOpacity_Handle = Selector.GetHandle("displayIfNeededInRectIgnoringOpacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayRect_ = "displayRect:";

	private static readonly IntPtr selDisplayRect_Handle = Selector.GetHandle("displayRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayRectIgnoringOpacity_ = "displayRectIgnoringOpacity:";

	private static readonly IntPtr selDisplayRectIgnoringOpacity_Handle = Selector.GetHandle("displayRectIgnoringOpacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayRectIgnoringOpacity_InContext_ = "displayRectIgnoringOpacity:inContext:";

	private static readonly IntPtr selDisplayRectIgnoringOpacity_InContext_Handle = Selector.GetHandle("displayRectIgnoringOpacity:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDragFile_FromRect_SlideBack_Event_ = "dragFile:fromRect:slideBack:event:";

	private static readonly IntPtr selDragFile_FromRect_SlideBack_Event_Handle = Selector.GetHandle("dragFile:fromRect:slideBack:event:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDragImage_At_Offset_Event_Pasteboard_Source_SlideBack_ = "dragImage:at:offset:event:pasteboard:source:slideBack:";

	private static readonly IntPtr selDragImage_At_Offset_Event_Pasteboard_Source_SlideBack_Handle = Selector.GetHandle("dragImage:at:offset:event:pasteboard:source:slideBack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDragPromisedFilesOfTypes_FromRect_Source_SlideBack_Event_ = "dragPromisedFilesOfTypes:fromRect:source:slideBack:event:";

	private static readonly IntPtr selDragPromisedFilesOfTypes_FromRect_Source_SlideBack_Event_Handle = Selector.GetHandle("dragPromisedFilesOfTypes:fromRect:source:slideBack:event:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingEnded_ = "draggingEnded:";

	private static readonly IntPtr selDraggingEnded_Handle = Selector.GetHandle("draggingEnded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingEntered_ = "draggingEntered:";

	private static readonly IntPtr selDraggingEntered_Handle = Selector.GetHandle("draggingEntered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingExited_ = "draggingExited:";

	private static readonly IntPtr selDraggingExited_Handle = Selector.GetHandle("draggingExited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingUpdated_ = "draggingUpdated:";

	private static readonly IntPtr selDraggingUpdated_Handle = Selector.GetHandle("draggingUpdated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawFocusRingMask = "drawFocusRingMask";

	private static readonly IntPtr selDrawFocusRingMaskHandle = Selector.GetHandle("drawFocusRingMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawPageBorderWithSize_ = "drawPageBorderWithSize:";

	private static readonly IntPtr selDrawPageBorderWithSize_Handle = Selector.GetHandle("drawPageBorderWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawRect_ = "drawRect:";

	private static readonly IntPtr selDrawRect_Handle = Selector.GetHandle("drawRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawSheetBorderWithSize_ = "drawSheetBorderWithSize:";

	private static readonly IntPtr selDrawSheetBorderWithSize_Handle = Selector.GetHandle("drawSheetBorderWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEffectiveAppearance = "effectiveAppearance";

	private static readonly IntPtr selEffectiveAppearanceHandle = Selector.GetHandle("effectiveAppearance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnclosingScrollView = "enclosingScrollView";

	private static readonly IntPtr selEnclosingScrollViewHandle = Selector.GetHandle("enclosingScrollView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndDocument = "endDocument";

	private static readonly IntPtr selEndDocumentHandle = Selector.GetHandle("endDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndPage = "endPage";

	private static readonly IntPtr selEndPageHandle = Selector.GetHandle("endPage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnterFullScreenMode_WithOptions_ = "enterFullScreenMode:withOptions:";

	private static readonly IntPtr selEnterFullScreenMode_WithOptions_Handle = Selector.GetHandle("enterFullScreenMode:withOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExerciseAmbiguityInLayout = "exerciseAmbiguityInLayout";

	private static readonly IntPtr selExerciseAmbiguityInLayoutHandle = Selector.GetHandle("exerciseAmbiguityInLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExitFullScreenModeWithOptions_ = "exitFullScreenModeWithOptions:";

	private static readonly IntPtr selExitFullScreenModeWithOptions_Handle = Selector.GetHandle("exitFullScreenModeWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstBaselineAnchor = "firstBaselineAnchor";

	private static readonly IntPtr selFirstBaselineAnchorHandle = Selector.GetHandle("firstBaselineAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstBaselineOffsetFromTop = "firstBaselineOffsetFromTop";

	private static readonly IntPtr selFirstBaselineOffsetFromTopHandle = Selector.GetHandle("firstBaselineOffsetFromTop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFittingSize = "fittingSize";

	private static readonly IntPtr selFittingSizeHandle = Selector.GetHandle("fittingSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFocusRingMaskBounds = "focusRingMaskBounds";

	private static readonly IntPtr selFocusRingMaskBoundsHandle = Selector.GetHandle("focusRingMaskBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFocusRingType = "focusRingType";

	private static readonly IntPtr selFocusRingTypeHandle = Selector.GetHandle("focusRingType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFocusView = "focusView";

	private static readonly IntPtr selFocusViewHandle = Selector.GetHandle("focusView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrame = "frame";

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameCenterRotation = "frameCenterRotation";

	private static readonly IntPtr selFrameCenterRotationHandle = Selector.GetHandle("frameCenterRotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameForAlignmentRect_ = "frameForAlignmentRect:";

	private static readonly IntPtr selFrameForAlignmentRect_Handle = Selector.GetHandle("frameForAlignmentRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameRotation = "frameRotation";

	private static readonly IntPtr selFrameRotationHandle = Selector.GetHandle("frameRotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGState = "gState";

	private static readonly IntPtr selGStateHandle = Selector.GetHandle("gState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGestureRecognizers = "gestureRecognizers";

	private static readonly IntPtr selGestureRecognizersHandle = Selector.GetHandle("gestureRecognizers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasAmbiguousLayout = "hasAmbiguousLayout";

	private static readonly IntPtr selHasAmbiguousLayoutHandle = Selector.GetHandle("hasAmbiguousLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeightAdjustLimit = "heightAdjustLimit";

	private static readonly IntPtr selHeightAdjustLimitHandle = Selector.GetHandle("heightAdjustLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeightAnchor = "heightAnchor";

	private static readonly IntPtr selHeightAnchorHandle = Selector.GetHandle("heightAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHitTest_ = "hitTest:";

	private static readonly IntPtr selHitTest_Handle = Selector.GetHandle("hitTest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInLiveResize = "inLiveResize";

	private static readonly IntPtr selInLiveResizeHandle = Selector.GetHandle("inLiveResize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputContext = "inputContext";

	private static readonly IntPtr selInputContextHandle = Selector.GetHandle("inputContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntrinsicContentSize = "intrinsicContentSize";

	private static readonly IntPtr selIntrinsicContentSizeHandle = Selector.GetHandle("intrinsicContentSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateIntrinsicContentSize = "invalidateIntrinsicContentSize";

	private static readonly IntPtr selInvalidateIntrinsicContentSizeHandle = Selector.GetHandle("invalidateIntrinsicContentSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityAlternateUIVisible = "isAccessibilityAlternateUIVisible";

	private static readonly IntPtr selIsAccessibilityAlternateUIVisibleHandle = Selector.GetHandle("isAccessibilityAlternateUIVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityDisclosed = "isAccessibilityDisclosed";

	private static readonly IntPtr selIsAccessibilityDisclosedHandle = Selector.GetHandle("isAccessibilityDisclosed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityEdited = "isAccessibilityEdited";

	private static readonly IntPtr selIsAccessibilityEditedHandle = Selector.GetHandle("isAccessibilityEdited");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityElement = "isAccessibilityElement";

	private static readonly IntPtr selIsAccessibilityElementHandle = Selector.GetHandle("isAccessibilityElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityEnabled = "isAccessibilityEnabled";

	private static readonly IntPtr selIsAccessibilityEnabledHandle = Selector.GetHandle("isAccessibilityEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityExpanded = "isAccessibilityExpanded";

	private static readonly IntPtr selIsAccessibilityExpandedHandle = Selector.GetHandle("isAccessibilityExpanded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFocused = "isAccessibilityFocused";

	private static readonly IntPtr selIsAccessibilityFocusedHandle = Selector.GetHandle("isAccessibilityFocused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFrontmost = "isAccessibilityFrontmost";

	private static readonly IntPtr selIsAccessibilityFrontmostHandle = Selector.GetHandle("isAccessibilityFrontmost");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityHidden = "isAccessibilityHidden";

	private static readonly IntPtr selIsAccessibilityHiddenHandle = Selector.GetHandle("isAccessibilityHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityMain = "isAccessibilityMain";

	private static readonly IntPtr selIsAccessibilityMainHandle = Selector.GetHandle("isAccessibilityMain");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityMinimized = "isAccessibilityMinimized";

	private static readonly IntPtr selIsAccessibilityMinimizedHandle = Selector.GetHandle("isAccessibilityMinimized");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityModal = "isAccessibilityModal";

	private static readonly IntPtr selIsAccessibilityModalHandle = Selector.GetHandle("isAccessibilityModal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityOrderedByRow = "isAccessibilityOrderedByRow";

	private static readonly IntPtr selIsAccessibilityOrderedByRowHandle = Selector.GetHandle("isAccessibilityOrderedByRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityProtectedContent = "isAccessibilityProtectedContent";

	private static readonly IntPtr selIsAccessibilityProtectedContentHandle = Selector.GetHandle("isAccessibilityProtectedContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityRequired = "isAccessibilityRequired";

	private static readonly IntPtr selIsAccessibilityRequiredHandle = Selector.GetHandle("isAccessibilityRequired");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilitySelected = "isAccessibilitySelected";

	private static readonly IntPtr selIsAccessibilitySelectedHandle = Selector.GetHandle("isAccessibilitySelected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilitySelectorAllowed_ = "isAccessibilitySelectorAllowed:";

	private static readonly IntPtr selIsAccessibilitySelectorAllowed_Handle = Selector.GetHandle("isAccessibilitySelectorAllowed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCompatibleWithResponsiveScrolling = "isCompatibleWithResponsiveScrolling";

	private static readonly IntPtr selIsCompatibleWithResponsiveScrollingHandle = Selector.GetHandle("isCompatibleWithResponsiveScrolling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDescendantOf_ = "isDescendantOf:";

	private static readonly IntPtr selIsDescendantOf_Handle = Selector.GetHandle("isDescendantOf:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDrawingFindIndicator = "isDrawingFindIndicator";

	private static readonly IntPtr selIsDrawingFindIndicatorHandle = Selector.GetHandle("isDrawingFindIndicator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFlipped = "isFlipped";

	private static readonly IntPtr selIsFlippedHandle = Selector.GetHandle("isFlipped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHidden = "isHidden";

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHiddenOrHasHiddenAncestor = "isHiddenOrHasHiddenAncestor";

	private static readonly IntPtr selIsHiddenOrHasHiddenAncestorHandle = Selector.GetHandle("isHiddenOrHasHiddenAncestor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHorizontalContentSizeConstraintActive = "isHorizontalContentSizeConstraintActive";

	private static readonly IntPtr selIsHorizontalContentSizeConstraintActiveHandle = Selector.GetHandle("isHorizontalContentSizeConstraintActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInFullScreenMode = "isInFullScreenMode";

	private static readonly IntPtr selIsInFullScreenModeHandle = Selector.GetHandle("isInFullScreenMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOpaque = "isOpaque";

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRotatedFromBase = "isRotatedFromBase";

	private static readonly IntPtr selIsRotatedFromBaseHandle = Selector.GetHandle("isRotatedFromBase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRotatedOrScaledFromBase = "isRotatedOrScaledFromBase";

	private static readonly IntPtr selIsRotatedOrScaledFromBaseHandle = Selector.GetHandle("isRotatedOrScaledFromBase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVerticalContentSizeConstraintActive = "isVerticalContentSizeConstraintActive";

	private static readonly IntPtr selIsVerticalContentSizeConstraintActiveHandle = Selector.GetHandle("isVerticalContentSizeConstraintActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKnowsPageRange_ = "knowsPageRange:";

	private static readonly IntPtr selKnowsPageRange_Handle = Selector.GetHandle("knowsPageRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastBaselineAnchor = "lastBaselineAnchor";

	private static readonly IntPtr selLastBaselineAnchorHandle = Selector.GetHandle("lastBaselineAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastBaselineOffsetFromBottom = "lastBaselineOffsetFromBottom";

	private static readonly IntPtr selLastBaselineOffsetFromBottomHandle = Selector.GetHandle("lastBaselineOffsetFromBottom");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayer = "layer";

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerContentsPlacement = "layerContentsPlacement";

	private static readonly IntPtr selLayerContentsPlacementHandle = Selector.GetHandle("layerContentsPlacement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerContentsRedrawPolicy = "layerContentsRedrawPolicy";

	private static readonly IntPtr selLayerContentsRedrawPolicyHandle = Selector.GetHandle("layerContentsRedrawPolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerUsesCoreImageFilters = "layerUsesCoreImageFilters";

	private static readonly IntPtr selLayerUsesCoreImageFiltersHandle = Selector.GetHandle("layerUsesCoreImageFilters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayout = "layout";

	private static readonly IntPtr selLayoutHandle = Selector.GetHandle("layout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutGuides = "layoutGuides";

	private static readonly IntPtr selLayoutGuidesHandle = Selector.GetHandle("layoutGuides");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutSubtreeIfNeeded = "layoutSubtreeIfNeeded";

	private static readonly IntPtr selLayoutSubtreeIfNeededHandle = Selector.GetHandle("layoutSubtreeIfNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeadingAnchor = "leadingAnchor";

	private static readonly IntPtr selLeadingAnchorHandle = Selector.GetHandle("leadingAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftAnchor = "leftAnchor";

	private static readonly IntPtr selLeftAnchorHandle = Selector.GetHandle("leftAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocationOfPrintRect_ = "locationOfPrintRect:";

	private static readonly IntPtr selLocationOfPrintRect_Handle = Selector.GetHandle("locationOfPrintRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockFocus = "lockFocus";

	private static readonly IntPtr selLockFocusHandle = Selector.GetHandle("lockFocus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockFocusIfCanDraw = "lockFocusIfCanDraw";

	private static readonly IntPtr selLockFocusIfCanDrawHandle = Selector.GetHandle("lockFocusIfCanDraw");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockFocusIfCanDrawInContext_ = "lockFocusIfCanDrawInContext:";

	private static readonly IntPtr selLockFocusIfCanDrawInContext_Handle = Selector.GetHandle("lockFocusIfCanDrawInContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeBackingLayer = "makeBackingLayer";

	private static readonly IntPtr selMakeBackingLayerHandle = Selector.GetHandle("makeBackingLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuForEvent_ = "menuForEvent:";

	private static readonly IntPtr selMenuForEvent_Handle = Selector.GetHandle("menuForEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouse_InRect_ = "mouse:inRect:";

	private static readonly IntPtr selMouse_InRect_Handle = Selector.GetHandle("mouse:inRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseDownCanMoveWindow = "mouseDownCanMoveWindow";

	private static readonly IntPtr selMouseDownCanMoveWindowHandle = Selector.GetHandle("mouseDownCanMoveWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsDisplay = "needsDisplay";

	private static readonly IntPtr selNeedsDisplayHandle = Selector.GetHandle("needsDisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsLayout = "needsLayout";

	private static readonly IntPtr selNeedsLayoutHandle = Selector.GetHandle("needsLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsPanelToBecomeKey = "needsPanelToBecomeKey";

	private static readonly IntPtr selNeedsPanelToBecomeKeyHandle = Selector.GetHandle("needsPanelToBecomeKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsToDrawRect_ = "needsToDrawRect:";

	private static readonly IntPtr selNeedsToDrawRect_Handle = Selector.GetHandle("needsToDrawRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsUpdateConstraints = "needsUpdateConstraints";

	private static readonly IntPtr selNeedsUpdateConstraintsHandle = Selector.GetHandle("needsUpdateConstraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextKeyView = "nextKeyView";

	private static readonly IntPtr selNextKeyViewHandle = Selector.GetHandle("nextKeyView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextValidKeyView = "nextValidKeyView";

	private static readonly IntPtr selNextValidKeyViewHandle = Selector.GetHandle("nextValidKeyView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoteFocusRingMaskChanged = "noteFocusRingMaskChanged";

	private static readonly IntPtr selNoteFocusRingMaskChangedHandle = Selector.GetHandle("noteFocusRingMaskChanged");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpaqueAncestor = "opaqueAncestor";

	private static readonly IntPtr selOpaqueAncestorHandle = Selector.GetHandle("opaqueAncestor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageFooter = "pageFooter";

	private static readonly IntPtr selPageFooterHandle = Selector.GetHandle("pageFooter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageHeader = "pageHeader";

	private static readonly IntPtr selPageHeaderHandle = Selector.GetHandle("pageHeader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformDragOperation_ = "performDragOperation:";

	private static readonly IntPtr selPerformDragOperation_Handle = Selector.GetHandle("performDragOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformKeyEquivalent_ = "performKeyEquivalent:";

	private static readonly IntPtr selPerformKeyEquivalent_Handle = Selector.GetHandle("performKeyEquivalent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformMnemonic_ = "performMnemonic:";

	private static readonly IntPtr selPerformMnemonic_Handle = Selector.GetHandle("performMnemonic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostsBoundsChangedNotifications = "postsBoundsChangedNotifications";

	private static readonly IntPtr selPostsBoundsChangedNotificationsHandle = Selector.GetHandle("postsBoundsChangedNotifications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostsFrameChangedNotifications = "postsFrameChangedNotifications";

	private static readonly IntPtr selPostsFrameChangedNotificationsHandle = Selector.GetHandle("postsFrameChangedNotifications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareContentInRect_ = "prepareContentInRect:";

	private static readonly IntPtr selPrepareContentInRect_Handle = Selector.GetHandle("prepareContentInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForDragOperation_ = "prepareForDragOperation:";

	private static readonly IntPtr selPrepareForDragOperation_Handle = Selector.GetHandle("prepareForDragOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForReuse = "prepareForReuse";

	private static readonly IntPtr selPrepareForReuseHandle = Selector.GetHandle("prepareForReuse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreparedContentRect = "preparedContentRect";

	private static readonly IntPtr selPreparedContentRectHandle = Selector.GetHandle("preparedContentRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreservesContentDuringLiveResize = "preservesContentDuringLiveResize";

	private static readonly IntPtr selPreservesContentDuringLiveResizeHandle = Selector.GetHandle("preservesContentDuringLiveResize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPressureConfiguration = "pressureConfiguration";

	private static readonly IntPtr selPressureConfigurationHandle = Selector.GetHandle("pressureConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousKeyView = "previousKeyView";

	private static readonly IntPtr selPreviousKeyViewHandle = Selector.GetHandle("previousKeyView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousValidKeyView = "previousValidKeyView";

	private static readonly IntPtr selPreviousValidKeyViewHandle = Selector.GetHandle("previousValidKeyView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrint_ = "print:";

	private static readonly IntPtr selPrint_Handle = Selector.GetHandle("print:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintJobTitle = "printJobTitle";

	private static readonly IntPtr selPrintJobTitleHandle = Selector.GetHandle("printJobTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectForPage_ = "rectForPage:";

	private static readonly IntPtr selRectForPage_Handle = Selector.GetHandle("rectForPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectForSmartMagnificationAtPoint_InRect_ = "rectForSmartMagnificationAtPoint:inRect:";

	private static readonly IntPtr selRectForSmartMagnificationAtPoint_InRect_Handle = Selector.GetHandle("rectForSmartMagnificationAtPoint:inRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectPreservedDuringLiveResize = "rectPreservedDuringLiveResize";

	private static readonly IntPtr selRectPreservedDuringLiveResizeHandle = Selector.GetHandle("rectPreservedDuringLiveResize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterForDraggedTypes_ = "registerForDraggedTypes:";

	private static readonly IntPtr selRegisterForDraggedTypes_Handle = Selector.GetHandle("registerForDraggedTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisteredDraggedTypes = "registeredDraggedTypes";

	private static readonly IntPtr selRegisteredDraggedTypesHandle = Selector.GetHandle("registeredDraggedTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReleaseGState = "releaseGState";

	private static readonly IntPtr selReleaseGStateHandle = Selector.GetHandle("releaseGState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllToolTips = "removeAllToolTips";

	private static readonly IntPtr selRemoveAllToolTipsHandle = Selector.GetHandle("removeAllToolTips");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveConstraint_ = "removeConstraint:";

	private static readonly IntPtr selRemoveConstraint_Handle = Selector.GetHandle("removeConstraint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveConstraints_ = "removeConstraints:";

	private static readonly IntPtr selRemoveConstraints_Handle = Selector.GetHandle("removeConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCursorRect_Cursor_ = "removeCursorRect:cursor:";

	private static readonly IntPtr selRemoveCursorRect_Cursor_Handle = Selector.GetHandle("removeCursorRect:cursor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromSuperview = "removeFromSuperview";

	private static readonly IntPtr selRemoveFromSuperviewHandle = Selector.GetHandle("removeFromSuperview");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromSuperviewWithoutNeedingDisplay = "removeFromSuperviewWithoutNeedingDisplay";

	private static readonly IntPtr selRemoveFromSuperviewWithoutNeedingDisplayHandle = Selector.GetHandle("removeFromSuperviewWithoutNeedingDisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveGestureRecognizer_ = "removeGestureRecognizer:";

	private static readonly IntPtr selRemoveGestureRecognizer_Handle = Selector.GetHandle("removeGestureRecognizer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveLayoutGuide_ = "removeLayoutGuide:";

	private static readonly IntPtr selRemoveLayoutGuide_Handle = Selector.GetHandle("removeLayoutGuide:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveToolTip_ = "removeToolTip:";

	private static readonly IntPtr selRemoveToolTip_Handle = Selector.GetHandle("removeToolTip:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTrackingArea_ = "removeTrackingArea:";

	private static readonly IntPtr selRemoveTrackingArea_Handle = Selector.GetHandle("removeTrackingArea:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTrackingRect_ = "removeTrackingRect:";

	private static readonly IntPtr selRemoveTrackingRect_Handle = Selector.GetHandle("removeTrackingRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenewGState = "renewGState";

	private static readonly IntPtr selRenewGStateHandle = Selector.GetHandle("renewGState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceSubview_With_ = "replaceSubview:with:";

	private static readonly IntPtr selReplaceSubview_With_Handle = Selector.GetHandle("replaceSubview:with:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequiresConstraintBasedLayout = "requiresConstraintBasedLayout";

	private static readonly IntPtr selRequiresConstraintBasedLayoutHandle = Selector.GetHandle("requiresConstraintBasedLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetCursorRects = "resetCursorRects";

	private static readonly IntPtr selResetCursorRectsHandle = Selector.GetHandle("resetCursorRects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeSubviewsWithOldSize_ = "resizeSubviewsWithOldSize:";

	private static readonly IntPtr selResizeSubviewsWithOldSize_Handle = Selector.GetHandle("resizeSubviewsWithOldSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeWithOldSuperviewSize_ = "resizeWithOldSuperviewSize:";

	private static readonly IntPtr selResizeWithOldSuperviewSize_Handle = Selector.GetHandle("resizeWithOldSuperviewSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightAnchor = "rightAnchor";

	private static readonly IntPtr selRightAnchorHandle = Selector.GetHandle("rightAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateByAngle_ = "rotateByAngle:";

	private static readonly IntPtr selRotateByAngle_Handle = Selector.GetHandle("rotateByAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleUnitSquareToSize_ = "scaleUnitSquareToSize:";

	private static readonly IntPtr selScaleUnitSquareToSize_Handle = Selector.GetHandle("scaleUnitSquareToSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollPoint_ = "scrollPoint:";

	private static readonly IntPtr selScrollPoint_Handle = Selector.GetHandle("scrollPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollRect_By_ = "scrollRect:by:";

	private static readonly IntPtr selScrollRect_By_Handle = Selector.GetHandle("scrollRect:by:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollRectToVisible_ = "scrollRectToVisible:";

	private static readonly IntPtr selScrollRectToVisible_Handle = Selector.GetHandle("scrollRectToVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAcceptsTouchEvents_ = "setAcceptsTouchEvents:";

	private static readonly IntPtr selSetAcceptsTouchEvents_Handle = Selector.GetHandle("setAcceptsTouchEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityActivationPoint_ = "setAccessibilityActivationPoint:";

	private static readonly IntPtr selSetAccessibilityActivationPoint_Handle = Selector.GetHandle("setAccessibilityActivationPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityAllowedValues_ = "setAccessibilityAllowedValues:";

	private static readonly IntPtr selSetAccessibilityAllowedValues_Handle = Selector.GetHandle("setAccessibilityAllowedValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityAlternateUIVisible_ = "setAccessibilityAlternateUIVisible:";

	private static readonly IntPtr selSetAccessibilityAlternateUIVisible_Handle = Selector.GetHandle("setAccessibilityAlternateUIVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityApplicationFocusedUIElement_ = "setAccessibilityApplicationFocusedUIElement:";

	private static readonly IntPtr selSetAccessibilityApplicationFocusedUIElement_Handle = Selector.GetHandle("setAccessibilityApplicationFocusedUIElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityCancelButton_ = "setAccessibilityCancelButton:";

	private static readonly IntPtr selSetAccessibilityCancelButton_Handle = Selector.GetHandle("setAccessibilityCancelButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityChildren_ = "setAccessibilityChildren:";

	private static readonly IntPtr selSetAccessibilityChildren_Handle = Selector.GetHandle("setAccessibilityChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityChildrenInNavigationOrder_ = "setAccessibilityChildrenInNavigationOrder:";

	private static readonly IntPtr selSetAccessibilityChildrenInNavigationOrder_Handle = Selector.GetHandle("setAccessibilityChildrenInNavigationOrder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityClearButton_ = "setAccessibilityClearButton:";

	private static readonly IntPtr selSetAccessibilityClearButton_Handle = Selector.GetHandle("setAccessibilityClearButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityCloseButton_ = "setAccessibilityCloseButton:";

	private static readonly IntPtr selSetAccessibilityCloseButton_Handle = Selector.GetHandle("setAccessibilityCloseButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityColumnCount_ = "setAccessibilityColumnCount:";

	private static readonly IntPtr selSetAccessibilityColumnCount_Handle = Selector.GetHandle("setAccessibilityColumnCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityColumnHeaderUIElements_ = "setAccessibilityColumnHeaderUIElements:";

	private static readonly IntPtr selSetAccessibilityColumnHeaderUIElements_Handle = Selector.GetHandle("setAccessibilityColumnHeaderUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityColumnIndexRange_ = "setAccessibilityColumnIndexRange:";

	private static readonly IntPtr selSetAccessibilityColumnIndexRange_Handle = Selector.GetHandle("setAccessibilityColumnIndexRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityColumnTitles_ = "setAccessibilityColumnTitles:";

	private static readonly IntPtr selSetAccessibilityColumnTitles_Handle = Selector.GetHandle("setAccessibilityColumnTitles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityColumns_ = "setAccessibilityColumns:";

	private static readonly IntPtr selSetAccessibilityColumns_Handle = Selector.GetHandle("setAccessibilityColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityContents_ = "setAccessibilityContents:";

	private static readonly IntPtr selSetAccessibilityContents_Handle = Selector.GetHandle("setAccessibilityContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityCriticalValue_ = "setAccessibilityCriticalValue:";

	private static readonly IntPtr selSetAccessibilityCriticalValue_Handle = Selector.GetHandle("setAccessibilityCriticalValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityCustomActions_ = "setAccessibilityCustomActions:";

	private static readonly IntPtr selSetAccessibilityCustomActions_Handle = Selector.GetHandle("setAccessibilityCustomActions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityCustomRotors_ = "setAccessibilityCustomRotors:";

	private static readonly IntPtr selSetAccessibilityCustomRotors_Handle = Selector.GetHandle("setAccessibilityCustomRotors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDecrementButton_ = "setAccessibilityDecrementButton:";

	private static readonly IntPtr selSetAccessibilityDecrementButton_Handle = Selector.GetHandle("setAccessibilityDecrementButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDefaultButton_ = "setAccessibilityDefaultButton:";

	private static readonly IntPtr selSetAccessibilityDefaultButton_Handle = Selector.GetHandle("setAccessibilityDefaultButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDisclosed_ = "setAccessibilityDisclosed:";

	private static readonly IntPtr selSetAccessibilityDisclosed_Handle = Selector.GetHandle("setAccessibilityDisclosed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDisclosedByRow_ = "setAccessibilityDisclosedByRow:";

	private static readonly IntPtr selSetAccessibilityDisclosedByRow_Handle = Selector.GetHandle("setAccessibilityDisclosedByRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDisclosedRows_ = "setAccessibilityDisclosedRows:";

	private static readonly IntPtr selSetAccessibilityDisclosedRows_Handle = Selector.GetHandle("setAccessibilityDisclosedRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDisclosureLevel_ = "setAccessibilityDisclosureLevel:";

	private static readonly IntPtr selSetAccessibilityDisclosureLevel_Handle = Selector.GetHandle("setAccessibilityDisclosureLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDocument_ = "setAccessibilityDocument:";

	private static readonly IntPtr selSetAccessibilityDocument_Handle = Selector.GetHandle("setAccessibilityDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityEdited_ = "setAccessibilityEdited:";

	private static readonly IntPtr selSetAccessibilityEdited_Handle = Selector.GetHandle("setAccessibilityEdited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityElement_ = "setAccessibilityElement:";

	private static readonly IntPtr selSetAccessibilityElement_Handle = Selector.GetHandle("setAccessibilityElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityEnabled_ = "setAccessibilityEnabled:";

	private static readonly IntPtr selSetAccessibilityEnabled_Handle = Selector.GetHandle("setAccessibilityEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityExpanded_ = "setAccessibilityExpanded:";

	private static readonly IntPtr selSetAccessibilityExpanded_Handle = Selector.GetHandle("setAccessibilityExpanded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityExtrasMenuBar_ = "setAccessibilityExtrasMenuBar:";

	private static readonly IntPtr selSetAccessibilityExtrasMenuBar_Handle = Selector.GetHandle("setAccessibilityExtrasMenuBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFilename_ = "setAccessibilityFilename:";

	private static readonly IntPtr selSetAccessibilityFilename_Handle = Selector.GetHandle("setAccessibilityFilename:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFocused_ = "setAccessibilityFocused:";

	private static readonly IntPtr selSetAccessibilityFocused_Handle = Selector.GetHandle("setAccessibilityFocused:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFocusedWindow_ = "setAccessibilityFocusedWindow:";

	private static readonly IntPtr selSetAccessibilityFocusedWindow_Handle = Selector.GetHandle("setAccessibilityFocusedWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFrame_ = "setAccessibilityFrame:";

	private static readonly IntPtr selSetAccessibilityFrame_Handle = Selector.GetHandle("setAccessibilityFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFrontmost_ = "setAccessibilityFrontmost:";

	private static readonly IntPtr selSetAccessibilityFrontmost_Handle = Selector.GetHandle("setAccessibilityFrontmost:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityFullScreenButton_ = "setAccessibilityFullScreenButton:";

	private static readonly IntPtr selSetAccessibilityFullScreenButton_Handle = Selector.GetHandle("setAccessibilityFullScreenButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityGrowArea_ = "setAccessibilityGrowArea:";

	private static readonly IntPtr selSetAccessibilityGrowArea_Handle = Selector.GetHandle("setAccessibilityGrowArea:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHandles_ = "setAccessibilityHandles:";

	private static readonly IntPtr selSetAccessibilityHandles_Handle = Selector.GetHandle("setAccessibilityHandles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHeader_ = "setAccessibilityHeader:";

	private static readonly IntPtr selSetAccessibilityHeader_Handle = Selector.GetHandle("setAccessibilityHeader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHelp_ = "setAccessibilityHelp:";

	private static readonly IntPtr selSetAccessibilityHelp_Handle = Selector.GetHandle("setAccessibilityHelp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHidden_ = "setAccessibilityHidden:";

	private static readonly IntPtr selSetAccessibilityHidden_Handle = Selector.GetHandle("setAccessibilityHidden:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHorizontalScrollBar_ = "setAccessibilityHorizontalScrollBar:";

	private static readonly IntPtr selSetAccessibilityHorizontalScrollBar_Handle = Selector.GetHandle("setAccessibilityHorizontalScrollBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHorizontalUnitDescription_ = "setAccessibilityHorizontalUnitDescription:";

	private static readonly IntPtr selSetAccessibilityHorizontalUnitDescription_Handle = Selector.GetHandle("setAccessibilityHorizontalUnitDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityHorizontalUnits_ = "setAccessibilityHorizontalUnits:";

	private static readonly IntPtr selSetAccessibilityHorizontalUnits_Handle = Selector.GetHandle("setAccessibilityHorizontalUnits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityIdentifier_ = "setAccessibilityIdentifier:";

	private static readonly IntPtr selSetAccessibilityIdentifier_Handle = Selector.GetHandle("setAccessibilityIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityIncrementButton_ = "setAccessibilityIncrementButton:";

	private static readonly IntPtr selSetAccessibilityIncrementButton_Handle = Selector.GetHandle("setAccessibilityIncrementButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityIndex_ = "setAccessibilityIndex:";

	private static readonly IntPtr selSetAccessibilityIndex_Handle = Selector.GetHandle("setAccessibilityIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityInsertionPointLineNumber_ = "setAccessibilityInsertionPointLineNumber:";

	private static readonly IntPtr selSetAccessibilityInsertionPointLineNumber_Handle = Selector.GetHandle("setAccessibilityInsertionPointLineNumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityLabel_ = "setAccessibilityLabel:";

	private static readonly IntPtr selSetAccessibilityLabel_Handle = Selector.GetHandle("setAccessibilityLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityLabelUIElements_ = "setAccessibilityLabelUIElements:";

	private static readonly IntPtr selSetAccessibilityLabelUIElements_Handle = Selector.GetHandle("setAccessibilityLabelUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityLabelValue_ = "setAccessibilityLabelValue:";

	private static readonly IntPtr selSetAccessibilityLabelValue_Handle = Selector.GetHandle("setAccessibilityLabelValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityLinkedUIElements_ = "setAccessibilityLinkedUIElements:";

	private static readonly IntPtr selSetAccessibilityLinkedUIElements_Handle = Selector.GetHandle("setAccessibilityLinkedUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMain_ = "setAccessibilityMain:";

	private static readonly IntPtr selSetAccessibilityMain_Handle = Selector.GetHandle("setAccessibilityMain:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMainWindow_ = "setAccessibilityMainWindow:";

	private static readonly IntPtr selSetAccessibilityMainWindow_Handle = Selector.GetHandle("setAccessibilityMainWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMarkerGroupUIElement_ = "setAccessibilityMarkerGroupUIElement:";

	private static readonly IntPtr selSetAccessibilityMarkerGroupUIElement_Handle = Selector.GetHandle("setAccessibilityMarkerGroupUIElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMarkerTypeDescription_ = "setAccessibilityMarkerTypeDescription:";

	private static readonly IntPtr selSetAccessibilityMarkerTypeDescription_Handle = Selector.GetHandle("setAccessibilityMarkerTypeDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMarkerUIElements_ = "setAccessibilityMarkerUIElements:";

	private static readonly IntPtr selSetAccessibilityMarkerUIElements_Handle = Selector.GetHandle("setAccessibilityMarkerUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMarkerValues_ = "setAccessibilityMarkerValues:";

	private static readonly IntPtr selSetAccessibilityMarkerValues_Handle = Selector.GetHandle("setAccessibilityMarkerValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMaxValue_ = "setAccessibilityMaxValue:";

	private static readonly IntPtr selSetAccessibilityMaxValue_Handle = Selector.GetHandle("setAccessibilityMaxValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMenuBar_ = "setAccessibilityMenuBar:";

	private static readonly IntPtr selSetAccessibilityMenuBar_Handle = Selector.GetHandle("setAccessibilityMenuBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMinValue_ = "setAccessibilityMinValue:";

	private static readonly IntPtr selSetAccessibilityMinValue_Handle = Selector.GetHandle("setAccessibilityMinValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMinimizeButton_ = "setAccessibilityMinimizeButton:";

	private static readonly IntPtr selSetAccessibilityMinimizeButton_Handle = Selector.GetHandle("setAccessibilityMinimizeButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityMinimized_ = "setAccessibilityMinimized:";

	private static readonly IntPtr selSetAccessibilityMinimized_Handle = Selector.GetHandle("setAccessibilityMinimized:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityModal_ = "setAccessibilityModal:";

	private static readonly IntPtr selSetAccessibilityModal_Handle = Selector.GetHandle("setAccessibilityModal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityNextContents_ = "setAccessibilityNextContents:";

	private static readonly IntPtr selSetAccessibilityNextContents_Handle = Selector.GetHandle("setAccessibilityNextContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityNumberOfCharacters_ = "setAccessibilityNumberOfCharacters:";

	private static readonly IntPtr selSetAccessibilityNumberOfCharacters_Handle = Selector.GetHandle("setAccessibilityNumberOfCharacters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityOrderedByRow_ = "setAccessibilityOrderedByRow:";

	private static readonly IntPtr selSetAccessibilityOrderedByRow_Handle = Selector.GetHandle("setAccessibilityOrderedByRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityOrientation_ = "setAccessibilityOrientation:";

	private static readonly IntPtr selSetAccessibilityOrientation_Handle = Selector.GetHandle("setAccessibilityOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityOverflowButton_ = "setAccessibilityOverflowButton:";

	private static readonly IntPtr selSetAccessibilityOverflowButton_Handle = Selector.GetHandle("setAccessibilityOverflowButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityParent_ = "setAccessibilityParent:";

	private static readonly IntPtr selSetAccessibilityParent_Handle = Selector.GetHandle("setAccessibilityParent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityPlaceholderValue_ = "setAccessibilityPlaceholderValue:";

	private static readonly IntPtr selSetAccessibilityPlaceholderValue_Handle = Selector.GetHandle("setAccessibilityPlaceholderValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityPreviousContents_ = "setAccessibilityPreviousContents:";

	private static readonly IntPtr selSetAccessibilityPreviousContents_Handle = Selector.GetHandle("setAccessibilityPreviousContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityProtectedContent_ = "setAccessibilityProtectedContent:";

	private static readonly IntPtr selSetAccessibilityProtectedContent_Handle = Selector.GetHandle("setAccessibilityProtectedContent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityProxy_ = "setAccessibilityProxy:";

	private static readonly IntPtr selSetAccessibilityProxy_Handle = Selector.GetHandle("setAccessibilityProxy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRequired_ = "setAccessibilityRequired:";

	private static readonly IntPtr selSetAccessibilityRequired_Handle = Selector.GetHandle("setAccessibilityRequired:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRole_ = "setAccessibilityRole:";

	private static readonly IntPtr selSetAccessibilityRole_Handle = Selector.GetHandle("setAccessibilityRole:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRoleDescription_ = "setAccessibilityRoleDescription:";

	private static readonly IntPtr selSetAccessibilityRoleDescription_Handle = Selector.GetHandle("setAccessibilityRoleDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRowCount_ = "setAccessibilityRowCount:";

	private static readonly IntPtr selSetAccessibilityRowCount_Handle = Selector.GetHandle("setAccessibilityRowCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRowHeaderUIElements_ = "setAccessibilityRowHeaderUIElements:";

	private static readonly IntPtr selSetAccessibilityRowHeaderUIElements_Handle = Selector.GetHandle("setAccessibilityRowHeaderUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRowIndexRange_ = "setAccessibilityRowIndexRange:";

	private static readonly IntPtr selSetAccessibilityRowIndexRange_Handle = Selector.GetHandle("setAccessibilityRowIndexRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRows_ = "setAccessibilityRows:";

	private static readonly IntPtr selSetAccessibilityRows_Handle = Selector.GetHandle("setAccessibilityRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityRulerMarkerType_ = "setAccessibilityRulerMarkerType:";

	private static readonly IntPtr selSetAccessibilityRulerMarkerType_Handle = Selector.GetHandle("setAccessibilityRulerMarkerType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySearchButton_ = "setAccessibilitySearchButton:";

	private static readonly IntPtr selSetAccessibilitySearchButton_Handle = Selector.GetHandle("setAccessibilitySearchButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySearchMenu_ = "setAccessibilitySearchMenu:";

	private static readonly IntPtr selSetAccessibilitySearchMenu_Handle = Selector.GetHandle("setAccessibilitySearchMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelected_ = "setAccessibilitySelected:";

	private static readonly IntPtr selSetAccessibilitySelected_Handle = Selector.GetHandle("setAccessibilitySelected:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedCells_ = "setAccessibilitySelectedCells:";

	private static readonly IntPtr selSetAccessibilitySelectedCells_Handle = Selector.GetHandle("setAccessibilitySelectedCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedChildren_ = "setAccessibilitySelectedChildren:";

	private static readonly IntPtr selSetAccessibilitySelectedChildren_Handle = Selector.GetHandle("setAccessibilitySelectedChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedColumns_ = "setAccessibilitySelectedColumns:";

	private static readonly IntPtr selSetAccessibilitySelectedColumns_Handle = Selector.GetHandle("setAccessibilitySelectedColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedRows_ = "setAccessibilitySelectedRows:";

	private static readonly IntPtr selSetAccessibilitySelectedRows_Handle = Selector.GetHandle("setAccessibilitySelectedRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedText_ = "setAccessibilitySelectedText:";

	private static readonly IntPtr selSetAccessibilitySelectedText_Handle = Selector.GetHandle("setAccessibilitySelectedText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedTextRange_ = "setAccessibilitySelectedTextRange:";

	private static readonly IntPtr selSetAccessibilitySelectedTextRange_Handle = Selector.GetHandle("setAccessibilitySelectedTextRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedTextRanges_ = "setAccessibilitySelectedTextRanges:";

	private static readonly IntPtr selSetAccessibilitySelectedTextRanges_Handle = Selector.GetHandle("setAccessibilitySelectedTextRanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityServesAsTitleForUIElements_ = "setAccessibilityServesAsTitleForUIElements:";

	private static readonly IntPtr selSetAccessibilityServesAsTitleForUIElements_Handle = Selector.GetHandle("setAccessibilityServesAsTitleForUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySharedCharacterRange_ = "setAccessibilitySharedCharacterRange:";

	private static readonly IntPtr selSetAccessibilitySharedCharacterRange_Handle = Selector.GetHandle("setAccessibilitySharedCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySharedFocusElements_ = "setAccessibilitySharedFocusElements:";

	private static readonly IntPtr selSetAccessibilitySharedFocusElements_Handle = Selector.GetHandle("setAccessibilitySharedFocusElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySharedTextUIElements_ = "setAccessibilitySharedTextUIElements:";

	private static readonly IntPtr selSetAccessibilitySharedTextUIElements_Handle = Selector.GetHandle("setAccessibilitySharedTextUIElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityShownMenu_ = "setAccessibilityShownMenu:";

	private static readonly IntPtr selSetAccessibilityShownMenu_Handle = Selector.GetHandle("setAccessibilityShownMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySortDirection_ = "setAccessibilitySortDirection:";

	private static readonly IntPtr selSetAccessibilitySortDirection_Handle = Selector.GetHandle("setAccessibilitySortDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySplitters_ = "setAccessibilitySplitters:";

	private static readonly IntPtr selSetAccessibilitySplitters_Handle = Selector.GetHandle("setAccessibilitySplitters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySubrole_ = "setAccessibilitySubrole:";

	private static readonly IntPtr selSetAccessibilitySubrole_Handle = Selector.GetHandle("setAccessibilitySubrole:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityTabs_ = "setAccessibilityTabs:";

	private static readonly IntPtr selSetAccessibilityTabs_Handle = Selector.GetHandle("setAccessibilityTabs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityTitle_ = "setAccessibilityTitle:";

	private static readonly IntPtr selSetAccessibilityTitle_Handle = Selector.GetHandle("setAccessibilityTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityTitleUIElement_ = "setAccessibilityTitleUIElement:";

	private static readonly IntPtr selSetAccessibilityTitleUIElement_Handle = Selector.GetHandle("setAccessibilityTitleUIElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityToolbarButton_ = "setAccessibilityToolbarButton:";

	private static readonly IntPtr selSetAccessibilityToolbarButton_Handle = Selector.GetHandle("setAccessibilityToolbarButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityTopLevelUIElement_ = "setAccessibilityTopLevelUIElement:";

	private static readonly IntPtr selSetAccessibilityTopLevelUIElement_Handle = Selector.GetHandle("setAccessibilityTopLevelUIElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityURL_ = "setAccessibilityURL:";

	private static readonly IntPtr selSetAccessibilityURL_Handle = Selector.GetHandle("setAccessibilityURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityUnitDescription_ = "setAccessibilityUnitDescription:";

	private static readonly IntPtr selSetAccessibilityUnitDescription_Handle = Selector.GetHandle("setAccessibilityUnitDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityUnits_ = "setAccessibilityUnits:";

	private static readonly IntPtr selSetAccessibilityUnits_Handle = Selector.GetHandle("setAccessibilityUnits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityValue_ = "setAccessibilityValue:";

	private static readonly IntPtr selSetAccessibilityValue_Handle = Selector.GetHandle("setAccessibilityValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityValueDescription_ = "setAccessibilityValueDescription:";

	private static readonly IntPtr selSetAccessibilityValueDescription_Handle = Selector.GetHandle("setAccessibilityValueDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVerticalScrollBar_ = "setAccessibilityVerticalScrollBar:";

	private static readonly IntPtr selSetAccessibilityVerticalScrollBar_Handle = Selector.GetHandle("setAccessibilityVerticalScrollBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVerticalUnitDescription_ = "setAccessibilityVerticalUnitDescription:";

	private static readonly IntPtr selSetAccessibilityVerticalUnitDescription_Handle = Selector.GetHandle("setAccessibilityVerticalUnitDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVerticalUnits_ = "setAccessibilityVerticalUnits:";

	private static readonly IntPtr selSetAccessibilityVerticalUnits_Handle = Selector.GetHandle("setAccessibilityVerticalUnits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVisibleCells_ = "setAccessibilityVisibleCells:";

	private static readonly IntPtr selSetAccessibilityVisibleCells_Handle = Selector.GetHandle("setAccessibilityVisibleCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVisibleCharacterRange_ = "setAccessibilityVisibleCharacterRange:";

	private static readonly IntPtr selSetAccessibilityVisibleCharacterRange_Handle = Selector.GetHandle("setAccessibilityVisibleCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVisibleChildren_ = "setAccessibilityVisibleChildren:";

	private static readonly IntPtr selSetAccessibilityVisibleChildren_Handle = Selector.GetHandle("setAccessibilityVisibleChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVisibleColumns_ = "setAccessibilityVisibleColumns:";

	private static readonly IntPtr selSetAccessibilityVisibleColumns_Handle = Selector.GetHandle("setAccessibilityVisibleColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityVisibleRows_ = "setAccessibilityVisibleRows:";

	private static readonly IntPtr selSetAccessibilityVisibleRows_Handle = Selector.GetHandle("setAccessibilityVisibleRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityWarningValue_ = "setAccessibilityWarningValue:";

	private static readonly IntPtr selSetAccessibilityWarningValue_Handle = Selector.GetHandle("setAccessibilityWarningValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityWindow_ = "setAccessibilityWindow:";

	private static readonly IntPtr selSetAccessibilityWindow_Handle = Selector.GetHandle("setAccessibilityWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityWindows_ = "setAccessibilityWindows:";

	private static readonly IntPtr selSetAccessibilityWindows_Handle = Selector.GetHandle("setAccessibilityWindows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityZoomButton_ = "setAccessibilityZoomButton:";

	private static readonly IntPtr selSetAccessibilityZoomButton_Handle = Selector.GetHandle("setAccessibilityZoomButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlphaValue_ = "setAlphaValue:";

	private static readonly IntPtr selSetAlphaValue_Handle = Selector.GetHandle("setAlphaValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimations_ = "setAnimations:";

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAppearance_ = "setAppearance:";

	private static readonly IntPtr selSetAppearance_Handle = Selector.GetHandle("setAppearance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoresizesSubviews_ = "setAutoresizesSubviews:";

	private static readonly IntPtr selSetAutoresizesSubviews_Handle = Selector.GetHandle("setAutoresizesSubviews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoresizingMask_ = "setAutoresizingMask:";

	private static readonly IntPtr selSetAutoresizingMask_Handle = Selector.GetHandle("setAutoresizingMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundFilters_ = "setBackgroundFilters:";

	private static readonly IntPtr selSetBackgroundFilters_Handle = Selector.GetHandle("setBackgroundFilters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBounds_ = "setBounds:";

	private static readonly IntPtr selSetBounds_Handle = Selector.GetHandle("setBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBoundsOrigin_ = "setBoundsOrigin:";

	private static readonly IntPtr selSetBoundsOrigin_Handle = Selector.GetHandle("setBoundsOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBoundsRotation_ = "setBoundsRotation:";

	private static readonly IntPtr selSetBoundsRotation_Handle = Selector.GetHandle("setBoundsRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBoundsSize_ = "setBoundsSize:";

	private static readonly IntPtr selSetBoundsSize_Handle = Selector.GetHandle("setBoundsSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanDrawConcurrently_ = "setCanDrawConcurrently:";

	private static readonly IntPtr selSetCanDrawConcurrently_Handle = Selector.GetHandle("setCanDrawConcurrently:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanDrawSubviewsIntoLayer_ = "setCanDrawSubviewsIntoLayer:";

	private static readonly IntPtr selSetCanDrawSubviewsIntoLayer_Handle = Selector.GetHandle("setCanDrawSubviewsIntoLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompositingFilter_ = "setCompositingFilter:";

	private static readonly IntPtr selSetCompositingFilter_Handle = Selector.GetHandle("setCompositingFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentCompressionResistancePriority_ForOrientation_ = "setContentCompressionResistancePriority:forOrientation:";

	private static readonly IntPtr selSetContentCompressionResistancePriority_ForOrientation_Handle = Selector.GetHandle("setContentCompressionResistancePriority:forOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentFilters_ = "setContentFilters:";

	private static readonly IntPtr selSetContentFilters_Handle = Selector.GetHandle("setContentFilters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentHuggingPriority_ForOrientation_ = "setContentHuggingPriority:forOrientation:";

	private static readonly IntPtr selSetContentHuggingPriority_ForOrientation_Handle = Selector.GetHandle("setContentHuggingPriority:forOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFocusRingType_ = "setFocusRingType:";

	private static readonly IntPtr selSetFocusRingType_Handle = Selector.GetHandle("setFocusRingType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrame_ = "setFrame:";

	private static readonly IntPtr selSetFrame_Handle = Selector.GetHandle("setFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameCenterRotation_ = "setFrameCenterRotation:";

	private static readonly IntPtr selSetFrameCenterRotation_Handle = Selector.GetHandle("setFrameCenterRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameOrigin_ = "setFrameOrigin:";

	private static readonly IntPtr selSetFrameOrigin_Handle = Selector.GetHandle("setFrameOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameRotation_ = "setFrameRotation:";

	private static readonly IntPtr selSetFrameRotation_Handle = Selector.GetHandle("setFrameRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameSize_ = "setFrameSize:";

	private static readonly IntPtr selSetFrameSize_Handle = Selector.GetHandle("setFrameSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGestureRecognizers_ = "setGestureRecognizers:";

	private static readonly IntPtr selSetGestureRecognizers_Handle = Selector.GetHandle("setGestureRecognizers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHidden_ = "setHidden:";

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizontalContentSizeConstraintActive_ = "setHorizontalContentSizeConstraintActive:";

	private static readonly IntPtr selSetHorizontalContentSizeConstraintActive_Handle = Selector.GetHandle("setHorizontalContentSizeConstraintActive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdentifier_ = "setIdentifier:";

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyboardFocusRingNeedsDisplayInRect_ = "setKeyboardFocusRingNeedsDisplayInRect:";

	private static readonly IntPtr selSetKeyboardFocusRingNeedsDisplayInRect_Handle = Selector.GetHandle("setKeyboardFocusRingNeedsDisplayInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayer_ = "setLayer:";

	private static readonly IntPtr selSetLayer_Handle = Selector.GetHandle("setLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayerContentsPlacement_ = "setLayerContentsPlacement:";

	private static readonly IntPtr selSetLayerContentsPlacement_Handle = Selector.GetHandle("setLayerContentsPlacement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayerContentsRedrawPolicy_ = "setLayerContentsRedrawPolicy:";

	private static readonly IntPtr selSetLayerContentsRedrawPolicy_Handle = Selector.GetHandle("setLayerContentsRedrawPolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayerUsesCoreImageFilters_ = "setLayerUsesCoreImageFilters:";

	private static readonly IntPtr selSetLayerUsesCoreImageFilters_Handle = Selector.GetHandle("setLayerUsesCoreImageFilters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplay_ = "setNeedsDisplay:";

	private static readonly IntPtr selSetNeedsDisplay_Handle = Selector.GetHandle("setNeedsDisplay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplayInRect_ = "setNeedsDisplayInRect:";

	private static readonly IntPtr selSetNeedsDisplayInRect_Handle = Selector.GetHandle("setNeedsDisplayInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsLayout_ = "setNeedsLayout:";

	private static readonly IntPtr selSetNeedsLayout_Handle = Selector.GetHandle("setNeedsLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsUpdateConstraints_ = "setNeedsUpdateConstraints:";

	private static readonly IntPtr selSetNeedsUpdateConstraints_Handle = Selector.GetHandle("setNeedsUpdateConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNextKeyView_ = "setNextKeyView:";

	private static readonly IntPtr selSetNextKeyView_Handle = Selector.GetHandle("setNextKeyView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPostsBoundsChangedNotifications_ = "setPostsBoundsChangedNotifications:";

	private static readonly IntPtr selSetPostsBoundsChangedNotifications_Handle = Selector.GetHandle("setPostsBoundsChangedNotifications:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPostsFrameChangedNotifications_ = "setPostsFrameChangedNotifications:";

	private static readonly IntPtr selSetPostsFrameChangedNotifications_Handle = Selector.GetHandle("setPostsFrameChangedNotifications:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreparedContentRect_ = "setPreparedContentRect:";

	private static readonly IntPtr selSetPreparedContentRect_Handle = Selector.GetHandle("setPreparedContentRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPressureConfiguration_ = "setPressureConfiguration:";

	private static readonly IntPtr selSetPressureConfiguration_Handle = Selector.GetHandle("setPressureConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShadow_ = "setShadow:";

	private static readonly IntPtr selSetShadow_Handle = Selector.GetHandle("setShadow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubviews_ = "setSubviews:";

	private static readonly IntPtr selSetSubviews_Handle = Selector.GetHandle("setSubviews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetToolTip_ = "setToolTip:";

	private static readonly IntPtr selSetToolTip_Handle = Selector.GetHandle("setToolTip:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTranslatesAutoresizingMaskIntoConstraints_ = "setTranslatesAutoresizingMaskIntoConstraints:";

	private static readonly IntPtr selSetTranslatesAutoresizingMaskIntoConstraints_Handle = Selector.GetHandle("setTranslatesAutoresizingMaskIntoConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUpGState = "setUpGState";

	private static readonly IntPtr selSetUpGStateHandle = Selector.GetHandle("setUpGState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserInterfaceLayoutDirection_ = "setUserInterfaceLayoutDirection:";

	private static readonly IntPtr selSetUserInterfaceLayoutDirection_Handle = Selector.GetHandle("setUserInterfaceLayoutDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerticalContentSizeConstraintActive_ = "setVerticalContentSizeConstraintActive:";

	private static readonly IntPtr selSetVerticalContentSizeConstraintActive_Handle = Selector.GetHandle("setVerticalContentSizeConstraintActive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWantsBestResolutionOpenGLSurface_ = "setWantsBestResolutionOpenGLSurface:";

	private static readonly IntPtr selSetWantsBestResolutionOpenGLSurface_Handle = Selector.GetHandle("setWantsBestResolutionOpenGLSurface:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWantsLayer_ = "setWantsLayer:";

	private static readonly IntPtr selSetWantsLayer_Handle = Selector.GetHandle("setWantsLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWantsRestingTouches_ = "setWantsRestingTouches:";

	private static readonly IntPtr selSetWantsRestingTouches_Handle = Selector.GetHandle("setWantsRestingTouches:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShadow = "shadow";

	private static readonly IntPtr selShadowHandle = Selector.GetHandle("shadow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldDelayWindowOrderingForEvent_ = "shouldDelayWindowOrderingForEvent:";

	private static readonly IntPtr selShouldDelayWindowOrderingForEvent_Handle = Selector.GetHandle("shouldDelayWindowOrderingForEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldDrawColor = "shouldDrawColor";

	private static readonly IntPtr selShouldDrawColorHandle = Selector.GetHandle("shouldDrawColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortSubviewsUsingFunction_Context_ = "sortSubviewsUsingFunction:context:";

	private static readonly IntPtr selSortSubviewsUsingFunction_Context_Handle = Selector.GetHandle("sortSubviewsUsingFunction:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubviews = "subviews";

	private static readonly IntPtr selSubviewsHandle = Selector.GetHandle("subviews");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuperview = "superview";

	private static readonly IntPtr selSuperviewHandle = Selector.GetHandle("superview");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTag = "tag";

	private static readonly IntPtr selTagHandle = Selector.GetHandle("tag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolTip = "toolTip";

	private static readonly IntPtr selToolTipHandle = Selector.GetHandle("toolTip");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTopAnchor = "topAnchor";

	private static readonly IntPtr selTopAnchorHandle = Selector.GetHandle("topAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackingAreas = "trackingAreas";

	private static readonly IntPtr selTrackingAreasHandle = Selector.GetHandle("trackingAreas");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrailingAnchor = "trailingAnchor";

	private static readonly IntPtr selTrailingAnchorHandle = Selector.GetHandle("trailingAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTranslateOriginToPoint_ = "translateOriginToPoint:";

	private static readonly IntPtr selTranslateOriginToPoint_Handle = Selector.GetHandle("translateOriginToPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTranslateRectsNeedingDisplayInRect_By_ = "translateRectsNeedingDisplayInRect:by:";

	private static readonly IntPtr selTranslateRectsNeedingDisplayInRect_By_Handle = Selector.GetHandle("translateRectsNeedingDisplayInRect:by:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTranslatesAutoresizingMaskIntoConstraints = "translatesAutoresizingMaskIntoConstraints";

	private static readonly IntPtr selTranslatesAutoresizingMaskIntoConstraintsHandle = Selector.GetHandle("translatesAutoresizingMaskIntoConstraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlockFocus = "unlockFocus";

	private static readonly IntPtr selUnlockFocusHandle = Selector.GetHandle("unlockFocus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnregisterDraggedTypes = "unregisterDraggedTypes";

	private static readonly IntPtr selUnregisterDraggedTypesHandle = Selector.GetHandle("unregisterDraggedTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateConstraints = "updateConstraints";

	private static readonly IntPtr selUpdateConstraintsHandle = Selector.GetHandle("updateConstraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateConstraintsForSubtreeIfNeeded = "updateConstraintsForSubtreeIfNeeded";

	private static readonly IntPtr selUpdateConstraintsForSubtreeIfNeededHandle = Selector.GetHandle("updateConstraintsForSubtreeIfNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateLayer = "updateLayer";

	private static readonly IntPtr selUpdateLayerHandle = Selector.GetHandle("updateLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateTrackingAreas = "updateTrackingAreas";

	private static readonly IntPtr selUpdateTrackingAreasHandle = Selector.GetHandle("updateTrackingAreas");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserInterfaceLayoutDirection = "userInterfaceLayoutDirection";

	private static readonly IntPtr selUserInterfaceLayoutDirectionHandle = Selector.GetHandle("userInterfaceLayoutDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidChangeBackingProperties = "viewDidChangeBackingProperties";

	private static readonly IntPtr selViewDidChangeBackingPropertiesHandle = Selector.GetHandle("viewDidChangeBackingProperties");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidChangeEffectiveAppearance = "viewDidChangeEffectiveAppearance";

	private static readonly IntPtr selViewDidChangeEffectiveAppearanceHandle = Selector.GetHandle("viewDidChangeEffectiveAppearance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidEndLiveResize = "viewDidEndLiveResize";

	private static readonly IntPtr selViewDidEndLiveResizeHandle = Selector.GetHandle("viewDidEndLiveResize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidHide = "viewDidHide";

	private static readonly IntPtr selViewDidHideHandle = Selector.GetHandle("viewDidHide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidMoveToSuperview = "viewDidMoveToSuperview";

	private static readonly IntPtr selViewDidMoveToSuperviewHandle = Selector.GetHandle("viewDidMoveToSuperview");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidMoveToWindow = "viewDidMoveToWindow";

	private static readonly IntPtr selViewDidMoveToWindowHandle = Selector.GetHandle("viewDidMoveToWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidUnhide = "viewDidUnhide";

	private static readonly IntPtr selViewDidUnhideHandle = Selector.GetHandle("viewDidUnhide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWillDraw = "viewWillDraw";

	private static readonly IntPtr selViewWillDrawHandle = Selector.GetHandle("viewWillDraw");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWillMoveToSuperview_ = "viewWillMoveToSuperview:";

	private static readonly IntPtr selViewWillMoveToSuperview_Handle = Selector.GetHandle("viewWillMoveToSuperview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWillMoveToWindow_ = "viewWillMoveToWindow:";

	private static readonly IntPtr selViewWillMoveToWindow_Handle = Selector.GetHandle("viewWillMoveToWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWillStartLiveResize = "viewWillStartLiveResize";

	private static readonly IntPtr selViewWillStartLiveResizeHandle = Selector.GetHandle("viewWillStartLiveResize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWithTag_ = "viewWithTag:";

	private static readonly IntPtr selViewWithTag_Handle = Selector.GetHandle("viewWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibleRect = "visibleRect";

	private static readonly IntPtr selVisibleRectHandle = Selector.GetHandle("visibleRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsBestResolutionOpenGLSurface = "wantsBestResolutionOpenGLSurface";

	private static readonly IntPtr selWantsBestResolutionOpenGLSurfaceHandle = Selector.GetHandle("wantsBestResolutionOpenGLSurface");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsDefaultClipping = "wantsDefaultClipping";

	private static readonly IntPtr selWantsDefaultClippingHandle = Selector.GetHandle("wantsDefaultClipping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsLayer = "wantsLayer";

	private static readonly IntPtr selWantsLayerHandle = Selector.GetHandle("wantsLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsPeriodicDraggingUpdates = "wantsPeriodicDraggingUpdates";

	private static readonly IntPtr selWantsPeriodicDraggingUpdatesHandle = Selector.GetHandle("wantsPeriodicDraggingUpdates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsRestingTouches = "wantsRestingTouches";

	private static readonly IntPtr selWantsRestingTouchesHandle = Selector.GetHandle("wantsRestingTouches");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsUpdateLayer = "wantsUpdateLayer";

	private static readonly IntPtr selWantsUpdateLayerHandle = Selector.GetHandle("wantsUpdateLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidthAdjustLimit = "widthAdjustLimit";

	private static readonly IntPtr selWidthAdjustLimitHandle = Selector.GetHandle("widthAdjustLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidthAnchor = "widthAnchor";

	private static readonly IntPtr selWidthAnchorHandle = Selector.GetHandle("widthAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillOpenMenu_WithEvent_ = "willOpenMenu:withEvent:";

	private static readonly IntPtr selWillOpenMenu_WithEvent_Handle = Selector.GetHandle("willOpenMenu:withEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillRemoveSubview_ = "willRemoveSubview:";

	private static readonly IntPtr selWillRemoveSubview_Handle = Selector.GetHandle("willRemoveSubview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindow = "window";

	private static readonly IntPtr selWindowHandle = Selector.GetHandle("window");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteEPSInsideRect_ToPasteboard_ = "writeEPSInsideRect:toPasteboard:";

	private static readonly IntPtr selWriteEPSInsideRect_ToPasteboard_Handle = Selector.GetHandle("writeEPSInsideRect:toPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritePDFInsideRect_ToPasteboard_ = "writePDFInsideRect:toPasteboard:";

	private static readonly IntPtr selWritePDFInsideRect_ToPasteboard_Handle = Selector.GetHandle("writePDFInsideRect:toPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityDisclosedByRow_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityExtrasMenuBar_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityMenuBar_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityParent_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityTitleUIElement_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityTopLevelUIElement_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_AccessibilityWindow_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnnouncementRequestedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationActivatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationDeactivatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationHiddenNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationShownNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BoundsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DrawerCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FocusChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FocusedWindowChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GlobalFrameChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HelpTagCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LayoutChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MainWindowChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MovedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSFullScreenModeAllScreens;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSFullScreenModeApplicationPresentationOptions;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSFullScreenModeSetting;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSFullScreenModeWindowLevel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResizedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowCollapsedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowCountChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RowExpandedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedCellsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedChildrenChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedChildrenMovedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedColumnsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedRowsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedTextChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SheetCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TitleChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UIElementDestroyedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UIElementFocusedChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnitsChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UpdatedTrackingAreasNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ValueChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowDeminiaturizedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowMiniaturizedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowMovedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowResizedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.None, null)]
	public virtual bool AcceptsTouchEvents
	{
		[Deprecated(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.None, null)]
		[Export("acceptsTouchEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAcceptsTouchEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsTouchEventsHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.None, null)]
		[Export("setAcceptsTouchEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAcceptsTouchEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAcceptsTouchEvents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
	public virtual NSArray AccessibilityActionNames
	{
		[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
		[Export("accessibilityActionNames")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityActionNamesHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityActionNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGPoint AccessibilityActivationPoint
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityActivationPoint", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selAccessibilityActivationPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selAccessibilityActivationPointHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityActivationPoint:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetAccessibilityActivationPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetAccessibilityActivationPoint_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSNumber[]? AccessibilityAllowedValues
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityAllowedValues", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityAllowedValuesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityAllowedValuesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityAllowedValues:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityAllowedValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityAllowedValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityAlternateUIVisible
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityAlternateUIVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityAlternateUIVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityAlternateUIVisibleHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityAlternateUIVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityAlternateUIVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityAlternateUIVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityApplicationFocusedUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityApplicationFocusedUIElement", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityApplicationFocusedUIElementHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityApplicationFocusedUIElementHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityApplicationFocusedUIElement:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityApplicationFocusedUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityApplicationFocusedUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
	public virtual NSArray AccessibilityAttributeNames
	{
		[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
		[Export("accessibilityAttributeNames")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityAttributeNamesHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityAttributeNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityCancelButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityCancelButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityCancelButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityCancelButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCancelButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityCancelButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityCancelButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityChildren
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityChildren", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityChildrenHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityChildrenHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityChildren:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityElement[]? AccessibilityChildrenInNavigationOrder
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("accessibilityChildrenInNavigationOrder", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSAccessibilityElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityChildrenInNavigationOrderHandle));
			}
			return NSArray.ArrayFromHandle<NSAccessibilityElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityChildrenInNavigationOrderHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setAccessibilityChildrenInNavigationOrder:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityChildrenInNavigationOrder_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityChildrenInNavigationOrder_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityClearButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityClearButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityClearButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityClearButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityClearButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityClearButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityClearButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityCloseButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityCloseButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityCloseButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityCloseButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCloseButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityCloseButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityCloseButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityColumnCount
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnCount")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityColumnCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnCountHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnCount:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityColumnCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityColumnCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityColumnHeaderUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnHeaderUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityColumnHeaderUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnHeaderUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnHeaderUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityColumnHeaderUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityColumnHeaderUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSRange AccessibilityColumnIndexRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnIndexRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilityColumnIndexRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnIndexRangeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnIndexRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetAccessibilityColumnIndexRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetAccessibilityColumnIndexRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityColumnTitles
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnTitles", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityColumnTitlesHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnTitlesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnTitles:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityColumnTitles_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityColumnTitles_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityColumns
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumns", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumns:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityContents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityContents", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityContentsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityContentsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityContents:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityCriticalValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityCriticalValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityCriticalValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityCriticalValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCriticalValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityCriticalValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityCriticalValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityCustomAction[]? AccessibilityCustomActions
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("accessibilityCustomActions", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSAccessibilityCustomAction>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityCustomActionsHandle));
			}
			return NSArray.ArrayFromHandle<NSAccessibilityCustomAction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityCustomActionsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCustomActions:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityCustomActions_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityCustomActions_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityCustomRotor[] AccessibilityCustomRotors
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("accessibilityCustomRotors", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSAccessibilityCustomRotor>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityCustomRotorsHandle));
			}
			return NSArray.ArrayFromHandle<NSAccessibilityCustomRotor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityCustomRotorsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCustomRotors:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityCustomRotors_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityCustomRotors_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityDecrementButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDecrementButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDecrementButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDecrementButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDecrementButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityDecrementButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityDecrementButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityDefaultButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDefaultButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDefaultButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDefaultButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDefaultButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityDefaultButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityDefaultButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityDisclosed
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityDisclosed")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityDisclosedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityDisclosedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosed:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityDisclosed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityDisclosed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityDisclosedByRow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDisclosedByRow", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisclosedByRowHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDisclosedByRowHandle)));
			MarkDirty();
			__mt_AccessibilityDisclosedByRow_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosedByRow:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityDisclosedByRow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityDisclosedByRow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityDisclosedByRow_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityDisclosedRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDisclosedRows", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDisclosedRowsHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisclosedRowsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosedRows:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityDisclosedRows_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityDisclosedRows_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityDisclosureLevel
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDisclosureLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityDisclosureLevelHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisclosureLevelHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosureLevel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityDisclosureLevel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityDisclosureLevel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityDocument
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDocument")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDocumentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDocumentHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDocument:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityDocument_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityDocument_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityEdited
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityEdited")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityEditedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityEditedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityEdited:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityEdited_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityEdited_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityElement")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityElementHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityElementHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityElement:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityElement_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityElement_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityEnabledHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityExpanded
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityExpanded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityExpandedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityExpandedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityExpanded:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityExpanded_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityExpanded_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityExtrasMenuBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityExtrasMenuBar", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityExtrasMenuBarHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityExtrasMenuBarHandle)));
			MarkDirty();
			__mt_AccessibilityExtrasMenuBar_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityExtrasMenuBar:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityExtrasMenuBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityExtrasMenuBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityExtrasMenuBar_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityFilename
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFilename")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityFilenameHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFilename:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityFilename_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityFilename_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityFocused
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityFocused")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityFocusedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityFocusedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFocused:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityFocused_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityFocused_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityFocusedWindow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFocusedWindow", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityFocusedWindowHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityFocusedWindowHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFocusedWindow:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityFocusedWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityFocusedWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGRect AccessibilityFrame
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFrame", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selAccessibilityFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAccessibilityFrameHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFrame:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetAccessibilityFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetAccessibilityFrame_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityFrontmost
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityFrontmost")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityFrontmostHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityFrontmostHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFrontmost:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityFrontmost_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityFrontmost_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityFullScreenButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFullScreenButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityFullScreenButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityFullScreenButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFullScreenButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityFullScreenButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityFullScreenButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityGrowArea
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityGrowArea", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityGrowAreaHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityGrowAreaHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityGrowArea:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityGrowArea_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityGrowArea_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityHandles
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHandles", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHandlesHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHandlesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHandles:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityHandles_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityHandles_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityHeader
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHeader", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHeaderHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHeaderHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHeader:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityHeader_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityHeader_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityHelp
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHelp")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHelpHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHelpHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHelp:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityHelp_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityHelp_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityHidden
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityHiddenHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityHidden_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityHorizontalScrollBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHorizontalScrollBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHorizontalScrollBarHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHorizontalScrollBarHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHorizontalScrollBar:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityHorizontalScrollBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityHorizontalScrollBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityHorizontalUnitDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHorizontalUnitDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHorizontalUnitDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHorizontalUnitDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHorizontalUnitDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityHorizontalUnitDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityHorizontalUnitDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityUnits AccessibilityHorizontalUnits
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHorizontalUnits", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityUnits)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilityHorizontalUnitsHandle);
			}
			return (NSAccessibilityUnits)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilityHorizontalUnitsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHorizontalUnits:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilityHorizontalUnits_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilityHorizontalUnits_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityIdentifierHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityIncrementButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityIncrementButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityIncrementButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityIncrementButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityIncrementButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityIncrementButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityIncrementButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityIndex
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityIndexHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityInsertionPointLineNumber
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityInsertionPointLineNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityInsertionPointLineNumberHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityInsertionPointLineNumberHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityInsertionPointLineNumber:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityInsertionPointLineNumber_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityInsertionPointLineNumber_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
	public virtual bool AccessibilityIsIgnored
	{
		[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
		[Export("accessibilityIsIgnored")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityIsIgnoredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityIsIgnoredHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityLabel
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityLabelHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLabel:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityLabelUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLabelUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityLabelUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityLabelUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLabelUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityLabelUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityLabelUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual float AccessibilityLabelValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLabelValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAccessibilityLabelValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAccessibilityLabelValueHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLabelValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetAccessibilityLabelValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetAccessibilityLabelValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityLinkedUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLinkedUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityLinkedUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityLinkedUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLinkedUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityLinkedUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityLinkedUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityMain
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityMain")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityMainHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityMainHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMain:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityMain_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityMain_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMainWindow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMainWindow", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMainWindowHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMainWindowHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMainWindow:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMainWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMainWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMarkerGroupUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerGroupUIElement", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMarkerGroupUIElementHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMarkerGroupUIElementHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerGroupUIElement:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMarkerGroupUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMarkerGroupUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityMarkerTypeDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerTypeDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMarkerTypeDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMarkerTypeDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerTypeDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMarkerTypeDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMarkerTypeDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityMarkerUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMarkerUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMarkerUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMarkerUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMarkerUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMarkerValues
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerValues", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMarkerValuesHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMarkerValuesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerValues:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMarkerValues_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMarkerValues_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMaxValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMaxValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMaxValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMaxValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMaxValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMaxValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMaxValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMenuBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMenuBar", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMenuBarHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMenuBarHandle)));
			MarkDirty();
			__mt_AccessibilityMenuBar_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMenuBar:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMenuBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMenuBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityMenuBar_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMinValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMinValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMinValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMinValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMinValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMinValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMinValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityMinimizeButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMinimizeButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMinimizeButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMinimizeButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMinimizeButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityMinimizeButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityMinimizeButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityMinimized
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityMinimized")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityMinimizedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityMinimizedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMinimized:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityMinimized_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityMinimized_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityModal
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityModal")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityModalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityModalHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityModal:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityModal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityModal_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityNextContents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityNextContents", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityNextContentsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityNextContentsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityNextContents:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityNextContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityNextContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityNotifiesWhenDestroyed
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("accessibilityNotifiesWhenDestroyed")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityNotifiesWhenDestroyedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityNotifiesWhenDestroyedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityNumberOfCharacters
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityNumberOfCharacters")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityNumberOfCharactersHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityNumberOfCharactersHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityNumberOfCharacters:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityNumberOfCharacters_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityNumberOfCharacters_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityOrderedByRow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityOrderedByRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityOrderedByRowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityOrderedByRowHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityOrderedByRow:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityOrderedByRow_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityOrderedByRow_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityOrientation AccessibilityOrientation
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityOrientation", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityOrientation)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilityOrientationHandle);
			}
			return (NSAccessibilityOrientation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilityOrientationHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityOrientation:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilityOrientation_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilityOrientation_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityOverflowButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityOverflowButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityOverflowButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityOverflowButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityOverflowButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityOverflowButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityOverflowButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
	public virtual NSArray AccessibilityParameterizedAttributeNames
	{
		[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
		[Export("accessibilityParameterizedAttributeNames")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParameterizedAttributeNamesHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParameterizedAttributeNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityParent
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityParent", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParentHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParentHandle)));
			MarkDirty();
			__mt_AccessibilityParent_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityParent:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityParent_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityParent_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityParent_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityPlaceholderValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityPlaceholderValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityPlaceholderValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityPlaceholderValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityPlaceholderValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityPlaceholderValue_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityPlaceholderValue_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityPreviousContents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityPreviousContents", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityPreviousContentsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityPreviousContentsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityPreviousContents:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityPreviousContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityPreviousContents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityProtectedContent
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityProtectedContent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityProtectedContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityProtectedContentHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityProtectedContent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityProtectedContent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityProtectedContent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityProxy
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityProxy", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityProxyHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityProxyHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityProxy:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityProxy_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityProxy_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityRequired
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("isAccessibilityRequired")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityRequiredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityRequiredHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRequired:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilityRequired_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilityRequired_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityRole
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRole")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRoleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRoleHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRole:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityRole_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityRole_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityRoleDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRoleDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRoleDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRoleDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRoleDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityRoleDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityRoleDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityRowCount
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRowCount")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAccessibilityRowCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowCountHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRowCount:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAccessibilityRowCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAccessibilityRowCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityRowHeaderUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRowHeaderUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRowHeaderUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowHeaderUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRowHeaderUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityRowHeaderUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityRowHeaderUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSRange AccessibilityRowIndexRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRowIndexRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilityRowIndexRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowIndexRangeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRowIndexRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetAccessibilityRowIndexRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetAccessibilityRowIndexRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRowsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityRulerMarkerType AccessibilityRulerMarkerType
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRulerMarkerType", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityRulerMarkerType)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilityRulerMarkerTypeHandle);
			}
			return (NSAccessibilityRulerMarkerType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilityRulerMarkerTypeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRulerMarkerType:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilityRulerMarkerType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilityRulerMarkerType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilitySearchButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySearchButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySearchButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySearchButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySearchButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySearchButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySearchButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilitySearchMenu
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySearchMenu", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySearchMenuHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySearchMenuHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySearchMenu:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySearchMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySearchMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilitySelected
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilitySelected")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilitySelectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilitySelectedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelected:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAccessibilitySelected_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAccessibilitySelected_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySelectedCells
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedCells", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedCellsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedCells:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedCells_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedCells_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySelectedChildren
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedChildren", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedChildrenHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedChildrenHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedChildren:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySelectedColumns
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedColumns", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedColumnsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedColumns:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySelectedRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedRows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedRowsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedRowsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedRows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilitySelectedText
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedTextHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedText:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedText_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedText_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSRange AccessibilitySelectedTextRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedTextRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilitySelectedTextRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedTextRangeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedTextRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetAccessibilitySelectedTextRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetAccessibilitySelectedTextRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSValue[]? AccessibilitySelectedTextRanges
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedTextRanges", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedTextRangesHandle));
			}
			return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedTextRangesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedTextRanges:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedTextRanges_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedTextRanges_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityServesAsTitleForUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityServesAsTitleForUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityServesAsTitleForUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityServesAsTitleForUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityServesAsTitleForUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityServesAsTitleForUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityServesAsTitleForUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSRange AccessibilitySharedCharacterRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySharedCharacterRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilitySharedCharacterRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilitySharedCharacterRangeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySharedCharacterRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetAccessibilitySharedCharacterRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetAccessibilitySharedCharacterRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySharedFocusElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySharedFocusElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySharedFocusElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySharedFocusElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySharedFocusElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySharedFocusElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySharedFocusElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySharedTextUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySharedTextUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySharedTextUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySharedTextUIElementsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySharedTextUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySharedTextUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySharedTextUIElements_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityShownMenu
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityShownMenu", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityShownMenuHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityShownMenuHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityShownMenu:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityShownMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityShownMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilitySortDirection AccessibilitySortDirection
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySortDirection", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilitySortDirection)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilitySortDirectionHandle);
			}
			return (NSAccessibilitySortDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilitySortDirectionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySortDirection:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilitySortDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilitySortDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilitySplitters
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySplitters", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySplittersHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySplittersHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySplitters:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySplitters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySplitters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilitySubrole
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySubrole")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySubroleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySubroleHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySubrole:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySubrole_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySubrole_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityTabs
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTabs", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityTabsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityTabsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTabs:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityTabs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityTabs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityTitle
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityTitleHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityTitleUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTitleUIElement", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityTitleUIElementHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityTitleUIElementHandle)));
			MarkDirty();
			__mt_AccessibilityTitleUIElement_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTitleUIElement:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityTitleUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityTitleUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityTitleUIElement_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityToolbarButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityToolbarButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityToolbarButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityToolbarButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityToolbarButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityToolbarButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityToolbarButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityTopLevelUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTopLevelUIElement", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityTopLevelUIElementHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityTopLevelUIElementHandle)));
			MarkDirty();
			__mt_AccessibilityTopLevelUIElement_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTopLevelUIElement:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityTopLevelUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityTopLevelUIElement_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityTopLevelUIElement_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityUnitDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityUnitDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityUnitDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityUnitDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityUnitDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityUnitDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityUnitDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityUnits AccessibilityUnits
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityUnits", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityUnits)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilityUnitsHandle);
			}
			return (NSAccessibilityUnits)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilityUnitsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityUnits:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilityUnits_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilityUnits_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSUrl? AccessibilityUrl
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityURL", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityURLHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityURL:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityValueDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityValueDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityValueDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityValueDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityValueDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityValueDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityValueDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityVerticalScrollBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVerticalScrollBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVerticalScrollBarHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVerticalScrollBarHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVerticalScrollBar:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVerticalScrollBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVerticalScrollBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityVerticalUnitDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVerticalUnitDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVerticalUnitDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVerticalUnitDescriptionHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVerticalUnitDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVerticalUnitDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVerticalUnitDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSAccessibilityUnits AccessibilityVerticalUnits
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVerticalUnits", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityUnits)Messaging.Int64_objc_msgSend(base.Handle, selAccessibilityVerticalUnitsHandle);
			}
			return (NSAccessibilityUnits)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAccessibilityVerticalUnitsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVerticalUnits:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAccessibilityVerticalUnits_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAccessibilityVerticalUnits_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityVisibleCells
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleCells", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleCellsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleCells:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVisibleCells_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVisibleCells_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSRange AccessibilityVisibleCharacterRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleCharacterRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selAccessibilityVisibleCharacterRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleCharacterRangeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleCharacterRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetAccessibilityVisibleCharacterRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetAccessibilityVisibleCharacterRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityVisibleChildren
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleChildren", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleChildrenHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleChildrenHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleChildren:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVisibleChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVisibleChildren_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityVisibleColumns
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleColumns", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleColumnsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleColumns:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVisibleColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVisibleColumns_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityVisibleRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleRows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleRowsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleRowsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleRows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityVisibleRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityVisibleRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityWarningValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityWarningValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityWarningValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityWarningValueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityWarningValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityWarningValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityWarningValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityWindow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityWindow", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityWindowHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityWindowHandle)));
			MarkDirty();
			__mt_AccessibilityWindow_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityWindow:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityWindow_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_AccessibilityWindow_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject[]? AccessibilityWindows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityWindows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityWindowsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityWindowsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityWindows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityWindows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityWindows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityZoomButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityZoomButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityZoomButtonHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityZoomButtonHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityZoomButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityZoomButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityZoomButton_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEdgeInsets AlignmentRectInsets
	{
		[Export("alignmentRectInsets")]
		get
		{
			NSApplication.EnsureUIThread();
			NSEdgeInsets retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSEdgeInsets_objc_msgSend_stret(out retval, base.Handle, selAlignmentRectInsetsHandle);
			}
			else
			{
				Messaging.NSEdgeInsets_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAlignmentRectInsetsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AllowsVibrancy
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("allowsVibrancy")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsVibrancyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsVibrancyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat AlphaValue
	{
		[Export("alphaValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAlphaValueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAlphaValueHandle);
		}
		[Export("setAlphaValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetAlphaValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetAlphaValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Animations
	{
		[Export("animations")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationsHandle));
		}
		[Export("setAnimations:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimations_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimations_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Animator
	{
		[Export("animator")]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimatorHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimatorHandle)));
			nSObject.SetAsProxy();
			return nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSAppearance? Appearance
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("appearance", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSend(base.Handle, selAppearanceHandle));
			}
			return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppearanceHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setAppearance:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAppearance_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAppearance_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutoresizesSubviews
	{
		[Export("autoresizesSubviews")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoresizesSubviewsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoresizesSubviewsHandle);
		}
		[Export("setAutoresizesSubviews:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoresizesSubviews_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoresizesSubviews_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewResizingMask AutoresizingMask
	{
		[Export("autoresizingMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSViewResizingMask)Messaging.UInt64_objc_msgSend(base.Handle, selAutoresizingMaskHandle);
			}
			return (NSViewResizingMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAutoresizingMaskHandle);
		}
		[Export("setAutoresizingMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAutoresizingMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAutoresizingMask_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilter[]? BackgroundFilters
	{
		[Export("backgroundFilters", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundFiltersHandle));
			}
			return NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundFiltersHandle));
		}
		[Export("setBackgroundFilters:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BaselineOffsetFromBottom
	{
		[Export("baselineOffsetFromBottom")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selBaselineOffsetFromBottomHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selBaselineOffsetFromBottomHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutYAxisAnchor BottomAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("bottomAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBottomAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBottomAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Bounds
	{
		[Export("bounds")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundsHandle);
			}
			return retval;
		}
		[Export("setBounds:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetBounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetBounds_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BoundsRotation
	{
		[Export("boundsRotation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selBoundsRotationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selBoundsRotationHandle);
		}
		[Export("setBoundsRotation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetBoundsRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetBoundsRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanBecomeKeyView
	{
		[Export("canBecomeKeyView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanBecomeKeyViewHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanBecomeKeyViewHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDrawConcurrently
	{
		[Export("canDrawConcurrently")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanDrawConcurrentlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanDrawConcurrentlyHandle);
		}
		[Export("setCanDrawConcurrently:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanDrawConcurrently_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanDrawConcurrently_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool CanDrawSubviewsIntoLayer
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("canDrawSubviewsIntoLayer")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanDrawSubviewsIntoLayerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanDrawSubviewsIntoLayerHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setCanDrawSubviewsIntoLayer:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanDrawSubviewsIntoLayer_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanDrawSubviewsIntoLayer_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutXAxisAnchor CenterXAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("centerXAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selCenterXAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCenterXAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutYAxisAnchor CenterYAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("centerYAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selCenterYAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCenterYAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilter? CompositingFilter
	{
		[Export("compositingFilter", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selCompositingFilterHandle));
			}
			return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompositingFilterHandle));
		}
		[Export("setCompositingFilter:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCompositingFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCompositingFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint[] Constraints
	{
		[Export("constraints")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend(base.Handle, selConstraintsHandle));
			}
			return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConstraintsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilter[]? ContentFilters
	{
		[Export("contentFilters", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentFiltersHandle));
			}
			return NSArray.ArrayFromHandle<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentFiltersHandle));
		}
		[Export("setContentFilters:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentFilters_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFocusRingType DefaultFocusRingType
	{
		[Export("defaultFocusRingType")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFocusRingType)Messaging.UInt64_objc_msgSend(class_ptr, selDefaultFocusRingTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSAppearance EffectiveAppearance
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("effectiveAppearance", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSend(base.Handle, selEffectiveAppearanceHandle));
			}
			return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEffectiveAppearanceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrollView EnclosingScrollView
	{
		[Export("enclosingScrollView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSScrollView>(Messaging.IntPtr_objc_msgSend(base.Handle, selEnclosingScrollViewHandle));
			}
			return Runtime.GetNSObject<NSScrollView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEnclosingScrollViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutYAxisAnchor FirstBaselineAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("firstBaselineAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstBaselineAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstBaselineAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nfloat FirstBaselineOffsetFromTop
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("firstBaselineOffsetFromTop")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFirstBaselineOffsetFromTopHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFirstBaselineOffsetFromTopHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize FittingSize
	{
		[Export("fittingSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selFittingSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selFittingSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect FocusRingMaskBounds
	{
		[Export("focusRingMaskBounds")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selFocusRingMaskBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFocusRingMaskBoundsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFocusRingType FocusRingType
	{
		[Export("focusRingType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSFocusRingType)Messaging.UInt64_objc_msgSend(base.Handle, selFocusRingTypeHandle);
			}
			return (NSFocusRingType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFocusRingTypeHandle);
		}
		[Export("setFocusRingType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFocusRingType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFocusRingType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameHandle);
			}
			return retval;
		}
		[Export("setFrame:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetFrame_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat FrameCenterRotation
	{
		[Export("frameCenterRotation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFrameCenterRotationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFrameCenterRotationHandle);
		}
		[Export("setFrameCenterRotation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFrameCenterRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFrameCenterRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat FrameRotation
	{
		[Export("frameRotation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFrameRotationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFrameRotationHandle);
		}
		[Export("setFrameRotation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFrameRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFrameRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSGestureRecognizer[] GestureRecognizers
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("gestureRecognizers", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSGestureRecognizer>(Messaging.IntPtr_objc_msgSend(base.Handle, selGestureRecognizersHandle));
			}
			return NSArray.ArrayFromHandle<NSGestureRecognizer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGestureRecognizersHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setGestureRecognizers:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGestureRecognizers_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGestureRecognizers_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasAmbiguousLayout
	{
		[Export("hasAmbiguousLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasAmbiguousLayoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAmbiguousLayoutHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat HeightAdjustLimit
	{
		[Export("heightAdjustLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selHeightAdjustLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selHeightAdjustLimitHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutDimension HeightAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("heightAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutDimension>(Messaging.IntPtr_objc_msgSend(base.Handle, selHeightAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutDimension>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHeightAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
		[Export("setHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidden_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual bool HorizontalContentSizeConstraintActive
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("isHorizontalContentSizeConstraintActive")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHorizontalContentSizeConstraintActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHorizontalContentSizeConstraintActiveHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setHorizontalContentSizeConstraintActive:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHorizontalContentSizeConstraintActive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHorizontalContentSizeConstraintActive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Export("setIdentifier:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InLiveResize
	{
		[Export("inLiveResize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selInLiveResizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selInLiveResizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextInputContext InputContext
	{
		[Export("inputContext")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTextInputContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputContextHandle));
			}
			return Runtime.GetNSObject<NSTextInputContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize IntrinsicContentSize
	{
		[Export("intrinsicContentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selIntrinsicContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selIntrinsicContentSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static bool IsCompatibleWithResponsiveScrolling
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("isCompatibleWithResponsiveScrolling")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsCompatibleWithResponsiveScrollingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDrawingFindIndicator
	{
		[Export("isDrawingFindIndicator")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDrawingFindIndicatorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDrawingFindIndicatorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFlipped
	{
		[Export("isFlipped")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlippedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsHiddenOrHasHiddenAncestor
	{
		[Export("isHiddenOrHasHiddenAncestor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenOrHasHiddenAncestorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenOrHasHiddenAncestorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsInFullscreenMode
	{
		[Export("isInFullScreenMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInFullScreenModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInFullScreenModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsOpaque
	{
		[Export("isOpaque")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpaqueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpaqueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsRotatedFromBase
	{
		[Export("isRotatedFromBase")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRotatedFromBaseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRotatedFromBaseHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsRotatedOrScaledFromBase
	{
		[Export("isRotatedOrScaledFromBase")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRotatedOrScaledFromBaseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRotatedOrScaledFromBaseHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutYAxisAnchor LastBaselineAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("lastBaselineAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selLastBaselineAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastBaselineAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nfloat LastBaselineOffsetFromBottom
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("lastBaselineOffsetFromBottom")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLastBaselineOffsetFromBottomHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLastBaselineOffsetFromBottomHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer? Layer
	{
		[Export("layer", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayerHandle));
			}
			return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayerHandle));
		}
		[Export("setLayer:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLayer_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLayer_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewLayerContentsPlacement LayerContentsPlacement
	{
		[Export("layerContentsPlacement")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSViewLayerContentsPlacement)Messaging.Int64_objc_msgSend(base.Handle, selLayerContentsPlacementHandle);
			}
			return (NSViewLayerContentsPlacement)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLayerContentsPlacementHandle);
		}
		[Export("setLayerContentsPlacement:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetLayerContentsPlacement_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLayerContentsPlacement_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewLayerContentsRedrawPolicy LayerContentsRedrawPolicy
	{
		[Export("layerContentsRedrawPolicy")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSViewLayerContentsRedrawPolicy)Messaging.Int64_objc_msgSend(base.Handle, selLayerContentsRedrawPolicyHandle);
			}
			return (NSViewLayerContentsRedrawPolicy)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLayerContentsRedrawPolicyHandle);
		}
		[Export("setLayerContentsRedrawPolicy:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetLayerContentsRedrawPolicy_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLayerContentsRedrawPolicy_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool LayerUsesCoreImageFilters
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("layerUsesCoreImageFilters")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLayerUsesCoreImageFiltersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLayerUsesCoreImageFiltersHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setLayerUsesCoreImageFilters:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLayerUsesCoreImageFilters_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLayerUsesCoreImageFilters_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutGuide[] LayoutGuides
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("layoutGuides", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSLayoutGuide>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutGuidesHandle));
			}
			return NSArray.ArrayFromHandle<NSLayoutGuide>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutGuidesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutXAxisAnchor LeadingAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("leadingAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeadingAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeadingAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutXAxisAnchor LeftAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("leftAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MouseDownCanMoveWindow
	{
		[Export("mouseDownCanMoveWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMouseDownCanMoveWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMouseDownCanMoveWindowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NeedsDisplay
	{
		[Export("needsDisplay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsDisplayHandle);
		}
		[Export("setNeedsDisplay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsDisplay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsDisplay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NeedsLayout
	{
		[Export("needsLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsLayoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsLayoutHandle);
		}
		[Export("setNeedsLayout:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsLayout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsLayout_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NeedsPanelToBecomeKey
	{
		[Export("needsPanelToBecomeKey")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsPanelToBecomeKeyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsPanelToBecomeKeyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NeedsUpdateConstraints
	{
		[Export("needsUpdateConstraints")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsUpdateConstraintsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsUpdateConstraintsHandle);
		}
		[Export("setNeedsUpdateConstraints:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsUpdateConstraints_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsUpdateConstraints_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? NextKeyView
	{
		[Export("nextKeyView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selNextKeyViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextKeyViewHandle));
		}
		[Export("setNextKeyView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNextKeyView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNextKeyView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView NextValidKeyView
	{
		[Export("nextValidKeyView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selNextValidKeyViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextValidKeyViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView OpaqueAncestor
	{
		[Export("opaqueAncestor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selOpaqueAncestorHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOpaqueAncestorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString PageFooter
	{
		[Export("pageFooter")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selPageFooterHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageFooterHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString PageHeader
	{
		[Export("pageHeader")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selPageHeaderHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageHeaderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PostsBoundsChangedNotifications
	{
		[Export("postsBoundsChangedNotifications")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPostsBoundsChangedNotificationsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPostsBoundsChangedNotificationsHandle);
		}
		[Export("setPostsBoundsChangedNotifications:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPostsBoundsChangedNotifications_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPostsBoundsChangedNotifications_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PostsFrameChangedNotifications
	{
		[Export("postsFrameChangedNotifications")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPostsFrameChangedNotificationsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPostsFrameChangedNotificationsHandle);
		}
		[Export("setPostsFrameChangedNotifications:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPostsFrameChangedNotifications_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPostsFrameChangedNotifications_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CGRect PreparedContentRect
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("preparedContentRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selPreparedContentRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPreparedContentRectHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setPreparedContentRect:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetPreparedContentRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetPreparedContentRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PreservesContentDuringLiveResize
	{
		[Export("preservesContentDuringLiveResize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesContentDuringLiveResizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesContentDuringLiveResizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSPressureConfiguration PressureConfiguration
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("pressureConfiguration", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPressureConfiguration>(Messaging.IntPtr_objc_msgSend(base.Handle, selPressureConfigurationHandle));
			}
			return Runtime.GetNSObject<NSPressureConfiguration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPressureConfigurationHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setPressureConfiguration:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPressureConfiguration_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPressureConfiguration_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView PreviousKeyView
	{
		[Export("previousKeyView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousKeyViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousKeyViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView PreviousValidKeyView
	{
		[Export("previousValidKeyView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousValidKeyViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousValidKeyViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PrintJobTitle
	{
		[Export("printJobTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintJobTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintJobTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect RectPreservedDuringLiveResize
	{
		[Export("rectPreservedDuringLiveResize")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selRectPreservedDuringLiveResizeHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRectPreservedDuringLiveResizeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutXAxisAnchor RightAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("rightAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSShadow Shadow
	{
		[Export("shadow", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSShadow>(Messaging.IntPtr_objc_msgSend(base.Handle, selShadowHandle));
			}
			return Runtime.GetNSObject<NSShadow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShadowHandle));
		}
		[Export("setShadow:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShadow_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShadow_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool ShouldDrawColor
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("shouldDrawColor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldDrawColorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldDrawColorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView[] Subviews
	{
		[Export("subviews", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubviewsHandle));
			}
			return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubviewsHandle));
		}
		[Export("setSubviews:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubviews_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubviews_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView Superview
	{
		[Export("superview")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selSuperviewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuperviewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Tag
	{
		[Export("tag")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selTagHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selTagHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ToolTip
	{
		[Export("toolTip")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selToolTipHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToolTipHandle));
		}
		[Export("setToolTip:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetToolTip_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetToolTip_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutYAxisAnchor TopAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("topAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selTopAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTopAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutXAxisAnchor TrailingAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("trailingAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrailingAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrailingAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TranslatesAutoresizingMaskIntoConstraints
	{
		[Export("translatesAutoresizingMaskIntoConstraints")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTranslatesAutoresizingMaskIntoConstraintsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTranslatesAutoresizingMaskIntoConstraintsHandle);
		}
		[Export("setTranslatesAutoresizingMaskIntoConstraints:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTranslatesAutoresizingMaskIntoConstraints_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTranslatesAutoresizingMaskIntoConstraints_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("userInterfaceLayoutDirection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSend(base.Handle, selUserInterfaceLayoutDirectionHandle);
			}
			return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUserInterfaceLayoutDirectionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setUserInterfaceLayoutDirection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetUserInterfaceLayoutDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetUserInterfaceLayoutDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual bool VerticalContentSizeConstraintActive
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("isVerticalContentSizeConstraintActive")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVerticalContentSizeConstraintActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVerticalContentSizeConstraintActiveHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setVerticalContentSizeConstraintActive:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVerticalContentSizeConstraintActive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVerticalContentSizeConstraintActive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
	public virtual bool WantsBestResolutionOpenGLSurface
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
		[Export("wantsBestResolutionOpenGLSurface")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsBestResolutionOpenGLSurfaceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsBestResolutionOpenGLSurfaceHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
		[Export("setWantsBestResolutionOpenGLSurface:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWantsBestResolutionOpenGLSurface_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWantsBestResolutionOpenGLSurface_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WantsDefaultClipping
	{
		[Export("wantsDefaultClipping")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsDefaultClippingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsDefaultClippingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WantsLayer
	{
		[Export("wantsLayer")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsLayerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsLayerHandle);
		}
		[Export("setWantsLayer:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWantsLayer_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWantsLayer_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual bool WantsPeriodicDraggingUpdates
	{
		[Export("wantsPeriodicDraggingUpdates")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsPeriodicDraggingUpdatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsPeriodicDraggingUpdatesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WantsRestingTouches
	{
		[Export("wantsRestingTouches")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsRestingTouchesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsRestingTouchesHandle);
		}
		[Export("setWantsRestingTouches:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWantsRestingTouches_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWantsRestingTouches_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WantsUpdateLayer
	{
		[Export("wantsUpdateLayer")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsUpdateLayerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsUpdateLayerHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat WidthAdjustLimit
	{
		[Export("widthAdjustLimit")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selWidthAdjustLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selWidthAdjustLimitHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLayoutDimension WidthAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("widthAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutDimension>(Messaging.IntPtr_objc_msgSend(base.Handle, selWidthAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutDimension>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWidthAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow Window
	{
		[Export("window")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowHandle));
			}
			return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowHandle));
		}
	}

	[Field("NSAccessibilityAnnouncementRequestedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveAnnouncementRequested helper method instead.")]
	public static NSString AnnouncementRequestedNotification
	{
		get
		{
			if (_AnnouncementRequestedNotification == null)
			{
				_AnnouncementRequestedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityAnnouncementRequestedNotification");
			}
			return _AnnouncementRequestedNotification;
		}
	}

	[Field("NSAccessibilityApplicationActivatedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveApplicationActivated helper method instead.")]
	public static NSString ApplicationActivatedNotification
	{
		get
		{
			if (_ApplicationActivatedNotification == null)
			{
				_ApplicationActivatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationActivatedNotification");
			}
			return _ApplicationActivatedNotification;
		}
	}

	[Field("NSAccessibilityApplicationDeactivatedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveApplicationDeactivated helper method instead.")]
	public static NSString ApplicationDeactivatedNotification
	{
		get
		{
			if (_ApplicationDeactivatedNotification == null)
			{
				_ApplicationDeactivatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationDeactivatedNotification");
			}
			return _ApplicationDeactivatedNotification;
		}
	}

	[Field("NSAccessibilityApplicationHiddenNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveApplicationHidden helper method instead.")]
	public static NSString ApplicationHiddenNotification
	{
		get
		{
			if (_ApplicationHiddenNotification == null)
			{
				_ApplicationHiddenNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationHiddenNotification");
			}
			return _ApplicationHiddenNotification;
		}
	}

	[Field("NSAccessibilityApplicationShownNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveApplicationShown helper method instead.")]
	public static NSString ApplicationShownNotification
	{
		get
		{
			if (_ApplicationShownNotification == null)
			{
				_ApplicationShownNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityApplicationShownNotification");
			}
			return _ApplicationShownNotification;
		}
	}

	[Field("NSViewBoundsDidChangeNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveBoundsChanged helper method instead.")]
	public static NSString BoundsChangedNotification
	{
		get
		{
			if (_BoundsChangedNotification == null)
			{
				_BoundsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewBoundsDidChangeNotification");
			}
			return _BoundsChangedNotification;
		}
	}

	[Field("NSAccessibilityCreatedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveCreated helper method instead.")]
	public static NSString CreatedNotification
	{
		get
		{
			if (_CreatedNotification == null)
			{
				_CreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityCreatedNotification");
			}
			return _CreatedNotification;
		}
	}

	[Field("NSAccessibilityDrawerCreatedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveDrawerCreated helper method instead.")]
	public static NSString DrawerCreatedNotification
	{
		get
		{
			if (_DrawerCreatedNotification == null)
			{
				_DrawerCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityDrawerCreatedNotification");
			}
			return _DrawerCreatedNotification;
		}
	}

	[Field("NSViewFocusDidChangeNotification", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 4, PlatformArchitecture.None, null)]
	[Advice("Use NSView.Notifications.ObserveFocusChanged helper method instead.")]
	public static NSString FocusChangedNotification
	{
		[Deprecated(PlatformName.MacOSX, 10, 4, PlatformArchitecture.None, null)]
		get
		{
			if (_FocusChangedNotification == null)
			{
				_FocusChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewFocusDidChangeNotification");
			}
			return _FocusChangedNotification;
		}
	}

	[Field("NSAccessibilityFocusedWindowChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveFocusedWindowChanged helper method instead.")]
	public static NSString FocusedWindowChangedNotification
	{
		get
		{
			if (_FocusedWindowChangedNotification == null)
			{
				_FocusedWindowChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFocusedWindowChangedNotification");
			}
			return _FocusedWindowChangedNotification;
		}
	}

	[Field("NSViewFrameDidChangeNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveFrameChanged helper method instead.")]
	public static NSString FrameChangedNotification
	{
		get
		{
			if (_FrameChangedNotification == null)
			{
				_FrameChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewFrameDidChangeNotification");
			}
			return _FrameChangedNotification;
		}
	}

	[Field("NSViewGlobalFrameDidChangeNotification", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
	[Advice("Use NSView.Notifications.ObserveGlobalFrameChanged helper method instead.")]
	public static NSString GlobalFrameChangedNotification
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
		get
		{
			if (_GlobalFrameChangedNotification == null)
			{
				_GlobalFrameChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewGlobalFrameDidChangeNotification");
			}
			return _GlobalFrameChangedNotification;
		}
	}

	[Field("NSAccessibilityHelpTagCreatedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveHelpTagCreated helper method instead.")]
	public static NSString HelpTagCreatedNotification
	{
		get
		{
			if (_HelpTagCreatedNotification == null)
			{
				_HelpTagCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityHelpTagCreatedNotification");
			}
			return _HelpTagCreatedNotification;
		}
	}

	[Field("NSAccessibilityLayoutChangedNotification", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Advice("Use NSView.Notifications.ObserveLayoutChanged helper method instead.")]
	public static NSString LayoutChangedNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LayoutChangedNotification == null)
			{
				_LayoutChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityLayoutChangedNotification");
			}
			return _LayoutChangedNotification;
		}
	}

	[Field("NSAccessibilityMainWindowChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveMainWindowChanged helper method instead.")]
	public static NSString MainWindowChangedNotification
	{
		get
		{
			if (_MainWindowChangedNotification == null)
			{
				_MainWindowChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMainWindowChangedNotification");
			}
			return _MainWindowChangedNotification;
		}
	}

	[Field("NSAccessibilityMovedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveMoved helper method instead.")]
	public static NSString MovedNotification
	{
		get
		{
			if (_MovedNotification == null)
			{
				_MovedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityMovedNotification");
			}
			return _MovedNotification;
		}
	}

	[Field("NSFullScreenModeAllScreens", "AppKit")]
	public static NSString NSFullScreenModeAllScreens
	{
		get
		{
			if (_NSFullScreenModeAllScreens == null)
			{
				_NSFullScreenModeAllScreens = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFullScreenModeAllScreens");
			}
			return _NSFullScreenModeAllScreens;
		}
	}

	[Field("NSFullScreenModeApplicationPresentationOptions", "AppKit")]
	public static NSString NSFullScreenModeApplicationPresentationOptions
	{
		get
		{
			if (_NSFullScreenModeApplicationPresentationOptions == null)
			{
				_NSFullScreenModeApplicationPresentationOptions = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFullScreenModeApplicationPresentationOptions");
			}
			return _NSFullScreenModeApplicationPresentationOptions;
		}
	}

	[Field("NSFullScreenModeSetting", "AppKit")]
	public static NSString NSFullScreenModeSetting
	{
		get
		{
			if (_NSFullScreenModeSetting == null)
			{
				_NSFullScreenModeSetting = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFullScreenModeSetting");
			}
			return _NSFullScreenModeSetting;
		}
	}

	[Field("NSFullScreenModeWindowLevel", "AppKit")]
	public static NSString NSFullScreenModeWindowLevel
	{
		get
		{
			if (_NSFullScreenModeWindowLevel == null)
			{
				_NSFullScreenModeWindowLevel = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFullScreenModeWindowLevel");
			}
			return _NSFullScreenModeWindowLevel;
		}
	}

	[Field("NSViewNoIntrinsicMetric", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static nfloat NoIntrinsicMetric
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSViewNoIntrinsicMetric");
		}
	}

	[Field("NSAccessibilityResizedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveResized helper method instead.")]
	public static NSString ResizedNotification
	{
		get
		{
			if (_ResizedNotification == null)
			{
				_ResizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityResizedNotification");
			}
			return _ResizedNotification;
		}
	}

	[Field("NSAccessibilityRowCollapsedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveRowCollapsed helper method instead.")]
	public static NSString RowCollapsedNotification
	{
		get
		{
			if (_RowCollapsedNotification == null)
			{
				_RowCollapsedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowCollapsedNotification");
			}
			return _RowCollapsedNotification;
		}
	}

	[Field("NSAccessibilityRowCountChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveRowCountChanged helper method instead.")]
	public static NSString RowCountChangedNotification
	{
		get
		{
			if (_RowCountChangedNotification == null)
			{
				_RowCountChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowCountChangedNotification");
			}
			return _RowCountChangedNotification;
		}
	}

	[Field("NSAccessibilityRowExpandedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveRowExpanded helper method instead.")]
	public static NSString RowExpandedNotification
	{
		get
		{
			if (_RowExpandedNotification == null)
			{
				_RowExpandedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityRowExpandedNotification");
			}
			return _RowExpandedNotification;
		}
	}

	[Field("NSAccessibilitySelectedCellsChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveSelectedCellsChanged helper method instead.")]
	public static NSString SelectedCellsChangedNotification
	{
		get
		{
			if (_SelectedCellsChangedNotification == null)
			{
				_SelectedCellsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedCellsChangedNotification");
			}
			return _SelectedCellsChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedChildrenChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveSelectedChildrenChanged helper method instead.")]
	public static NSString SelectedChildrenChangedNotification
	{
		get
		{
			if (_SelectedChildrenChangedNotification == null)
			{
				_SelectedChildrenChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedChildrenChangedNotification");
			}
			return _SelectedChildrenChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedChildrenMovedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveSelectedChildrenMoved helper method instead.")]
	public static NSString SelectedChildrenMovedNotification
	{
		get
		{
			if (_SelectedChildrenMovedNotification == null)
			{
				_SelectedChildrenMovedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedChildrenMovedNotification");
			}
			return _SelectedChildrenMovedNotification;
		}
	}

	[Field("NSAccessibilitySelectedColumnsChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveSelectedColumnsChanged helper method instead.")]
	public static NSString SelectedColumnsChangedNotification
	{
		get
		{
			if (_SelectedColumnsChangedNotification == null)
			{
				_SelectedColumnsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedColumnsChangedNotification");
			}
			return _SelectedColumnsChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedRowsChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveSelectedRowsChanged helper method instead.")]
	public static NSString SelectedRowsChangedNotification
	{
		get
		{
			if (_SelectedRowsChangedNotification == null)
			{
				_SelectedRowsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedRowsChangedNotification");
			}
			return _SelectedRowsChangedNotification;
		}
	}

	[Field("NSAccessibilitySelectedTextChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveSelectedTextChanged helper method instead.")]
	public static NSString SelectedTextChangedNotification
	{
		get
		{
			if (_SelectedTextChangedNotification == null)
			{
				_SelectedTextChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySelectedTextChangedNotification");
			}
			return _SelectedTextChangedNotification;
		}
	}

	[Field("NSAccessibilitySheetCreatedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveSheetCreated helper method instead.")]
	public static NSString SheetCreatedNotification
	{
		get
		{
			if (_SheetCreatedNotification == null)
			{
				_SheetCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilitySheetCreatedNotification");
			}
			return _SheetCreatedNotification;
		}
	}

	[Field("NSAccessibilityTitleChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveTitleChanged helper method instead.")]
	public static NSString TitleChangedNotification
	{
		get
		{
			if (_TitleChangedNotification == null)
			{
				_TitleChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityTitleChangedNotification");
			}
			return _TitleChangedNotification;
		}
	}

	[Field("NSAccessibilityUIElementDestroyedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveUIElementDestroyed helper method instead.")]
	public static NSString UIElementDestroyedNotification
	{
		get
		{
			if (_UIElementDestroyedNotification == null)
			{
				_UIElementDestroyedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUIElementDestroyedNotification");
			}
			return _UIElementDestroyedNotification;
		}
	}

	[Field("NSAccessibilityFocusedUIElementChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveUIElementFocusedChanged helper method instead.")]
	public static NSString UIElementFocusedChangedNotification
	{
		get
		{
			if (_UIElementFocusedChangedNotification == null)
			{
				_UIElementFocusedChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityFocusedUIElementChangedNotification");
			}
			return _UIElementFocusedChangedNotification;
		}
	}

	[Field("NSAccessibilityUnitsChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveUnitsChanged helper method instead.")]
	public static NSString UnitsChangedNotification
	{
		get
		{
			if (_UnitsChangedNotification == null)
			{
				_UnitsChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityUnitsChangedNotification");
			}
			return _UnitsChangedNotification;
		}
	}

	[Field("NSViewDidUpdateTrackingAreasNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveUpdatedTrackingAreas helper method instead.")]
	public static NSString UpdatedTrackingAreasNotification
	{
		get
		{
			if (_UpdatedTrackingAreasNotification == null)
			{
				_UpdatedTrackingAreasNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewDidUpdateTrackingAreasNotification");
			}
			return _UpdatedTrackingAreasNotification;
		}
	}

	[Field("NSAccessibilityValueChangedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveValueChanged helper method instead.")]
	public static NSString ValueChangedNotification
	{
		get
		{
			if (_ValueChangedNotification == null)
			{
				_ValueChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityValueChangedNotification");
			}
			return _ValueChangedNotification;
		}
	}

	[Field("NSAccessibilityWindowCreatedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveWindowCreated helper method instead.")]
	public static NSString WindowCreatedNotification
	{
		get
		{
			if (_WindowCreatedNotification == null)
			{
				_WindowCreatedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowCreatedNotification");
			}
			return _WindowCreatedNotification;
		}
	}

	[Field("NSAccessibilityWindowDeminiaturizedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveWindowDeminiaturized helper method instead.")]
	public static NSString WindowDeminiaturizedNotification
	{
		get
		{
			if (_WindowDeminiaturizedNotification == null)
			{
				_WindowDeminiaturizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowDeminiaturizedNotification");
			}
			return _WindowDeminiaturizedNotification;
		}
	}

	[Field("NSAccessibilityWindowMiniaturizedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveWindowMiniaturized helper method instead.")]
	public static NSString WindowMiniaturizedNotification
	{
		get
		{
			if (_WindowMiniaturizedNotification == null)
			{
				_WindowMiniaturizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowMiniaturizedNotification");
			}
			return _WindowMiniaturizedNotification;
		}
	}

	[Field("NSAccessibilityWindowMovedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveWindowMoved helper method instead.")]
	public static NSString WindowMovedNotification
	{
		get
		{
			if (_WindowMovedNotification == null)
			{
				_WindowMovedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowMovedNotification");
			}
			return _WindowMovedNotification;
		}
	}

	[Field("NSAccessibilityWindowResizedNotification", "AppKit")]
	[Advice("Use NSView.Notifications.ObserveWindowResized helper method instead.")]
	public static NSString WindowResizedNotification
	{
		get
		{
			if (_WindowResizedNotification == null)
			{
				_WindowResizedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAccessibilityWindowResizedNotification");
			}
			return _WindowResizedNotification;
		}
	}

	[MonoPInvokeCallback(typeof(view_compare_func))]
	private static nint view_compare(IntPtr view1, IntPtr view2, IntPtr context)
	{
		SortData sortData = (SortData)GCHandle.FromIntPtr(context).Target;
		try
		{
			NSView arg = (NSView)Runtime.GetNSObject(view1);
			NSView arg2 = (NSView)Runtime.GetNSObject(view2);
			return (nint)(long)sortData.Comparer(arg, arg2);
		}
		catch (Exception exception)
		{
			sortData.Exception = exception;
			return (nint)0L;
		}
	}

	public void SortSubviews(Func<NSView, NSView, NSComparisonResult> comparer)
	{
		if (comparer == null)
		{
			throw new ArgumentNullException("comparer");
		}
		IntPtr functionPointerForDelegate = Marshal.GetFunctionPointerForDelegate(view_comparer);
		SortData sortData = new SortData
		{
			Comparer = comparer
		};
		GCHandle value = GCHandle.Alloc(sortData);
		try
		{
			SortSubviews(functionPointerForDelegate, GCHandle.ToIntPtr(value));
			if (sortData.Exception != null)
			{
				throw new Exception("An exception occurred during sorting.", sortData.Exception);
			}
		}
		finally
		{
			value.Free();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSView()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSView(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("acceptsFirstMouse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptsFirstMouse(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAcceptsFirstMouse_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAcceptsFirstMouse_Handle, theEvent.Handle);
	}

	[Export("accessibilityPerformAction:")]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AccessibilityPerformAction(NSString action)
	{
		NSApplication.EnsureUIThread();
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAccessibilityPerformAction_Handle, action.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccessibilityPerformAction_Handle, action.Handle);
		}
	}

	[Export("accessibilityPerformCancel")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformCancel()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformCancelHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformCancelHandle);
	}

	[Export("accessibilityPerformConfirm")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformConfirm()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformConfirmHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformConfirmHandle);
	}

	[Export("accessibilityPerformDecrement")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformDecrement()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformDecrementHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformDecrementHandle);
	}

	[Export("accessibilityPerformDelete")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformDelete()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformDeleteHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformDeleteHandle);
	}

	[Export("accessibilityPerformIncrement")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformIncrement()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformIncrementHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformIncrementHandle);
	}

	[Export("accessibilityPerformPick")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformPick()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformPickHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformPickHandle);
	}

	[Export("accessibilityPerformPress")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformPress()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformPressHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformPressHandle);
	}

	[Export("accessibilityPerformRaise")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformRaise()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformRaiseHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformRaiseHandle);
	}

	[Export("accessibilityPerformShowAlternateUI")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformShowAlternateUI()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformShowAlternateUIHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformShowAlternateUIHandle);
	}

	[Export("accessibilityPerformShowDefaultUI")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformShowDefaultUI()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformShowDefaultUIHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformShowDefaultUIHandle);
	}

	[Export("accessibilityPerformShowMenu")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformShowMenu()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformShowMenuHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformShowMenuHandle);
	}

	[Export("addConstraint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddConstraint(NSLayoutConstraint constraint)
	{
		NSApplication.EnsureUIThread();
		if (constraint == null)
		{
			throw new ArgumentNullException("constraint");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddConstraint_Handle, constraint.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddConstraint_Handle, constraint.Handle);
		}
	}

	[Export("addConstraints:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddConstraints(NSLayoutConstraint[] constraints)
	{
		NSApplication.EnsureUIThread();
		if (constraints == null)
		{
			throw new ArgumentNullException("constraints");
		}
		NSArray nSArray = NSArray.FromNSObjects(constraints);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddConstraints_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddConstraints_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("addCursorRect:cursor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddCursorRect(CGRect aRect, NSCursor cursor)
	{
		NSApplication.EnsureUIThread();
		if (cursor == null)
		{
			throw new ArgumentNullException("cursor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selAddCursorRect_Cursor_Handle, aRect, cursor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selAddCursorRect_Cursor_Handle, aRect, cursor.Handle);
		}
	}

	[Export("addGestureRecognizer:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddGestureRecognizer(NSGestureRecognizer gestureRecognizer)
	{
		NSApplication.EnsureUIThread();
		if (gestureRecognizer == null)
		{
			throw new ArgumentNullException("gestureRecognizer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddGestureRecognizer_Handle, gestureRecognizer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddGestureRecognizer_Handle, gestureRecognizer.Handle);
		}
	}

	[Export("addLayoutGuide:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddLayoutGuide(NSLayoutGuide guide)
	{
		NSApplication.EnsureUIThread();
		if (guide == null)
		{
			throw new ArgumentNullException("guide");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddLayoutGuide_Handle, guide.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddLayoutGuide_Handle, guide.Handle);
		}
	}

	[Export("addSubview:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSubview(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSubview_Handle, aView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSubview_Handle, aView.Handle);
		}
	}

	[Export("addSubview:positioned:relativeTo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSubview(NSView aView, NSWindowOrderingMode place, NSView? otherView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selAddSubview_Positioned_RelativeTo_Handle, aView.Handle, (long)place, otherView?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selAddSubview_Positioned_RelativeTo_Handle, aView.Handle, (long)place, otherView?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("addToolTipRect:owner:userData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint AddToolTip(CGRect rect, NSObject owner, IntPtr userData)
	{
		NSApplication.EnsureUIThread();
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_CGRect_IntPtr_IntPtr(base.Handle, selAddToolTipRect_Owner_UserData_Handle, rect, owner.Handle, userData);
		}
		return Messaging.nint_objc_msgSendSuper_CGRect_IntPtr_IntPtr(base.SuperHandle, selAddToolTipRect_Owner_UserData_Handle, rect, owner.Handle, userData);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint AddToolTip(CGRect rect, INSToolTipOwner owner)
	{
		return AddToolTip(rect, (NSObject)owner, IntPtr.Zero);
	}

	[Export("addTrackingArea:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTrackingArea(NSTrackingArea trackingArea)
	{
		NSApplication.EnsureUIThread();
		if (trackingArea == null)
		{
			throw new ArgumentNullException("trackingArea");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTrackingArea_Handle, trackingArea.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTrackingArea_Handle, trackingArea.Handle);
		}
	}

	[Export("addTrackingRect:owner:userData:assumeInside:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint AddTrackingRect(CGRect aRect, NSObject anObject, IntPtr data, bool assumeInside)
	{
		NSApplication.EnsureUIThread();
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_CGRect_IntPtr_IntPtr_bool(base.Handle, selAddTrackingRect_Owner_UserData_AssumeInside_Handle, aRect, anObject.Handle, data, assumeInside);
		}
		return Messaging.nint_objc_msgSendSuper_CGRect_IntPtr_IntPtr_bool(base.SuperHandle, selAddTrackingRect_Owner_UserData_AssumeInside_Handle, aRect, anObject.Handle, data, assumeInside);
	}

	[Export("adjustPageHeightNew:top:bottom:limit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AdjustPageHeightNew(ref nfloat newBottom, nfloat top, nfloat proposedBottom, nfloat bottomLimit)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_ref_nfloat_nfloat_nfloat_nfloat(base.Handle, selAdjustPageHeightNew_Top_Bottom_Limit_Handle, ref newBottom, top, proposedBottom, bottomLimit);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_ref_nfloat_nfloat_nfloat_nfloat(base.SuperHandle, selAdjustPageHeightNew_Top_Bottom_Limit_Handle, ref newBottom, top, proposedBottom, bottomLimit);
		}
	}

	[Export("adjustPageWidthNew:left:right:limit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AdjustPageWidthNew(ref nfloat newRight, nfloat left, nfloat proposedRight, nfloat rightLimit)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_ref_nfloat_nfloat_nfloat_nfloat(base.Handle, selAdjustPageWidthNew_Left_Right_Limit_Handle, ref newRight, left, proposedRight, rightLimit);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_ref_nfloat_nfloat_nfloat_nfloat(base.SuperHandle, selAdjustPageWidthNew_Left_Right_Limit_Handle, ref newRight, left, proposedRight, rightLimit);
		}
	}

	[Export("adjustScroll:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect AdjustScroll(CGRect newVisible)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selAdjustScroll_Handle, newVisible);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selAdjustScroll_Handle, newVisible);
		}
		return retval;
	}

	[Export("allocateGState")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AllocateGState()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAllocateGStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAllocateGStateHandle);
		}
	}

	[Export("ancestorSharedWithView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView AncestorSharedWithView(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAncestorSharedWithView_Handle, aView.Handle));
		}
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAncestorSharedWithView_Handle, aView.Handle));
	}

	[Export("animationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject AnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, key.Handle));
	}

	[Export("autoscroll:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Autoscroll(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAutoscroll_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAutoscroll_Handle, theEvent.Handle);
	}

	[Export("backingAlignedRect:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect BackingAlignedRect(CGRect aRect, NSAlignmentOptions options)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_Int64(out retval, base.Handle, selBackingAlignedRect_Options_Handle, aRect, (long)options);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_Int64(out retval, base.SuperHandle, selBackingAlignedRect_Options_Handle, aRect, (long)options);
		}
		return retval;
	}

	[Export("beginDocument")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginDocument()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBeginDocumentHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBeginDocumentHandle);
		}
	}

	[Export("beginDraggingSessionWithItems:event:source:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDraggingSession BeginDraggingSession(NSDraggingItem[] items, NSEvent evnt, INSDraggingSource source)
	{
		NSApplication.EnsureUIThread();
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		if (evnt == null)
		{
			throw new ArgumentNullException("evnt");
		}
		if (source != null)
		{
			if (!(source is NSObject))
			{
				throw new ArgumentException("The object passed of type " + source.GetType()?.ToString() + " does not derive from NSObject");
			}
			NSArray nSArray = NSArray.FromNSObjects(items);
			NSDraggingSession result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDraggingSession>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginDraggingSessionWithItems_Event_Source_Handle, nSArray.Handle, evnt.Handle, source.Handle)) : Runtime.GetNSObject<NSDraggingSession>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selBeginDraggingSessionWithItems_Event_Source_Handle, nSArray.Handle, evnt.Handle, source.Handle)));
			nSArray.Dispose();
			return result;
		}
		throw new ArgumentNullException("source");
	}

	[Export("beginPageInRect:atPlacement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginPage(CGRect rect, CGPoint placement)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGPoint(base.Handle, selBeginPageInRect_AtPlacement_Handle, rect, placement);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGPoint(base.SuperHandle, selBeginPageInRect_AtPlacement_Handle, rect, placement);
		}
	}

	[Export("bitmapImageRepForCachingDisplayInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBitmapImageRep BitmapImageRepForCachingDisplayInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSBitmapImageRep>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selBitmapImageRepForCachingDisplayInRect_Handle, rect));
		}
		return Runtime.GetNSObject<NSBitmapImageRep>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selBitmapImageRepForCachingDisplayInRect_Handle, rect));
	}

	[Export("cacheDisplayInRect:toBitmapImageRep:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CacheDisplay(CGRect rect, NSBitmapImageRep bitmapImageRep)
	{
		NSApplication.EnsureUIThread();
		if (bitmapImageRep == null)
		{
			throw new ArgumentNullException("bitmapImageRep");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selCacheDisplayInRect_ToBitmapImageRep_Handle, rect, bitmapImageRep.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selCacheDisplayInRect_ToBitmapImageRep_Handle, rect, bitmapImageRep.Handle);
		}
	}

	[Export("canDraw")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "'DrawRect' or 'UpdateLayer' will be called when it is able to draw.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDraw()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selCanDrawHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanDrawHandle);
	}

	[Export("centerScanRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect CenterScanRect(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selCenterScanRect_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selCenterScanRect_Handle, aRect);
		}
		return retval;
	}

	[Export("concludeDragOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConcludeDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selConcludeDragOperation_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selConcludeDragOperation_Handle, sender.Handle);
		}
	}

	[Export("convertPointFromBacking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointFromBacking(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointFromBacking_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointFromBacking_Handle, aPoint);
	}

	[Export("convertPointFromBase:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointFromBase(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointFromBase_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointFromBase_Handle, aPoint);
	}

	[Export("convertPointFromLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointFromLayer(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointFromLayer_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointFromLayer_Handle, aPoint);
	}

	[Export("convertPoint:fromView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointFromView(CGPoint aPoint, NSView? aView)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPoint_FromView_Handle, aPoint, aView?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPoint_FromView_Handle, aPoint, aView?.Handle ?? IntPtr.Zero);
	}

	[Export("convertPointToBacking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointToBacking(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointToBacking_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointToBacking_Handle, aPoint);
	}

	[Export("convertPointToBase:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointToBase(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointToBase_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointToBase_Handle, aPoint);
	}

	[Export("convertPointToLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointToLayer(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointToLayer_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointToLayer_Handle, aPoint);
	}

	[Export("convertPoint:toView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointToView(CGPoint aPoint, NSView? aView)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPoint_ToView_Handle, aPoint, aView?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPoint_ToView_Handle, aPoint, aView?.Handle ?? IntPtr.Zero);
	}

	[Export("convertRectFromBacking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectFromBacking(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectFromBacking_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectFromBacking_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectFromBase:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectFromBase(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectFromBase_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectFromBase_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectFromLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectFromLayer(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectFromLayer_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectFromLayer_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRect:fromView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectFromView(CGRect aRect, NSView? aView)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRect_FromView_Handle, aRect, aView?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRect_FromView_Handle, aRect, aView?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("convertRectToBacking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectToBacking(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectToBacking_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectToBacking_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectToBase:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectToBase(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectToBase_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectToBase_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectToLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectToLayer(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectToLayer_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectToLayer_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRect:toView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectToView(CGRect aRect, NSView? aView)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_IntPtr(out retval, base.Handle, selConvertRect_ToView_Handle, aRect, aView?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out retval, base.SuperHandle, selConvertRect_ToView_Handle, aRect, aView?.Handle ?? IntPtr.Zero);
		}
		return retval;
	}

	[Export("convertSizeFromBacking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ConvertSizeFromBacking(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeFromBacking_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeFromBacking_Handle, aSize);
	}

	[Export("convertSizeFromBase:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ConvertSizeFromBase(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeFromBase_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeFromBase_Handle, aSize);
	}

	[Export("convertSizeFromLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ConvertSizeFromLayer(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeFromLayer_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeFromLayer_Handle, aSize);
	}

	[Export("convertSize:fromView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ConvertSizeFromView(CGSize aSize, NSView? aView)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize_IntPtr(base.Handle, selConvertSize_FromView_Handle, aSize, aView?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize_IntPtr(base.SuperHandle, selConvertSize_FromView_Handle, aSize, aView?.Handle ?? IntPtr.Zero);
	}

	[Export("convertSizeToBacking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ConvertSizeToBacking(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeToBacking_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeToBacking_Handle, aSize);
	}

	[Export("convertSizeToBase:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ConvertSizeToBase(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeToBase_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeToBase_Handle, aSize);
	}

	[Export("convertSizeToLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ConvertSizeToLayer(CGSize aSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selConvertSizeToLayer_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selConvertSizeToLayer_Handle, aSize);
	}

	[Export("convertSize:toView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ConvertSizeToView(CGSize aSize, NSView? aView)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize_IntPtr(base.Handle, selConvertSize_ToView_Handle, aSize, aView?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize_IntPtr(base.SuperHandle, selConvertSize_ToView_Handle, aSize, aView?.Handle ?? IntPtr.Zero);
	}

	[Export("dataWithEPSInsideRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData DataWithEpsInsideRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selDataWithEPSInsideRect_Handle, rect));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selDataWithEPSInsideRect_Handle, rect));
	}

	[Export("dataWithPDFInsideRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData DataWithPdfInsideRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selDataWithPDFInsideRect_Handle, rect));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selDataWithPDFInsideRect_Handle, rect));
	}

	[Export("defaultAnimationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject DefaultAnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultAnimationForKey_Handle, key.Handle));
	}

	[Export("defaultMenu")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMenu DefaultMenu()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultMenuHandle));
	}

	[Export("didAddSubview:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidAddSubview(NSView? subview)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidAddSubview_Handle, subview?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidAddSubview_Handle, subview?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("viewDidChangeBackingProperties")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeBackingProperties()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidChangeBackingPropertiesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidChangeBackingPropertiesHandle);
		}
	}

	[Export("didCloseMenu:withEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCloseMenu(NSMenu menu, NSEvent? theEvent)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDidCloseMenu_WithEvent_Handle, menu.Handle, theEvent?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDidCloseMenu_WithEvent_Handle, menu.Handle, theEvent?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("discardCursorRects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscardCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardCursorRectsHandle);
		}
	}

	[Export("display")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Display()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayHandle);
		}
	}

	[Export("displayIfNeeded")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayIfNeededHandle);
		}
	}

	[Export("displayIfNeededIgnoringOpacity")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayIfNeededIgnoringOpacity()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisplayIfNeededIgnoringOpacityHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisplayIfNeededIgnoringOpacityHandle);
		}
	}

	[Export("displayIfNeededInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayIfNeededInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDisplayIfNeededInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDisplayIfNeededInRect_Handle, rect);
		}
	}

	[Export("displayIfNeededInRectIgnoringOpacity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayIfNeededInRectIgnoringOpacity(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDisplayIfNeededInRectIgnoringOpacity_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDisplayIfNeededInRectIgnoringOpacity_Handle, rect);
		}
	}

	[Export("displayRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDisplayRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDisplayRect_Handle, rect);
		}
	}

	[Export("displayRectIgnoringOpacity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayRectIgnoringOpacity(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDisplayRectIgnoringOpacity_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDisplayRectIgnoringOpacity_Handle, rect);
		}
	}

	[Export("displayRectIgnoringOpacity:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayRectIgnoringOpacity(CGRect aRect, NSGraphicsContext context)
	{
		NSApplication.EnsureUIThread();
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDisplayRectIgnoringOpacity_InContext_Handle, aRect, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDisplayRectIgnoringOpacity_InContext_Handle, aRect, context.Handle);
		}
	}

	[Export("dragFile:fromRect:slideBack:event:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'BeginDraggingSession (NSDraggingItem [], NSEvent, NSDraggingSource)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DragFile(string filename, CGRect aRect, bool slideBack, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		IntPtr arg = NSString.CreateNative(filename);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_bool_IntPtr(base.SuperHandle, selDragFile_FromRect_SlideBack_Event_Handle, arg, aRect, slideBack, theEvent.Handle) : Messaging.bool_objc_msgSend_IntPtr_CGRect_bool_IntPtr(base.Handle, selDragFile_FromRect_SlideBack_Event_Handle, arg, aRect, slideBack, theEvent.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dragImage:at:offset:event:pasteboard:source:slideBack:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, "Use BeginDraggingSession instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DragImage(NSImage anImage, CGPoint viewLocation, CGSize initialOffset, NSEvent theEvent, NSPasteboard pboard, NSObject sourceObj, bool slideFlag)
	{
		NSApplication.EnsureUIThread();
		if (anImage == null)
		{
			throw new ArgumentNullException("anImage");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (sourceObj == null)
		{
			throw new ArgumentNullException("sourceObj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_CGSize_IntPtr_IntPtr_IntPtr_bool(base.Handle, selDragImage_At_Offset_Event_Pasteboard_Source_SlideBack_Handle, anImage.Handle, viewLocation, initialOffset, theEvent.Handle, pboard.Handle, sourceObj.Handle, slideFlag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_CGSize_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selDragImage_At_Offset_Event_Pasteboard_Source_SlideBack_Handle, anImage.Handle, viewLocation, initialOffset, theEvent.Handle, pboard.Handle, sourceObj.Handle, slideFlag);
		}
	}

	[Export("dragPromisedFilesOfTypes:fromRect:source:slideBack:event:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'BeginDraggingSession (NSDraggingItem [], NSEvent, NSDraggingSource)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DragPromisedFilesOfTypes(string[] typeArray, CGRect aRect, NSObject sourceObject, bool slideBack, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (typeArray == null)
		{
			throw new ArgumentNullException("typeArray");
		}
		if (sourceObject == null)
		{
			throw new ArgumentNullException("sourceObject");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		NSArray nSArray = NSArray.FromStrings(typeArray);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_bool_IntPtr(base.SuperHandle, selDragPromisedFilesOfTypes_FromRect_Source_SlideBack_Event_Handle, nSArray.Handle, aRect, sourceObject.Handle, slideBack, theEvent.Handle) : Messaging.bool_objc_msgSend_IntPtr_CGRect_IntPtr_bool_IntPtr(base.Handle, selDragPromisedFilesOfTypes_FromRect_Source_SlideBack_Event_Handle, nSArray.Handle, aRect, sourceObject.Handle, slideBack, theEvent.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("draggingEnded:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingEnded(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDraggingEnded_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingEnded_Handle, sender.Handle);
		}
	}

	[Export("draggingEntered:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation DraggingEntered(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selDraggingEntered_Handle, sender.Handle);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingEntered_Handle, sender.Handle);
	}

	[Export("draggingExited:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingExited(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDraggingExited_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingExited_Handle, sender.Handle);
		}
	}

	[Export("draggingUpdated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation DraggingUpdated(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selDraggingUpdated_Handle, sender.Handle);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingUpdated_Handle, sender.Handle);
	}

	[Export("drawFocusRingMask")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawFocusRingMask()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDrawFocusRingMaskHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDrawFocusRingMaskHandle);
		}
	}

	[Export("drawPageBorderWithSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawPageBorder(CGSize borderSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selDrawPageBorderWithSize_Handle, borderSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selDrawPageBorderWithSize_Handle, borderSize);
		}
	}

	[Export("drawRect:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawRect(CGRect dirtyRect)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawRect_Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawRect_Handle, dirtyRect);
		}
	}

	[Export("drawSheetBorderWithSize:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Never called.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawSheetBorder(CGSize borderSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selDrawSheetBorderWithSize_Handle, borderSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selDrawSheetBorderWithSize_Handle, borderSize);
		}
	}

	[Export("endDocument")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndDocument()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEndDocumentHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEndDocumentHandle);
		}
	}

	[Export("endPage")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndPage()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEndPageHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEndPageHandle);
		}
	}

	[Export("enterFullScreenMode:withOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EnterFullscreenModeWithOptions(NSScreen screen, NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (screen == null)
		{
			throw new ArgumentNullException("screen");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selEnterFullScreenMode_WithOptions_Handle, screen.Handle, options.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEnterFullScreenMode_WithOptions_Handle, screen.Handle, options.Handle);
	}

	[Export("exerciseAmbiguityInLayout")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExerciseAmbiguityInLayout()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selExerciseAmbiguityInLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selExerciseAmbiguityInLayoutHandle);
		}
	}

	[Export("exitFullScreenModeWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExitFullscreenModeWithOptions(NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selExitFullScreenModeWithOptions_Handle, options.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selExitFullScreenModeWithOptions_Handle, options.Handle);
		}
	}

	[Export("focusView")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSView? FocusView()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(class_ptr, selFocusViewHandle));
	}

	[Export("gState")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GState()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selGStateHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selGStateHandle);
	}

	[Export("accessibilityActionDescription:")]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString GetAccessibilityActionDescription(NSString action)
	{
		NSApplication.EnsureUIThread();
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAccessibilityActionDescription_Handle, action.Handle));
		}
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccessibilityActionDescription_Handle, action.Handle));
	}

	[Export("accessibilityArrayAttributeCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetAccessibilityArrayAttributeCount(NSString attribute)
	{
		NSApplication.EnsureUIThread();
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr(base.Handle, selAccessibilityArrayAttributeCount_Handle, attribute.Handle);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccessibilityArrayAttributeCount_Handle, attribute.Handle);
	}

	[Export("accessibilityArrayAttributeValues:index:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] GetAccessibilityArrayAttributeValues(NSString attribute, nuint index, nuint maxCount)
	{
		NSApplication.EnsureUIThread();
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint(base.Handle, selAccessibilityArrayAttributeValues_Index_MaxCount_Handle, attribute.Handle, index, maxCount));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint(base.SuperHandle, selAccessibilityArrayAttributeValues_Index_MaxCount_Handle, attribute.Handle, index, maxCount));
	}

	[Export("accessibilityAttributedStringForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString? GetAccessibilityAttributedString(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAccessibilityAttributedStringForRange_Handle, range));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAccessibilityAttributedStringForRange_Handle, range));
	}

	[Export("accessibilityCellForColumn:row:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? GetAccessibilityCellForColumn(nint column, nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selAccessibilityCellForColumn_Row_Handle, column, row));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selAccessibilityCellForColumn_Row_Handle, column, row));
	}

	[Export("accessibilityFocusedUIElement")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetAccessibilityFocusedUIElement()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityFocusedUIElementHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityFocusedUIElementHandle));
	}

	[Export("accessibilityFrameForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetAccessibilityFrame(NSRange range)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_NSRange(out retval, base.Handle, selAccessibilityFrameForRange_Handle, range);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_NSRange(out retval, base.SuperHandle, selAccessibilityFrameForRange_Handle, range);
		}
		return retval;
	}

	[Export("accessibilityHitTest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetAccessibilityHitTest(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selAccessibilityHitTest_Handle, point));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selAccessibilityHitTest_Handle, point));
	}

	[Export("accessibilityIndexOfChild:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetAccessibilityIndexOfChild(NSObject child)
	{
		NSApplication.EnsureUIThread();
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr(base.Handle, selAccessibilityIndexOfChild_Handle, child.Handle);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccessibilityIndexOfChild_Handle, child.Handle);
	}

	[Export("accessibilityLayoutPointForScreenPoint:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint GetAccessibilityLayoutForScreen(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selAccessibilityLayoutPointForScreenPoint_Handle, point);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selAccessibilityLayoutPointForScreenPoint_Handle, point);
	}

	[Export("accessibilityLayoutSizeForScreenSize:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize GetAccessibilityLayoutForScreen(CGSize size)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selAccessibilityLayoutSizeForScreenSize_Handle, size);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selAccessibilityLayoutSizeForScreenSize_Handle, size);
	}

	[Export("accessibilityLineForIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetAccessibilityLine(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selAccessibilityLineForIndex_Handle, index);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityLineForIndex_Handle, index);
	}

	[Export("accessibilityRangeForPosition:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetAccessibilityRange(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_CGPoint(base.Handle, selAccessibilityRangeForPosition_Handle, point);
		}
		return Messaging.NSRange_objc_msgSendSuper_CGPoint(base.SuperHandle, selAccessibilityRangeForPosition_Handle, point);
	}

	[Export("accessibilityRangeForIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetAccessibilityRange(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nint(base.Handle, selAccessibilityRangeForIndex_Handle, index);
		}
		return Messaging.NSRange_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityRangeForIndex_Handle, index);
	}

	[Export("accessibilityRangeForLine:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetAccessibilityRangeForLine(nint line)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nint(base.Handle, selAccessibilityRangeForLine_Handle, line);
		}
		return Messaging.NSRange_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityRangeForLine_Handle, line);
	}

	[Export("accessibilityRTFForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetAccessibilityRtf(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAccessibilityRTFForRange_Handle, range));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAccessibilityRTFForRange_Handle, range));
	}

	[Export("accessibilityScreenPointForLayoutPoint:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint GetAccessibilityScreenForLayout(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selAccessibilityScreenPointForLayoutPoint_Handle, point);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selAccessibilityScreenPointForLayoutPoint_Handle, point);
	}

	[Export("accessibilityScreenSizeForLayoutSize:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize GetAccessibilityScreenForLayout(CGSize size)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selAccessibilityScreenSizeForLayoutSize_Handle, size);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selAccessibilityScreenSizeForLayoutSize_Handle, size);
	}

	[Export("accessibilityStringForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetAccessibilityString(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAccessibilityStringForRange_Handle, range));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAccessibilityStringForRange_Handle, range));
	}

	[Export("accessibilityStyleRangeForIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetAccessibilityStyleRange(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nint(base.Handle, selAccessibilityStyleRangeForIndex_Handle, index);
		}
		return Messaging.NSRange_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityStyleRangeForIndex_Handle, index);
	}

	[Export("accessibilityAttributeValue:")]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetAccessibilityValue(NSString attribute)
	{
		NSApplication.EnsureUIThread();
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAccessibilityAttributeValue_Handle, attribute.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccessibilityAttributeValue_Handle, attribute.Handle));
	}

	[Export("accessibilityAttributeValue:forParameter:")]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetAccessibilityValue(NSString attribute, NSObject parameter)
	{
		NSApplication.EnsureUIThread();
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (parameter == null)
		{
			throw new ArgumentNullException("parameter");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selAccessibilityAttributeValue_ForParameter_Handle, attribute.Handle, parameter.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAccessibilityAttributeValue_ForParameter_Handle, attribute.Handle, parameter.Handle));
	}

	[Export("alignmentRectForFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetAlignmentRectForFrame(CGRect frame)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selAlignmentRectForFrame_Handle, frame);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selAlignmentRectForFrame_Handle, frame);
		}
		return retval;
	}

	[Export("constraintsAffectingLayoutForOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint[] GetConstraintsAffectingLayout(NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selConstraintsAffectingLayoutForOrientation_Handle, (long)orientation));
		}
		return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selConstraintsAffectingLayoutForOrientation_Handle, (long)orientation));
	}

	[Export("contentCompressionResistancePriorityForOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetContentCompressionResistancePriority(NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_Int64(base.Handle, selContentCompressionResistancePriorityForOrientation_Handle, (long)orientation);
		}
		return Messaging.float_objc_msgSendSuper_Int64(base.SuperHandle, selContentCompressionResistancePriorityForOrientation_Handle, (long)orientation);
	}

	[Export("contentHuggingPriorityForOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetContentHuggingPriorityForOrientation(NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_Int64(base.Handle, selContentHuggingPriorityForOrientation_Handle, (long)orientation);
		}
		return Messaging.float_objc_msgSendSuper_Int64(base.SuperHandle, selContentHuggingPriorityForOrientation_Handle, (long)orientation);
	}

	[Export("frameForAlignmentRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetFrameForAlignmentRect(CGRect alignmentRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selFrameForAlignmentRect_Handle, alignmentRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selFrameForAlignmentRect_Handle, alignmentRect);
		}
		return retval;
	}

	[Export("hitTest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView HitTest(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selHitTest_Handle, aPoint));
		}
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selHitTest_Handle, aPoint));
	}

	[Export("invalidateIntrinsicContentSize")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateIntrinsicContentSize()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateIntrinsicContentSizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateIntrinsicContentSizeHandle);
		}
	}

	[Export("accessibilityIsAttributeSettable:")]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAccessibilityAttributeSettable(NSString attribute)
	{
		NSApplication.EnsureUIThread();
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAccessibilityIsAttributeSettable_Handle, attribute.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccessibilityIsAttributeSettable_Handle, attribute.Handle);
	}

	[Export("isAccessibilitySelectorAllowed:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAccessibilitySelectorAllowed(Selector selector)
	{
		NSApplication.EnsureUIThread();
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsAccessibilitySelectorAllowed_Handle, selector.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsAccessibilitySelectorAllowed_Handle, selector.Handle);
	}

	[Export("isDescendantOf:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDescendantOf(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDescendantOf_Handle, aView.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDescendantOf_Handle, aView.Handle);
	}

	[Export("mouse:inRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsMouseInRect(CGPoint aPoint, CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint_CGRect(base.Handle, selMouse_InRect_Handle, aPoint, aRect);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint_CGRect(base.SuperHandle, selMouse_InRect_Handle, aPoint, aRect);
	}

	[Export("knowsPageRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool KnowsPageRange(ref NSRange aRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_ref_NSRange(base.Handle, selKnowsPageRange_Handle, ref aRange);
		}
		return Messaging.bool_objc_msgSendSuper_ref_NSRange(base.SuperHandle, selKnowsPageRange_Handle, ref aRange);
	}

	[Export("layout")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Layout()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutHandle);
		}
	}

	[Export("layoutSubtreeIfNeeded")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LayoutSubtreeIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutSubtreeIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutSubtreeIfNeededHandle);
		}
	}

	[Export("locationOfPrintRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint LocationOfPrintRect(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGRect(base.Handle, selLocationOfPrintRect_Handle, aRect);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGRect(base.SuperHandle, selLocationOfPrintRect_Handle, aRect);
	}

	[Export("lockFocus")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Subclass NSView and implement 'DrawRect'.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LockFocus()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLockFocusHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLockFocusHandle);
		}
	}

	[Export("lockFocusIfCanDraw")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Subclass NSView and implement 'DrawRect'.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LockFocusIfCanDraw()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selLockFocusIfCanDrawHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLockFocusIfCanDrawHandle);
	}

	[Export("lockFocusIfCanDrawInContext:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSView.DisplayRectIgnoringOpacity (CGRect, NSGraphicsContext)' to draw into a graphics context.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LockFocusIfCanDrawInContext(NSGraphicsContext context)
	{
		NSApplication.EnsureUIThread();
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selLockFocusIfCanDrawInContext_Handle, context.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selLockFocusIfCanDrawInContext_Handle, context.Handle);
	}

	[Export("makeBackingLayer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer MakeBackingLayer()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selMakeBackingLayerHandle));
		}
		return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMakeBackingLayerHandle));
	}

	[Export("menuForEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu MenuForEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMenuForEvent_Handle, theEvent.Handle));
		}
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMenuForEvent_Handle, theEvent.Handle));
	}

	[Export("needsToDrawRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NeedsToDraw(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect(base.Handle, selNeedsToDrawRect_Handle, aRect);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect(base.SuperHandle, selNeedsToDrawRect_Handle, aRect);
	}

	[Export("noteFocusRingMaskChanged")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NoteFocusRingMaskChanged()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selNoteFocusRingMaskChangedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selNoteFocusRingMaskChangedHandle);
		}
	}

	[Export("performDragOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PerformDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformDragOperation_Handle, sender.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformDragOperation_Handle, sender.Handle);
	}

	[Export("performKeyEquivalent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool PerformKeyEquivalent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformKeyEquivalent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformKeyEquivalent_Handle, theEvent.Handle);
	}

	[Export("performMnemonic:")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PerformMnemonic(string mnemonic)
	{
		NSApplication.EnsureUIThread();
		if (mnemonic == null)
		{
			throw new ArgumentNullException("mnemonic");
		}
		IntPtr arg = NSString.CreateNative(mnemonic);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformMnemonic_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformMnemonic_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("prepareContentInRect:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareContentInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selPrepareContentInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selPrepareContentInRect_Handle, rect);
		}
	}

	[Export("prepareForDragOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PrepareForDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPrepareForDragOperation_Handle, sender.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareForDragOperation_Handle, sender.Handle);
	}

	[Export("prepareForReuse")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareForReuse()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareForReuseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareForReuseHandle);
		}
	}

	[Export("print:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Print(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrint_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrint_Handle, sender.Handle);
		}
	}

	[Export("rectForPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect RectForPage(nint pageNumber)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selRectForPage_Handle, pageNumber);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selRectForPage_Handle, pageNumber);
		}
		return retval;
	}

	[Export("rectForSmartMagnificationAtPoint:inRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect RectForSmartMagnificationAtPoint(CGPoint atPoint, CGRect inRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGPoint_CGRect(out retval, base.Handle, selRectForSmartMagnificationAtPoint_InRect_Handle, atPoint, inRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGPoint_CGRect(out retval, base.SuperHandle, selRectForSmartMagnificationAtPoint_InRect_Handle, atPoint, inRect);
		}
		return retval;
	}

	[Export("registerForDraggedTypes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterForDraggedTypes(string[] newTypes)
	{
		NSApplication.EnsureUIThread();
		if (newTypes == null)
		{
			throw new ArgumentNullException("newTypes");
		}
		NSArray nSArray = NSArray.FromStrings(newTypes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRegisterForDraggedTypes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterForDraggedTypes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("registeredDraggedTypes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] RegisteredDragTypes()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRegisteredDraggedTypesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRegisteredDraggedTypesHandle));
	}

	[Export("releaseGState")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReleaseGState()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReleaseGStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReleaseGStateHandle);
		}
	}

	[Export("removeAllToolTips")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllToolTips()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllToolTipsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllToolTipsHandle);
		}
	}

	[Export("removeConstraint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveConstraint(NSLayoutConstraint constraint)
	{
		NSApplication.EnsureUIThread();
		if (constraint == null)
		{
			throw new ArgumentNullException("constraint");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveConstraint_Handle, constraint.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveConstraint_Handle, constraint.Handle);
		}
	}

	[Export("removeConstraints:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveConstraints(NSLayoutConstraint[] constraints)
	{
		NSApplication.EnsureUIThread();
		if (constraints == null)
		{
			throw new ArgumentNullException("constraints");
		}
		NSArray nSArray = NSArray.FromNSObjects(constraints);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveConstraints_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveConstraints_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeCursorRect:cursor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveCursorRect(CGRect aRect, NSCursor cursor)
	{
		NSApplication.EnsureUIThread();
		if (cursor == null)
		{
			throw new ArgumentNullException("cursor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selRemoveCursorRect_Cursor_Handle, aRect, cursor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selRemoveCursorRect_Cursor_Handle, aRect, cursor.Handle);
		}
	}

	[Export("removeFromSuperview")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveFromSuperview()
	{
		NSApplication.EnsureUIThread();
		NSView superview = Superview;
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveFromSuperviewHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveFromSuperviewHandle);
		}
		if (superview != null)
		{
			NSView[] subviews = superview.Subviews;
		}
	}

	[Export("removeFromSuperviewWithoutNeedingDisplay")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveFromSuperviewWithoutNeedingDisplay()
	{
		NSApplication.EnsureUIThread();
		NSView superview = Superview;
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveFromSuperviewWithoutNeedingDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveFromSuperviewWithoutNeedingDisplayHandle);
		}
		if (superview != null)
		{
			NSView[] subviews = superview.Subviews;
		}
	}

	[Export("removeGestureRecognizer:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveGestureRecognizer(NSGestureRecognizer gestureRecognizer)
	{
		NSApplication.EnsureUIThread();
		if (gestureRecognizer == null)
		{
			throw new ArgumentNullException("gestureRecognizer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveGestureRecognizer_Handle, gestureRecognizer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveGestureRecognizer_Handle, gestureRecognizer.Handle);
		}
	}

	[Export("removeLayoutGuide:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveLayoutGuide(NSLayoutGuide guide)
	{
		NSApplication.EnsureUIThread();
		if (guide == null)
		{
			throw new ArgumentNullException("guide");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveLayoutGuide_Handle, guide.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveLayoutGuide_Handle, guide.Handle);
		}
	}

	[Export("removeToolTip:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveToolTip(nint tag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveToolTip_Handle, tag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveToolTip_Handle, tag);
		}
	}

	[Export("removeTrackingArea:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTrackingArea(NSTrackingArea trackingArea)
	{
		NSApplication.EnsureUIThread();
		if (trackingArea == null)
		{
			throw new ArgumentNullException("trackingArea");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTrackingArea_Handle, trackingArea.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTrackingArea_Handle, trackingArea.Handle);
		}
	}

	[Export("removeTrackingRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTrackingRect(nint tag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveTrackingRect_Handle, tag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveTrackingRect_Handle, tag);
		}
	}

	[Export("renewGState")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RenewGState()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRenewGStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRenewGStateHandle);
		}
	}

	[Export("replaceSubview:with:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceSubviewWith(NSView oldView, NSView newView)
	{
		NSApplication.EnsureUIThread();
		if (oldView == null)
		{
			throw new ArgumentNullException("oldView");
		}
		if (newView == null)
		{
			throw new ArgumentNullException("newView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceSubview_With_Handle, oldView.Handle, newView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceSubview_With_Handle, oldView.Handle, newView.Handle);
		}
	}

	[Export("requiresConstraintBasedLayout")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool RequiresConstraintBasedLayout()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(class_ptr, selRequiresConstraintBasedLayoutHandle);
	}

	[Export("resetCursorRects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResetCursorRects()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetCursorRectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetCursorRectsHandle);
		}
	}

	[Export("resizeSubviewsWithOldSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResizeSubviewsWithOldSize(CGSize oldSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selResizeSubviewsWithOldSize_Handle, oldSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selResizeSubviewsWithOldSize_Handle, oldSize);
		}
	}

	[Export("resizeWithOldSuperviewSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResizeWithOldSuperviewSize(CGSize oldSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selResizeWithOldSuperviewSize_Handle, oldSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selResizeWithOldSuperviewSize_Handle, oldSize);
		}
	}

	[Export("rotateByAngle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RotateByAngle(nfloat angle)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, selRotateByAngle_Handle, angle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selRotateByAngle_Handle, angle);
		}
	}

	[Export("scaleUnitSquareToSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScaleUnitSquareToSize(CGSize newUnitSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selScaleUnitSquareToSize_Handle, newUnitSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selScaleUnitSquareToSize_Handle, newUnitSize);
		}
	}

	[Export("scrollPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollPoint(CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selScrollPoint_Handle, aPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selScrollPoint_Handle, aPoint);
		}
	}

	[Export("scrollRect:by:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use NSScrollView to achieve scrolling views.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollRect(CGRect aRect, CGSize delta)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGSize(base.Handle, selScrollRect_By_Handle, aRect, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGSize(base.SuperHandle, selScrollRect_By_Handle, aRect, delta);
		}
	}

	[Export("scrollRectToVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ScrollRectToVisible(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect(base.Handle, selScrollRectToVisible_Handle, aRect);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect(base.SuperHandle, selScrollRectToVisible_Handle, aRect);
	}

	[Export("accessibilitySetValue:forAttribute:")]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the NSAccessibility protocol methods instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAccessibilityValue(NSString attribute, NSObject value)
	{
		NSApplication.EnsureUIThread();
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAccessibilitySetValue_ForAttribute_Handle, attribute.Handle, value.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAccessibilitySetValue_ForAttribute_Handle, attribute.Handle, value.Handle);
		}
	}

	[Export("setBoundsOrigin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBoundsOrigin(CGPoint newOrigin)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetBoundsOrigin_Handle, newOrigin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetBoundsOrigin_Handle, newOrigin);
		}
	}

	[Export("setBoundsSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBoundsSize(CGSize newSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selSetBoundsSize_Handle, newSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetBoundsSize_Handle, newSize);
		}
	}

	[Export("setContentCompressionResistancePriority:forOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetContentCompressionResistancePriority(float priority, NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_Int64(base.Handle, selSetContentCompressionResistancePriority_ForOrientation_Handle, priority, (long)orientation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_Int64(base.SuperHandle, selSetContentCompressionResistancePriority_ForOrientation_Handle, priority, (long)orientation);
		}
	}

	[Export("setContentHuggingPriority:forOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetContentHuggingPriorityForOrientation(float priority, NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_Int64(base.Handle, selSetContentHuggingPriority_ForOrientation_Handle, priority, (long)orientation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_Int64(base.SuperHandle, selSetContentHuggingPriority_ForOrientation_Handle, priority, (long)orientation);
		}
	}

	[Export("setFrameOrigin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFrameOrigin(CGPoint newOrigin)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetFrameOrigin_Handle, newOrigin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetFrameOrigin_Handle, newOrigin);
		}
	}

	[Export("setFrameSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFrameSize(CGSize newSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selSetFrameSize_Handle, newSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetFrameSize_Handle, newSize);
		}
	}

	[Export("setKeyboardFocusRingNeedsDisplayInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetKeyboardFocusRingNeedsDisplay(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selSetKeyboardFocusRingNeedsDisplayInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetKeyboardFocusRingNeedsDisplayInRect_Handle, rect);
		}
	}

	[Export("setNeedsDisplayInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeedsDisplayInRect(CGRect invalidRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selSetNeedsDisplayInRect_Handle, invalidRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetNeedsDisplayInRect_Handle, invalidRect);
		}
	}

	[Export("setUpGState")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetUpGState()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetUpGStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetUpGStateHandle);
		}
	}

	[Export("shouldDelayWindowOrderingForEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldDelayWindowOrderingForEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldDelayWindowOrderingForEvent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldDelayWindowOrderingForEvent_Handle, theEvent.Handle);
	}

	[Export("sortSubviewsUsingFunction:context:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void SortSubviews(IntPtr function_pointer, IntPtr context)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSortSubviewsUsingFunction_Context_Handle, function_pointer, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSortSubviewsUsingFunction_Context_Handle, function_pointer, context);
		}
	}

	[Export("trackingAreas")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTrackingArea[] TrackingAreas()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSTrackingArea>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackingAreasHandle));
		}
		return NSArray.ArrayFromHandle<NSTrackingArea>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackingAreasHandle));
	}

	[Export("translateOriginToPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TranslateOriginToPoint(CGPoint translation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selTranslateOriginToPoint_Handle, translation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selTranslateOriginToPoint_Handle, translation);
		}
	}

	[Export("translateRectsNeedingDisplayInRect:by:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TranslateRectsNeedingDisplay(CGRect clipRect, CGSize delta)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGSize(base.Handle, selTranslateRectsNeedingDisplayInRect_By_Handle, clipRect, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGSize(base.SuperHandle, selTranslateRectsNeedingDisplayInRect_By_Handle, clipRect, delta);
		}
	}

	[Export("unlockFocus")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Subclass NSView and implement 'DrawRect'.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnlockFocus()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnlockFocusHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnlockFocusHandle);
		}
	}

	[Export("unregisterDraggedTypes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnregisterDraggedTypes()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnregisterDraggedTypesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnregisterDraggedTypesHandle);
		}
	}

	[Export("updateConstraints")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual void UpdateConstraints()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateConstraintsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateConstraintsHandle);
		}
	}

	[Export("updateConstraintsForSubtreeIfNeeded")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateConstraintsForSubtreeIfNeeded()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateConstraintsForSubtreeIfNeededHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateConstraintsForSubtreeIfNeededHandle);
		}
	}

	[Export("updateLayer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateLayer()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateLayerHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateLayerHandle);
		}
	}

	[Export("updateTrackingAreas")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateTrackingAreas()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateTrackingAreasHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateTrackingAreasHandle);
		}
	}

	[Export("viewDidChangeEffectiveAppearance")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewDidChangeEffectiveAppearance()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidChangeEffectiveAppearanceHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidChangeEffectiveAppearanceHandle);
		}
	}

	[Export("viewDidEndLiveResize")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewDidEndLiveResize()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidEndLiveResizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidEndLiveResizeHandle);
		}
	}

	[Export("viewDidHide")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewDidHide()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidHideHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidHideHandle);
		}
	}

	[Export("viewDidMoveToSuperview")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewDidMoveToSuperview()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidMoveToSuperviewHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidMoveToSuperviewHandle);
		}
	}

	[Export("viewDidMoveToWindow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewDidMoveToWindow()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidMoveToWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidMoveToWindowHandle);
		}
	}

	[Export("viewDidUnhide")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewDidUnhide()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidUnhideHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidUnhideHandle);
		}
	}

	[Export("viewWillDraw")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewWillDraw()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewWillDrawHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewWillDrawHandle);
		}
	}

	[Export("viewWillMoveToSuperview:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewWillMoveToSuperview(NSView? newSuperview)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selViewWillMoveToSuperview_Handle, newSuperview?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selViewWillMoveToSuperview_Handle, newSuperview?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("viewWillMoveToWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewWillMoveToWindow(NSWindow? newWindow)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selViewWillMoveToWindow_Handle, newWindow?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selViewWillMoveToWindow_Handle, newWindow?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("viewWillStartLiveResize")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewWillStartLiveResize()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewWillStartLiveResizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewWillStartLiveResizeHandle);
		}
	}

	[Export("viewWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ViewWithTag(nint aTag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selViewWithTag_Handle, aTag));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selViewWithTag_Handle, aTag));
	}

	[Export("visibleRect")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect VisibleRect()
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selVisibleRectHandle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVisibleRectHandle);
		}
		return retval;
	}

	[Export("willOpenMenu:withEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillOpenMenu(NSMenu menu, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selWillOpenMenu_WithEvent_Handle, menu.Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWillOpenMenu_WithEvent_Handle, menu.Handle, theEvent.Handle);
		}
	}

	[Export("willRemoveSubview:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillRemoveSubview(NSView? subview)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillRemoveSubview_Handle, subview?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillRemoveSubview_Handle, subview?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("writeEPSInsideRect:toPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteEpsInsideRect(CGRect rect, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selWriteEPSInsideRect_ToPasteboard_Handle, rect, pboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selWriteEPSInsideRect_ToPasteboard_Handle, rect, pboard.Handle);
		}
	}

	[Export("writePDFInsideRect:toPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WritePdfInsideRect(CGRect rect, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selWritePDFInsideRect_ToPasteboard_Handle, rect, pboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selWritePDFInsideRect_ToPasteboard_Handle, rect, pboard.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AccessibilityDisclosedByRow_var = null;
			__mt_AccessibilityExtrasMenuBar_var = null;
			__mt_AccessibilityMenuBar_var = null;
			__mt_AccessibilityParent_var = null;
			__mt_AccessibilityTitleUIElement_var = null;
			__mt_AccessibilityTopLevelUIElement_var = null;
			__mt_AccessibilityWindow_var = null;
		}
	}
}
