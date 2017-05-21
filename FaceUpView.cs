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

        public void LoadMaskImages (string applicationPath)
        {
            try
            {
                if(!mgr.LoadImages(applicationPath))
                    throw new Exception("Images not found");

                List<FaceUpManager.Picture> eyeMasks = mgr.GetMaskImagesOf(FaceUpManager.MaskType.EYE),
                    chinMasks = mgr.GetMaskImagesOf(FaceUpManager.MaskType.CHIN),
                    hairMasks = mgr.GetMaskImagesOf(FaceUpManager.MaskType.HAIR);

                for(int i = 0; i < hairMasks.Count; i++)
                {
                    imageListHair.Images.Add(hairMasks[0].source);
                    listViewHair.Items.Add("", i);
                }

                for (int i = 0; i < eyeMasks.Count; i++)
                {
                    imageListEye.Images.Add(eyeMasks[i].source);
                    listViewEye.Items.Add("", i);
                }

                for (int i = 0; i < chinMasks.Count; i++)
                {
                    imageListChin.Images.Add(chinMasks[i].source);
                    listViewChin.Items.Add("", i);
                }

                /*
                 * размер картинок можно поменять так, больше способов не знаю
                imageListChin.ImageSize = new Size(100,100);
                imageListEye.ImageSize = new Size(100, 100);
                imageListHair.ImageSize = new Size(100, 100);
                */
               
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки масок");
            }
        }
    }
}