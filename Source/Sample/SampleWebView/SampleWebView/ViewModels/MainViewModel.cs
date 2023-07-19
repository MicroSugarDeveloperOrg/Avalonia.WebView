using ReactiveUI;
using System.Reactive;

namespace SampleWebView.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel() 
    {
        BaiduCommand = ReactiveCommand.Create<object>(t =>
        {
            Url = new Uri("https://www.bilibili.com/");
            //Url = new Uri(" https://www.android.com/");
        });

        IconFontCommand = ReactiveCommand.Create<object>(t =>
        {
            Url = new Uri("https://www.iconfont.cn/");
        });

        ShowOrHideCommand = ReactiveCommand.Create<object>(t =>
        {
            IsShow = !IsShow;
        });
    }

    private Uri? _url;
    public Uri? Url
    {
        get => _url;
        set => this.RaiseAndSetIfChanged(ref _url, value);
    }

    private bool _isShow = true;
    public bool IsShow
    {
        get => _isShow;
        set => this.RaiseAndSetIfChanged(ref _isShow, value);
    }

    public ReactiveCommand<object, Unit> BaiduCommand { get; }
    public ReactiveCommand<object, Unit> IconFontCommand { get; }
    public ReactiveCommand<object, Unit> ShowOrHideCommand { get; }
}
