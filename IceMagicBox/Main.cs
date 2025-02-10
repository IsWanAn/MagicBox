using AntdUI;
using IceMagicBox.Utils;
using IceMagicBox.Views;
using Microsoft.Win32;
using Sunny.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IceMagicBox
{
    public partial class Main : AntdUI.Window
    {
        private bool isLight = true;
        private object currControl;
        private bool isUpdatingTabs;

        public Main()
        {
            InitializeComponent();
            InitData();
            //监听系统深浅色变化
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General)
            {
                isLight = ThemeHelper.IsLightMode();
                btnColor.Toggle = !isLight;
                ThemeHelper.SetColorMode(this, isLight);
            }
        }

        private void pageHeader1_Click(object sender, EventArgs e)
        {

        }


        private void InitData()
        {
            //根据系统亮暗初始化一次
            isLight = ThemeHelper.IsLightMode();
            btnColor.Toggle = !isLight;
            ThemeHelper.SetColorMode(this, isLight);
            //初始化消息弹出位置
            Config.ShowInWindow = true;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (menu.Collapsed)
            {
                menu.Width = (int)(160 * Config.Dpi);
            }
            else
            {
                menu.Width = (int)(44 * Config.Dpi);
            }
            btnCollapse.Toggle = !btnCollapse.Toggle;
            menu.Collapsed = !menu.Collapsed;
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            isLight = !isLight;
            //这里使用了Toggle属性切换图标
            btnColor.Toggle = !isLight;
            ThemeHelper.SetColorMode(this, isLight);
        }

        private void menu_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            string name = (string)e.Value.Text;
            // 检查是否已存在同名 TabPage
            foreach (var tab in tabs.Pages)
            {
                if (tab is AntdUI.TabPage existingTab && existingTab.Text == name)
                {
                    isUpdatingTabs = true;
                    tabs.SelectedTab = existingTab; // 直接跳转到已存在的 TabPage
                    isUpdatingTabs = false;
                    currControl = existingTab.Controls.Count > 0 ? existingTab.Controls[0] as UserControl : null;
                    return;
                }
            }

            // 如果不存在相应的 TabPage，创建新的
            UserControl control = null;
            switch (name)
            {
                case "Copilot":
                    control = new CopilotControler();
                    break;
                case "ChatGPT":
                    control = new GPTControler();
                    break;
                case "StringFormat":
                    control = new StringFormatControler();
                    break;
                case "Them":
                    control = new ThemControler(this);
                    break;
                default:
                    break;
            }
            if (control != null)
            {
                //容器添加控件，需要调整dpi
                control.Dock = DockStyle.Fill;
                AutoDpi(control);
                AntdUI.TabPage tabPage = new AntdUI.TabPage()
                {
                    Text = name,
                };
                tabPage.Controls.Add(control);
                tabs.Pages.Add(tabPage);
                isUpdatingTabs = true;
                tabs.SelectedTab = tabPage;
                isUpdatingTabs = false;
                currControl = control;
            }
        }

        private void tabs_SelectedIndexChanged(object sender, IntEventArgs e)
        {

        }
    }
}
