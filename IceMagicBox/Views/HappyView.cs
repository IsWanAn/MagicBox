using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceMagicBox.Views
{
    public partial class HappyView : UserControl
    {
        Happy happy = new Happy();
        public HappyView()
        {
            InitializeComponent();
        }
        CancellationTokenSource cts;
        private void button1_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            Task.Run(async () =>
            {
               await happy.StartHappy(cts.Token);
            }, cts.Token);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(cts is null || (cts is not null && cts.IsCancellationRequested)))
            {
                cts.Cancel();
            }
            else
            {
                MessageBox.Show("not start yet");
            }
        }
    }
}
