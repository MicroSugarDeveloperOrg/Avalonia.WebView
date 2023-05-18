#define TRACE
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Effects;
using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.Wpf;

[ToolboxItem(true)]
public class WebView2 : HwndHost
{
	private class WebView2KeyEventArgs : KeyEventArgs
	{
		public WebView2KeyEventArgs(KeyboardDevice keyboard, PresentationSource inputSource, int timestamp, Key key)
			: base(keyboard, inputSource, timestamp, key)
		{
		}
	}

	private static class NativeMethods
	{
		[Flags]
		public enum WS : uint
		{
			None = 0u,
			CLIPCHILDREN = 0x2000000u,
			VISIBLE = 0x10000000u,
			CHILD = 0x40000000u
		}

		[Flags]
		public enum WS_EX : uint
		{
			None = 0u,
			TRANSPARENT = 0x20u
		}

		public enum WM : uint
		{
			SETFOCUS = 7u,
			PAINT = 15u
		}

		public struct Rect
		{
			public int left;

			public int top;

			public int right;

			public int bottom;
		}

		public struct PaintStruct
		{
			public IntPtr hdc;

			public bool fErase;

			public Rect rcPaint;

			public bool fRestore;

			public bool fIncUpdate;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] rgbReserved;
		}

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr BeginPaint(IntPtr hwnd, out PaintStruct lpPaint);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool EndPaint(IntPtr hwnd, ref PaintStruct lpPaint);

		[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr CreateWindowExW(WS_EX dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, WS dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DestroyWindow(IntPtr hwnd);
	}

	public static readonly DependencyProperty CreationPropertiesProperty = DependencyProperty.Register("CreationProperties", typeof(CoreWebView2CreationProperties), typeof(WebView2), new PropertyMetadata(null, null, CoerceCreationPropertiesProperty));

	private TaskCompletionSource<IntPtr> _hwndTaskSource = new TaskCompletionSource<IntPtr>();

	private Task _initTask;

	private bool _browserHitTransparent;

	private bool _isExplicitEnvironment;

	private bool _isExplicitControllerOptions;

	private bool _disposed;

	private bool _browserCrashed;

	private ImplicitInitGate _implicitInitGate = new ImplicitInitGate();

	private DependencyProperty _propertyChangingFromCore;

	public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(Uri), typeof(WebView2), new PropertyMetadata(null, SourcePropertyChanged, null), SourcePropertyValid);

	private static readonly DependencyPropertyKey CanGoBackPropertyKey = DependencyProperty.RegisterReadOnly("CanGoBack", typeof(bool), typeof(WebView2), new PropertyMetadata(false));

	public static readonly DependencyProperty CanGoBackProperty = CanGoBackPropertyKey.DependencyProperty;

	private static readonly DependencyPropertyKey CanGoForwardPropertyKey = DependencyProperty.RegisterReadOnly("CanGoForward", typeof(bool), typeof(WebView2), new PropertyMetadata(false));

	public static readonly DependencyProperty CanGoForwardProperty = CanGoForwardPropertyKey.DependencyProperty;

	public static readonly DependencyProperty ZoomFactorProperty = DependencyProperty.Register("ZoomFactor", typeof(double), typeof(WebView2), new PropertyMetadata(1.0, ZoomFactorPropertyChanged, null));

	public static readonly DependencyProperty DefaultBackgroundColorProperty = DependencyProperty.Register("DefaultBackgroundColor", typeof(System.Drawing.Color), typeof(WebView2), new PropertyMetadata(System.Drawing.Color.White, DefaultBackgroundColorPropertyChanged, null));

	public static readonly DependencyProperty AllowExternalDropProperty = DependencyProperty.Register("AllowExternalDrop", typeof(bool), typeof(WebView2), new PropertyMetadata(true, AllowExternalDropPropertyChanged));

	public static readonly DependencyProperty DesignModeForegroundColorProperty = DependencyProperty.Register("DesignModeForegroundColor", typeof(System.Drawing.Color), typeof(WebView2), new PropertyMetadata(System.Drawing.Color.Black));

	[Category("Common")]
	public CoreWebView2CreationProperties CreationProperties
	{
		get
		{
			return (CoreWebView2CreationProperties)GetValue(CreationPropertiesProperty);
		}
		set
		{
			SetValue(CreationPropertiesProperty, value);
		}
	}

	private CoreWebView2Environment Environment { get; set; }

	private CoreWebView2Controller CoreWebView2Controller { get; set; }

	private CoreWebView2ControllerOptions ControllerOptions { get; set; }

	[Browsable(false)]
	public CoreWebView2 CoreWebView2
	{
		get
		{
			VerifyAccess();
			VerifyNotDisposed();
			VerifyBrowserNotCrashed();
			return CoreWebView2Controller?.CoreWebView2;
		}
	}

	[Category("Common")]
	public Uri Source
	{
		get
		{
			return (Uri)GetValue(SourceProperty);
		}
		set
		{
			SetValue(SourceProperty, value);
		}
	}

	[Browsable(false)]
	public bool CanGoBack => (bool)GetValue(CanGoBackProperty);

	[Browsable(false)]
	public bool CanGoForward => (bool)GetValue(CanGoForwardProperty);

	[Category("Common")]
	public double ZoomFactor
	{
		get
		{
			return (double)GetValue(ZoomFactorProperty);
		}
		set
		{
			SetValue(ZoomFactorProperty, value);
		}
	}

	[Category("Common")]
	public System.Drawing.Color DefaultBackgroundColor
	{
		get
		{
			return (System.Drawing.Color)GetValue(DefaultBackgroundColorProperty);
		}
		set
		{
			SetValue(DefaultBackgroundColorProperty, value);
		}
	}

	[Category("Common")]
	public bool AllowExternalDrop
	{
		get
		{
			return (bool)GetValue(AllowExternalDropProperty);
		}
		set
		{
			SetValue(AllowExternalDropProperty, value);
		}
	}

	[Category("Common")]
	public System.Drawing.Color DesignModeForegroundColor
	{
		get
		{
			return (System.Drawing.Color)GetValue(DesignModeForegroundColorProperty);
		}
		set
		{
			SetValue(DesignModeForegroundColorProperty, value);
		}
	}

	protected bool IsInDesignMode => DesignerProperties.GetIsInDesignMode(this);

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public new System.Windows.Media.Brush OpacityMask => base.OpacityMask;

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public new double Opacity => base.Opacity;

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public new Effect Effect => base.Effect;

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public new ContextMenu ContextMenu => base.ContextMenu;

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public new Style FocusVisualStyle => base.FocusVisualStyle;

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public new InputScope InputScope => base.InputScope;

	public event EventHandler<CoreWebView2InitializationCompletedEventArgs> CoreWebView2InitializationCompleted;

	public event EventHandler<CoreWebView2SourceChangedEventArgs> SourceChanged;

	public event EventHandler<CoreWebView2NavigationStartingEventArgs> NavigationStarting;

	public event EventHandler<CoreWebView2NavigationCompletedEventArgs> NavigationCompleted;

	public event EventHandler<EventArgs> ZoomFactorChanged;

	public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading;

	public event EventHandler<CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived;

	public WebView2()
	{
		base.Loaded += _implicitInitGate.OnSynchronizationContextExists;
	}

	private static object CoerceCreationPropertiesProperty(DependencyObject d, object value)
	{
		if (((WebView2)d).Environment != null)
		{
			return DependencyProperty.UnsetValue;
		}
		return value;
	}

	protected override HandleRef BuildWindowCore(HandleRef hwndParent)
	{
		IntPtr intPtr = NativeMethods.CreateWindowExW(NativeMethods.WS_EX.TRANSPARENT, "static", string.Empty, NativeMethods.WS.CLIPCHILDREN | NativeMethods.WS.VISIBLE | NativeMethods.WS.CHILD, 0, 0, 0, 0, hwndParent.Handle, IntPtr.Zero, Marshal.GetHINSTANCE(typeof(NativeMethods).Module), IntPtr.Zero);
		if (CoreWebView2Controller != null)
		{
			ReparentController(intPtr);
		}
		if (!_hwndTaskSource.Task.IsCompleted)
		{
			_hwndTaskSource.SetResult(intPtr);
		}
		return new HandleRef(null, intPtr);
	}

	protected override void DestroyWindowCore(HandleRef hwnd)
	{
		if (CoreWebView2Controller != null)
		{
			ReparentController(IntPtr.Zero);
		}
		NativeMethods.DestroyWindow(hwnd.Handle);
	}

	protected override IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
	{
		switch (msg)
		{
		case 7:
			CoreWebView2Controller?.MoveFocus(CoreWebView2MoveFocusReason.Programmatic);
			break;
		case 15:
			if (!IsInDesignMode)
			{
				NativeMethods.BeginPaint(hwnd, out var lpPaint);
				NativeMethods.EndPaint(hwnd, ref lpPaint);
				handled = true;
				return IntPtr.Zero;
			}
			break;
		}
		return base.WndProc(hwnd, msg, wParam, lParam, ref handled);
	}

	protected override void OnRender(DrawingContext dc)
	{
		if (!IsInDesignMode)
		{
			base.OnRender(dc);
			return;
		}
		SolidColorBrush brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(DefaultBackgroundColor.A, DefaultBackgroundColor.R, DefaultBackgroundColor.G, DefaultBackgroundColor.B));
		SolidColorBrush solidColorBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(DesignModeForegroundColor.A, DesignModeForegroundColor.R, DesignModeForegroundColor.G, DesignModeForegroundColor.B));
		System.Windows.Media.Pen pen = new System.Windows.Media.Pen(solidColorBrush, 2.0);
		dc.DrawRectangle(brush, pen, new Rect(base.RenderSize));
		Typeface typeface = new Typeface("default");
		if (typeface == null && Fonts.SystemTypefaces.Count > 0)
		{
			typeface = Fonts.SystemTypefaces.GetEnumerator().Current;
		}
		System.Windows.Point point = new System.Windows.Point(base.RenderSize.Width / 2.0, base.RenderSize.Height / 2.0);
		FormattedText formattedText = new FormattedText("WebView2", CultureInfo.CurrentCulture, FlowDirection.LeftToRight, typeface, 20.0, solidColorBrush, VisualTreeHelper.GetDpi(this).PixelsPerDip);
		point = new System.Windows.Point(point.X - formattedText.WidthIncludingTrailingWhitespace / 2.0, point.Y - formattedText.Height / 2.0);
		dc.DrawText(formattedText, point);
	}

	private void VerifyCoreWebView2()
	{
		if (CoreWebView2 == null)
		{
			throw new InvalidOperationException("Attempted to use WebView2 functionality which requires its CoreWebView2 prior to the CoreWebView2 being initialized.  Call EnsureCoreWebView2Async or set the Source property first.");
		}
	}

	private void RegisterProfileDeletedEvent(bool register, CoreWebView2 coreWebView2)
	{
		if (register)
		{
			coreWebView2.Profile.Deleted += Profile_Deleted;
		}
		else
		{
			coreWebView2.Profile.Deleted -= Profile_Deleted;
		}
	}

	public Task EnsureCoreWebView2Async(CoreWebView2Environment environment = null, CoreWebView2ControllerOptions controllerOptions = null)
	{
		if (IsInDesignMode)
		{
			return Task.FromResult(0);
		}
		VerifyAccess();
		VerifyNotDisposed();
		VerifyBrowserNotCrashed();
		if (SynchronizationContext.Current == null)
		{
			throw new InvalidOperationException("EnsureCoreWebView2Async cannot be used before the application's event loop has started running.");
		}
		if (_initTask == null || _initTask.IsFaulted)
		{
			_initTask = Init();
		}
		else
		{
			if ((!_isExplicitEnvironment && environment != null) || (_isExplicitEnvironment && environment != null && Environment != environment))
			{
				throw new ArgumentException("WebView2 was already initialized with a different CoreWebView2Environment. Check to see if the Source property was already set or EnsureCoreWebView2Async was previously called with different values.");
			}
			if ((!_isExplicitControllerOptions && controllerOptions != null) || (_isExplicitControllerOptions && controllerOptions != null && ControllerOptions != controllerOptions))
			{
				throw new ArgumentException("WebView2 was already initialized with a different CoreWebView2ControllerOptions. Check to see if the Source property was already set or EnsureCoreWebView2Async was previously called with different values.");
			}
		}
		return _initTask;
		async Task Init()
		{
			_ = 5;
			try
			{
				if (environment != null)
				{
					Environment = environment;
					_isExplicitEnvironment = true;
				}
				else if (CreationProperties != null)
				{
					CoreWebView2Environment environment2 = await CreationProperties.CreateEnvironmentAsync();
					Environment = environment2;
				}
				if (Environment == null)
				{
					CoreWebView2Environment environment2 = await CoreWebView2Environment.CreateAsync();
					Environment = environment2;
				}
				if (controllerOptions != null)
				{
					ControllerOptions = controllerOptions;
					_isExplicitControllerOptions = true;
				}
				else if (CreationProperties != null)
				{
					ControllerOptions = CreationProperties.CreateCoreWebView2ControllerOptions(Environment);
				}
				if (DefaultBackgroundColor != (System.Drawing.Color)DefaultBackgroundColorProperty.GetMetadata(this).DefaultValue)
				{
					System.Environment.SetEnvironmentVariable("WEBVIEW2_DEFAULT_BACKGROUND_COLOR", System.Drawing.Color.FromArgb(DefaultBackgroundColor.ToArgb()).Name);
				}
				if (ControllerOptions != null)
				{
					CoreWebView2Environment environment3 = Environment;
					CoreWebView2Controller coreWebView2Controller = await environment3.CreateCoreWebView2ControllerAsync(await _hwndTaskSource.Task, ControllerOptions);
					CoreWebView2Controller = coreWebView2Controller;
				}
				else
				{
					CoreWebView2Environment environment3 = Environment;
					CoreWebView2Controller coreWebView2Controller = await environment3.CreateCoreWebView2ControllerAsync(await _hwndTaskSource.Task);
					CoreWebView2Controller = coreWebView2Controller;
				}
				try
				{
					_browserHitTransparent = CoreWebView2Controller.IsBrowserHitTransparent;
				}
				catch (NotImplementedException)
				{
				}
				if (!_browserHitTransparent)
				{
					CoreWebView2Controller.AcceleratorKeyPressed += CoreWebView2Controller_AcceleratorKeyPressed;
				}
				CoreWebView2Controller.GotFocus += CoreWebView2Controller_GotFocus;
				CoreWebView2Controller.LostFocus += CoreWebView2Controller_LostFocus;
				CoreWebView2Controller.MoveFocusRequested += CoreWebView2Controller_MoveFocusRequested;
				CoreWebView2Controller.ZoomFactorChanged += CoreWebView2Controller_ZoomFactorChanged;
				CoreWebView2.ContentLoading += CoreWebView2_ContentLoading;
				CoreWebView2.HistoryChanged += CoreWebView2_HistoryChanged;
				CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
				CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
				CoreWebView2.ProcessFailed += CoreWebView2_ProcessFailed;
				CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;
				CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
				try
				{
					RegisterProfileDeletedEvent(register: true, CoreWebView2);
				}
				catch (Exception)
				{
				}
				base.IsVisibleChanged += UIElement_IsVisibleChanged;
				if (CoreWebView2Controller.ParentWindow != base.Handle)
				{
					ReparentController(base.Handle, sync: false);
				}
				if (CoreWebView2Controller.ParentWindow != IntPtr.Zero)
				{
					SyncControllerWithParentWindow();
				}
				bool flag = Source != null;
				if (Source == null)
				{
					SetCurrentValueFromCore(SourceProperty, new Uri(CoreWebView2.Source));
				}
				if (ZoomFactor != (double)ZoomFactorProperty.GetMetadata(this).DefaultValue)
				{
					CoreWebView2Controller.ZoomFactor = ZoomFactor;
				}
				if (DefaultBackgroundColor != (System.Drawing.Color)DefaultBackgroundColorProperty.GetMetadata(this).DefaultValue)
				{
					CoreWebView2Controller.DefaultBackgroundColor = DefaultBackgroundColor;
				}
				if (AllowExternalDrop != (bool)AllowExternalDropProperty.GetMetadata(this).DefaultValue)
				{
					try
					{
						CoreWebView2Controller.AllowExternalDrop = AllowExternalDrop;
					}
					catch (NotImplementedException)
					{
					}
				}
				this.CoreWebView2InitializationCompleted?.Invoke(this, new CoreWebView2InitializationCompletedEventArgs());
				if (flag)
				{
					CoreWebView2.Navigate(Source.AbsoluteUri);
				}
			}
			catch (Exception ex4)
			{
				this.CoreWebView2InitializationCompleted?.Invoke(this, new CoreWebView2InitializationCompletedEventArgs(ex4));
				throw;
			}
		}
	}

	private void Profile_Deleted(object sender, object e)
	{
		Uninitialize();
	}

	public Task EnsureCoreWebView2Async(CoreWebView2Environment environment)
	{
		return EnsureCoreWebView2Async(environment, null);
	}

	protected override void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			Uninitialize();
			base.Dispose(disposing);
			_disposed = true;
		}
	}

	private void VerifyNotDisposed()
	{
		if (_disposed)
		{
			throw new ObjectDisposedException(base.Name);
		}
	}

	private void Uninitialize(bool browserCrashed = false)
	{
		_browserCrashed = browserCrashed;
		if (CoreWebView2Controller != null)
		{
			CoreWebView2Controller coreWebView2Controller = CoreWebView2Controller;
			CoreWebView2Controller = null;
			base.IsVisibleChanged -= UIElement_IsVisibleChanged;
			if (!_browserCrashed)
			{
				coreWebView2Controller.CoreWebView2.ContentLoading -= CoreWebView2_ContentLoading;
				coreWebView2Controller.CoreWebView2.HistoryChanged -= CoreWebView2_HistoryChanged;
				coreWebView2Controller.CoreWebView2.NavigationCompleted -= CoreWebView2_NavigationCompleted;
				coreWebView2Controller.CoreWebView2.NavigationStarting -= CoreWebView2_NavigationStarting;
				coreWebView2Controller.CoreWebView2.ProcessFailed -= CoreWebView2_ProcessFailed;
				coreWebView2Controller.CoreWebView2.SourceChanged -= CoreWebView2_SourceChanged;
				coreWebView2Controller.CoreWebView2.WebMessageReceived -= CoreWebView2_WebMessageReceived;
				try
				{
					RegisterProfileDeletedEvent(register: false, coreWebView2Controller.CoreWebView2);
				}
				catch (Exception)
				{
				}
				if (!_browserHitTransparent)
				{
					coreWebView2Controller.AcceleratorKeyPressed -= CoreWebView2Controller_AcceleratorKeyPressed;
				}
				coreWebView2Controller.GotFocus -= CoreWebView2Controller_GotFocus;
				coreWebView2Controller.LostFocus -= CoreWebView2Controller_LostFocus;
				coreWebView2Controller.MoveFocusRequested -= CoreWebView2Controller_MoveFocusRequested;
				coreWebView2Controller.ZoomFactorChanged -= CoreWebView2Controller_ZoomFactorChanged;
				coreWebView2Controller.Close();
			}
			coreWebView2Controller = null;
		}
		Environment = null;
	}

	private void CoreWebView2_ProcessFailed(object sender, CoreWebView2ProcessFailedEventArgs e)
	{
		if (e.ProcessFailedKind == CoreWebView2ProcessFailedKind.BrowserProcessExited)
		{
			Uninitialize(browserCrashed: true);
		}
	}

	private void VerifyBrowserNotCrashed()
	{
		if (_browserCrashed)
		{
			throw new InvalidOperationException("The WebView control is no longer valid because the browser process crashed.To work around this, please listen for the CoreWebView2.ProcessFailed event to explicitly manage the lifetime of the WebView2 control in the event of a browser failure.https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.processfailed");
		}
	}

	public override void BeginInit()
	{
		base.BeginInit();
		_implicitInitGate.BeginInit();
	}

	public override void EndInit()
	{
		_implicitInitGate.EndInit();
		base.EndInit();
	}

	private void SetCurrentValueFromCore(DependencyProperty property, object value)
	{
		Trace.Assert(_propertyChangingFromCore == null);
		_propertyChangingFromCore = property;
		SetCurrentValue(property, value);
		_propertyChangingFromCore = null;
	}

	private bool IsPropertyChangingFromCore(DependencyProperty property)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		return property == _propertyChangingFromCore;
	}

	private void ReparentController(IntPtr hwnd, bool sync = true)
	{
		if (hwnd == IntPtr.Zero)
		{
			CoreWebView2Controller.IsVisible = false;
			CoreWebView2Controller.ParentWindow = IntPtr.Zero;
			return;
		}
		CoreWebView2Controller.ParentWindow = hwnd;
		if (sync)
		{
			SyncControllerWithParentWindow();
		}
	}

	private void SyncControllerWithParentWindow()
	{
		UpdateWindowPos();
		if (Keyboard.FocusedElement == this)
		{
			CoreWebView2Controller.MoveFocus(CoreWebView2MoveFocusReason.Programmatic);
		}
		CoreWebView2Controller.IsVisible = base.Visibility == Visibility.Visible;
	}

	private void UIElement_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (CoreWebView2Controller == null)
		{
			return;
		}
		try
		{
			CoreWebView2Controller.IsVisible = (bool)e.NewValue;
		}
		catch (InvalidOperationException ex)
		{
			if (ex.InnerException.HResult != -2147019873)
			{
				throw ex;
			}
		}
	}

	protected override void OnWindowPositionChanged(Rect rcBoundingBox)
	{
		base.OnWindowPositionChanged(rcBoundingBox);
		if (CoreWebView2Controller != null)
		{
			CoreWebView2Controller.Bounds = new Rectangle(0, 0, Convert.ToInt32(rcBoundingBox.Size.Width), Convert.ToInt32(rcBoundingBox.Size.Height));
		}
		CoreWebView2Controller?.NotifyParentWindowPositionChanged();
	}

	private static bool SourcePropertyValid(object val)
	{
		Uri uri = (Uri)val;
		if (!(uri == null))
		{
			return uri.IsAbsoluteUri;
		}
		return true;
	}

	private static void SourcePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		WebView2 control = (WebView2)d;
		if (!control.IsPropertyChangingFromCore(SourceProperty))
		{
			Uri uri = (Uri)e.OldValue;
			Uri uri2 = (Uri)e.NewValue;
			if (uri2 == null)
			{
				throw new NotImplementedException("The Source property cannot be set to null.");
			}
			if (control.CoreWebView2 != null && (uri == null || uri.AbsoluteUri != uri2.AbsoluteUri))
			{
				control.CoreWebView2.Navigate(uri2.AbsoluteUri);
			}
			control._implicitInitGate.RunWhenOpen(delegate
			{
				control.EnsureCoreWebView2Async();
			});
		}
	}

	private void CoreWebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
	{
		SetCurrentValueFromCore(SourceProperty, new Uri(CoreWebView2.Source));
		this.SourceChanged?.Invoke(this, e);
	}

	private void CoreWebView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
	{
		this.NavigationStarting?.Invoke(this, e);
	}

	private void CoreWebView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		this.NavigationCompleted?.Invoke(this, e);
	}

	private void CoreWebView2_HistoryChanged(object sender, object e)
	{
		SetValue(CanGoBackPropertyKey, CoreWebView2.CanGoBack);
		SetValue(CanGoForwardPropertyKey, CoreWebView2.CanGoForward);
	}

	protected override bool TabIntoCore(TraversalRequest request)
	{
		if (CoreWebView2 == null)
		{
			return base.TabIntoCore(request);
		}
		switch (request.FocusNavigationDirection)
		{
		case FocusNavigationDirection.Next:
		case FocusNavigationDirection.First:
			CoreWebView2Controller.MoveFocus(CoreWebView2MoveFocusReason.Next);
			return true;
		case FocusNavigationDirection.Previous:
		case FocusNavigationDirection.Last:
			CoreWebView2Controller.MoveFocus(CoreWebView2MoveFocusReason.Previous);
			return true;
		default:
			return base.TabIntoCore(request);
		}
	}

	protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
	{
		base.OnGotKeyboardFocus(e);
		CoreWebView2Controller?.MoveFocus(CoreWebView2MoveFocusReason.Programmatic);
	}

	private void CoreWebView2Controller_MoveFocusRequested(object sender, CoreWebView2MoveFocusRequestedEventArgs e)
	{
		switch (e.Reason)
		{
		case CoreWebView2MoveFocusReason.Programmatic:
		case CoreWebView2MoveFocusReason.Next:
			MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
			break;
		case CoreWebView2MoveFocusReason.Previous:
			MoveFocus(new TraversalRequest(FocusNavigationDirection.Previous));
			break;
		}
		e.Handled = true;
	}

	private void CoreWebView2Controller_GotFocus(object sender, object e)
	{
		RaiseEvent(new RoutedEventArgs(UIElement.GotFocusEvent));
	}

	private void CoreWebView2Controller_LostFocus(object sender, object e)
	{
		RaiseEvent(new RoutedEventArgs(UIElement.LostFocusEvent));
	}

	private void CoreWebView2Controller_AcceleratorKeyPressed(object sender, CoreWebView2AcceleratorKeyPressedEventArgs e)
	{
		WebView2KeyEventArgs webView2KeyEventArgs = new WebView2KeyEventArgs(Keyboard.PrimaryDevice, PresentationSource.FromDependencyObject(this), System.Environment.TickCount, KeyInterop.KeyFromVirtualKey((int)e.VirtualKey))
		{
			RoutedEvent = ((e.KeyEventKind == CoreWebView2KeyEventKind.KeyDown || e.KeyEventKind == CoreWebView2KeyEventKind.SystemKeyDown) ? UIElement.PreviewKeyDownEvent : UIElement.PreviewKeyUpEvent)
		};
		RaiseEvent(webView2KeyEventArgs);
		e.Handled = webView2KeyEventArgs.Handled;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		base.OnKeyUp(e);
	}

	protected override void OnPreviewKeyDown(KeyEventArgs e)
	{
		base.OnPreviewKeyDown(e);
		if (!_browserHitTransparent && e is WebView2KeyEventArgs)
		{
			e.RoutedEvent = UIElement.KeyDownEvent;
			RaiseEvent(e);
		}
	}

	protected override void OnPreviewKeyUp(KeyEventArgs e)
	{
		base.OnPreviewKeyUp(e);
		if (!_browserHitTransparent && e is WebView2KeyEventArgs)
		{
			e.RoutedEvent = UIElement.KeyUpEvent;
			RaiseEvent(e);
		}
	}

	private static void ZoomFactorPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		WebView2 webView = (WebView2)d;
		if (webView.CoreWebView2 != null && !webView.IsPropertyChangingFromCore(ZoomFactorProperty))
		{
			webView.CoreWebView2Controller.ZoomFactor = (double)e.NewValue;
		}
	}

	private void CoreWebView2Controller_ZoomFactorChanged(object sender, object e)
	{
		SetCurrentValueFromCore(ZoomFactorProperty, CoreWebView2Controller.ZoomFactor);
		this.ZoomFactorChanged?.Invoke(this, EventArgs.Empty);
	}

	private static void DefaultBackgroundColorPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		WebView2 webView = (WebView2)d;
		if (webView.CoreWebView2Controller != null)
		{
			webView.CoreWebView2Controller.DefaultBackgroundColor = (System.Drawing.Color)e.NewValue;
		}
	}

	private static void AllowExternalDropPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		WebView2 webView = (WebView2)d;
		if (webView.CoreWebView2Controller != null)
		{
			try
			{
				webView.CoreWebView2Controller.AllowExternalDrop = (bool)e.NewValue;
			}
			catch (NotImplementedException)
			{
			}
		}
	}

	public void GoBack()
	{
		if (CoreWebView2 != null)
		{
			CoreWebView2.GoBack();
		}
	}

	public void GoForward()
	{
		if (CoreWebView2 != null)
		{
			CoreWebView2.GoForward();
		}
	}

	public void Reload()
	{
		VerifyCoreWebView2();
		CoreWebView2.Reload();
	}

	public void Stop()
	{
		VerifyCoreWebView2();
		CoreWebView2.Stop();
	}

	public void NavigateToString(string htmlContent)
	{
		VerifyCoreWebView2();
		CoreWebView2.NavigateToString(htmlContent);
	}

	private void CoreWebView2_ContentLoading(object sender, CoreWebView2ContentLoadingEventArgs e)
	{
		this.ContentLoading?.Invoke(this, e);
	}

	public async Task<string> ExecuteScriptAsync(string javaScript)
	{
		VerifyCoreWebView2();
		return await CoreWebView2.ExecuteScriptAsync(javaScript);
	}

	private void CoreWebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
	{
		this.WebMessageReceived?.Invoke(this, e);
	}
}
