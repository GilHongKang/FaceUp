using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace FaceUp
{
    struct Utils 
    {
        static public int ScalePixels ( int pixels, int scale )
        {
            double result = (Convert.ToDouble( scale ) / 100.0) * Convert.ToDouble( pixels );
            return Convert.ToInt32( result );
        }

        static public int GetScaledBackOffset (int width, int scale)
        {
            return ( Utils.ScalePixels( width, scale ) - width ) / 2;
        }
    }


    class FaceUpManager
    {
        public int FacesAmount = 0;
        public Mask SelectedHairMask = new Mask( MaskType.HAIR );
        public Mask SelectedEyeMask = new Mask( MaskType.EYE );
        public Mask SelectedChinMask = new Mask( MaskType.CHIN );
        public Bitmap CapturedBmp = null;
        public int GlobalScale = 120;

        private VideoCapture Capture = new VideoCapture();
        private CascadeClassifier HaarCascade = new CascadeClassifier( "haarcascade_frontalface_default.xml" );
        private List<Mask> HairMasks = new List<Mask>();
        private List<Mask> EyeMasks = new List<Mask>();
        private List<Mask> ChinMasks = new List<Mask>();

        public Bitmap DrawProcessedFrame () 
        {
            Image<Bgr, byte> captureImg = Capture.QueryFrame().ToImage<Bgr, byte>();

            if (captureImg != null)
            {
                Image<Gray, byte> grayCaptureImg = captureImg.Convert<Gray, byte>();
                var faces = HaarCascade.DetectMultiScale( grayCaptureImg, 1.3, 7 );
                FacesAmount = faces.Length;

                CapturedBmp = captureImg.ToBitmap();
                foreach (var face in faces)
                {
                    int scaledOffsetX, scaledOffsetY, width;

                    Graphics graphics = Graphics.FromImage( CapturedBmp );

                    scaledOffsetX = Utils.GetScaledBackOffset( face.Width, SelectedEyeMask.Scale + GlobalScale );
                    scaledOffsetY = Utils.GetScaledBackOffset( face.Height, SelectedEyeMask.Scale + GlobalScale );
                    width = Utils.ScalePixels( face.Width, SelectedEyeMask.Scale + GlobalScale );
                    graphics.DrawImage( 
                        SelectedEyeMask.GetImage(),
                        face.X + SelectedEyeMask.OffsetX - scaledOffsetX,
                        face.Y - SelectedEyeMask.OffsetY - scaledOffsetY,
                        width,
                        width
                    );

                    scaledOffsetX = Utils.GetScaledBackOffset( face.Width, SelectedChinMask.Scale + GlobalScale );
                    scaledOffsetY = Utils.GetScaledBackOffset( face.Height, SelectedChinMask.Scale + GlobalScale );
                    width = Utils.ScalePixels( face.Width, SelectedChinMask.Scale + GlobalScale );
                    graphics.DrawImage(
                        SelectedChinMask.GetImage(),
                        face.X + SelectedChinMask.OffsetX - scaledOffsetX,
                        face.Y - SelectedChinMask.OffsetY - scaledOffsetY,
                        width,
                        width
                    );

                    scaledOffsetX = Utils.GetScaledBackOffset( face.Width, SelectedHairMask.Scale + GlobalScale );
                    scaledOffsetY = Utils.GetScaledBackOffset( face.Height, SelectedHairMask.Scale + GlobalScale );
                    width = Utils.ScalePixels( face.Width, SelectedHairMask.Scale + GlobalScale );
                    graphics.DrawImage(
                        SelectedHairMask.GetImage(),
                        face.X + SelectedHairMask.OffsetX - scaledOffsetX,
                        face.Y - SelectedHairMask.OffsetY - scaledOffsetY,
                        width,
                        width
                    );
                }
            }
            else
            {
                throw new Exception( "Ошибка подключения веб-камеры" );
            }

            return CapturedBmp;
        }

        public string[] LoadMasks ( MaskType type, string appPath ) 
        {
            string dir;

            switch (type)
            {
                case MaskType.HAIR:
                    dir = appPath + @"\img\hair\";
                    break;
                case MaskType.EYE:
                    dir = appPath + @"\img\eye\";
                    break;
                case MaskType.CHIN:
                    dir = appPath + @"\img\chin\";
                    break;
                default:
                    return new string[0];
            }

            return Directory.GetFiles( dir );
        }

        public void AddMask ( Mask mask, int index )
        {
            List<Mask> masksList;
            mask.Index = index;

            switch (mask.Type)
            {
                case MaskType.HAIR:
                    masksList = this.HairMasks;
                    break;
                case MaskType.EYE:
                    masksList = this.EyeMasks;
                    break;
                case MaskType.CHIN:
                    masksList = this.ChinMasks;
                    break;
                default:
                    return;
            }

            masksList.Add( mask );
        }

        public void SelectMask ( MaskType type, int index )
        {
            List<Mask> masksList;

            switch (type)
            {
                case MaskType.HAIR:
                    masksList = this.HairMasks;
                    break;
                case MaskType.EYE:
                    masksList = this.EyeMasks;
                    break;
                case MaskType.CHIN:
                    masksList = this.ChinMasks;
                    break;
                default:
                    return;
            }

            foreach ( Mask mask in masksList )
            {
                if (mask.Index == index)
                {
                    SelectMask( mask );
                    break;
                }
            }
        }

        public void SelectMask ( Mask mask )
        {
            switch (mask.Type)
            {
                case MaskType.HAIR:
                    SelectedHairMask = mask;
                    break;
                case MaskType.EYE:
                    SelectedEyeMask = mask;
                    break;
                case MaskType.CHIN:
                    SelectedChinMask = mask;
                    break;
                default:
                    return;
            }
        }
    }
}
