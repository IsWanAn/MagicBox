namespace IceMagicBox.Views
{
    partial class ThemControler
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowPanel1 = new AntdUI.FlowPanel();
            SuspendLayout();
            // 
            // flowPanel1
            // 
            flowPanel1.Dock = DockStyle.Fill;
            flowPanel1.Location = new Point(0, 0);
            flowPanel1.Name = "flowPanel1";
            flowPanel1.Size = new Size(858, 461);
            flowPanel1.TabIndex = 0;
            flowPanel1.Text = "flowPanel1";
            // 
            // ThemControler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowPanel1);
            Name = "ThemControler";
            Size = new Size(858, 461);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.FlowPanel flowPanel1;
    }
}
