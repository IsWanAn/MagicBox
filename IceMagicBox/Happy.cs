using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IceMagicBox
{
    class Happy
    {
        [Flags]
        public enum EXECUTION_STATE : uint
        {
            // Token: 0x04000007 RID: 7
            ES_CONTINUOUS = 2147483648U,
            // Token: 0x04000008 RID: 8
            ES_SYSTEM_REQUIRED = 1U,
            // Token: 0x04000009 RID: 9
            ES_DISPLAY_REQUIRED = 2U
        }

        public struct POINT
        {
            // Token: 0x04000004 RID: 4
            public int X;

            // Token: 0x04000005 RID: 5
            public int Y;
        }
        // Token: 0x06000004 RID: 4
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        // Token: 0x06000005 RID: 5
        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);
        [DllImport("kernel32.dll")]
        private static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
        public async Task StartHappy(CancellationToken cancellationToken)
        {

            SetThreadExecutionState((EXECUTION_STATE)2147483651U);
            while (!cancellationToken.IsCancellationRequested)
            {
                POINT currentPos;
                GetCursorPos(out currentPos);
                int offsetX = currentPos.X + 1;
                int offsetY = currentPos.Y + 1;
                SetCursorPos(offsetX, offsetY);
                await Task.Delay(100);
                SetCursorPos(currentPos.X, currentPos.Y);
                await Task.Delay(2000);
            }
        }
    }
}
