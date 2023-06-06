echo a = %1
echo b = %2

dotnet nuget push _nuget\BlazorWebView.Avalonia.%1.nupkg --api-key %2 --source https://api.nuget.org/v3/index.json

dotnet nuget push _nuget\WebView.Avalonia.%1.nupkg --api-key %2 --source https://api.nuget.org/v3/index.json

dotnet nuget push _nuget\WebView.Avalonia.Android.%1.nupkg --api-key %2 --source https://api.nuget.org/v3/index.json

dotnet nuget push _nuget\WebView.Avalonia.Desktop.%1.nupkg --api-key %2 --source https://api.nuget.org/v3/index.json

dotnet nuget push _nuget\WebView.Avalonia.iOS.%1.nupkg --api-key %2 --source https://api.nuget.org/v3/index.json

dotnet nuget push _nuget\WebView.Avalonia.Linux.%1.nupkg --api-key %2 --source https://api.nuget.org/v3/index.json

dotnet nuget push _nuget\WebView.Avalonia.MacCatalyst.%1.nupkg --api-key %2 --source https://api.nuget.org/v3/index.json

dotnet nuget push _nuget\WebView.Avalonia.Windows.%1.nupkg --api-key %2 --source https://api.nuget.org/v3/index.json
 