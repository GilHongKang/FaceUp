using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FaceUp
{
    //Фронтенд
    partial class MainForm
    {
        private FaceUpManager mgr = new FaceUpManager();

        private void StartCaptureProcess ()
        {
            Application.Idle -= ProcessFrame;
        }

        private void StopCaptureProcess ()
        {
            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame ( object sender, EventArgs arg )
        {
            captureArea.Image = mgr.GetProcessedFrame();
        }

        private void LoadMasks ()
        {
            List<string> hairMasks = mgr.GetMasks( "hair" );
            List<string> eyeMasks = mgr.GetMasks( "eye" );
            List<string> chinMasks = mgr.GetMasks( "chin" );

            foreach ( var mask in hairMasks )
            {
                //заполнение листа
            }

            foreach ( var mask in eyeMasks )
            {
                //заполнение листа
            }

            foreach ( var mask in chinMasks )
            {
                //заполнение листа
            }
        }
    }
}
