using AntdUI;
using IceMagicBox.Utils;

namespace IceMagicBox.Views
{
    public partial class ThemControler : UserControl
    {
        public ThemControler(AntdUI.Window window)
        {

            InitializeComponent();
            this.Load += ThemControler_Load;
            Window = window ?? throw new ArgumentNullException(nameof(window));
        }

        private void ThemControler_Load(object? sender, EventArgs e)
        {
            this.flowPanel1.AutoScroll = true;
            UploadDragger uploadDragger = new UploadDragger();
            uploadDragger.Padding = new Padding(6, 6, 6, 6);
            uploadDragger.Size = new Size(260, 140);
            uploadDragger.Radius = 6;
            this.flowPanel1.Controls.Add(uploadDragger);

            Image3D image3D = new Image3D();
            image3D.Padding = new Padding(6, 6, 6, 6);
            image3D.Size = new Size(260, 140);
            image3D.Radius = 6;
            image3D.Image = Properties.Resources._001;
            image3D.Click += (s, e) =>
            {
                if (e is MouseEventArgs me && me.Button == MouseButtons.Left)
                    Preview.open(new Preview.Config(Window, (s as Image3D).Image));
                else
                    Button_base_Click(s, e);
            };

            this.flowPanel1.Controls.Add(image3D);


        }

        public AntdUI.Window Window { get; }


        private void Button_base_Click(object sender, EventArgs e)
        {
            string svg_save = "<svg viewBox=\"0 0 1024 1024\"><path d=\"M893.3 293.3L730.7 130.7c-7.5-7.5-16.7-13-26.7-16V112H144c-17.7 0-32 14.3-32 32v736c0 17.7 14.3 32 32 32h736c17.7 0 32-14.3 32-32V338.5c0-17-6.7-33.2-18.7-45.2zM384 184h256v104H384V184z m456 656H184V184h136v136c0 17.7 14.3 32 32 32h320c17.7 0 32-14.3 32-32V205.8l136 136V840z\" ></path><path d=\"M512 442c-79.5 0-144 64.5-144 144s64.5 144 144 144 144-64.5 144-144-64.5-144-144-144z m0 224c-44.2 0-80-35.8-80-80s35.8-80 80-80 80 35.8 80 80-35.8 80-80 80z\"></path></svg>",
svg_print = "<svg viewBox=\"0 0 1024 1024\"><path d=\"M820 436h-40c-4.4 0-8 3.6-8 8v40c0 4.4 3.6 8 8 8h40c4.4 0 8-3.6 8-8v-40c0-4.4-3.6-8-8-8z\"></path><path d=\"M852 332H732V120c0-4.4-3.6-8-8-8H300c-4.4 0-8 3.6-8 8v212H172c-44.2 0-80 35.8-80 80v328c0 17.7 14.3 32 32 32h168v132c0 4.4 3.6 8 8 8h424c4.4 0 8-3.6 8-8V772h168c17.7 0 32-14.3 32-32V412c0-44.2-35.8-80-80-80zM360 180h304v152H360V180z m304 664H360V568h304v276z m200-140H732V500H292v204H160V412c0-6.6 5.4-12 12-12h680c6.6 0 12 5.4 12 12v292z\"></path></svg>",
svg_share = "<svg viewBox=\"0 0 1024 1024\"><path d=\"M752 664c-28.5 0-54.8 10-75.4 26.7L469.4 540.8c1.7-9.3 2.6-19 2.6-28.8s-0.9-19.4-2.6-28.8l207.2-149.9C697.2 350 723.5 360 752 360c66.2 0 120-53.8 120-120s-53.8-120-120-120-120 53.8-120 120c0 11.6 1.6 22.7 4.7 33.3L439.9 415.8C410.7 377.1 364.3 352 312 352c-88.4 0-160 71.6-160 160s71.6 160 160 160c52.3 0 98.7-25.1 127.9-63.8l196.8 142.5c-3.1 10.6-4.7 21.8-4.7 33.3 0 66.2 53.8 120 120 120s120-53.8 120-120-53.8-120-120-120z m0-476c28.7 0 52 23.3 52 52s-23.3 52-52 52-52-23.3-52-52 23.3-52 52-52zM312 600c-48.5 0-88-39.5-88-88s39.5-88 88-88 88 39.5 88 88-39.5 88-88 88z m440 236c-28.7 0-52-23.3-52-52s23.3-52 52-52 52 23.3 52 52-23.3 52-52 52z\"></path></svg>",
svg_about = "<svg viewBox=\"0 0 1024 1024\"><path d=\"M716.3 313.8c19-18.9 19-49.7 0-68.6l-69.9-69.9 0.1 0.1c-18.5-18.5-50.3-50.3-95.3-95.2-21.2-20.7-55.5-20.5-76.5 0.5L80.9 474.2c-21.2 21.1-21.2 55.3 0 76.4L474.6 944c21.2 21.1 55.4 21.1 76.5 0l165.1-165c19-18.9 19-49.7 0-68.6-19-18.9-49.7-18.9-68.7 0l-125 125.2c-5.2 5.2-13.3 5.2-18.5 0L189.5 521.4c-5.2-5.2-5.2-13.3 0-18.5l314.4-314.2c0.4-0.4 0.9-0.7 1.3-1.1 5.2-4.1 12.4-3.7 17.2 1.1l125.2 125.1c19 19 49.8 19 68.7 0z\"></path><path d=\"M408.6 514.4a106.3 106.2 0 1 0 212.6 0 106.3 106.2 0 1 0-212.6 0Z\"></path><path d=\"M944.8 475.8L821.9 353.5c-19-18.9-49.8-18.9-68.7 0.1-19 18.9-19 49.7 0 68.6l83 82.9c5.2 5.2 5.2 13.3 0 18.5l-81.8 81.7c-19 18.9-19 49.7 0 68.6 19 18.9 49.7 18.9 68.7 0l121.8-121.7c21.1-21.1 21.1-55.2-0.1-76.4z\"></path></svg>";

            var menulist = new AntdUI.IContextMenuStripItem[]
            {
                  new AntdUI.ContextMenuStripItem("设置为壁纸")
        {
            IconSvg =  "PictureOutlined",

        },

        new AntdUI.ContextMenuStripItemDivider(),
        new AntdUI.ContextMenuStripItem("另存为", "Ctrl+S")
        {
            IconSvg = svg_save
        },
        new AntdUI.ContextMenuStripItem("打印", "Ctrl+P")
        {
            IconSvg = svg_print
        },
        new AntdUI.ContextMenuStripItemDivider(),
        new AntdUI.ContextMenuStripItem("共享")
        {
            IconSvg = svg_share
        },
        new AntdUI.ContextMenuStripItem("关于")
        {
            IconSvg = svg_about
        },
            };
            AntdUI.ContextMenuStrip.Config config = new AntdUI.ContextMenuStrip.Config(sender as Image3D, it =>
            {
                if (it.Text.Contains("壁纸"))
                {
                    WallpaperChanger.SetWallpaper((sender as Image3D).Image);
                }
                AntdUI.Message.info(Window, it.Text, autoClose: 3);
            }, menulist)
            {

                Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
            };
            AntdUI.ContextMenuStrip.open(config);
        }
    }
}
