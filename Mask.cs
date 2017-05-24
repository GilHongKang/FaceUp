using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FaceUp
{
    class Mask
    {
        public int Index = 0;
        public int OffsetX = 0;
        public int OffsetY = 0;
        public int Scale = 100;
        public int TrackBarOffsetX = 10;
        public int TrackBarOffsetY = 8;
        public int TrackBarScale = 10;
        public string Path = "";
        public MaskType Type;

        private Image Image;

        public Mask ( MaskType type )
        {
            this.Type = type;
        }

        public Mask ( MaskType type, string path )
        {
            this.Path = path;
            this.Type = type;
        }

        public Image GetImage ()
        {
            if (Path != "")
                return Image = Image.FromFile( this.Path );
            else
                return new Bitmap( 1, 1 );
        }

        public void ChangeScale ( int percents )
        {
            double result = (Convert.ToDouble( Scale ) * (percents / 100.0)) + 100.0;
            this.Scale = Convert.ToInt32( result );
        }
    }
}
