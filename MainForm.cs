using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceUp
{
    public partial class MainForm : Form
    {
        private SettingsForm settingsForm = new SettingsForm();

        public MainForm ()
        {
            InitializeComponent();

            settingsForm.Owner = this;
            settingsForm.SetupSettings();
            LoadMaskImages();
            StartCaptureProcess();
        }

        //Обработчики кнопок сайдбара
        private void btnPlayPause_Click ( object sender, EventArgs e )
        {
            ToggleCaptureProcess();
        }

        private void btnShot_Click ( object sender, EventArgs e )
        {
            SaveImage();
        }

        private void btnOpenOutputDir_Click ( object sender, EventArgs e )
        {
            OpenOutputDir();
        }

        private void btnClearMasks_Click ( object sender, EventArgs e )
        {
            ClearMask( ActiveMaskType );
        }

        //Обработчики смены вкладок
        private void tabCtrlMasks_Selecting ( object sender, TabControlCancelEventArgs e )
        {
            UpdateValues();
        }

        //Обработчики корректировки
        private void trackBarCorrectionSize_Scroll ( object sender, EventArgs e )
        {
            CorrectMaskScale( trackBarCorrectionSize.Value - 10 );
        }

        private void trackBarCorrectionX_Scroll ( object sender, EventArgs e )
        {
            CorrectMaskX( trackBarCorrectionX.Value - 10 );
        }

        private void trackBarCorrectionY_Scroll ( object sender, EventArgs e )
        {
            CorrectMaskY( trackBarCorrectionY.Value - 8 );
        }

        //Обработчики меню
        private void openDirToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            OpenOutputDir();
        }

        private void shotToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            SaveImage();
        }

        private void shotAndSaveToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            SaveImage( true );
        }

        private void exitToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void playPauseToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            ToggleCaptureProcess();
        }

        private void settingsToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            settingsForm.Show();
        }

        private void aboutToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        //Обработчики выбора масок
        private void listViewHair_SelectedIndexChanged ( object sender, EventArgs e )
        {
            SelectMask( listViewHair );
        }

        private void listViewEye_SelectedIndexChanged ( object sender, EventArgs e )
        {
            SelectMask( listViewEye );
        }

        private void listViewChin_SelectedIndexChanged ( object sender, EventArgs e )
        {
            SelectMask( listViewChin );
        }

        //Таймер покадровый (~30 кадров/сек)
        private void timer_Tick ( object sender, EventArgs e )
        {
            ProcessFrame();
        }

        private void helpToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            System.Diagnostics.Process.Start( Application.StartupPath + @"\help.chm" );
        }
    }
}
