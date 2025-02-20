using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace IceMagicBox.Views
{
    public partial class BaseControl : UserControl
    {
        public Uri? WebSource{ get; set; }
        public BaseControl()
        {
            InitializeComponent();
        }

       

        private async void BaseControl_Load(object sender, EventArgs e)
        {
           await  InitializeWebView2();
        }

        async Task InitializeWebView2()
        {
            WebView2 webView21 = new WebView2();
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(null, "UserDataFolder", null);
            await webView21.EnsureCoreWebView2Async(webViewEnvironment);
            if (WebSource is not null) {

                webView21.Source = WebSource;
            }
            webView21.Dock= DockStyle.Fill;
            this.Controls.Add(webView21);
        }
    }
}
