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

        public MainForm ()
        {
            InitializeComponent();

            LoadMaskImages( Application.StartupPath );
            StartCaptureProcess();
        }

        //Обработчики кнопок сайдбара
        private void btnPlayPause_Click ( object sender, EventArgs e )
        {
            ToggleCaptureProcess();
        }

        //Обработчики смены вкладок


        //Обработчики корректировки
        private void trackBarCorrectionSize_Scroll ( object sender, EventArgs e )
        {
            CorrectMaskSize( activeMaskType, trackBarCorrectionSize.Value );
        }

        private void trackBarCorrectionX_Scroll ( object sender, EventArgs e )
        {
            CorrectMaskX( activeMaskType, trackBarCorrectionX.Value );
        }

        private void trackBarCorrectionY_Scroll ( object sender, EventArgs e )
        {
            CorrectMaskY( activeMaskType, trackBarCorrectionY.Value );
        }

        //Обработчики меню
        private void openToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void exitToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void playPauseToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            ToggleCaptureProcess();
        }

        private void aboutToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void listViewHair_SelectedIndexChanged ( object sender, EventArgs e )
        {
            SelectMask( MaskType.HAIR );
        }

        private void listViewEye_SelectedIndexChanged ( object sender, EventArgs e )
        {
            SelectMask( MaskType.EYE );
        }

        private void listViewChin_SelectedIndexChanged ( object sender, EventArgs e )
        {
            SelectMask( MaskType.CHIN );
        }


    }
}
