using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace Youtube_Video_Player
{
    public class YoutubePlayer
    {
        private const string VirtualHost = "ytplayer.local";

        private readonly WebView2 _web;
        private readonly string _tempFolder;
        private bool _initialized;

        public YoutubePlayer(WebView2 webView)
        {
            _web = webView ?? throw new ArgumentNullException(nameof(webView));

            _tempFolder = Path.Combine(Path.GetTempPath(), "YoutubePlayer_" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(_tempFolder);

            // Clean up the temp folder when the WebView2 is disposed with the form.
            _web.Disposed += (s, e) =>
            {
                try { Directory.Delete(_tempFolder, true); } catch { /* ignore */ }
            };
        }

        /// <summary>Plays the video from a YouTube link. Throws ArgumentException if the link is invalid.</summary>
        public async Task PlayVideoAsync(string url, bool autoplay = true)
        {
            string videoId = ExtractVideoId(url);
            if (videoId == null)
                throw new ArgumentException("That doesn't look like a valid YouTube link.");

            await EnsureInitializedAsync();

            string html = $@"<!DOCTYPE html>
<html>
<head>
  <meta charset=""utf-8"">
  <meta name=""referrer"" content=""strict-origin-when-cross-origin"">
  <style>html,body{{margin:0;height:100%;background:#000;overflow:hidden}}iframe{{border:0;width:100%;height:100%}}</style>
</head>
<body>
  <iframe
    src=""https://www.youtube.com/embed/{videoId}?autoplay={(autoplay ? 1 : 0)}&rel=0""
    allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; fullscreen""
    referrerpolicy=""strict-origin-when-cross-origin""
    allowfullscreen></iframe>
</body>
</html>";

            File.WriteAllText(Path.Combine(_tempFolder, "player.html"), html);

            // Add a cache-busting query so replaying the same video reloads the page.
            _web.CoreWebView2.Navigate($"https://{VirtualHost}/player.html?t={DateTime.UtcNow.Ticks}");
        }

        public void Stop()
        {
            if (_initialized)
                _web.CoreWebView2.Navigate("about:blank");
        }

        private async Task EnsureInitializedAsync()
        {
            if (_initialized) return;

            await _web.EnsureCoreWebView2Async();
            _web.CoreWebView2.SetVirtualHostNameToFolderMapping(
                VirtualHost, _tempFolder, CoreWebView2HostResourceAccessKind.Allow);
            _initialized = true;
        }

        public static string ExtractVideoId(string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return null;

            var match = Regex.Match(url.Trim(),
                @"(?:youtube\.com/(?:watch\?(?:.*&)?v=|embed/|shorts/|live/|v/)|youtu\.be/)([A-Za-z0-9_-]{11})",
                RegexOptions.IgnoreCase);

            return match.Success ? match.Groups[1].Value : null;
        }
    }
}