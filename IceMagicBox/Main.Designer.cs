namespace IceMagicBox
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            AntdUI.MenuItem menuItem1 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem2 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem3 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem4 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem5 = new AntdUI.MenuItem();
            pageHeader1 = new AntdUI.PageHeader();
            btnColor = new AntdUI.Button();
            button2 = new AntdUI.Button();
            button1 = new AntdUI.Button();
            tabs = new AntdUI.Tabs();
            btnCollapse = new AntdUI.Button();
            menu = new AntdUI.Menu();
            pageHeader1.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader1
            // 
            pageHeader1.Controls.Add(btnColor);
            pageHeader1.Controls.Add(button2);
            pageHeader1.Controls.Add(button1);
            pageHeader1.DividerShow = true;
            pageHeader1.Dock = DockStyle.Top;
            pageHeader1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageHeader1.Icon = Properties.Resources.人工智能;
            pageHeader1.Location = new Point(0, 0);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowButton = true;
            pageHeader1.ShowIcon = true;
            pageHeader1.Size = new Size(1024, 40);
            pageHeader1.TabIndex = 0;
            pageHeader1.Text = "MagicBox";
            pageHeader1.Click += pageHeader1_Click;
            // 
            // btnColor
            // 
            btnColor.Dock = DockStyle.Right;
            btnColor.IconSize = new Size(20, 20);
            btnColor.IconSvg = "SunOutlined";
            btnColor.Location = new Point(730, 0);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(50, 40);
            btnColor.TabIndex = 5;
            btnColor.ToggleIconSvg = "MoonOutlined";
            btnColor.Click += btnLight_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.IconSize = new Size(20, 20);
            button2.IconSvg = resources.GetString("button2.IconSvg");
            button2.Location = new Point(780, 0);
            button2.Name = "button2";
            button2.Size = new Size(50, 40);
            button2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Ghost = true;
            button1.IconRatio = 0.6F;
            button1.IconSize = new Size(20, 20);
            button1.IconSvg = "TranslationOutlined";
            button1.Location = new Point(830, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 40);
            button1.TabIndex = 3;
            // 
            // tabs
            // 
            tabs.Dock = DockStyle.Fill;
            tabs.Location = new Point(44, 40);
            tabs.Name = "tabs";
            tabs.Size = new Size(980, 540);
            tabs.Style = styleLine1;
            tabs.TabIndex = 7;
            tabs.TabMenuVisible = false;
            tabs.Text = "tabs1";
            tabs.SelectedIndexChanged += tabs_SelectedIndexChanged;
            // 
            // btnCollapse
            // 
            btnCollapse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCollapse.IconHoverSvg = "";
            btnCollapse.IconSvg = "MenuUnfoldOutlined";
            btnCollapse.Location = new Point(0, 536);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Radius = 0;
            btnCollapse.Size = new Size(44, 44);
            btnCollapse.TabIndex = 5;
            btnCollapse.ToggleIconSvg = "MenuFoldOutlined";
            btnCollapse.Click += btnCollapse_Click;
            // 
            // menu
            // 
            menu.Collapsed = true;
            menu.Dock = DockStyle.Left;
            menu.Indent = true;
            menuItem1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            menuItem1.Icon = Properties.Resources.ChatGPT;
            menuItem1.Text = "ChatGPT";
            menuItem2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuItem2.Icon = Properties.Resources.copilot;
            menuItem2.Text = "Copilot";
            menuItem3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            menuItem3.Icon = Properties.Resources._string;
            menuItem3.Text = "StringFormat";
            menuItem4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            menuItem4.Icon = Properties.Resources.Happy;
            menuItem4.Text = "Fun";
            menuItem5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            menuItem5.Icon = Properties.Resources.Them;
            menuItem5.Text = "Them";
            menu.Items.Add(menuItem1);
            menu.Items.Add(menuItem2);
            menu.Items.Add(menuItem3);
            menu.Items.Add(menuItem4);
            menu.Items.Add(menuItem5);
            menu.Location = new Point(0, 40);
            menu.Name = "menu";
            menu.Size = new Size(44, 540);
            menu.TabIndex = 4;
            menu.Text = "menu1";
            menu.SelectChanged += menu_SelectChanged;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1024, 580);
            Controls.Add(tabs);
            Controls.Add(btnCollapse);
            Controls.Add(menu);
            Controls.Add(pageHeader1);
            Name = "Main";
            Text = "Form1";
            pageHeader1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Button button2;
        private AntdUI.Button button1;
        private AntdUI.Button btnColor;
        private AntdUI.Tabs tabs;
        private AntdUI.Button btnCollapse;
        private AntdUI.Menu menu;
    }
}
