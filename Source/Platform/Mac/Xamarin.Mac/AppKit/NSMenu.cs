using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMenu", true)]
public class NSMenu : NSObject, INSAccessibility, INativeObject, IDisposable, INSCoding, INSCopying, INSUserInterfaceItemIdentification
{
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

		public static NSObject ObserveDidAddItem(EventHandler<NSMenuItemIndexEventArgs> handler)
		{
			EventHandler<NSMenuItemIndexEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidAddItemNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSMenuItemIndexEventArgs(notification));
			});
		}

		public static NSObject ObserveDidAddItem(NSObject objectToObserve, EventHandler<NSMenuItemIndexEventArgs> handler)
		{
			EventHandler<NSMenuItemIndexEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidAddItemNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSMenuItemIndexEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidBeginTracking(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginTrackingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidBeginTracking(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginTrackingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidChangeItem(EventHandler<NSMenuItemIndexEventArgs> handler)
		{
			EventHandler<NSMenuItemIndexEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeItemNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSMenuItemIndexEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeItem(NSObject objectToObserve, EventHandler<NSMenuItemIndexEventArgs> handler)
		{
			EventHandler<NSMenuItemIndexEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeItemNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSMenuItemIndexEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEndTracking(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndTrackingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEndTracking(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndTrackingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidRemoveItem(EventHandler<NSMenuItemIndexEventArgs> handler)
		{
			EventHandler<NSMenuItemIndexEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidRemoveItemNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSMenuItemIndexEventArgs(notification));
			});
		}

		public static NSObject ObserveDidRemoveItem(NSObject objectToObserve, EventHandler<NSMenuItemIndexEventArgs> handler)
		{
			EventHandler<NSMenuItemIndexEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidRemoveItemNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSMenuItemIndexEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidSendAction(EventHandler<NSMenuItemEventArgs> handler)
		{
			EventHandler<NSMenuItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidSendActionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSMenuItemEventArgs(notification));
			});
		}

		public static NSObject ObserveDidSendAction(NSObject objectToObserve, EventHandler<NSMenuItemEventArgs> handler)
		{
			EventHandler<NSMenuItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidSendActionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSMenuItemEventArgs(notification));
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

		public static NSObject ObserveWillSendAction(EventHandler<NSMenuItemEventArgs> handler)
		{
			EventHandler<NSMenuItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillSendActionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSMenuItemEventArgs(notification));
			});
		}

		public static NSObject ObserveWillSendAction(NSObject objectToObserve, EventHandler<NSMenuItemEventArgs> handler)
		{
			EventHandler<NSMenuItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillSendActionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSMenuItemEventArgs(notification));
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityActivationPoint = "accessibilityActivationPoint";

	private static readonly IntPtr selAccessibilityActivationPointHandle = Selector.GetHandle("accessibilityActivationPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityAddChildElement_ = "accessibilityAddChildElement:";

	private static readonly IntPtr selAccessibilityAddChildElement_Handle = Selector.GetHandle("accessibilityAddChildElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityAllowedValues = "accessibilityAllowedValues";

	private static readonly IntPtr selAccessibilityAllowedValuesHandle = Selector.GetHandle("accessibilityAllowedValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityApplicationFocusedUIElement = "accessibilityApplicationFocusedUIElement";

	private static readonly IntPtr selAccessibilityApplicationFocusedUIElementHandle = Selector.GetHandle("accessibilityApplicationFocusedUIElement");

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
	private const string selAccessibilityElementWithRole_Frame_Label_Parent_ = "accessibilityElementWithRole:frame:label:parent:";

	private static readonly IntPtr selAccessibilityElementWithRole_Frame_Label_Parent_Handle = Selector.GetHandle("accessibilityElementWithRole:frame:label:parent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityExtrasMenuBar = "accessibilityExtrasMenuBar";

	private static readonly IntPtr selAccessibilityExtrasMenuBarHandle = Selector.GetHandle("accessibilityExtrasMenuBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFilename = "accessibilityFilename";

	private static readonly IntPtr selAccessibilityFilenameHandle = Selector.GetHandle("accessibilityFilename");

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
	private const string selAccessibilityFrameInParentSpace = "accessibilityFrameInParentSpace";

	private static readonly IntPtr selAccessibilityFrameInParentSpaceHandle = Selector.GetHandle("accessibilityFrameInParentSpace");

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
	private const string selAccessibilityInsertionPointLineNumber = "accessibilityInsertionPointLineNumber";

	private static readonly IntPtr selAccessibilityInsertionPointLineNumberHandle = Selector.GetHandle("accessibilityInsertionPointLineNumber");

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
	private const string selAccessibilityNumberOfCharacters = "accessibilityNumberOfCharacters";

	private static readonly IntPtr selAccessibilityNumberOfCharactersHandle = Selector.GetHandle("accessibilityNumberOfCharacters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityOrientation = "accessibilityOrientation";

	private static readonly IntPtr selAccessibilityOrientationHandle = Selector.GetHandle("accessibilityOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityOverflowButton = "accessibilityOverflowButton";

	private static readonly IntPtr selAccessibilityOverflowButtonHandle = Selector.GetHandle("accessibilityOverflowButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParent = "accessibilityParent";

	private static readonly IntPtr selAccessibilityParentHandle = Selector.GetHandle("accessibilityParent");

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
	private const string selAddItem_ = "addItem:";

	private static readonly IntPtr selAddItem_Handle = Selector.GetHandle("addItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddItemWithTitle_Action_KeyEquivalent_ = "addItemWithTitle:action:keyEquivalent:";

	private static readonly IntPtr selAddItemWithTitle_Action_KeyEquivalent_Handle = Selector.GetHandle("addItemWithTitle:action:keyEquivalent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsContextMenuPlugIns = "allowsContextMenuPlugIns";

	private static readonly IntPtr selAllowsContextMenuPlugInsHandle = Selector.GetHandle("allowsContextMenuPlugIns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoenablesItems = "autoenablesItems";

	private static readonly IntPtr selAutoenablesItemsHandle = Selector.GetHandle("autoenablesItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelTracking = "cancelTracking";

	private static readonly IntPtr selCancelTrackingHandle = Selector.GetHandle("cancelTracking");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelTrackingWithoutAnimation = "cancelTrackingWithoutAnimation";

	private static readonly IntPtr selCancelTrackingWithoutAnimationHandle = Selector.GetHandle("cancelTrackingWithoutAnimation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFont = "font";

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHelpRequested_ = "helpRequested:";

	private static readonly IntPtr selHelpRequested_Handle = Selector.GetHandle("helpRequested:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlightedItem = "highlightedItem";

	private static readonly IntPtr selHighlightedItemHandle = Selector.GetHandle("highlightedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItem_ = "indexOfItem:";

	private static readonly IntPtr selIndexOfItem_Handle = Selector.GetHandle("indexOfItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemWithRepresentedObject_ = "indexOfItemWithRepresentedObject:";

	private static readonly IntPtr selIndexOfItemWithRepresentedObject_Handle = Selector.GetHandle("indexOfItemWithRepresentedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemWithSubmenu_ = "indexOfItemWithSubmenu:";

	private static readonly IntPtr selIndexOfItemWithSubmenu_Handle = Selector.GetHandle("indexOfItemWithSubmenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemWithTag_ = "indexOfItemWithTag:";

	private static readonly IntPtr selIndexOfItemWithTag_Handle = Selector.GetHandle("indexOfItemWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemWithTarget_AndAction_ = "indexOfItemWithTarget:andAction:";

	private static readonly IntPtr selIndexOfItemWithTarget_AndAction_Handle = Selector.GetHandle("indexOfItemWithTarget:andAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemWithTitle_ = "indexOfItemWithTitle:";

	private static readonly IntPtr selIndexOfItemWithTitle_Handle = Selector.GetHandle("indexOfItemWithTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTitle_ = "initWithTitle:";

	private static readonly IntPtr selInitWithTitle_Handle = Selector.GetHandle("initWithTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertItem_AtIndex_ = "insertItem:atIndex:";

	private static readonly IntPtr selInsertItem_AtIndex_Handle = Selector.GetHandle("insertItem:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertItemWithTitle_Action_KeyEquivalent_AtIndex_ = "insertItemWithTitle:action:keyEquivalent:atIndex:";

	private static readonly IntPtr selInsertItemWithTitle_Action_KeyEquivalent_AtIndex_Handle = Selector.GetHandle("insertItemWithTitle:action:keyEquivalent:atIndex:");

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
	private const string selIsTornOff = "isTornOff";

	private static readonly IntPtr selIsTornOffHandle = Selector.GetHandle("isTornOff");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemArray = "itemArray";

	private static readonly IntPtr selItemArrayHandle = Selector.GetHandle("itemArray");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtIndex_ = "itemAtIndex:";

	private static readonly IntPtr selItemAtIndex_Handle = Selector.GetHandle("itemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemChanged_ = "itemChanged:";

	private static readonly IntPtr selItemChanged_Handle = Selector.GetHandle("itemChanged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemWithTag_ = "itemWithTag:";

	private static readonly IntPtr selItemWithTag_Handle = Selector.GetHandle("itemWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemWithTitle_ = "itemWithTitle:";

	private static readonly IntPtr selItemWithTitle_Handle = Selector.GetHandle("itemWithTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuBarHeight = "menuBarHeight";

	private static readonly IntPtr selMenuBarHeightHandle = Selector.GetHandle("menuBarHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuBarVisible = "menuBarVisible";

	private static readonly IntPtr selMenuBarVisibleHandle = Selector.GetHandle("menuBarVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuChangedMessagesEnabled = "menuChangedMessagesEnabled";

	private static readonly IntPtr selMenuChangedMessagesEnabledHandle = Selector.GetHandle("menuChangedMessagesEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuZone = "menuZone";

	private static readonly IntPtr selMenuZoneHandle = Selector.GetHandle("menuZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumWidth = "minimumWidth";

	private static readonly IntPtr selMinimumWidthHandle = Selector.GetHandle("minimumWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfItems = "numberOfItems";

	private static readonly IntPtr selNumberOfItemsHandle = Selector.GetHandle("numberOfItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformActionForItemAtIndex_ = "performActionForItemAtIndex:";

	private static readonly IntPtr selPerformActionForItemAtIndex_Handle = Selector.GetHandle("performActionForItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformKeyEquivalent_ = "performKeyEquivalent:";

	private static readonly IntPtr selPerformKeyEquivalent_Handle = Selector.GetHandle("performKeyEquivalent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPopUpContextMenu_WithEvent_ForView_ = "popUpContextMenu:withEvent:forView:";

	private static readonly IntPtr selPopUpContextMenu_WithEvent_ForView_Handle = Selector.GetHandle("popUpContextMenu:withEvent:forView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPopUpContextMenu_WithEvent_ForView_WithFont_ = "popUpContextMenu:withEvent:forView:withFont:";

	private static readonly IntPtr selPopUpContextMenu_WithEvent_ForView_WithFont_Handle = Selector.GetHandle("popUpContextMenu:withEvent:forView:withFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPopUpMenuPositioningItem_AtLocation_InView_ = "popUpMenuPositioningItem:atLocation:inView:";

	private static readonly IntPtr selPopUpMenuPositioningItem_AtLocation_InView_Handle = Selector.GetHandle("popUpMenuPositioningItem:atLocation:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertiesToUpdate = "propertiesToUpdate";

	private static readonly IntPtr selPropertiesToUpdateHandle = Selector.GetHandle("propertiesToUpdate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllItems = "removeAllItems";

	private static readonly IntPtr selRemoveAllItemsHandle = Selector.GetHandle("removeAllItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItem_ = "removeItem:";

	private static readonly IntPtr selRemoveItem_Handle = Selector.GetHandle("removeItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItemAtIndex_ = "removeItemAtIndex:";

	private static readonly IntPtr selRemoveItemAtIndex_Handle = Selector.GetHandle("removeItemAtIndex:");

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
	private const string selSetAccessibilityFrameInParentSpace_ = "setAccessibilityFrameInParentSpace:";

	private static readonly IntPtr selSetAccessibilityFrameInParentSpace_Handle = Selector.GetHandle("setAccessibilityFrameInParentSpace:");

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
	private const string selSetAllowsContextMenuPlugIns_ = "setAllowsContextMenuPlugIns:";

	private static readonly IntPtr selSetAllowsContextMenuPlugIns_Handle = Selector.GetHandle("setAllowsContextMenuPlugIns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoenablesItems_ = "setAutoenablesItems:";

	private static readonly IntPtr selSetAutoenablesItems_Handle = Selector.GetHandle("setAutoenablesItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFont_ = "setFont:";

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdentifier_ = "setIdentifier:";

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetItemArray_ = "setItemArray:";

	private static readonly IntPtr selSetItemArray_Handle = Selector.GetHandle("setItemArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenuBarVisible_ = "setMenuBarVisible:";

	private static readonly IntPtr selSetMenuBarVisible_Handle = Selector.GetHandle("setMenuBarVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenuChangedMessagesEnabled_ = "setMenuChangedMessagesEnabled:";

	private static readonly IntPtr selSetMenuChangedMessagesEnabled_Handle = Selector.GetHandle("setMenuChangedMessagesEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumWidth_ = "setMinimumWidth:";

	private static readonly IntPtr selSetMinimumWidth_Handle = Selector.GetHandle("setMinimumWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsStateColumn_ = "setShowsStateColumn:";

	private static readonly IntPtr selSetShowsStateColumn_Handle = Selector.GetHandle("setShowsStateColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubmenu_ForItem_ = "setSubmenu:forItem:";

	private static readonly IntPtr selSetSubmenu_ForItem_Handle = Selector.GetHandle("setSubmenu:forItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSupermenu_ = "setSupermenu:";

	private static readonly IntPtr selSetSupermenu_Handle = Selector.GetHandle("setSupermenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserInterfaceLayoutDirection_ = "setUserInterfaceLayoutDirection:";

	private static readonly IntPtr selSetUserInterfaceLayoutDirection_Handle = Selector.GetHandle("setUserInterfaceLayoutDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsStateColumn = "showsStateColumn";

	private static readonly IntPtr selShowsStateColumnHandle = Selector.GetHandle("showsStateColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupermenu = "supermenu";

	private static readonly IntPtr selSupermenuHandle = Selector.GetHandle("supermenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdate = "update";

	private static readonly IntPtr selUpdateHandle = Selector.GetHandle("update");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserInterfaceLayoutDirection = "userInterfaceLayoutDirection";

	private static readonly IntPtr selUserInterfaceLayoutDirectionHandle = Selector.GetHandle("userInterfaceLayoutDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMenu");

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
	private object? __mt_Supermenu_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

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
	private static NSString? _CreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidAddItemNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidBeginTrackingNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeItemNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEndTrackingNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidRemoveItemNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidSendActionNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DrawerCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FocusedWindowChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HelpTagCreatedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LayoutChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MainWindowChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MovedNotification;

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
	private static NSString? _ValueChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillSendActionNotification;

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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGPoint AccessibilityActivationPoint
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityActivationPoint", ArgumentSemantic.Assign)]
		get
		{
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityCancelButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityCancelButton", ArgumentSemantic.Retain)]
		get
		{
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
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisclosedByRowHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDisclosedByRowHandle)));
			MarkDirty();
			__mt_AccessibilityDisclosedByRow_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosedByRow:", ArgumentSemantic.Weak)]
		set
		{
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
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityExtrasMenuBarHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityExtrasMenuBarHandle)));
			MarkDirty();
			__mt_AccessibilityExtrasMenuBar_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityExtrasMenuBar:", ArgumentSemantic.Weak)]
		set
		{
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
	public virtual CGRect AccessibilityFrameInParentSpace
	{
		[Export("accessibilityFrameInParentSpace")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selAccessibilityFrameInParentSpaceHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAccessibilityFrameInParentSpaceHandle);
			}
			return retval;
		}
		[Export("setAccessibilityFrameInParentSpace:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetAccessibilityFrameInParentSpace_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetAccessibilityFrameInParentSpace_Handle, value);
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? AccessibilityLabel
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLabel")]
		get
		{
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
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityMenuBarHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityMenuBarHandle)));
			MarkDirty();
			__mt_AccessibilityMenuBar_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMenuBar:", ArgumentSemantic.Weak)]
		set
		{
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint AccessibilityNumberOfCharacters
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityNumberOfCharacters")]
		get
		{
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? AccessibilityParent
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityParent", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParentHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParentHandle)));
			MarkDirty();
			__mt_AccessibilityParent_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityParent:", ArgumentSemantic.Weak)]
		set
		{
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
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityTitleUIElementHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityTitleUIElementHandle)));
			MarkDirty();
			__mt_AccessibilityTitleUIElement_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTitleUIElement:", ArgumentSemantic.Weak)]
		set
		{
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
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityTopLevelUIElementHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityTopLevelUIElementHandle)));
			MarkDirty();
			__mt_AccessibilityTopLevelUIElement_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTopLevelUIElement:", ArgumentSemantic.Weak)]
		set
		{
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
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityWindowHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityWindowHandle)));
			MarkDirty();
			__mt_AccessibilityWindow_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityWindow:", ArgumentSemantic.Weak)]
		set
		{
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
	public virtual bool AllowsContextMenuPlugIns
	{
		[Export("allowsContextMenuPlugIns")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsContextMenuPlugInsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsContextMenuPlugInsHandle);
		}
		[Export("setAllowsContextMenuPlugIns:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsContextMenuPlugIns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsContextMenuPlugIns_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutoEnablesItems
	{
		[Export("autoenablesItems")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoenablesItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoenablesItemsHandle);
		}
		[Export("setAutoenablesItems:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoenablesItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoenablesItems_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Count
	{
		[Export("numberOfItems")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfItemsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfItemsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSMenuDelegate? Delegate
	{
		get
		{
			return WeakDelegate as INSMenuDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont Font
	{
		[Export("font", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend(base.Handle, selFontHandle));
			}
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontHandle));
		}
		[Export("setFont:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFont_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem? HighlightedItem
	{
		[Export("highlightedItem")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selHighlightedItemHandle));
			}
			return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHighlightedItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Export("setIdentifier:", ArgumentSemantic.Copy)]
		set
		{
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
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	public virtual bool IsTornOff
	{
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		[Export("isTornOff")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTornOffHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTornOffHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem[] Items
	{
		[Export("itemArray", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSMenuItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemArrayHandle));
			}
			return NSArray.ArrayFromHandle<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemArrayHandle));
		}
		[Export("setItemArray:", ArgumentSemantic.Copy)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetItemArray_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetItemArray_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MenuBarHeight
	{
		[Export("menuBarHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMenuBarHeightHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMenuBarHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool MenuBarVisible
	{
		[Export("menuBarVisible")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selMenuBarVisibleHandle);
		}
		[Export("setMenuBarVisible:")]
		set
		{
			Messaging.void_objc_msgSend_bool(class_ptr, selSetMenuBarVisible_Handle, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	public virtual bool MenuChangedMessagesEnabled
	{
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		[Export("menuChangedMessagesEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMenuChangedMessagesEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMenuChangedMessagesEnabledHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		[Export("setMenuChangedMessagesEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMenuChangedMessagesEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMenuChangedMessagesEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	public static NSZone MenuZone
	{
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		[Export("menuZone")]
		get
		{
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(class_ptr, selMenuZoneHandle);
			return (intPtr == IntPtr.Zero) ? null : new NSZone(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinimumWidth
	{
		[Export("minimumWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumWidthHandle);
		}
		[Export("setMinimumWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsStateColumn
	{
		[Export("showsStateColumn")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsStateColumnHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsStateColumnHandle);
		}
		[Export("setShowsStateColumn:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsStateColumn_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsStateColumn_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu? Supermenu
	{
		[Export("supermenu", ArgumentSemantic.Assign)]
		get
		{
			NSMenu nSMenu = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupermenuHandle)) : Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupermenuHandle)));
			MarkDirty();
			__mt_Supermenu_var = nSMenu;
			return nSMenu;
		}
		[Export("setSupermenu:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSupermenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSupermenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Supermenu_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("userInterfaceLayoutDirection", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSend(base.Handle, selUserInterfaceLayoutDirectionHandle);
			}
			return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUserInterfaceLayoutDirectionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setUserInterfaceLayoutDirection:", ArgumentSemantic.Assign)]
		set
		{
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
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[Field("NSAccessibilityAnnouncementRequestedNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveAnnouncementRequested helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveApplicationActivated helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveApplicationDeactivated helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveApplicationHidden helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveApplicationShown helper method instead.")]
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

	[Field("NSAccessibilityCreatedNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveCreated helper method instead.")]
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

	[Field("NSMenuDidAddItemNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveDidAddItem helper method instead.")]
	public static NSString DidAddItemNotification
	{
		get
		{
			if (_DidAddItemNotification == null)
			{
				_DidAddItemNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSMenuDidAddItemNotification");
			}
			return _DidAddItemNotification;
		}
	}

	[Field("NSMenuDidBeginTrackingNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveDidBeginTracking helper method instead.")]
	public static NSString DidBeginTrackingNotification
	{
		get
		{
			if (_DidBeginTrackingNotification == null)
			{
				_DidBeginTrackingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSMenuDidBeginTrackingNotification");
			}
			return _DidBeginTrackingNotification;
		}
	}

	[Field("NSMenuDidChangeItemNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveDidChangeItem helper method instead.")]
	public static NSString DidChangeItemNotification
	{
		get
		{
			if (_DidChangeItemNotification == null)
			{
				_DidChangeItemNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSMenuDidChangeItemNotification");
			}
			return _DidChangeItemNotification;
		}
	}

	[Field("NSMenuDidEndTrackingNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveDidEndTracking helper method instead.")]
	public static NSString DidEndTrackingNotification
	{
		get
		{
			if (_DidEndTrackingNotification == null)
			{
				_DidEndTrackingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSMenuDidEndTrackingNotification");
			}
			return _DidEndTrackingNotification;
		}
	}

	[Field("NSMenuDidRemoveItemNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveDidRemoveItem helper method instead.")]
	public static NSString DidRemoveItemNotification
	{
		get
		{
			if (_DidRemoveItemNotification == null)
			{
				_DidRemoveItemNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSMenuDidRemoveItemNotification");
			}
			return _DidRemoveItemNotification;
		}
	}

	[Field("NSMenuDidSendActionNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveDidSendAction helper method instead.")]
	public static NSString DidSendActionNotification
	{
		get
		{
			if (_DidSendActionNotification == null)
			{
				_DidSendActionNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSMenuDidSendActionNotification");
			}
			return _DidSendActionNotification;
		}
	}

	[Field("NSAccessibilityDrawerCreatedNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveDrawerCreated helper method instead.")]
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

	[Field("NSAccessibilityFocusedWindowChangedNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveFocusedWindowChanged helper method instead.")]
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

	[Field("NSAccessibilityHelpTagCreatedNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveHelpTagCreated helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveLayoutChanged helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveMainWindowChanged helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveMoved helper method instead.")]
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

	[Field("NSAccessibilityResizedNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveResized helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveRowCollapsed helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveRowCountChanged helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveRowExpanded helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveSelectedCellsChanged helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveSelectedChildrenChanged helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveSelectedChildrenMoved helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveSelectedColumnsChanged helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveSelectedRowsChanged helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveSelectedTextChanged helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveSheetCreated helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveTitleChanged helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveUIElementDestroyed helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveUIElementFocusedChanged helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveUnitsChanged helper method instead.")]
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

	[Field("NSAccessibilityValueChangedNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveValueChanged helper method instead.")]
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

	[Field("NSMenuWillSendActionNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveWillSendAction helper method instead.")]
	public static NSString WillSendActionNotification
	{
		get
		{
			if (_WillSendActionNotification == null)
			{
				_WillSendActionNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSMenuWillSendActionNotification");
			}
			return _WillSendActionNotification;
		}
	}

	[Field("NSAccessibilityWindowCreatedNotification", "AppKit")]
	[Advice("Use NSMenu.Notifications.ObserveWindowCreated helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveWindowDeminiaturized helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveWindowMiniaturized helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveWindowMoved helper method instead.")]
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
	[Advice("Use NSMenu.Notifications.ObserveWindowResized helper method instead.")]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMenu()
		: base(NSObjectFlag.Empty)
	{
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
	public NSMenu(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected NSMenu(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMenu(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTitle:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMenu(string aTitle)
		: base(NSObjectFlag.Empty)
	{
		if (aTitle == null)
		{
			throw new ArgumentNullException("aTitle");
		}
		IntPtr arg = NSString.CreateNative(aTitle);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTitle_Handle, arg), "initWithTitle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTitle_Handle, arg), "initWithTitle:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("accessibilityAddChildElement:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AccessibilityAddChildElement(NSAccessibilityElement childElement)
	{
		if (childElement == null)
		{
			throw new ArgumentNullException("childElement");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAccessibilityAddChildElement_Handle, childElement.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccessibilityAddChildElement_Handle, childElement.Handle);
		}
	}

	[Export("accessibilityPerformCancel")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessibilityPerformCancel()
	{
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
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformShowMenuHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformShowMenuHandle);
	}

	[Export("addItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddItem(NSMenuItem newItem)
	{
		if (newItem == null)
		{
			throw new ArgumentNullException("newItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItem_Handle, newItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItem_Handle, newItem.Handle);
		}
	}

	[Export("addItemWithTitle:action:keyEquivalent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem AddItem(string title, Selector? action, string charCode)
	{
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (charCode == null)
		{
			throw new ArgumentNullException("charCode");
		}
		IntPtr arg = NSString.CreateNative(title);
		IntPtr arg2 = NSString.CreateNative(charCode);
		NSMenuItem result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddItemWithTitle_Action_KeyEquivalent_Handle, arg, (action == null) ? IntPtr.Zero : action.Handle, arg2)) : Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAddItemWithTitle_Action_KeyEquivalent_Handle, arg, (action == null) ? IntPtr.Zero : action.Handle, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("cancelTracking")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelTracking()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelTrackingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelTrackingHandle);
		}
	}

	[Export("cancelTrackingWithoutAnimation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelTrackingWithoutAnimation()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelTrackingWithoutAnimationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelTrackingWithoutAnimationHandle);
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("accessibilityElementWithRole:frame:label:parent:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject CreateElement(NSString role, CGRect frame, NSString label, NSObject parent)
	{
		if (role == null)
		{
			throw new ArgumentNullException("role");
		}
		if (label == null)
		{
			throw new ArgumentNullException("label");
		}
		if (parent == null)
		{
			throw new ArgumentNullException("parent");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr_IntPtr(class_ptr, selAccessibilityElementWithRole_Frame_Label_Parent_Handle, role.Handle, frame, label.Handle, parent.Handle));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("accessibilityAttributedStringForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString? GetAccessibilityAttributedString(NSRange range)
	{
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
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selAccessibilityCellForColumn_Row_Handle, column, row));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selAccessibilityCellForColumn_Row_Handle, column, row));
	}

	[Export("accessibilityFrameForRange:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetAccessibilityFrame(NSRange range)
	{
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

	[Export("accessibilityLayoutPointForScreenPoint:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint GetAccessibilityLayoutForScreen(CGPoint point)
	{
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
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nint(base.Handle, selAccessibilityStyleRangeForIndex_Handle, index);
		}
		return Messaging.NSRange_objc_msgSendSuper_nint(base.SuperHandle, selAccessibilityStyleRangeForIndex_Handle, index);
	}

	[Export("helpRequested:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HelpRequested(NSEvent eventPtr)
	{
		if (eventPtr == null)
		{
			throw new ArgumentNullException("eventPtr");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selHelpRequested_Handle, eventPtr.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selHelpRequested_Handle, eventPtr.Handle);
		}
	}

	[Export("indexOfItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOf(NSMenuItem index)
	{
		if (index == null)
		{
			throw new ArgumentNullException("index");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfItem_Handle, index.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItem_Handle, index.Handle);
	}

	[Export("indexOfItemWithTitle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOf(string aTitle)
	{
		if (aTitle == null)
		{
			throw new ArgumentNullException("aTitle");
		}
		IntPtr arg = NSString.CreateNative(aTitle);
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemWithTitle_Handle, arg) : Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfItemWithTitle_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("indexOfItemWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOf(nint itemTag)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selIndexOfItemWithTag_Handle, itemTag);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selIndexOfItemWithTag_Handle, itemTag);
	}

	[Export("indexOfItemWithRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfItem(NSObject? obj)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfItemWithRepresentedObject_Handle, obj?.Handle ?? IntPtr.Zero);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemWithRepresentedObject_Handle, obj?.Handle ?? IntPtr.Zero);
	}

	[Export("indexOfItemWithSubmenu:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfItem(NSMenu? submenu)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfItemWithSubmenu_Handle, submenu?.Handle ?? IntPtr.Zero);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemWithSubmenu_Handle, submenu?.Handle ?? IntPtr.Zero);
	}

	[Export("indexOfItemWithTarget:andAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfItem(NSObject? target, Selector? actionSelector)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr_IntPtr(base.Handle, selIndexOfItemWithTarget_AndAction_Handle, target?.Handle ?? IntPtr.Zero, (actionSelector == null) ? IntPtr.Zero : actionSelector.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIndexOfItemWithTarget_AndAction_Handle, target?.Handle ?? IntPtr.Zero, (actionSelector == null) ? IntPtr.Zero : actionSelector.Handle);
	}

	[Export("insertItem:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertItem(NSMenuItem newItem, nint index)
	{
		if (newItem == null)
		{
			throw new ArgumentNullException("newItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertItem_AtIndex_Handle, newItem.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertItem_AtIndex_Handle, newItem.Handle, index);
		}
	}

	[Export("insertItemWithTitle:action:keyEquivalent:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem InsertItem(string title, Selector? action, string charCode, nint index)
	{
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (charCode == null)
		{
			throw new ArgumentNullException("charCode");
		}
		IntPtr arg = NSString.CreateNative(title);
		IntPtr arg2 = NSString.CreateNative(charCode);
		NSMenuItem result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nint(base.SuperHandle, selInsertItemWithTitle_Action_KeyEquivalent_AtIndex_Handle, arg, (action == null) ? IntPtr.Zero : action.Handle, arg2, index)) : Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nint(base.Handle, selInsertItemWithTitle_Action_KeyEquivalent_AtIndex_Handle, arg, (action == null) ? IntPtr.Zero : action.Handle, arg2, index)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMenuItem InsertItem(string title, string charCode, nint index)
	{
		return InsertItem(title, null, charCode, index);
	}

	[Export("isAccessibilitySelectorAllowed:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAccessibilitySelectorAllowed(Selector selector)
	{
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

	[Obsolete("Use 'Items' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem[] ItemArray()
	{
		return Items;
	}

	[Export("itemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem? ItemAt(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selItemAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selItemAtIndex_Handle, index));
	}

	[Export("itemChanged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemChanged(NSMenuItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selItemChanged_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemChanged_Handle, item.Handle);
		}
	}

	[Export("itemWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem? ItemWithTag(nint tag)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selItemWithTag_Handle, tag));
		}
		return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selItemWithTag_Handle, tag));
	}

	[Export("itemWithTitle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem? ItemWithTitle(string title)
	{
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSMenuItem result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemWithTitle_Handle, arg)) : Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selItemWithTitle_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("performActionForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformActionForItem(nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selPerformActionForItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selPerformActionForItemAtIndex_Handle, index);
		}
	}

	[Export("performKeyEquivalent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PerformKeyEquivalent(NSEvent theEvent)
	{
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

	[Export("popUpContextMenu:withEvent:forView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PopUpContextMenu(NSMenu menu, NSEvent theEvent, NSView view)
	{
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selPopUpContextMenu_WithEvent_ForView_Handle, menu.Handle, theEvent.Handle, view.Handle);
	}

	[Export("popUpContextMenu:withEvent:forView:withFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PopUpContextMenu(NSMenu menu, NSEvent theEvent, NSView view, NSFont? font)
	{
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selPopUpContextMenu_WithEvent_ForView_WithFont_Handle, menu.Handle, theEvent.Handle, view.Handle, font?.Handle ?? IntPtr.Zero);
	}

	[Export("popUpMenuPositioningItem:atLocation:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PopUpMenu(NSMenuItem? item, CGPoint location, NSView? view)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGPoint_IntPtr(base.Handle, selPopUpMenuPositioningItem_AtLocation_InView_Handle, item?.Handle ?? IntPtr.Zero, location, view?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGPoint_IntPtr(base.SuperHandle, selPopUpMenuPositioningItem_AtLocation_InView_Handle, item?.Handle ?? IntPtr.Zero, location, view?.Handle ?? IntPtr.Zero);
	}

	[Export("propertiesToUpdate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuProperty PropertiesToUpdate()
	{
		if (base.IsDirectBinding)
		{
			return (NSMenuProperty)Messaging.UInt64_objc_msgSend(base.Handle, selPropertiesToUpdateHandle);
		}
		return (NSMenuProperty)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPropertiesToUpdateHandle);
	}

	[Export("removeAllItems")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllItems()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllItemsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllItemsHandle);
		}
	}

	[Export("removeItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveItem(NSMenuItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveItem_Handle, item.Handle);
		}
	}

	[Export("removeItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveItemAt(nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveItemAtIndex_Handle, index);
		}
	}

	[Export("setSubmenu:forItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSubmenu(NSMenu? aMenu, NSMenuItem anItem)
	{
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetSubmenu_ForItem_Handle, aMenu?.Handle ?? IntPtr.Zero, anItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetSubmenu_ForItem_Handle, aMenu?.Handle ?? IntPtr.Zero, anItem.Handle);
		}
	}

	[Export("update")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateHandle);
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
			__mt_Supermenu_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
