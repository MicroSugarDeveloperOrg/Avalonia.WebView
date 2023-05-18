using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.WinForms;

public class WebView2 : Control, ISupportInitialize
{
    private static class NativeMethods
    {
        [Flags]
        public enum WS_EX : uint
        {
            None = 0u,
            TRANSPARENT = 0x20u
        }

        public enum WM : uint
        {
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
    }

    private const string _designText = "WebView2";

    private const int _designBorderWidth = 2;

    private CoreWebView2CreationProperties _creationProperties;

    internal Task _initTask;

    private bool _browserHitTransparent;

    private bool _isExplicitEnvironment;

    private bool _isExplicitControllerOptions;

    private CoreWebView2MoveFocusReason _lastMoveFocusReason;

    private Form _parentForm;

    private CoreWebView2Controller _coreWebView2Controller;

    private double _zoomFactor = 1.0;

    private bool _allowExternalDrop = true;

    private bool _inInit;

    private Uri _source;

    private Color _defaultBackgroundColor = Color.White;

    private bool _browserCrashed;

    private IContainer components;

    [Browsable(false)]
    public CoreWebView2CreationProperties CreationProperties
    {
        get
        {
            return _creationProperties;
        }
        set
        {
            if (_initTask != null)
                throw new InvalidOperationException("CreationProperties cannot be modified after the initialization of CoreWebView2 has begun.");

            _creationProperties = value;
        }
    }

    private CoreWebView2Environment Environment { get; set; }

    private CoreWebView2ControllerOptions ControllerOptions { get; set; }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams createParams = base.CreateParams;
            createParams.ExStyle |= 32;
            return createParams;
        }
    }

    private bool IsInitialized { get; set; }

    private bool IsInDesignMode => GetSitedParentSite(this)?.DesignMode ?? false;

    public CoreWebView2 CoreWebView2
    {
        get
        {
            try
            {
                return _coreWebView2Controller?.CoreWebView2;
            }
            catch (Exception innerException)
            {
                if (base.InvokeRequired)
                    throw new InvalidOperationException("CoreWebView2 can only be accessed from the UI thread.", innerException);

                throw;
            }
        }
    }

    public double ZoomFactor
    {
        get
        {
            if (_coreWebView2Controller != null)
                return _coreWebView2Controller.ZoomFactor;

            return _zoomFactor;
        }
        set
        {
            _zoomFactor = value;
            if (_coreWebView2Controller != null)
                _coreWebView2Controller.ZoomFactor = value;
        }
    }

    public bool AllowExternalDrop
    {
        get
        {
            if (_coreWebView2Controller != null)
                return _coreWebView2Controller.AllowExternalDrop;

            return _allowExternalDrop;
        }
        set
        {
            _allowExternalDrop = value;
            if (_coreWebView2Controller != null)
                _coreWebView2Controller.AllowExternalDrop = value;
        }
    }

    [Browsable(true)]
    public Uri Source
    {
        get
        {
            return _source;
        }
        set
        {
            if (value == null)
            {
                if (!(_source == null))
                    throw new NotImplementedException("Setting Source to null is not implemented yet.");

                return;
            }
            if (!value.IsAbsoluteUri)
                throw new ArgumentException("Only absolute URI is allowed", "Source");

            if (IsInitialized && _source != null && _source.AbsoluteUri == value.AbsoluteUri)
                return;

            _source = value;
            if (!_inInit)
            {
                if (!IsInitialized)
                    EnsureCoreWebView2Async();
                else
                    CoreWebView2.Navigate(value.AbsoluteUri);
            }
        }
    }

    [Browsable(false)]
    public bool CanGoForward => CoreWebView2?.CanGoForward ?? false;

    [Browsable(false)]
    public bool CanGoBack => CoreWebView2?.CanGoBack ?? false;

    public Color DefaultBackgroundColor
    {
        get
        {
            if (_coreWebView2Controller != null)
            {
                return _coreWebView2Controller.DefaultBackgroundColor;
            }
            return _defaultBackgroundColor;
        }
        set
        {
            if (_coreWebView2Controller != null)
            {
                _coreWebView2Controller.DefaultBackgroundColor = value;
            }
            else
            {
                _defaultBackgroundColor = value;
            }
        }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new Font Font => base.Font;

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new string Text => base.Text;

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new bool AllowDrop => base.AllowDrop;

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new ContextMenuStrip ContextMenuStrip => base.ContextMenuStrip;

    public event EventHandler<CoreWebView2InitializationCompletedEventArgs> CoreWebView2InitializationCompleted;

    public event EventHandler<CoreWebView2NavigationStartingEventArgs> NavigationStarting;

    public event EventHandler<CoreWebView2NavigationCompletedEventArgs> NavigationCompleted;

    public event EventHandler<CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived;

    public event EventHandler<CoreWebView2SourceChangedEventArgs> SourceChanged;

    public event EventHandler<CoreWebView2ContentLoadingEventArgs> ContentLoading;

    public event EventHandler<EventArgs> ZoomFactorChanged;

    [ToolboxItem(true)]
    public WebView2()
    {
        InitializeComponent();
        SetStyle(ControlStyles.UserPaint, value: true);
        SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && !base.IsDisposed)
        {
            if (IsInitialized)
            {
                UnsubscribeHandlersAndCloseController();
            }
            if (components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    private void UnsubscribeHandlersAndCloseController(bool browserCrashed = false)
    {
        IsInitialized = false;
        _browserCrashed = browserCrashed;
        base.HandleDestroyed -= WebView2_HandleDestroyed;
        base.HandleCreated -= WebView2_HandleCreated;
        if (_parentForm != null)
            _parentForm.LocationChanged -= WebView2_WindowPositionChanged;

        if (!_browserCrashed)
        {
            CoreWebView2.NavigationCompleted -= CoreWebView2_NavigationCompleted;
            CoreWebView2.NavigationStarting -= CoreWebView2_NavigationStarting;
            CoreWebView2.SourceChanged -= CoreWebView2_SourceChanged;
            CoreWebView2.WebMessageReceived -= CoreWebView2_WebMessageReceived;
            CoreWebView2.ContentLoading -= CoreWebView2_ContentLoading;
            CoreWebView2.ProcessFailed -= CoreWebView2_ProcessFailed;
            _coreWebView2Controller.ZoomFactorChanged -= _coreWebView2Controller_ZoomFactorChanged;
            _coreWebView2Controller.MoveFocusRequested -= CoreWebView2Controller_MoveFocusRequested;
            if (!_browserHitTransparent)
                _coreWebView2Controller.AcceleratorKeyPressed -= _coreWebView2Controller_AcceleratorKeyPressed;
            else
                _coreWebView2Controller.KeyPressed -= _coreWebView2Controller_KeyPressed;

            _coreWebView2Controller.Close();
        }
        _coreWebView2Controller = null;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (IsInDesignMode)
        {
            e.Graphics.FillRectangle(new SolidBrush(BackColor), base.ClientRectangle);
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(ForeColor), 2f), base.ClientRectangle);
            SizeF sizeF = e.Graphics.MeasureString("WebView2", Font);
            if (BackgroundImage != null)
                e.Graphics.DrawImage(BackgroundImage, new Rectangle(Point.Empty, base.ClientSize));

            e.Graphics.DrawString("WebView2", Font, new SolidBrush(ForeColor), (float)(base.ClientSize.Width / 2) - sizeF.Width / 2f, (float)(base.ClientSize.Height / 2) - sizeF.Height / 2f);
        }
    }

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == 15 && !IsInDesignMode)
        {
            NativeMethods.BeginPaint(m.HWnd, out var lpPaint);
            NativeMethods.EndPaint(m.HWnd, ref lpPaint);
            m.Result = IntPtr.Zero;
        }
        else
            base.WndProc(ref m);
    }

    public Task EnsureCoreWebView2Async(CoreWebView2Environment environment = null, CoreWebView2ControllerOptions controllerOptions = null)
    {
        if (IsInDesignMode)
        {
            return Task.FromResult(0);
        }
        VerifyNotClosedGuard();
        VerifyBrowserNotCrashedGuard();
        if (base.InvokeRequired)
            throw new InvalidOperationException("The method EnsureCoreWebView2Async can be invoked only from the UI thread.");

        if (_initTask == null || _initTask.IsFaulted)
            _initTask = InitCoreWebView2Async(environment, controllerOptions);

        else
        {
            if ((!_isExplicitEnvironment && environment != null) || (_isExplicitEnvironment && environment != null && Environment != environment))
                throw new ArgumentException("WebView2 was already initialized with a different CoreWebView2Environment. Check to see if the Source property was already set or EnsureCoreWebView2Async was previously called with different values.");

            if ((!_isExplicitControllerOptions && controllerOptions != null) || (_isExplicitControllerOptions && controllerOptions != null && ControllerOptions != controllerOptions))
                throw new ArgumentException("WebView2 was already initialized with a different CoreWebView2ControllerOptions. Check to see if the Source property was already set or EnsureCoreWebView2Async was previously called with different values.");
        }
        return _initTask;
    }

    public Task EnsureCoreWebView2Async(CoreWebView2Environment environment) => EnsureCoreWebView2Async(environment, null);

    private async Task InitCoreWebView2Async(CoreWebView2Environment environment = null, CoreWebView2ControllerOptions controllerOptions = null)
    {
        _ = 3;
        try
        {
            if (environment != null)
            {
                Environment = environment;
                _isExplicitEnvironment = true;
            }
            else if (CreationProperties != null)
            {
                Environment = await CreationProperties.CreateEnvironmentAsync();
            }
            if (Environment == null)
            {
                Environment = await CoreWebView2Environment.CreateAsync();
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
            if (_defaultBackgroundColor != Color.White)
                System.Environment.SetEnvironmentVariable("WEBVIEW2_DEFAULT_BACKGROUND_COLOR", Color.FromArgb(DefaultBackgroundColor.ToArgb()).Name);

            if (ControllerOptions != null)
                _coreWebView2Controller = await Environment.CreateCoreWebView2ControllerAsync(base.Handle, ControllerOptions);
            else
                _coreWebView2Controller = await Environment.CreateCoreWebView2ControllerAsync(base.Handle);

            try
            {
                _browserHitTransparent = _coreWebView2Controller.IsBrowserHitTransparent;
            }
            catch (NotImplementedException)
            {
            }
            _coreWebView2Controller.ZoomFactor = _zoomFactor;
            _coreWebView2Controller.DefaultBackgroundColor = _defaultBackgroundColor;
            _coreWebView2Controller.Bounds = new Rectangle(0, 0, base.Width, base.Height);
            _coreWebView2Controller.IsVisible = base.Visible;
            try
            {
                _coreWebView2Controller.AllowExternalDrop = _allowExternalDrop;
            }
            catch (NotImplementedException)
            {
            }
            _coreWebView2Controller.MoveFocusRequested += CoreWebView2Controller_MoveFocusRequested;
            if (!_browserHitTransparent)
                _coreWebView2Controller.AcceleratorKeyPressed += _coreWebView2Controller_AcceleratorKeyPressed;
            else
                _coreWebView2Controller.KeyPressed += _coreWebView2Controller_KeyPressed;

            _coreWebView2Controller.ZoomFactorChanged += _coreWebView2Controller_ZoomFactorChanged;
            CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
            CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
            CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;
            CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
            CoreWebView2.ContentLoading += CoreWebView2_ContentLoading;
            CoreWebView2.ProcessFailed += CoreWebView2_ProcessFailed;
            base.HandleDestroyed += WebView2_HandleDestroyed;
            base.HandleCreated += WebView2_HandleCreated;
            if (Focused)
                _coreWebView2Controller.MoveFocus(CoreWebView2MoveFocusReason.Programmatic);

            bool num = _source != null;
            if (_source == null)
                _source = new Uri(CoreWebView2.Source);

            IsInitialized = true;
            this.CoreWebView2InitializationCompleted?.Invoke(this, new CoreWebView2InitializationCompletedEventArgs());
            if (num)
                CoreWebView2.Navigate(_source.AbsoluteUri);
        }
        catch (Exception ex3)
        {
            this.CoreWebView2InitializationCompleted?.Invoke(this, new CoreWebView2InitializationCompletedEventArgs(ex3));
            throw;
        }
    }

    private void WebView2_HandleCreated(object sender, EventArgs e)
    {
        _coreWebView2Controller.ParentWindow = base.Handle;
        _coreWebView2Controller.IsVisible = base.Visible;
    }

    private void WebView2_HandleDestroyed(object sender, EventArgs e)
    {
        _coreWebView2Controller.IsVisible = false;
        _coreWebView2Controller.ParentWindow = IntPtr.Zero;
    }
  
    private void WebView2_WindowPositionChanged(object sender, EventArgs e) => _coreWebView2Controller?.NotifyParentWindowPositionChanged();

    private void _coreWebView2Controller_KeyPressed(object sender, CoreWebView2PrivateKeyPressedEventArgs e)
    {
        switch (e.KeyEventKind)
        {
            case CoreWebView2KeyEventKind.KeyDown:
            case CoreWebView2KeyEventKind.SystemKeyDown:
                {
                    KeyEventArgs keyEventArgs2 = new KeyEventArgs((Keys)e.VirtualKey);
                    OnKeyDown(keyEventArgs2);
                    e.Handled = keyEventArgs2.Handled;
                    break;
                }
            case CoreWebView2KeyEventKind.KeyUp:
            case CoreWebView2KeyEventKind.SystemKeyUp:
                {
                    KeyEventArgs keyEventArgs = new KeyEventArgs((Keys)e.VirtualKey);
                    OnKeyUp(keyEventArgs);
                    e.Handled = keyEventArgs.Handled;
                    break;
                }
        }
    }

    private void _coreWebView2Controller_AcceleratorKeyPressed(object sender, CoreWebView2AcceleratorKeyPressedEventArgs e)
    {
        switch (e.KeyEventKind)
        {
            case CoreWebView2KeyEventKind.KeyDown:
            case CoreWebView2KeyEventKind.SystemKeyDown:
                {
                    KeyEventArgs keyEventArgs2 = new KeyEventArgs((Keys)e.VirtualKey);
                    OnKeyDown(keyEventArgs2);
                    e.Handled = keyEventArgs2.Handled;
                    break;
                }
            case CoreWebView2KeyEventKind.KeyUp:
            case CoreWebView2KeyEventKind.SystemKeyUp:
                {
                    KeyEventArgs keyEventArgs = new KeyEventArgs((Keys)e.VirtualKey);
                    OnKeyUp(keyEventArgs);
                    e.Handled = keyEventArgs.Handled;
                    break;
                }
        }
    }

    private void CoreWebView2Controller_MoveFocusRequested(object sender, CoreWebView2MoveFocusRequestedEventArgs e)
    {
        bool forward = e.Reason == CoreWebView2MoveFocusReason.Next || e.Reason == CoreWebView2MoveFocusReason.Programmatic;
        e.Handled = (FindForm() ?? base.Parent)?.SelectNextControl(this, forward, tabStopOnly: true, nested: true, wrap: true) ?? true;
        if (_lastMoveFocusReason != 0)
        {
            _coreWebView2Controller.MoveFocus(_lastMoveFocusReason);
            _lastMoveFocusReason = CoreWebView2MoveFocusReason.Programmatic;
        }
    }

    protected override void OnVisibleChanged(EventArgs e)
    {
        base.OnVisibleChanged(e);
        if (IsInitialized && !_browserCrashed)
            _coreWebView2Controller.IsVisible = base.Visible;
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        if (IsInitialized && !_browserCrashed)
            _coreWebView2Controller.Bounds = new Rectangle(0, 0, base.Width, base.Height);
    }

    protected override void Select(bool directed, bool forward)
    {
        if (directed)
        {
            _lastMoveFocusReason = (forward ? CoreWebView2MoveFocusReason.Next : CoreWebView2MoveFocusReason.Previous);
        }
        base.Select(directed, forward);
    }

    protected override void OnGotFocus(EventArgs e)
    {
        base.OnGotFocus(e);
        if (IsInitialized && !_browserCrashed)
        {
            try
            {
                _coreWebView2Controller.MoveFocus(_lastMoveFocusReason);
            }
            catch (InvalidOperationException ex)
            {
                if (ex.InnerException!.HResult != -2147019873)
                {
                    throw ex;
                }
            }
        }
        _lastMoveFocusReason = CoreWebView2MoveFocusReason.Programmatic;
    }

    protected override void OnParentChanged(EventArgs e)
    {
        base.OnParentChanged(e);
        Form form = FindForm();
        if (form != null && form != _parentForm)
        {
            form.LocationChanged += WebView2_WindowPositionChanged;
            if (_parentForm != null)
                _parentForm.LocationChanged -= WebView2_WindowPositionChanged;

            _parentForm = form;
        }
    }

    private ISite GetSitedParentSite(Control control)
    {
        if (control != null)
        {
            if (control.Site == null && control.Parent != null)
                return GetSitedParentSite(control.Parent);

            return control.Site;
        }
        throw new ArgumentNullException("control");
    }

    void ISupportInitialize.BeginInit() => _inInit = true;

    void ISupportInitialize.EndInit()
    {
        _inInit = false;
        if (!(_source == null))
        {
            if (!IsInitialized)
                EnsureCoreWebView2Async();
            else
                CoreWebView2.Navigate(_source.AbsoluteUri);
        }
    }

    private bool ShouldSerializeSource() => (_source?.AbsoluteUri?.Length).GetValueOrDefault() > 0;

    private void ResetSource() => _source = null;

    public async Task<string> ExecuteScriptAsync(string script)
    {
        VerifyInitializedGuard();
        VerifyBrowserNotCrashedGuard();
        return await CoreWebView2.ExecuteScriptAsync(script);
    }

    public void Reload()
    {
        VerifyInitializedGuard();
        VerifyBrowserNotCrashedGuard();
        CoreWebView2.Reload();
    }

    public void GoForward() => CoreWebView2?.GoForward();

    public void GoBack() => CoreWebView2?.GoBack();

    public void NavigateToString(string htmlContent)
    {
        VerifyInitializedGuard();
        VerifyBrowserNotCrashedGuard();
        CoreWebView2.NavigateToString(htmlContent);
    }

    public void Stop() => CoreWebView2?.Stop();

    private void VerifyInitializedGuard()
    {
        if (!IsInitialized)
            throw new InvalidOperationException("The instance of CoreWebView2 is uninitialized and unable to complete this operation. See EnsureCoreWebView2Async.");
    }

    private void VerifyNotClosedGuard()
    {
        if (base.IsDisposed)
            throw new InvalidOperationException("The instance of CoreWebView2 is disposed and unable to complete this operation.");
    }

    private void VerifyBrowserNotCrashedGuard()
    {
        if (_browserCrashed)
            throw new InvalidOperationException("The instance of CoreWebView2 is no longer valid because the browser process crashed.To work around this, please listen for the ProcessFailed event to explicitly manage the lifetime of the WebView2 control in the event of a browser failure.https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.processfailed");
    }

    private void CoreWebView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e) => NavigationStarting?.Invoke(this, e);

    private void CoreWebView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e) => NavigationCompleted?.Invoke(this, e);

    private void CoreWebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e) => WebMessageReceived?.Invoke(this, e);

    private void CoreWebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
    {
        _source = new Uri(CoreWebView2.Source);
        SourceChanged?.Invoke(this, e);
    }

    private void CoreWebView2_ContentLoading(object sender, CoreWebView2ContentLoadingEventArgs e) => ContentLoading?.Invoke(this, e);

    private void CoreWebView2_ProcessFailed(object sender, CoreWebView2ProcessFailedEventArgs e)
    {
        if (e.ProcessFailedKind == CoreWebView2ProcessFailedKind.BrowserProcessExited)
            UnsubscribeHandlersAndCloseController(browserCrashed: true);
    }

    private void _coreWebView2Controller_ZoomFactorChanged(object sender, object e)
    {
        _zoomFactor = _coreWebView2Controller.ZoomFactor;
        this.ZoomFactorChanged?.Invoke(this, EventArgs.Empty);
    }

        
    private void InitializeComponent() => components = new Container();
}
