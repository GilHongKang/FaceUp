using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceUp
{
    //Фронтенд
    partial class MainForm
    {
        public bool isCapturing = false;
        public ListViewItem activeMaskItem;

        public MaskType activeMaskType
        {
            get
            {
                switch (tabCtrlMasks.SelectedTab.Text)
                {
                    case "Волосы":
                        return MaskType.HAIR;
                    case "Глаза":
                        return MaskType.EYE;
                    case "Подбородок":
                        return MaskType.CHIN;
                    default:
                        return MaskType.HAIR;
                }
            }
        }

        private FaceUpManager mgr = new FaceUpManager();
        private List<FaceUpManager.Picture> hairMasks;
        private List<FaceUpManager.Picture> eyeMasks;
        private List<FaceUpManager.Picture> chinMasks;

        public void ToggleCaptureProcess()
        {
            if (isCapturing)
            {
                StopCaptureProcess();
            }
            else
            {
                StartCaptureProcess();
            }
        }

        public void StartCaptureProcess()
        {
            Application.Idle += ProcessFrame;
            isCapturing = true;

            btnPlayPause.Text = "Пауза";
            playPauseToolStripMenuItem.Text = "Пауза";
        }

        public void StopCaptureProcess()
        {
            Application.Idle -= ProcessFrame;
            isCapturing = false;

            btnPlayPause.Text = "Возобновить";
            playPauseToolStripMenuItem.Text = "Возобновить";
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            try
            {
                captureArea.Image = mgr.DrawProcessedFrame();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения веб-камеры");
                StopCaptureProcess();
            }
        }

        public void LoadMaskImages(string applicationPath)
        {
            try
            {
                if (!mgr.LoadImages(applicationPath)) throw new Exception("Изображения не найдены");

                eyeMasks = mgr.GetMaskImagesOf(FaceUpManager.MaskType.EYE);
                chinMasks = mgr.GetMaskImagesOf(FaceUpManager.MaskType.CHIN);
                hairMasks = mgr.GetMaskImagesOf(FaceUpManager.MaskType.HAIR);

                hairMasks.Select(image => new { image.source, image.id })
                    .ToList().ForEach(obj =>
                   {
                       ListViewItem item = new ListViewItem();
                       item.Tag = obj.id;
                       imageListHair.Images.Add(obj.source);
                       item.ImageIndex = imageListHair.Images.Count - 1;
                       listViewHair.Items.Add(item);
                   });

                eyeMasks.Select(image => new { image.source, image.id })
                    .ToList().ForEach(obj =>
                   {
                       ListViewItem item = new ListViewItem();
                       item.Tag = obj.id;
                       imageListEye.Images.Add(obj.source);
                       item.ImageIndex = imageListEye.Images.Count - 1;
                       listViewEye.Items.Add(item);
                   });

                chinMasks.Select(image => new { image.source, image.id })
                    .ToList().ForEach(obj =>
                   {
                       ListViewItem item = new ListViewItem();
                       item.Tag = obj.id;
                       imageListChin.Images.Add(obj.source);
                       item.ImageIndex = imageListChin.Images.Count - 1;
                       listViewChin.Items.Add(item);
                   });
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки масок");
            }
        }

        public void SelectMask(MaskType maskType)
        {
            try
            {
                switch (maskType)
                {
                    case MaskType.HAIR:
                        activeMaskItem = listViewHair.SelectedItems[0];
                        break;
                    case MaskType.EYE:
                        activeMaskItem = listViewEye.SelectedItems[0];
                        break;
                    case MaskType.CHIN:
                        activeMaskItem = listViewChin.SelectedItems[0];
                        break;
                    default:
                        return;
                }

                int id = int.Parse(activeMaskItem.Tag.ToString());

                FaceUpManager.Picture picture = mgr.GetMaskById(id);

                switch (maskType)
                {
                    case MaskType.HAIR:
                        mgr.currentMasks.SetHair(picture);
                        break;
                    case MaskType.EYE:
                        mgr.currentMasks.SetEye(picture);
                        break;
                    case MaskType.CHIN:
                        mgr.currentMasks.SetChin(picture);
                        break;
                    default:
                        return;
                }
            }
            catch (Exception ex) { }

        }

        public void CorrectMaskSize(MaskType maskType, int size)
        {
            switch (maskType)
            {
                case MaskType.HAIR:
                    {
                        var hairSize = mgr.currentMasks.hair.GetSizeOffsets();
                        mgr.currentMasks.hair.ChangeSizeOffsets(120 + ((size - 12) * 20), 120 + ((size - 12) * 20));
                    }
                    break;
                case MaskType.EYE:
                    {
                        var eyeSize = mgr.currentMasks.eye.GetSizeOffsets();
                        mgr.currentMasks.eye.ChangeSizeOffsets(120 + ((size - 12) * 20), 120 + ((size - 12) * 20));
                    }
                    break;
                case MaskType.CHIN:
                    {
                        var chinSize = mgr.currentMasks.chin.GetSizeOffsets();
                        mgr.currentMasks.chin.ChangeSizeOffsets(120 + ((size - 12) * 20), 120 + ((size - 12) * 20));
                    }
                    break;
            }
        }

        public void CorrectMaskX(MaskType maskType, int offsetX)
        {

            statusStrip__CorrectionX.Text = "Корректировка по оси X: " + ((offsetX - 12) * 30).ToString();

            switch (maskType)
            {
                case MaskType.HAIR:
                    {
                        var hairSize = mgr.currentMasks.hair.GetPositionOffsets();
                        mgr.currentMasks.hair.ChangePositionOffsets((offsetX - 12) * 30, hairSize.Y);
                    }
                    break;
                case MaskType.EYE:
                    {
                        var eyeSize = mgr.currentMasks.eye.GetPositionOffsets();
                        mgr.currentMasks.eye.ChangePositionOffsets(((offsetX - 12) * 30), eyeSize.Y);
                    }
                    break;
                case MaskType.CHIN:
                    {
                        var chinSize = mgr.currentMasks.chin.GetPositionOffsets();
                        mgr.currentMasks.chin.ChangePositionOffsets(((offsetX - 12) * 30), chinSize.Y);
                    }
                    break;
            }
            /*
            var hairMask = hairMasks[0];
            hairMask.ChangePositionOffsets(-10, 10);
            hairMask.ChangeSizeOffsets(20, 100);
            hairMask.GetPositionOffsets();
            hairMask.GetSizeOffsets();
            */

            /*
            размер картинок можно поменять так, больше способов не знаю
            imageListChin.ImageSize = new Size(100,100);
            imageListEye.ImageSize = new Size(100, 100);
            imageListHair.ImageSize = new Size(100, 100);
            */
        }

        public void CorrectMaskY(MaskType maskType, int offsetY)
        {

            statusStrip__CorrectionY.Text = "Корректировка по оси Y: " + ((offsetY - 12) * 30).ToString();

            switch (maskType)
            {
                case MaskType.HAIR:
                    {
                        var hairSize = mgr.currentMasks.hair.GetPositionOffsets();
                        mgr.currentMasks.hair.ChangePositionOffsets(hairSize.X, ((offsetY - 12) * 30));
                    }
                    break;
                case MaskType.EYE:
                    {
                        var eyeSize = mgr.currentMasks.eye.GetPositionOffsets();
                        mgr.currentMasks.eye.ChangePositionOffsets(eyeSize.X, ((offsetY - 12) * 30));
                    }
                    break;
                case MaskType.CHIN:
                    {
                        var chinSize = mgr.currentMasks.chin.GetPositionOffsets();
                        mgr.currentMasks.chin.ChangePositionOffsets(chinSize.X, ((offsetY - 12) * 30));
                    }
                    break;
            }
        }
    }

}
