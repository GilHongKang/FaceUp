using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceUp
{
    public partial class SettingsForm : Form
    {
        public string OutputDir = null;

        private IniFile iniFile = new IniFile( "settings.ini" );
        private string NewOutputDir = null;

        public SettingsForm ()
        {
            InitializeComponent();
        }

        private void SettingsForm_Shown ( object sender, EventArgs e )
        {
            textBoxOutputDir.Text = OutputDir;
        }

        private void btnExit_Click ( object sender, EventArgs e )
        {
            NewOutputDir = null;
            textBoxOutputDir.Text = OutputDir;
            this.Hide();
        }

        private void btnSave_Click ( object sender, EventArgs e )
        {
            OutputDir = NewOutputDir;
            NewOutputDir = null;

            iniFile.Write( "OutputDir", OutputDir );
            this.Hide();
        }

        private void btnSelectOutputFolder_Click ( object sender, EventArgs e )
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.Cancel)
            {
                NewOutputDir = folderBrowserDialog.SelectedPath;
                textBoxOutputDir.Text = NewOutputDir;
            }
        }

        public void SetupSettings () 
        {
            try
            {
                string iniFilePath = Application.StartupPath + @"settings.ini";

                if (System.IO.File.Exists( iniFilePath ))
                {
                    OutputDir = iniFile.Read( "OutputDir" );
                }
                else
                {
                    string myPicturesDir = Environment.GetFolderPath( Environment.SpecialFolder.MyPictures );
                    OutputDir = System.IO.Path.Combine( myPicturesDir, "FaceUp" );

                    if (!System.IO.Directory.Exists( OutputDir ))
                    {
                        System.IO.Directory.CreateDirectory( OutputDir );
                    }

                    iniFile.Write( "OutputDir", OutputDir );
                }
            }
            catch
            {
                MessageBox.Show( @"Ошибка чтения/записи файла settings.ini" );
            }
        }
    }
}
