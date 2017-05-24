using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace FaceUp
{
    //Фронтенд
    partial class MainForm
    {
        private bool IsWebcamConnected = false;
        public bool IsCapturing = false;
        public ListViewItem ActiveMaskItem;
        public MaskType ActiveMaskType
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

        private FaceUpManager Mgr = new FaceUpManager();

        public void ToggleCaptureProcess()
        {
            if (IsCapturing)
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
            timer.Start();
            IsCapturing = true;

            btnPlayPause.Text = "Пауза";
            playPauseToolStripMenuItem.Text = "Пауза";
        }

        public void StopCaptureProcess()
        {
            timer.Stop();
            IsCapturing = false;

            btnPlayPause.Text = "Возобновить";
            playPauseToolStripMenuItem.Text = "Возобновить";
        }

        private void ProcessFrame ()
        {
            try
            {
                captureArea.Image = Mgr.DrawProcessedFrame();
                statusStrip__PeopleAmount.Text = "Людей на снимке: " + Mgr.FacesAmount;
                IsWebcamConnected = true;
            }
            catch
            {
                StopCaptureProcess();
                IsWebcamConnected = false;
                MessageBox.Show( "Ошибка подключения веб-камеры" );
            }
        }

        public void LoadMaskImages()
        {
            LoadMaskImages( MaskType.HAIR, listViewHair );
            LoadMaskImages( MaskType.EYE, listViewEye );
            LoadMaskImages( MaskType.CHIN, listViewChin );
        }

        public void LoadMaskImages ( MaskType type, ListView listView ) 
        {
            string[] imgPaths = Mgr.LoadMasks( type, Application.StartupPath );
            foreach (string imgPath in imgPaths)
            {
                ListViewItem item = new ListViewItem();
                listView.LargeImageList.Images.Add( Bitmap.FromFile( imgPath ) );
                item.ImageIndex = listView.LargeImageList.Images.Count - 1;
                listView.Items.Add( item );

                Mgr.AddMask( new Mask( type, imgPath ), item.ImageIndex );
            }
        }

        public void SelectMask( ListView listView )
        {
            try
            {
                ActiveMaskItem = listView.SelectedItems[0];
                Mgr.SelectMask( ActiveMaskType, ActiveMaskItem.ImageIndex );
                UpdateValues();
            }
            catch (Exception) { }
        }

        public void UpdateValues () 
        {
            Mask selectedMask;

            switch (ActiveMaskType)
            {
                case MaskType.HAIR:
                    selectedMask = Mgr.SelectedHairMask;
                    break;
                case MaskType.EYE:
                    selectedMask = Mgr.SelectedEyeMask;
                    break;
                case MaskType.CHIN:
                    selectedMask = Mgr.SelectedChinMask;
                    break;
                default:
                    return;
            }

            trackBarCorrectionSize.Value = selectedMask.TrackBarScale;
            trackBarCorrectionX.Value = selectedMask.TrackBarOffsetX;
            trackBarCorrectionY.Value = selectedMask.TrackBarOffsetY;

            statusStrip__PeopleAmount.Text = "Людей на снимке: " + Mgr.FacesAmount;
            statusStrip__CorrectionSize.Text = "Размер: " + selectedMask.Scale + "%";
            statusStrip__CorrectionX.Text = "Корректировка по оси X: " + selectedMask.OffsetX;
            statusStrip__CorrectionY.Text = "Корректировка по оси Y: " + selectedMask.OffsetY;
        }

        public void CorrectMaskScale( int scale )
        {
            switch (ActiveMaskType)
            {
                case MaskType.HAIR:
                    Mgr.SelectedHairMask.ChangeScale( scale * 5 );
                    Mgr.SelectedHairMask.TrackBarScale = trackBarCorrectionSize.Value;
                    break;
                case MaskType.EYE:
                    Mgr.SelectedEyeMask.ChangeScale( scale * 5 );
                    Mgr.SelectedEyeMask.TrackBarScale = trackBarCorrectionSize.Value;
                    break;
                case MaskType.CHIN:
                    Mgr.SelectedChinMask.ChangeScale( scale * 5 );
                    Mgr.SelectedChinMask.TrackBarScale = trackBarCorrectionSize.Value;
                    break;
            }

            statusStrip__CorrectionSize.Text = "Размер: " + (100 + (scale * 5)) + "%";
        }

        public void CorrectMaskX( int offsetX )
        {
            switch (ActiveMaskType)
            {
                case MaskType.HAIR:
                    Mgr.SelectedHairMask.OffsetX = offsetX * 3;
                    Mgr.SelectedHairMask.TrackBarOffsetX = trackBarCorrectionX.Value;
                    break;
                case MaskType.EYE:
                    Mgr.SelectedEyeMask.OffsetX = offsetX * 3;
                    Mgr.SelectedEyeMask.TrackBarOffsetX = trackBarCorrectionX.Value;
                    break;
                case MaskType.CHIN:
                    Mgr.SelectedChinMask.OffsetX = offsetX * 3;
                    Mgr.SelectedChinMask.TrackBarOffsetX = trackBarCorrectionX.Value;
                    break;
            }

            statusStrip__CorrectionX.Text = "Корректировка по оси X: " + offsetX;
        }

        public void CorrectMaskY( int offsetY )
        {
            switch (ActiveMaskType)
            {
                case MaskType.HAIR:
                    Mgr.SelectedHairMask.OffsetY = offsetY * 3;
                    Mgr.SelectedHairMask.TrackBarOffsetY = trackBarCorrectionY.Value;
                    break;
                case MaskType.EYE:
                    Mgr.SelectedEyeMask.OffsetY = offsetY * 3;
                    Mgr.SelectedEyeMask.TrackBarOffsetY = trackBarCorrectionY.Value;
                    break;
                case MaskType.CHIN:
                    Mgr.SelectedChinMask.OffsetY = offsetY * 3;
                    Mgr.SelectedEyeMask.TrackBarOffsetY = trackBarCorrectionY.Value;
                    break;
            }

            statusStrip__CorrectionY.Text = "Корректировка по оси Y: " + offsetY;
        }

        public void ClearMask ( MaskType type ) 
        {
            switch (type)
            {
                case MaskType.HAIR:
                    Mgr.SelectedHairMask = new Mask( MaskType.HAIR );
                    break;
                case MaskType.EYE:
                    Mgr.SelectedEyeMask = new Mask( MaskType.EYE );
                    break;
                case MaskType.CHIN:
                    Mgr.SelectedChinMask = new Mask( MaskType.CHIN );
                    break;
            }
        }

        public void SaveImage ( bool showDialog = false )
        {
            if (IsWebcamConnected) 
            {
                if (showDialog)
                {
                    StopCaptureProcess();

                    if (saveImageDialog.ShowDialog() == DialogResult.Cancel)
                    {
                        StartCaptureProcess();
                        return;
                    }
                    else
                    {
                        string path = saveImageDialog.FileName;
                        try
                        {
                            Mgr.CapturedBmp.Save( saveImageDialog.FileName );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show( ex.Message );
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (!Directory.Exists( settingsForm.OutputDir ))
                        {
                            Directory.CreateDirectory( settingsForm.OutputDir );
                        }
                        Mgr.CapturedBmp.Save( settingsForm.OutputDir + @"\FaceUp_" + DateTime.Now.ToFileTime().ToString() + ".jpg" );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show( ex.Message );
                    }
                }
            }
        }

        public void OpenOutputDir () 
        {
            Process.Start( "explorer.exe", settingsForm.OutputDir );
        }
    }

}
