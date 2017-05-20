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
        public bool isCapturing = false;

        private FaceUpManager mgr = new FaceUpManager();

        public void ToggleCaptureProcess ()
        {
            if (isCapturing)
            {
                StartCaptureProcess();
            }
            else
            {
                StopCaptureProcess();
            }
        }

        public void StartCaptureProcess ()
        {
            Application.Idle -= ProcessFrame;
            isCapturing = true;

            btnPlayPause.Text = "Пауза";
            playPauseToolStripMenuItem.Text = "Пауза";
        }

        public void StopCaptureProcess ()
        {
            Application.Idle += ProcessFrame;
            isCapturing = false;

            btnPlayPause.Text = "Возобновить";
            playPauseToolStripMenuItem.Text = "Возобновить";
        }

        private void ProcessFrame ( object sender, EventArgs arg )
        {
            try
            {
                captureArea.Image = mgr.DrawProcessedFrame();
            }
            catch ( Exception )
            {
                MessageBox.Show( "Ошибка подключения веб-камеры" );
            }
        }

        public void LoadMaskImages ()
        {
            try 
            {
                List<string> hairMasks = mgr.GetMaskPathsOf( "hair" );
                List<string> eyeMasks = mgr.GetMaskPathsOf( "eye" );
                List<string> chinMasks = mgr.GetMaskPathsOf( "chin" );

                foreach (var mask in hairMasks)
                {
                    //заполнение листа
                }

                foreach (var mask in eyeMasks)
                {
                    //заполнение листа
                }

                foreach (var mask in chinMasks)
                {
                    //заполнение листа
                }
            }
            catch ( Exception )
            {
                MessageBox.Show( "Ошибка загрузки масок" );
            }
        }
    }
}
