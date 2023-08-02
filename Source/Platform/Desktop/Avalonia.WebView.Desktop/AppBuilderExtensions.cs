﻿using System.Runtime.InteropServices;

namespace Avalonia.WebView.Desktop;

public static class AppBuilderExtensions
{
    public static AppBuilder UseDesktopWebView(this AppBuilder builder, bool isWslDevelop = false)
    {
#if NETSTANDARD
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            builder.UseWindowWebView();
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            builder.UseLinuxWebView(isWslDevelop);
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            builder.UseMacCatalystWebView();
#endif
        return builder;
    }
}
