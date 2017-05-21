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
    public partial class AboutForm : Form
    {
        public AboutForm ()
        {
            InitializeComponent();
        }

        private void linkLabelLicense_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e )
        {
            System.Diagnostics.Process.Start( "https://opensource.org/licenses/mit-license.php" );
        }
    }
}
