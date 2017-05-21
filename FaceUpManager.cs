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
using Emgu.CV.UI;
using Emgu.Util;

namespace FaceUp
{
    //Твой бэкенд
    class FaceUpManager
    {
        //возвращает лист путей к маскам из папки или битмапы, еще не известно

        List<Picture> allPicturies; // all image list
        private VideoCapture captureDevice = new VideoCapture(); // web camera
        private CascadeClassifier haarCascade; // Haar Classifier

        public enum MaskType
        {
            EYE,
            HAIR,
            CHIN
        };

        public struct Picture
        {
            public MaskType maskType;
            public string path;
            public Image source;

            public Picture(MaskType maskType, string filePath, Image imageSource)
            {
                this.maskType = maskType;
                this.path = filePath;
                this.source = imageSource;
            }
        }

        public FaceUpManager()
        {
            allPicturies = new List<Picture>();

            if (!File.Exists(System.IO.Directory.GetCurrentDirectory() + @"\haarcascade_frontalface_default.xml"))
                throw new Exception("File with Haar cascade not found");

            haarCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");
        }
        
 

        //загрузка картинок
        public bool LoadImages(string applicationPath)
        {
            string eyePath = applicationPath + @"\img\eye\",
                chinPath = applicationPath + @"\img\chin\",
                hairPath = applicationPath + @"\img\hair\";

            if (!Directory.Exists(eyePath) || !Directory.Exists(chinPath))
                return false;

            string[] eyeFilePaths = Directory.GetFiles(eyePath),
                chinFilePaths = Directory.GetFiles(chinPath),
                hairFilePaths = Directory.GetFiles(hairPath);

            foreach(string eyeFilePath in eyeFilePaths)
                this.allPicturies.Add(new Picture(MaskType.EYE, eyeFilePath, Image.FromFile(eyeFilePath)));

            foreach (string chinFilePath in chinFilePaths)
                this.allPicturies.Add(new Picture(MaskType.CHIN, chinFilePath, Image.FromFile(chinFilePath)));

            foreach (string hairFilePath in hairFilePaths)
                this.allPicturies.Add(new Picture(MaskType.HAIR, hairFilePath, Image.FromFile(hairFilePath)));

            return true;
        }

        public List<Picture> GetMaskImagesOf( MaskType maskType )
        {
            return allPicturies.Where(image => image.maskType == maskType).ToList<Picture>();
        }
        
        //обрабатывает фрейм и возвращает новый рисунок на вывод

        /*
         * можно вызывать в while(1) {}
        */
        public Bitmap DrawProcessedFrame ()
        {
            Image<Bgr, byte> img = captureDevice.QueryFrame().ToImage<Bgr, byte>();

            if (img != null)
            {
                Image<Gray, byte> grayImg = img.Convert<Gray, byte>();
                var faces = haarCascade.DetectMultiScale(grayImg, 1.4, 2);

                var image = img.ToBitmap();
                Graphics g = Graphics.FromImage(image);

                foreach (var face in faces)
                {
                    img.Draw(face, new Bgr(Color.Green), 3);
                }

                return image;
            }

            return null;
        }

        public Bitmap DrawProcessedFrame(Image<Bgr, byte> imageFromCamera)
        {
            if(imageFromCamera == null)
                return null;
           
            Image<Gray, byte> grayImg = imageFromCamera.Convert<Gray, byte>();
            var faces = haarCascade.DetectMultiScale(grayImg, 1.4, 2);

            var image = imageFromCamera.ToBitmap();
            Graphics g = Graphics.FromImage(image);

            foreach (var face in faces)
            {
                imageFromCamera.Draw(face, new Bgr(Color.Green), 3);
            }

            return image;
        }
    }
}
