using Microsoft.Maui.Embedding;
using Android.App;
using Android.OS;
using Syncfusion.Maui.ProgressBar;
using Microsoft.Maui.Platform;
using Syncfusion.Maui.Core.Hosting;

namespace NativeEmbedding_CircularProgressBar
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        MauiContext? _mauiContext;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            MauiAppBuilder builder = MauiApp.CreateBuilder();
            builder.UseMauiEmbedding<Microsoft.Maui.Controls.Application>();
            builder.ConfigureSyncfusionCore();
            MauiApp mauiApp = builder.Build();
            _mauiContext = new MauiContext(mauiApp.Services, this);

            SfCircularProgressBar circularProgressBar = new SfCircularProgressBar { Progress = 75, SegmentCount = 4 };
            Android.Views.View view = circularProgressBar.ToPlatform(_mauiContext);

            // Set our view from the "main" layout resource
            SetContentView(view);
        }
    }
}