using IceMagicBox.Utils;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace IceMagicBox.Views
{
    public partial class BaseControl : UserControl
    {
        WebView2 webView21 = new WebView2();

        public Uri? WebSource { get; set; }
        public BaseControl()
        {
            InitializeComponent();
        }



        private async void BaseControl_Load(object sender, EventArgs e)
        {
            await InitializeWebView2();
        }

        async Task InitializeWebView2()
        {
            var options = new CoreWebView2EnvironmentOptions
            {
                AreBrowserExtensionsEnabled = true
            };
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(null, "UserDataFolder", options);
            await webView21.EnsureCoreWebView2Async(webViewEnvironment);
            await LoadAdGuardExtension();
            if (WebSource is not null)
            {

                webView21.Source = WebSource;
            }
            webView21.Dock = DockStyle.Fill;
            this.Controls.Add(webView21);
        }


        private async Task LoadAdGuardExtension()
        {
            var extensionId = "bgnkhhnnamicmpeenaelnjfhikgbkllg";
            var extensions = await webView21.CoreWebView2.Profile.GetBrowserExtensionsAsync();
            var archivepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Extensions/Web/AdGuard/{extensionId}.zip") ;
            var extensionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"UserDataFolder/EBWebView/Default/Extensions/{extensionId}");
            if (!Directory.Exists(extensionPath))
            {
                Directory.CreateDirectory(extensionPath);
            }
            SevenZipUtill.Extract(archivepath,  extensionPath);
            bool isInstalled = extensions.Any(ext => ext.Id == extensionId);
            if (!isInstalled)
            {
                await webView21.CoreWebView2.Profile.AddBrowserExtensionAsync(extensionPath);
            }
        }
    }
}
