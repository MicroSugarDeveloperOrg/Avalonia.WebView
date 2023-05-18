using System.Threading.Tasks;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.Wpf;

public class CoreWebView2CreationProperties : DependencyObject
{
	public static readonly DependencyProperty BrowserExecutableFolderProperty = DependencyProperty.Register("BrowserExecutableFolder", typeof(string), typeof(CoreWebView2CreationProperties), new PropertyMetadata(null, EnvironmentPropertyChanged));

	public static readonly DependencyProperty UserDataFolderProperty = DependencyProperty.Register("UserDataFolder", typeof(string), typeof(CoreWebView2CreationProperties), new PropertyMetadata(null, EnvironmentPropertyChanged));

	public static readonly DependencyProperty LanguageProperty = DependencyProperty.Register("Language", typeof(string), typeof(CoreWebView2CreationProperties), new PropertyMetadata(null, EnvironmentPropertyChanged));

	public static readonly DependencyProperty AdditionalBrowserArgumentsProperty = DependencyProperty.Register("AdditionalBrowserArguments", typeof(string), typeof(CoreWebView2CreationProperties), new PropertyMetadata(null, EnvironmentPropertyChanged));

	public static readonly DependencyProperty ProfileNameProperty = DependencyProperty.Register("ProfileName", typeof(string), typeof(CoreWebView2CreationProperties), new PropertyMetadata(null, null));

	public static readonly DependencyProperty IsInPrivateModeEnabledProperty = DependencyProperty.Register("IsInPrivateModeEnabled", typeof(bool?), typeof(CoreWebView2CreationProperties), new PropertyMetadata(null, null));

	public static readonly DependencyProperty ScriptLocaleProperty = DependencyProperty.Register("ScriptLocale", typeof(string), typeof(CoreWebView2CreationProperties), new PropertyMetadata(null, null));

	private Task<CoreWebView2Environment> _task;

	public string BrowserExecutableFolder
	{
		get
		{
			return (string)GetValue(BrowserExecutableFolderProperty);
		}
		set
		{
			SetValue(BrowserExecutableFolderProperty, value);
		}
	}

	public string UserDataFolder
	{
		get
		{
			return (string)GetValue(UserDataFolderProperty);
		}
		set
		{
			SetValue(UserDataFolderProperty, value);
		}
	}

	public string Language
	{
		get
		{
			return (string)GetValue(LanguageProperty);
		}
		set
		{
			SetValue(LanguageProperty, value);
		}
	}

	public string AdditionalBrowserArguments
	{
		get
		{
			return (string)GetValue(AdditionalBrowserArgumentsProperty);
		}
		set
		{
			SetValue(AdditionalBrowserArgumentsProperty, value);
		}
	}

	public string ProfileName
	{
		get
		{
			return (string)GetValue(ProfileNameProperty);
		}
		set
		{
			SetValue(ProfileNameProperty, value);
		}
	}

	public bool? IsInPrivateModeEnabled
	{
		get
		{
			return (bool?)GetValue(IsInPrivateModeEnabledProperty);
		}
		set
		{
			SetValue(IsInPrivateModeEnabledProperty, value);
		}
	}

	public string ScriptLocale
	{
		get
		{
			return (string)GetValue(ScriptLocaleProperty);
		}
		set
		{
			SetValue(ScriptLocaleProperty, value);
		}
	}

	private static void EnvironmentPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
	{
		((CoreWebView2CreationProperties)d)._task = null;
	}

	internal Task<CoreWebView2Environment> CreateEnvironmentAsync()
	{
		if (_task == null && (BrowserExecutableFolder != null || UserDataFolder != null || Language != null || AdditionalBrowserArguments != null))
		{
			_task = CoreWebView2Environment.CreateAsync(BrowserExecutableFolder, UserDataFolder, new CoreWebView2EnvironmentOptions(AdditionalBrowserArguments, Language));
		}
		return _task ?? Task.FromResult<CoreWebView2Environment>(null);
	}

	internal CoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions(CoreWebView2Environment environment)
	{
		CoreWebView2ControllerOptions coreWebView2ControllerOptions = null;
		if (ProfileName != null || IsInPrivateModeEnabled.HasValue || ScriptLocale != null)
		{
			coreWebView2ControllerOptions = environment.CreateCoreWebView2ControllerOptions();
			coreWebView2ControllerOptions.ProfileName = ProfileName;
			coreWebView2ControllerOptions.IsInPrivateModeEnabled = IsInPrivateModeEnabled.GetValueOrDefault();
			coreWebView2ControllerOptions.ScriptLocale = ScriptLocale;
		}
		return coreWebView2ControllerOptions;
	}
}
